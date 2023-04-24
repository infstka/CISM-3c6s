using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LR4
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void cipher_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cipher_combobox.SelectedIndex == 1)
            {
                key_label.Visible = true;
                key_textbox.Visible = true;
            }
            else
            {
                key_label.Visible = false;
                key_textbox.Visible = false;
            }
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            if (cipher_combobox.SelectedIndex == 0)
            {
                // Создаем объект Stopwatch
                Stopwatch stopwatch = new Stopwatch();

                // Начинаем измерение времени
                stopwatch.Start();

                int k = 7;
                char[] alphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();
                string encryptedText = "";

                foreach (char c in input_textbox.Text.ToLower())
                {
                    if (Array.IndexOf(alphabet, c) > -1)
                    {
                        int newIndex = (Array.IndexOf(alphabet, c) + k) % alphabet.Length;
                        encryptedText += alphabet[newIndex];
                    }
                    else
                    {
                        encryptedText += c;
                    }
                }

                // Останавливаем измерение времени
                stopwatch.Stop();

                // Получаем время выполнения в миллисекундах
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                execTime_textbox.Text = $"{elapsedMilliseconds} мс";
                output_textbox.Text = encryptedText;
            }

            if (cipher_combobox.SelectedIndex == 1)
            {
                string keyword = key_textbox.Text;

                // Создаем объект Stopwatch
                Stopwatch stopwatch = new Stopwatch();

                // Начинаем измерение времени
                stopwatch.Start();

                char[] alphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();
                char[,] trisemusTable = GenerateTrisemusTable(keyword);

                string encryptedText = "";
                for (int i = 0; i < input_textbox.Text.Length; i++)
                {
                    char c = input_textbox.Text[i];
                    int row, col;
                    FindCharInTable(c, trisemusTable, out row, out col);

                    if (row >= 0 && col >= 0)
                    {
                        int newRow, newCol;

                        if (i < input_textbox.Text.Length - 1 && input_textbox.Text[i + 1] == c)
                        {
                            // Для повторяющихся символов вставляем пробел между ними
                            encryptedText += ' ';
                            continue;
                        }
                        else if (col == 4)
                        {
                            // Заменяем символ в середине на символ в левом столбце
                            newRow = row;
                            newCol = 0;
                        }
                        else
                        {
                            // Переходим на следующий столбец по горизонтали
                            newRow = row;
                            newCol = col + 1;
                        }

                        encryptedText += trisemusTable[newRow, newCol];
                    }
                    else
                    {
                        encryptedText += c;
                    }
                }

                // Останавливаем измерение времени
                stopwatch.Stop();

                // Получаем время выполнения в миллисекундах
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                execTime_textbox.Text = $"{elapsedMilliseconds} мс";
                output_textbox.Text = encryptedText;
            }
        }

        private void decode_button_Click(object sender, EventArgs e)
        {
            if (cipher_combobox.SelectedIndex == 0)
            {
                // Создаем объект Stopwatch
                Stopwatch stopwatch = new Stopwatch();

                // Начинаем измерение времени
                stopwatch.Start();

                int k = 7;
                char[] alphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();
                string decryptedText = "";

                foreach (char c in input_textbox.Text.ToLower())
                {
                    if (Array.IndexOf(alphabet, c) > -1)
                    {
                        int newIndex = (Array.IndexOf(alphabet, c) - k + alphabet.Length) % alphabet.Length;
                        decryptedText += alphabet[newIndex];
                    }
                    else
                    {
                        decryptedText += c;
                    }
                }

                // Останавливаем измерение времени
                stopwatch.Stop();

                // Получаем время выполнения в миллисекундах
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                execTime_textbox.Text = $"{elapsedMilliseconds} мс";
                output_textbox.Text = decryptedText;
            }

            if (cipher_combobox.SelectedIndex == 1)
            {
                string keyword = key_textbox.Text;

                // Создаем объект Stopwatch
                Stopwatch stopwatch = new Stopwatch();

                // Начинаем измерение времени
                stopwatch.Start();

                char[] alphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();
                char[,] trisemusTable = GenerateTrisemusTable(keyword);

                string decryptedText = "";
                for (int i = 0; i < input_textbox.Text.Length; i++)
                {
                    char c = input_textbox.Text[i];

                    if (c == ' ')
                    {
                        decryptedText += c;
                        continue;
                    }

                    int row, col;
                    FindCharInTable(c, trisemusTable, out row, out col);

                    if (row >= 0 && col >= 0)
                    {
                        int newRow, newCol;

                        if (col == 0)
                        {
                            // Заменяем символ в левом столбце на символ в середине
                            newRow = row;
                            newCol = 4;
                        }
                        else
                        {
                            // Переходим на предыдущий столбец по горизонтали
                            newRow = row;
                            newCol = col - 1;
                        }

                        decryptedText += trisemusTable[newRow, newCol];
                    }
                    else
                    {
                        decryptedText += c;
                    }
                }

                // Останавливаем измерение времени
                stopwatch.Stop();

                // Получаем время выполнения в миллисекундах
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                execTime_textbox.Text = $"{elapsedMilliseconds} мс";
                output_textbox.Text = decryptedText;
            }
        }

        static char[,] GenerateTrisemusTable(string keyword)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyzäöüß".ToCharArray();
            char[,] table = new char[5, 5];
            string key = keyword.ToLower().Replace('j', 'i') + new string(alphabet).Replace('j', 'i');
            key = new string(key.Distinct().ToArray());

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    table[i, j] = key[k];
                    k++;
                }
            }

            return table;
        }

        static void FindCharInTable(char c, char[,] table, out int row, out int col)
        {
            row = -1;
            col = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (table[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }
    }
}
