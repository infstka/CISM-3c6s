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
    public partial class UI : Form
    {
        List<string> words_list = new List<string>();
        string text = "Mary had to make a decision and she knew that whatever decision she made, it would upset someone. It seemed like such a silly reason for people to get upset but she knew the minute that she began to consider doing it that there was no way everyone in her life would be pleased with what she ultimately decided to do. It was simply a question of who she would rather displease most. While this had always been her parents, and especially her mom, in the past that she tried to keep from upsetting, she decided that this time the person she was going to please the most with her decision was herself.";
        public UI()
        {
            InitializeComponent();
            string[] buffer = text.Split(' ');
            foreach (var a in buffer)
            {
                words_list.Add(a);
            }
        }

        private BitArray byte_to_bit(byte @byte)
        {
            BitArray ba = new BitArray(8);
            bool st = false;
            for (int i = 0; i < 8; i++)
            {
                if ((@byte >> i & 1) == 1)
                {
                    st = true;
                }
                else st = false;
                ba[i] = st;
            }
            return ba;
        }

        private byte bit_to_byte(BitArray ba)
        {
            byte num = 0;
            for (int i = 0; i < ba.Count; i++)
                if (ba[i] == true)
                    num += (byte)Math.Pow(2, i);
            return num;
        }

        private string string_length_modify(string input, int length)
        {
            if (input.Length < length)
            {
                return input.PadRight(length);
            }
            else if (input.Length > length)
            {
                return input.Substring(0, length);
            }
            return input;
        }

        private string aproach_modify(string input, int spacing)
        {
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

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Document document = new Document();
            DocumentBuilder db = new DocumentBuilder(document);
            byte[] bytes = Encoding.ASCII.GetBytes(txtInput.Text);
            List<bool> lb = new List<bool>();
            string input = "";

            foreach (var a in bytes)
            {
                foreach (var b in byte_to_bit(a))
                {
                    lb.Add((bool)b);
                    Console.WriteLine((bool)b);
                }
            }
            while (lb.Count >= input.Length)
            {
                input += words_list[random.Next(0, words_list.Count)] + " ";
            }

            input = input.TrimEnd();
            Debug.WriteLine(input);
            Debug.WriteLine(input.Length);
            Debug.WriteLine(lb.Count);

            for (int i = 0; i < input.Length; i++)
            {
                if (i < lb.Count)
                {
                    if (lb[i] == true)
                    {
                        db.Font.Spacing = 10.4;
                    }
                    else
                    {
                        db.Font.Spacing = 0.6;
                    }
                }
                else
                {
                    db.Font.Spacing = 0.5;
                }
                db.Write(input[i].ToString());
            }
            document.Save("D:\\BSTU\\CISM-3c6s\\LR15\\LR15_Апрош.docx");
            info_tb.Text = "Текст зашифрован в файл LR15_Апрош";
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            List<bool> lb = new List<bool>();
            Document document = new Document("D:\\BSTU\\CISM-3c6s\\LR15\\LR15_Апрош.docx");
            DocumentBuilder db = new DocumentBuilder(document);
            for (int i = 0; i < document.Sections[0].Body.Paragraphs[1].Runs.Count; i++)
            {
                if (document.Sections[0].Body.Paragraphs[1].Runs[i].Font.Spacing == 10.4)
                {
                    lb.Add(true);
                }
                else if (document.Sections[0].Body.Paragraphs[1].Runs[i].Font.Spacing == 0.6)
                {
                    lb.Add(false);
                }
            }
            List<byte> lbb = new List<byte>();
            for (int i = 0; i < lb.Count; i += 8)
            {
                BitArray ba = new BitArray(8);
                List<bool> list_bool = lb.GetRange(i, 8);
                for (int j = 0; j < list_bool.Count; j++)
                {
                    ba.Set(j, list_bool[j]);
                }
                lbb.Add(bit_to_byte(ba));
            }

            txtModifiedApproach.Text = Encoding.ASCII.GetString(lbb.ToArray());
            info_tb.Text = "Текст из файла LR15_Апрош расшифрован";
        }
    }
}
