using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LR9
{
    public partial class UI : Form
    {
        Bag bag = new Bag();
        int[] sis;
        int[] ns;
        int[] bag_encode;
        int a;
        int n;

        public UI()
        {
            InitializeComponent();
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            sis = bag.generate_superincreasing_sequence(8);
            string result = "";
            foreach (var item in sis)
            {
                result += item + " ";
            }
            sp_textbox.Text = result;
        }

        private void ns_calc_button_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var di in sis)
            {
                sum += di;
            }
            n = bag.get_N(sum);
            a = bag.get_A(n);
            ns = bag.generate_norm_sequence(sis, a, n, sis.Length);
            string result = "";
            foreach (var item in ns)
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

            bag_encode = bag.encode(ns, input_textbox.Text, sis.Length);
            string result = "";
            foreach (var item in bag_encode)
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
            int a = bag.a(this.a, n);
            string decodeStr = input_textbox.Text;
            int[] S = new int[bag_encode.Length];
            string M2 = "";

            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            for (int i = 0; i < bag_encode.Length; i++)
            {
                S[i] = (bag_encode[i] * a) % n;
            }

            foreach (int Si in S)
            {
                string M2i = bag.decode(sis, Si, sis.Length);//110000
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
