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

        private readonly RC4 rc;
        private readonly RC4 rc2;
        private byte[] encryptedData;
        public UI()
        {
            InitializeComponent();
            int[] ikey = { 1, 11, 21, 31, 41, 51 };
            byte[] key = new byte[ikey.Length];

            for (int i = 0; i < ikey.Length; i++)
            {
                key[i] = Convert.ToByte(ikey[i]);
            }

            rc = new RC4(key);  // Используется ключ rc для шифрования
            rc2 = new RC4(key); // Используется ключ rc2 для расшифровки
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            string message = input_textbox.Text;
            byte[] testBytes = ASCIIEncoding.ASCII.GetBytes(message);

            encryptedData = rc.Encode(testBytes, testBytes.Length);
            output_textbox.Text = ASCIIEncoding.ASCII.GetString(encryptedData);

            int[] seq = new int[length];
            int buf = x;
            string bbsNext = "";
            for (int i = 0; i < length; i++)
            {
                buf = Program.BBSnext(buf, i);
                seq[i] = buf;
                bbsNext += $"x{i} = ({buf}*{buf})mod {n} = {buf}\r\n";
            }

            bbs_textbox.Text = bbsNext;
            psp_textbox.Text = string.Join("; ", seq);

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

            byte[] decrypted = rc2.Encode(encryptedData, encryptedData.Length);
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
            encryptedData = null;
        }
    }
}
