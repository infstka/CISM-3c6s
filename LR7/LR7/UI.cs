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
        private static string input_file = "D:\\BSTU\\CISM-3c6s\\LR7\\input.txt";
        private static string output_file = "D:\\BSTU\\CISM-3c6s\\LR7\\output.txt";

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

            string input_text = input_textbox.Text;
            string first_key = key1_textbox.Text;
            string second_key = key2_textbox.Text;

            var encoded_text = Encode(input_text, first_key);
            encoded_text = Encode(encoded_text, second_key);
            encoded_text = Encode(encoded_text, first_key);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            execTime_textbox.Text = $"{elapsedMilliseconds} мс";
            output_textbox.Text = encoded_text;
            using (StreamWriter sw = new StreamWriter(output_file, false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(encoded_text);
            }
        }

        private void decode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            string input_text = input_textbox.Text;
            string first_key = key1_textbox.Text;
            string second_key = key2_textbox.Text;

            var decoded_text = Decode(input_text, first_key);
            decoded_text = Decode(decoded_text, second_key);
            decoded_text = Decode(decoded_text, first_key);

            // Останавливаем измерение времени
            stopwatch.Stop();
            // Получаем время выполнения в миллисекундах
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            execTime_textbox.Text = $"{elapsedMilliseconds} мс";
            output_textbox.Text = decoded_text;
            using (StreamWriter sw = new StreamWriter(input_file, false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(decoded_text);
            }
        }

        private static string Encode(string input, string key)
        {
            var encrypt_array = UTF8Encoding.UTF8.GetBytes(input);
            var mdfive_hash = new MD5CryptoServiceProvider();
            var key_array = mdfive_hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            mdfive_hash.Clear();

            var triple_des = new TripleDESCryptoServiceProvider();
            triple_des.Key = key_array;
            triple_des.Mode = CipherMode.ECB;
            triple_des.Padding = PaddingMode.Zeros;

            var cTransform = triple_des.CreateEncryptor();
            byte[] res_array = cTransform.TransformFinalBlock(encrypt_array, 0, encrypt_array.Length);
            triple_des.Clear();
            return Convert.ToBase64String(res_array, 0, res_array.Length);
        }

        private static string Decode(string input, string key)
        {
            var encrypt_array = Convert.FromBase64String(input);
            var mdfive_hash = new MD5CryptoServiceProvider();
            var key_array = mdfive_hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            mdfive_hash.Clear();

            var triple_des = new TripleDESCryptoServiceProvider();
            triple_des.Key = key_array;
            triple_des.Mode = CipherMode.ECB;
            triple_des.Padding = PaddingMode.Zeros;

            var cTransform = triple_des.CreateDecryptor();
            byte[] res_array = cTransform.TransformFinalBlock(encrypt_array, 0, encrypt_array.Length);
            triple_des.Clear();
            return UTF8Encoding.UTF8.GetString(res_array);
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
