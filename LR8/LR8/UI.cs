using LR8;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace LR8
{
    public partial class UI : Form
    {
        private static readonly int n = 253;
        private static readonly int x = 5;
        private static readonly int length = 13;

        private readonly RC4 first_rc;
        private readonly RC4 second_rc;

        private byte[] encoded_data;

        public UI()
        {
            InitializeComponent();
            int[] key_array = { 1, 11, 21, 31, 41, 51 };
            byte[] key = new byte[key_array.Length];

            for (int i = 0; i < key_array.Length; i++)
            {
                key[i] = Convert.ToByte(key_array[i]);
            }

            //key for encoding
            first_rc = new RC4(key);
            //key for decoding
            second_rc = new RC4(key);
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            string text = input_textbox.Text;
            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(text);

            encoded_data = first_rc.Encode(bytes, bytes.Length);
            output_textbox.Text = ASCIIEncoding.ASCII.GetString(encoded_data);

            int[] sequence = new int[length];
            int buffer = x;
            string bbs = "";
            for (int i = 0; i < length; i++)
            {
                buffer = Program.BBSnext(buffer, i);
                sequence[i] = buffer;
                bbs += $"x{i} = ({buffer} * {buffer})mod {n} = {buffer}\r\n";
            }

            bbs_textbox.Text = bbs;
            psp_textbox.Text = string.Join("; ", sequence);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;

            exectime_textbox.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void decode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            byte[] decrypted = second_rc.Encode(encoded_data, encoded_data.Length);
            output_textbox.Text = ASCIIEncoding.ASCII.GetString(decrypted);

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;

            exectime_textbox.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Clear();
            output_textbox.Clear();
            bbs_textbox.Clear();
            psp_textbox.Clear();
            exectime_textbox.Clear();
            encoded_data = null;
        }
    }
}
