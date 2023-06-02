using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using Aspose.Words;
using System.Collections;
using System.Diagnostics;

namespace LR15
{
    public partial class Form1 : Form
    {
        List<string> someWords = new List<string>();
        string someText = "Mary had to make a decision and she knew that whatever decision she made, it would upset someone. It seemed like such a silly reason for people to get upset but she knew the minute that she began to consider doing it that there was no way everyone in her life would be pleased with what she ultimately decided to do. It was simply a question of who she would rather displease most. While this had always been her parents, and especially her mom, in the past that she tried to keep from upsetting, she decided that this time the person she was going to please the most with her decision was herself.";
        public Form1()
        {
            InitializeComponent();
            string[] buffer = someText.Split(' ');
            foreach (var a in buffer)
            {
                someWords.Add(a);
            }
        }

        private BitArray ByteToBit(byte src)
        {
            BitArray bitArray = new BitArray(8);
            bool st = false;
            for (int i = 0; i < 8; i++)
            {
                if ((src >> i & 1) == 1)
                {
                    st = true;
                }
                else st = false;
                bitArray[i] = st;
            }
            return bitArray;
        }

        private byte BitToByte(BitArray scr)
        {
            byte num = 0;
            for (int i = 0; i < scr.Count; i++)
                if (scr[i] == true)
                    num += (byte)Math.Pow(2, i);
            return num;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            byte[] bytes = Encoding.ASCII.GetBytes(txtInput.Text);
            List<bool> bits = new List<bool>();
            string inputString = "";

            foreach (var a in bytes)
            {
                foreach (var b in ByteToBit(a))
                {
                    bits.Add((bool)b);
                    Console.WriteLine((bool)b);
                }
            }
            while (bits.Count >= inputString.Length)
            {
                inputString += someWords[rnd.Next(0, someWords.Count)] + " ";
            }

            inputString = inputString.TrimEnd();
            Debug.WriteLine(inputString);
            Debug.WriteLine(inputString.Length);
            Debug.WriteLine(bits.Count);

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i < bits.Count)
                {
                    if (bits[i] == true)
                    {
                        //Если бит равен true, устанавливается меньшее значение параметра Spacing шрифта
                        builder.Font.Spacing = 10.4;
                    }
                    else
                    {
                        //Если бит равен false, устанавливается большее значение параметра Spacing шрифта 
                        builder.Font.Spacing = 0.6;
                    }
                }
                else
                {
                    builder.Font.Spacing = 0.5;
                }
                builder.Write(inputString[i].ToString());
            }
            doc.Save("D:\\BSTU\\CISM-3c6s\\LR15\\LR15_Апрош.docx");
            info_tb.Text = "Текст зашифрован в файл LR15_Апрош";
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            List<bool> bits = new List<bool>();
            Document doc = new Document("D:\\BSTU\\CISM-3c6s\\LR15\\LR15_Апрош.docx");
            DocumentBuilder builder = new DocumentBuilder(doc);
            for (int i = 0; i < doc.Sections[0].Body.Paragraphs[1].Runs.Count; i++)
            {
                //добавляется бит со значением true в список bits.
                if (doc.Sections[0].Body.Paragraphs[1].Runs[i].Font.Spacing == 10.4)
                {
                    bits.Add(true);
                }
                //добавляется бит со значением false в список bits.
                else if (doc.Sections[0].Body.Paragraphs[1].Runs[i].Font.Spacing == 0.6)
                {
                    bits.Add(false);
                }
            }
            List<byte> bytesBuffer = new List<byte>();
            for (int i = 0; i < bits.Count; i += 8)
            {
                BitArray buffer = new BitArray(8);
                List<bool> boolBuffer = bits.GetRange(i, 8);
                for (int j = 0; j < boolBuffer.Count; j++)
                {
                    buffer.Set(j, boolBuffer[j]);
                }
                bytesBuffer.Add(BitToByte(buffer));
            }

            txtModifiedApproach.Text = Encoding.ASCII.GetString(bytesBuffer.ToArray());
            info_tb.Text = "Текст из файла LR15_Апрош расшифрован";
        }

        private string ModifyStringLength(string input, int length)
        {
            // Если строка короче заданной длины, добавляем пробелы в конец
            if (input.Length < length)
            {
                return input.PadRight(length);
            }
            // Если строка длиннее заданной длины, обрезаем ее
            else if (input.Length > length)
            {
                return input.Substring(0, length);
            }
            // Возвращаем исходную строку, если она уже имеет заданную длину
            return input;
        }

        private string ModifyApproach(string input, int spacing)
        {
            // Модифицируем аппрош путем изменения расстояния между буквами
            string modifiedApproach = string.Empty;

            using (Graphics g = CreateGraphics())
            {
                foreach (char c in input)
                {
                    modifiedApproach += c + new string(' ', spacing);
                }
            }

            return modifiedApproach;
        }
    }
}
