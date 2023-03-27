using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR3
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void task1_button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(task1_textbox1.Text);

            if (Function.IsPrimeNumber(num)) task1_textbox2.Text = "простое";
            else task1_textbox2.Text = "составное";
        }

        private void task2_button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task2_textbox1.Text);
            int b = Convert.ToInt32(task2_textbox2.Text);
            task2_textbox3.Text = Convert.ToString(Function.Evklid_NOD(a, b));
        }

        private void task3_button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task3_textbox1.Text);
            int b = Convert.ToInt32(task3_textbox2.Text);
            int c = Convert.ToInt32(task3_textbox3.Text);
            task3_textbox4.Text = Convert.ToString(Function.Evklid_NOD_Three(a, b, c));
        }

        private void task4_button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task4_textbox1.Text);
            int b = Convert.ToInt32(task4_textbox2.Text);
            List<int> result = new List<int>();
            result = Function.SieveOfEratosthenes(a, b);
            string resultToString = string.Join(", ", result);

            task4_textbox3.Text = resultToString;
            task4_textbox4.Text = Convert.ToString(result.Count);
            if (a > 1)
            {
                task4_textbox5.Text = Convert.ToString(b / Math.Log(b));
            }
            else
            {
                task4_textbox5.Text = "a > 1";
            }
        }

        private void task1_button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32("421457");

            if (Function.IsPrimeNumber(num)) task1_textbox2.Text = "простое";
            else task1_textbox2.Text = "составное";
        }

        private void task5_button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(task5_textbox1.Text);
            StringBuilder result = new StringBuilder();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    if (!dict.ContainsKey(i))
                    {
                        dict[i] = 1;
                    }
                    else
                    {
                        dict[i]++;
                    }
                    num /= i;
                }
            }

            foreach (int key in dict.Keys)
            {
                result.Append(key.ToString());
                if (dict[key] > 1)
                {
                    result.Append("^" + dict[key].ToString());
                }
                result.Append(" * ");
            }

            if (result.Length > 0)
            {
                result.Remove(result.Length - 3, 3);
                task5_textbox2.Text = result.ToString();
            }
            else
            {
                task5_textbox2.Text = "1";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            task1_textbox1.Text = "";
            task1_textbox2.Text = "";
            task2_textbox1.Text = "";
            task2_textbox2.Text = "";
            task2_textbox3.Text = "";
            task3_textbox1.Text = "";
            task3_textbox2.Text = "";
            task3_textbox3.Text = "";
            task3_textbox4.Text = "";
            task4_textbox1.Text = "";
            task4_textbox2.Text = "";
            task4_textbox3.Text = "";
            task4_textbox4.Text = "";
            task4_textbox5.Text = "";
            task5_textbox1.Text = "";
            task5_textbox2.Text = "";
        }
    }


}
