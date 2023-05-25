using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class UI : Form
    {
        static int g_main;
        static BigInteger a;
        List<BigInteger> array_cipher_text;
        int x;
        int egp;

        BigInteger p;
        BigInteger q;
        BigInteger n;
        BigInteger d;
        BigInteger m;
        BigInteger evalue;
        List<char> characters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                        'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                                                        'u', 'v', 'w', 'x', 'y', 'z',' ','.',',','!','?' };
        public UI()
        {
            InitializeComponent();
        }
        private bool IsTheNumberSimple(BigInteger n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        private BigInteger Calculate_e(BigInteger n)
        {
            BigInteger e = n - 1;

            for (long i = 2; i <= n; i++)
                if ((n % i == 0) && (e % i == 0))
                {
                    e--;
                    i = 1;
                }
            return e;
        }
        private long Calculate_d(BigInteger e, BigInteger n)
        {
            long d = 1000;

            while (true)
            {
                if ((e * d) % n == 1)
                    break;
                else
                    d++;
            }

            return d;
        }
        private void RSA_Encode_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            p = Convert.ToInt64(p_input.Text);
            q = Convert.ToInt64(q_input.Text);
            n = p * q;
            m = (p - 1) * (q - 1);
            evalue = Calculate_e(m);
            d = Calculate_d(evalue, m);
            string text = RSA_Input.Text.ToLower();
            text = encryptRSA(text);
            RSA_Output.Text = text;
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            ExecTime.Text = $"{elapsed.TotalMilliseconds:F2} мс (RSA Encode)";
        }
        private string encryptRSA(string text)
        {
            string output = "";
            foreach (var t in text)
            {
                Console.WriteLine(evalue);
                BigInteger index = characters.IndexOf(t);
                BigInteger c = BigInteger.Pow(index, (int)evalue) % n;
                output += c + " ";
            }
            return output;
        }
        private string decryptRSA(string text)
        {
            string result = "";
            string[] ciphers = text.Split(' ');
            List<string> buffer = new List<string>();
            foreach (var t in ciphers)
            {
                Console.WriteLine(t);
                buffer.Add(t.Trim(' '));
            }
            buffer.RemoveAt(buffer.Count - 1);
            foreach (var t in buffer)
            {
                long bufferNum = Convert.ToInt32(t);
                BigInteger index = BigInteger.ModPow(bufferNum, d, n);
                Console.WriteLine(index);
                result += characters[(int)index];

            }
            return result;
        }
        private void RSA_Decode_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string text = RSA_Output.Text;
            RSA_DecodedRes.Text = decryptRSA(text);
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            ExecTime.Text = $"{elapsed.TotalMilliseconds:F2} мс (RSA Decode)";
        }

        private void EG_Encode_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            EG_Output.Text = "";
            egp = 0;
            Random random = new Random();
            egp = getP();
            x = random.Next(1, egp - 1); //Генерирую закрытый ключ
            BigInteger y = BigInteger.Pow(g_main, x) % egp; //Нахожу открытый ключ
            array_cipher_text = new List<BigInteger>();
            array_cipher_text = egEncrypt(EG_Input.Text, egp, y);
            Console.WriteLine(array_cipher_text.Count);
            foreach (var t in array_cipher_text)
            {
                EG_Output.Text += t;
            }
            EG_text.Visible = true;
            El_Gamal_info.Visible = true;
            El_Gamal_info.Text = $"p: {egp}; g: {g_main}\r\ny (открытый ключ): {y}\r\nx (закрытый ключ): {x}";
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            ExecTime.Text = $"{elapsed.TotalMilliseconds:F2} мс (El-Gamal Encode)";
        }
        public static int getP()
        {
            Random random = new Random();
            int p = 0;
            Boolean boolean = false;
            do
            {
                p = random.Next(2000, 2500);

                for (int i = 2; i != p; i++)
                {
                    if (i == p - 1)
                    {
                        boolean = getG(p, p - 1);
                        break;
                    }
                    if (p % i == 0) break;
                }
            }
            while (boolean == false);
            return p;
        }
        public static bool getG(int p, int g)
        {
            bool boolean = false;
            List<BigInteger> array_mod_number = new List<BigInteger>();

            BigInteger integer = ((BigInteger.Pow(g, 1)) % p);
            array_mod_number.Add(integer);

            for (int i = 2; i != p; i++)
            {
                integer = BigInteger.Pow(g, i) % p;
                for (int j = 0; j != i - 1; j++)
                {
                    if (array_mod_number[j] == integer)
                    {
                        g--;
                        array_mod_number.Clear();
                        i = 1;
                        integer = BigInteger.Pow(g, 1) % p;
                        array_mod_number.Add(integer);
                        break;
                    }

                    if ((j == i - 2) && (array_mod_number[j] != integer))
                    {
                        array_mod_number.Add(integer);
                    }
                }
            }
            g_main = g;
            boolean = true;
            return boolean;
        }
        public static List<BigInteger> egEncrypt(string text, int p, BigInteger y)
        {
            List<BigInteger> array = new List<BigInteger>();
            Random random = new Random();
            int k = random.Next(1, p - 1);


            for (int i = 0; i != text.Length; i++)
            {
                a = BigInteger.Pow(g_main, k) % p;
                array.Add((BigInteger.Pow(y, k) * (int)text[i]) % p);
            }
            return array;
        }
        public static string egDecrypt(int length_text, List<BigInteger> array_number, int x, int p)
        {
            string save_text = "";
            BigInteger integer;

            for (int i = 0; i != length_text; i++)
            {
                integer = (array_number[i] * (BigInteger.Pow(a, p - 1 - x))) % p;
                save_text += (char)integer;
            }
            return save_text;
        }

        private void EG_Decode_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            EG_DecodedRes.Text = egDecrypt(EG_Input.Text.Length, array_cipher_text, x, egp);
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            ExecTime.Text = $"{elapsed.TotalMilliseconds:F2} мс (El-Gamal Decode)";
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
            RSA_Input.Text = "";
            RSA_Output.Text = "";
            RSA_DecodedRes.Text = "";
            p_input.Text = "";
            q_input.Text = "";
            El_Gamal_info.Text = "";
            EG_Input.Text = "";
            EG_Output.Text = "";
            EG_DecodedRes.Text = "";
            ExecTime.Text = "";
        }
    }
}
