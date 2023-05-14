using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LR9
{
    public partial class UI : Form
    {
        Bag r = new Bag();
        int[] d2;
        int[] E;
        int[] C;
        int a;
        int n;

        public UI()
        {
            InitializeComponent();
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            d2 = r.Generate(8);
            string result = "";
            foreach (var item in d2)
            {
                result += item + " ";
            }
            sp_textbox.Text = result;
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var di in d2)
            {
                sum += di;
            }
            n = r.getN(sum);
            a = r.getA(n);
            E = r.getNorm(d2, a, n, d2.Length);
            string result = "";
            foreach (var item in E)
            {
                result += item + " ";
            }
            np_textbox.Text = result;
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            C = r.encode(E, input_textbox.Text, d2.Length);
            string result = "";
            foreach (var item in C)
            {
                result += item + " ";
            }
            output_textbox.Text = result;

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;

            exectime_textbox.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void decode_button_Click(object sender, EventArgs e)
        {
            int a_1 = r.a_1(a, n);
            string decodeStr = input_textbox.Text;
            int[] S = new int[C.Length];
            string M2 = "";

            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            for (int i = 0; i < C.Length; i++)
            {
                S[i] = (C[i] * a_1) % n;
            }

            foreach (int Si in S)
            {
                string M2i = r.decode(d2, Si, d2.Length);//110000
                M2 += M2i + " ";
            }

            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;

            exectime_textbox.Text = $"{elapsed.TotalMilliseconds:F2} мс";

            M2 = M2.Replace(" ", "");
            var stringArray = Enumerable.Range(0, M2.Length / 8).Select(i => Convert.ToByte(M2.Substring(i * 8, 8), 2)).ToArray();
            var str = Encoding.UTF8.GetString(stringArray);
            output_textbox.Text = str;
        }
    }
}
