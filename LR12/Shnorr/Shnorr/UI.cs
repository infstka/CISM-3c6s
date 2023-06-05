using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shnorr
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            txtP.Text = "2267";
            txtQ.Text = "103";
            txtG.Text = "354";
            txtY.Text = "967";
            txtX.Text = "30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"\nЭЦП на основе Шнорра\n");
            Console.InputEncoding = Encoding.ASCII;
        }

        public static class ElGamal
        {
            public static BigInteger mdfive_hash(string input)
            {
                var md5 = MD5.Create();
                var input_bytes = Encoding.ASCII.GetBytes(input);
                var hash = md5.ComputeHash(input_bytes);
                return new BigInteger(hash.Concat(new byte[] {
                    0
                }).ToArray());
            }
        }

        public static class Shnorr
        {
            public static void Calculate(BigInteger p, BigInteger q, string text, BigInteger g, BigInteger obg, int x)
            {
                BigInteger y = BigInteger.ModPow(obg, x, p);
                BigInteger a = BigInteger.Pow(g, 13) % p;
                BigInteger first_hash = ElGamal.mdfive_hash(text + a.ToString());

                File.WriteAllText(".\\shnorr.txt", first_hash.ToString());
                BigInteger b = (13 + x * first_hash) % q;
                BigInteger dov = BigInteger.ModPow(g, b, p);
                BigInteger X = (dov * BigInteger.ModPow(y, first_hash, p)) % p;
                BigInteger second_hash = ElGamal.mdfive_hash(text + X.ToString());

                var f = first_hash == second_hash;
                MessageBox.Show(f.ToString());
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            BigInteger p, q, g, y;
            int x;
            string text;

            if (!BigInteger.TryParse(txtP.Text, out p) ||
                !BigInteger.TryParse(txtQ.Text, out q) ||
                !BigInteger.TryParse(txtG.Text, out g) ||
                !BigInteger.TryParse(txtY.Text, out y) ||
                !int.TryParse(txtX.Text, out x) ||
                string.IsNullOrEmpty(txtText.Text))
            {
                MessageBox.Show("Некорректный ввод данных");
                return;
            }

            text = txtText.Text;
            Shnorr.Calculate(p, q, text, g, y, x);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;
            execTime.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void compare_Click(object sender, EventArgs e)
        {
            BigInteger p, q, g, y;
            int x;
            string first_text, second_text;

            if (!BigInteger.TryParse(txtP.Text, out p) ||
                !BigInteger.TryParse(txtQ.Text, out q) ||
                !BigInteger.TryParse(txtG.Text, out g) ||
                !BigInteger.TryParse(txtY.Text, out y) ||
                !int.TryParse(txtX.Text, out x) ||
                string.IsNullOrEmpty(txtText.Text) ||
                string.IsNullOrEmpty(txtSecondText.Text))
            {
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }

            first_text = txtText.Text;
            second_text = txtSecondText.Text;

            var first_hasg = ElGamal.mdfive_hash(first_text + x.ToString());
            var second_hash = ElGamal.mdfive_hash(second_text + x.ToString());

            var result = first_hasg == second_hash;
            MessageBox.Show(result.ToString());
        }
    }
}
