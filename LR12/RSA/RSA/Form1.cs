using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] characters = new char[] { '#', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };

        private void encode_Click(object sender, EventArgs e)
        {
            if ((p_tb.Text.Length > 0) && (q_tb.Text.Length > 0) && (textFilePath.Text.Length > 0) && (signFilePath.Text.Length > 0))
            {
                long p = Convert.ToInt64(p_tb.Text);
                long q = Convert.ToInt64(q_tb.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    // Создаем объект Stopwatch
                    Stopwatch stopwatch = new Stopwatch();

                    // Начинаем измерение времени
                    stopwatch.Start();

                    string hash = File.ReadAllText(textFilePath.Text).GetHashCode().ToString();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = RSA_Endoce(hash, e_, n);

                    StreamWriter sw = new StreamWriter(signFilePath.Text);
                    foreach (string item in result)
                        sw.WriteLine(item);
                    sw.Close();

                    d_tb.Text = d.ToString();
                    n_tb.Text = n.ToString();

                    Process.Start(signFilePath.Text);
                    // Останавливаем измерение времени
                    stopwatch.Stop();

                    // Получаем время выполнения в миллисекундах
                    TimeSpan elapsed = stopwatch.Elapsed;

                    execTime.Text = $"{elapsed.TotalMilliseconds:F2} мс";
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q и пути к файлам!");
        }

        //расшифровать
        private void decode_Click(object sender, EventArgs e)
        {
            if ((d_tb.Text.Length > 0) && (n_tb.Text.Length > 0) && (textFilePath.Text.Length > 0) && (signFilePath.Text.Length > 0))
            {
                long d = Convert.ToInt64(d_tb.Text);
                long n = Convert.ToInt64(n_tb.Text);

                List<string> input = new List<string>();

                StreamReader sr = new StreamReader(signFilePath.Text);

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                string result = RSA_Dedoce(input, d, n);

                string hash = File.ReadAllText(textFilePath.Text).GetHashCode().ToString();

                if (result.Equals(hash))
                    MessageBox.Show("Подписи совпали, файл подлинный");
                else
                    MessageBox.Show("Подписи не совпали, файл не подлинный");
            }
            else
                MessageBox.Show("Введите секретный ключ и пути к файлам!");
        }

        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        //зашифровать
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        //расшифровать
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        private void textFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = ofd.FileName;
            }
        }

        private void signFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                signFilePath.Text = ofd.FileName;
            }
        }
    }
}