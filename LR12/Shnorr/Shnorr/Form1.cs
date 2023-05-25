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
    public partial class Form1 : Form
    {
        public static class ElGamal
        {
            public static BigInteger CalculateMd5Hash(string input)
            {
                var md5 = MD5.Create();
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hash = md5.ComputeHash(inputBytes);
                return new BigInteger(hash.Concat(new byte[] { 0 }).ToArray());
            }
        }

        public static class Shnorr
        {
            public static void Do(BigInteger p, BigInteger q, string text, BigInteger g, BigInteger obg, int x)
            {
                BigInteger y = BigInteger.ModPow(obg, x, p);
                BigInteger a = BigInteger.Pow(g, 13) % p;
                BigInteger hash = ElGamal.CalculateMd5Hash(text + a.ToString());

                File.WriteAllText(".\\shnorr.txt", hash.ToString());
                BigInteger b = (13 + x * hash) % q;
                BigInteger dov = BigInteger.ModPow(g, b, p);
                BigInteger X = (dov * BigInteger.ModPow(y, hash, p)) % p;
                BigInteger hash2 = ElGamal.CalculateMd5Hash(text + X.ToString());

                var f = hash == hash2;
                MessageBox.Show(f.ToString());
            }
        }

        public Form1()
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

        private void btnSign_Click(object sender, EventArgs e)
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
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }

            text = txtText.Text;
            Shnorr.Do(p, q, text, g, y, x);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;
            execTime.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            BigInteger p, q, g, y;
            int x;
            string text, fakeText;

            if (!BigInteger.TryParse(txtP.Text, out p) ||
                !BigInteger.TryParse(txtQ.Text, out q) ||
                !BigInteger.TryParse(txtG.Text, out g) ||
                !BigInteger.TryParse(txtY.Text, out y) ||
                !int.TryParse(txtX.Text, out x) ||
                string.IsNullOrEmpty(txtText.Text) ||
                string.IsNullOrEmpty(txtFakeText.Text))
            {
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }

            text = txtText.Text;
            fakeText = txtFakeText.Text;

            var hash1 = ElGamal.CalculateMd5Hash(text + x.ToString());
            var hash2 = ElGamal.CalculateMd5Hash(fakeText + x.ToString());

            var result = hash1 == hash2;
            MessageBox.Show(result.ToString());
        }
    }
}
