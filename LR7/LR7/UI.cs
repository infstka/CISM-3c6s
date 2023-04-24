using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace LR7
{
    public partial class UI : Form
    {
        private static string inputFile = "D:\\BSTU\\CISM-3c6s\\LR7\\input.txt";
        private static string outputFile = "D:\\BSTU\\CISM-3c6s\\LR7\\output.txt";

        public UI()
        {
            InitializeComponent();
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            string input = input_textbox.Text;
            string key1 = key1_textbox.Text;
            string key2 = key2_textbox.Text;

            var encoded = Encode(input, key1);
            encoded = Encode(encoded, key2);
            encoded = Encode(encoded, key1);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            execTime_textbox.Text = $"{elapsedMilliseconds} мс";

            output_textbox.Text = encoded;

            using (StreamWriter sw = new StreamWriter(outputFile, false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(encoded);
            }
        }

        private void decode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            string input = input_textbox.Text;
            string key1 = key1_textbox.Text;
            string key2 = key2_textbox.Text;

            var decoded = Decode(input, key1);
            decoded = Decode(decoded, key2);
            decoded = Decode(decoded, key1);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            execTime_textbox.Text = $"{elapsedMilliseconds} мс";

            output_textbox.Text = decoded;

            using (StreamWriter sw = new StreamWriter(inputFile, false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(decoded);
            }
        }

        private static string Encode(string input, string key)
        {
            var toEncryptArray = UTF8Encoding.UTF8.GetBytes(input);
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.Zeros;

            var cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private static string Decode(string input, string key)
        {
            var toEncryptArray = Convert.FromBase64String(input);
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.Zeros;

            var cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            output_textbox.Text = "";
            key1_textbox.Text = "";
            key2_textbox.Text = "";
            execTime_textbox.Text = "";
        }
    }
}
