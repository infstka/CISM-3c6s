using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LR14
{
    public partial class UI : Form
    {

        public int int_length = 1;
        public int text_count = 0;

        public UI()
        {
            InitializeComponent();
        }

        private BitArray byte_to_bit(byte src)
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

        private byte bit_to_bytw(BitArray scr)
        {
            byte num = 0;
            for (int i = 0; i < scr.Count; i++)
                if (scr[i] == true)
                    num += (byte)Math.Pow(2, i);
            return num;
        }

        private bool check_is_encrypted(Bitmap scr)
        {
            byte[] byte_r = new byte[1];
            Color color = scr.GetPixel(0, 0);
            BitArray color_ba = byte_to_bit(color.R); 
            BitArray text_ba = byte_to_bit(color.R); ;
            text_ba[0] = color_ba[0];
            text_ba[1] = color_ba[1];

            color_ba = byte_to_bit(color.G);
            text_ba[2] = color_ba[0];
            text_ba[3] = color_ba[1];
            text_ba[4] = color_ba[2];

            color_ba = byte_to_bit(color.B);
            text_ba[5] = color_ba[0];
            text_ba[6] = color_ba[1];
            text_ba[7] = color_ba[2];
            byte_r[0] = bit_to_bytw(text_ba); 
            string m = Encoding.GetEncoding(1251).GetString(byte_r);

            if (m == "/")
            {
                return true;
            }
            else return false;
        }

        private void write_text(int count, Bitmap src)
        {
            byte[] symbols = Encoding.GetEncoding(1251).GetBytes(count.ToString());
            for (int i = 0; i < symbols.Length; i++)
            {
                BitArray ba = byte_to_bit(symbols[i]); 
                Color color = src.GetPixel(0, i + 1); 
                BitArray current_color = byte_to_bit(color.R); 
                current_color[0] = ba[0];
                current_color[1] = ba[1];
                byte R = bit_to_bytw(current_color); 

                current_color = byte_to_bit(color.G);
                current_color[0] = ba[2];
                current_color[1] = ba[3];
                current_color[2] = ba[4];
                byte G = bit_to_bytw(current_color);

                current_color = byte_to_bit(color.B);
                current_color[0] = ba[5];
                current_color[1] = ba[6];
                current_color[2] = ba[7];
                byte B = bit_to_bytw(current_color);

                Color newColor = Color.FromArgb(R, G, B);
                src.SetPixel(0, i + 1, newColor); 
            }
        }

        private int read_text(Bitmap src)
        {
            byte[] byte_r = new byte[3]; 
            for (int i = 0; i < byte_r.Length; i++)
            {
                Color color = src.GetPixel(0, i + 1); 
                BitArray color_ba = byte_to_bit(color.R);
                BitArray ba = byte_to_bit(color.R); ; 
                ba[0] = color_ba[0];
                ba[1] = color_ba[1];

                color_ba = byte_to_bit(color.G);
                ba[2] = color_ba[0];
                ba[3] = color_ba[1];
                ba[4] = color_ba[2];

                color_ba = byte_to_bit(color.B);
                ba[5] = color_ba[0];
                ba[6] = color_ba[1];
                ba[7] = color_ba[2];
                byte_r[i] = bit_to_bytw(ba);
            }
            string m = Encoding.GetEncoding(1251).GetString(byte_r);

            int res = Convert.ToInt32(m, 16);
            return res;
        }

        private void encode(object sender, EventArgs e)
        {
            string image_file;
            string text_file;
            OpenFileDialog ofd_image = new OpenFileDialog();
            ofd_image.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";

            if (ofd_image.ShowDialog() == DialogResult.OK)
            {
                image_file = ofd_image.FileName;
            }
            else
            {
                image_file = "";
                return;
            }

            FileStream fs_image;

            try
            {
                fs_image = new FileStream(image_file, FileMode.Open); 
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap bitmap = new Bitmap(fs_image);

            OpenFileDialog ofd_text = new OpenFileDialog();
            ofd_text.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (ofd_text.ShowDialog() == DialogResult.OK)
            {
                text_file = ofd_text.FileName;
            }
            else
            {
                text_file = "";
                return;
            }

            using (StreamReader sr = new StreamReader(text_file))
            {
                string sod = sr.ReadToEnd();
                int_length = sod.Length;
            }

            FileStream fs_text;
            try
            {
                fs_text = new FileStream(text_file, FileMode.Open); 
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BinaryReader br = new BinaryReader(fs_text, Encoding.ASCII);

            List<byte> byte_list = new List<byte>();
            while (br.PeekChar() != -1)
            {
                byte_list.Add(br.ReadByte());
            }
            text_count = byte_list.Count; 
            br.Close();
            fs_image.Close();

            if (text_count > (bitmap.Width * bitmap.Height))
            {
                MessageBox.Show("Картинка слишком маленькая");
                return;
            }

            if (check_is_encrypted(bitmap))
            {
                MessageBox.Show("Невозможно зашифровать");
                return;
            }

            byte[] symbol_byte = Encoding.GetEncoding(1251).GetBytes("/");
            BitArray symbol_ba = byte_to_bit(symbol_byte[0]);
            Color current_color = bitmap.GetPixel(0, 0);
            BitArray btb_ba = byte_to_bit(current_color.R);
            btb_ba[0] = symbol_ba[0];
            btb_ba[1] = symbol_ba[1];
            byte R = bit_to_bytw(btb_ba);

            btb_ba = byte_to_bit(current_color.G);
            btb_ba[0] = symbol_ba[2];
            btb_ba[1] = symbol_ba[3];
            btb_ba[2] = symbol_ba[4];
            byte G = bit_to_bytw(btb_ba);

            btb_ba = byte_to_bit(current_color.B);
            btb_ba[0] = symbol_ba[5];
            btb_ba[1] = symbol_ba[6];
            btb_ba[2] = symbol_ba[7];
            byte B = bit_to_bytw(btb_ba);

            Color nColor = Color.FromArgb(R, G, B);

            bitmap.SetPixel(0, 0, nColor);
            write_text(text_count, bitmap);

            int index = 0;
            bool st = false;

            //по строкам
            //for (int j = 0; j < bitmap.Height; j++)
            //{
            //    for (int i = 4; i < bitmap.Width; i++)
            //    {
            //        Color pixel = bitmap.GetPixel(i, j);
            //        if (index == byte_list.Count)
            //        {
            //            st = true;
            //            break;
            //        }
            //        BitArray color_ba = byte_to_bit(pixel.R);
            //        BitArray text_ba = byte_to_bit(byte_list[index]);
            //        color_ba[0] = text_ba[0]; 
            //        color_ba[1] = text_ba[1]; 
            //        byte newR = bit_to_bytw(color_ba);

            //        color_ba = byte_to_bit(pixel.G);
            //        color_ba[0] = text_ba[2];
            //        color_ba[1] = text_ba[3];
            //        color_ba[2] = text_ba[4];
            //        byte newG = bit_to_bytw(color_ba);

            //        color_ba = byte_to_bit(pixel.B);
            //        color_ba[0] = text_ba[5];
            //        color_ba[1] = text_ba[6];
            //        color_ba[2] = text_ba[7];
            //        byte newB = bit_to_bytw(color_ba);

            //        Color newColor = Color.FromArgb(newR, newG, newB);
            //        bitmap.SetPixel(i, j, newColor);
            //        index++;
            //    }
            //    if (st)
            //    {
            //        break;
            //    }
            //}

            //по столбцам
            for (int j = 0; j < bitmap.Width; j++)
            {
                for (int i = 4; i < bitmap.Height; i++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    if (index == byte_list.Count)
                    {
                        st = true;
                        break;
                    }
                    BitArray colorArray = byte_to_bit(pixelColor.R);
                    BitArray messageArray = byte_to_bit(byte_list[index]);
                    colorArray[0] = messageArray[0]; 
                    colorArray[1] = messageArray[1]; 
                    byte newR = bit_to_bytw(colorArray);

                    colorArray = byte_to_bit(pixelColor.G);
                    colorArray[0] = messageArray[2];
                    colorArray[1] = messageArray[3];
                    colorArray[2] = messageArray[4];
                    byte newG = bit_to_bytw(colorArray);

                    colorArray = byte_to_bit(pixelColor.B);
                    colorArray[0] = messageArray[5];
                    colorArray[1] = messageArray[6];
                    colorArray[2] = messageArray[7];
                    byte newB = bit_to_bytw(colorArray);

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    bitmap.SetPixel(i, j, newColor);
                    index++;
                }
                if (st)
                {
                    break;
                }
            }

            image.Image = bitmap;
            StreamReader srd = new StreamReader("D:\\BSTU\\CISM-3c6s\\LR14\\input.txt");
            txtIn.Text = srd.ReadToEnd();
            srd.Close();

            String sif;
            SaveFileDialog sfd_image = new SaveFileDialog();
            sfd_image.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (sfd_image.ShowDialog() == DialogResult.OK)
            {
                sif = sfd_image.FileName;
            }
            else
            {
                sif = "";
                return;
            };

            FileStream fs_imgae;

            try
            {
                fs_imgae = new FileStream(sif, FileMode.Create); 
            }
            catch (IOException)
            {
                MessageBox.Show("File cannot be open", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bitmap.Save(fs_imgae, System.Drawing.Imaging.ImageFormat.Bmp);
            fs_imgae.Close(); 
        }

        private void decode(object sender, EventArgs e)
        {
            string image_file;
            OpenFileDialog ofd_image = new OpenFileDialog();
            ofd_image.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (ofd_image.ShowDialog() == DialogResult.OK)
            {
                image_file = ofd_image.FileName;
            }
            else
            {
                image_file = "";
                return;
            }

            FileStream fs_image;
            try
            {
                fs_image = new FileStream(image_file, FileMode.Open);
            }
            catch (IOException)
            {
                MessageBox.Show("File cannot be open", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap ba_image = new Bitmap(fs_image);
            if (!check_is_encrypted(ba_image))
            {
                MessageBox.Show("No encrypted info", "Error", MessageBoxButtons.OK);
                return;
            }

            int cs = read_text(ba_image);

            byte[] text = new byte[cs];
            int index = 0;
            bool st = false;

            //по строкам
            //for (int i = 4; i < ba_image.Width; i++)
            //{
            //    for (int j = 0; j < ba_image.Height; j++)
            //    {
            //        Color pixel = ba_image.GetPixel(i, j);
            //        if (index == text.Length)
            //        {
            //            st = true;
            //            break;
            //        }
            //        BitArray color_ba = byte_to_bit(pixel.R);
            //        BitArray text_ba = byte_to_bit(pixel.R); ;
            //        text_ba[0] = color_ba[0];
            //        text_ba[1] = color_ba[1];

            //        color_ba = byte_to_bit(pixel.G);
            //        text_ba[2] = color_ba[0];
            //        text_ba[3] = color_ba[1];
            //        text_ba[4] = color_ba[2];

            //        color_ba = byte_to_bit(pixel.B);
            //        text_ba[5] = color_ba[0];
            //        text_ba[6] = color_ba[1];
            //        text_ba[7] = color_ba[2];
            //        text[index] = bit_to_bytw(text_ba);
            //        index++;
            //    }
            //    if (st) break;
            //}

            //по столбцам
            for (int j = 0; j < ba_image.Width; j++)
            {
                for (int i = 4; i < ba_image.Height; i++)
                {
                    Color pixelColor = ba_image.GetPixel(i, j);
                    if (index == text.Length)
                    {
                        st = true;
                        break;
                    }
                    BitArray colorArray = byte_to_bit(pixelColor.R);
                    BitArray messageArray = byte_to_bit(pixelColor.R);
                    messageArray[0] = colorArray[0];
                    messageArray[1] = colorArray[1];

                    colorArray = byte_to_bit(pixelColor.G);
                    messageArray[2] = colorArray[0];
                    messageArray[3] = colorArray[1];
                    messageArray[4] = colorArray[2];

                    colorArray = byte_to_bit(pixelColor.B);
                    messageArray[5] = colorArray[0];
                    messageArray[6] = colorArray[1];
                    messageArray[7] = colorArray[2];
                    text[index] = bit_to_bytw(messageArray);
                    index++;
                }
                if (st) break;
            }

            string text_string = Encoding.GetEncoding(1251).GetString(text);
            text_string = text_string.Substring(0, text_count);

            string string_textfile;
            SaveFileDialog sfd_text = new SaveFileDialog();
            sfd_text.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (sfd_text.ShowDialog() == DialogResult.OK)
            {
                string_textfile = sfd_text.FileName;
            }
            else
            {
                string_textfile = "";
                return;
            };

            FileStream fs_text;
            try
            {
                fs_text = new FileStream(string_textfile, FileMode.Create);
            }
            catch (IOException)
            {
                MessageBox.Show("File cannot be open", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamWriter sw_text = new StreamWriter(fs_text, Encoding.Default);
            sw_text.Write(text_string);
            MessageBox.Show("Get text", "Success", MessageBoxButtons.OK);
            sw_text.Close();
            fs_text.Close();

            pictOut.Image = ba_image;
            StreamReader sr = new StreamReader("D:\\BSTU\\CISM-3c6s\\LR14\\output.txt");
            txtOut.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
