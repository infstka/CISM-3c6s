﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LR2
{
    public partial class UI : Form
    {

        string polski = "aąbcćdeęfghijklłmnńoóprsśtuwyzźż";
        string bulgarian = "абвгдежзийклмнопрстуфхцчшщъьюя";
        string text;

        public UI()
        {
            InitializeComponent();
        }

        private void FileSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string file = ofd.FileName;
            text = System.IO.File.ReadAllText(file);
            result.Text = "";
        }

        private void TextDecoder(string s)
        {
            string alphabetBuf;
           
            if (language.SelectedIndex == 1)
            {
                alphabetBuf = polski;
            }
            else
            {
                alphabetBuf = bulgarian;
            }

            double entropyBuf = EntropyShennon(s, alphabetBuf);
            result.Text += "Энтропия: " + entropyBuf + "\n";
            result.Text += "Количество информации: " + CountInf(entropyBuf, s.Length) + "\n----------------------------------\n";

            if (error.Checked)
            {
                result.Text += "Вероятность ошибки 0.1: " + EffectiveEntropy(0.1, 0) * s.Length + "\n";
                result.Text += "Вероятность ошибки 0.5: " + EffectiveEntropy(0.51, 0) * s.Length + "\n";
                result.Text += "Вероятность ошибки 1: " + EffectiveEntropy(1, 0) * s.Length + "\n----------------------------------\n";
            }

            if (ASCII.Checked)
            {
                string ASCIIbuf = "Бинарный вид: ";
                byte[] byteBuf;

                if (language.SelectedIndex > 0)
                {
                    byteBuf = Encoding.UTF8.GetBytes(s);
                }
                else
                {
                    byteBuf = Encoding.ASCII.GetBytes(s);
                }
                foreach (byte a in byteBuf)
                {
                    ASCIIbuf += Convert.ToString(a, 2) + " ";
                }

                result.Text += ASCIIbuf + "\n----------------------------------\n";
                entropyBuf = EntropyShennon(ASCIIbuf, "10");
                result.Text += "Энтропия (ASCII): " + entropyBuf + "\n";
                result.Text += "Количество информации (ASCII): " + CountInf(entropyBuf, ASCIIbuf.Length) + "\n----------------------------------\n";
               
                if (error.Checked)
                {
                    result.Text += "Вероятность ошибки 0.1: " + EffectiveEntropy(0.1, 0) * ASCIIbuf.Length + "\n";
                    result.Text += "Вероятность ошибки 0.5: " + EffectiveEntropy(0.5, 0) * ASCIIbuf.Length + "\n";
                    result.Text += "Вероятность ошибки 1: " + EffectiveEntropy(1, EntropyShennon(ASCIIbuf, "10")) * ASCIIbuf.Length + "\n----------------------------------\n";
                }
            }
        }

        private double EntropyShennon(string s, string aplhabet)
        {
            double buf = 0;
            foreach (char character in aplhabet)
            {
                int counter = symbolEntries(character, s);
                result.Text += "Символ " + character + ": " + "\nКол-во вхождений: " + counter + "\nВероятность вхождения: " + (counter / (double)s.Length) + "\n----------------------------------\n";
               
                if ((counter / (double)s.Length) > 0)
                {
                    buf -= (counter / (double)s.Length) * Math.Log((counter / (double)s.Length), 2);
                }
            }
            return buf;
        }

        private int symbolEntries(char character, string message)
        {
            int counter = 0;
            foreach (char a in message)
            {
                if (character == a)
                {
                    counter++;
                }
            }
            return counter;
        }

        private double CountInf(double entropy, int N)
        {
            return entropy * N;
        }

        private double EffectiveEntropy(double error, double binEntrhopy)
        {
            if (binEntrhopy == 0)
            {
                if (error == 1)
                {
                    var d = 1 - ((-error) * Math.Log(error, 2) - (1 - error) * Math.Log(1 - error, 2));
                    if (Double.IsNaN(d))
                    {
                        d = 0;
                    }
                    return d;
                }
                else
                {
                    var d = 1 - ((-error) * Math.Log(error, 2) - (1 - error) * Math.Log(1 - error, 2));
                    return d;
                }
            }
            else
            {
                var d = binEntrhopy;
                return d;
            }
        }

        private double BinEntropy(string s)
        {
            int counter = 0;

            foreach (char c in s)
            {
                Console.WriteLine(counter + ": " + c);
                counter++;
            }

            double entropyBuf = EntropyShennon(s, "01");
            result.Text += "Энтропия: " + entropyBuf + "\n";
            result.Text += "Количество информации: " + CountInf(entropyBuf, s.Length) + "\n";
            return entropyBuf;
        }

        private void count_Click(object sender, EventArgs e)
        {
            result.Text = "";
            if (language.SelectedIndex != 0)
            {
                TextDecoder(text.ToLower().Replace(" ", ""));
            }
            else
            {
                BinEntropy(text.ToLower().Replace(" ", ""));
            }
        }

        private void language_Selection(object sender, EventArgs e)
        {
            if (language.SelectedIndex == 0)
            {
                ASCII.Checked = false;
                ASCII.Enabled = false;
                error.Enabled = false;
                error.Checked = false;
            }
            else
            {
                ASCII.Enabled = true;
                ASCII.Checked = true;
            }
        }
        private void invsbleASCII_CB(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                error.Enabled = true;
                error.Checked = true;
            }
            else
            {
                error.Enabled = false;
                error.Checked = false;
            }
        }

        private void textPLButton_Click(object sender, EventArgs e)
        {
            string text1 = textPLBox.Text;
            System.IO.File.WriteAllText(@"D:\BSTU\CISM-3c6s\LR2\textPL.txt", text1);
        }

        private void textBULButton_Click(object sender, EventArgs e)
        {
            string text2 = textBULBox.Text;
            System.IO.File.WriteAllText(@"D:\BSTU\CISM-3c6s\LR2\textBUL.txt", text2);
        }

        private void textBINButton_Click(object sender, EventArgs e)
        {
            string text3 = textBINBox.Text;
            System.IO.File.WriteAllText(@"D:\BSTU\CISM-3c6s\LR2\textBIN.txt", text3);
        }
    }
}
