using LR16;
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

namespace LR16
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        class Perc
        {
            int L = 3;
            int N = 8;
            public int[] input;
            public int[] weight;
            public int output;

            public Perc(int[] _weights)
            {
                weight = new int[N];
                for (int i = 0; i < _weights.Length; i++)
                {
                    weight[i] = _weights[i];
                }

            }

            public int get_output(int[] AInputs)
            {
                input = AInputs;
                output = 0;

                for (int i = 0; i < N; i++)
                {
                    output += input[i] * weight[i];
                }

                if (output > 0)
                {
                    output = 1;
                }

                else
                {
                    output = -1;
                }

                return output;
            }

            public void weights(int tpm_output)
            {
                if (tpm_output == output)
                {
                    for (int i = 0; i < N; i++)
                    {
                        weight[i] = weight[i] + (output * input[i]);
                        if (weight[i] >= L)
                        {
                            weight[i] = L;
                        }
                        else if (weight[i] < -L)
                        {
                            weight[i] = -L;
                        }
                    }
                }
            }
        }

        class TreeParityMachine
        {
            public Perc[] percepts;
            int output;
            int K = 5;
            int N = 8;

            public TreeParityMachine(int[] first, int[] second, int[] third, int[] fourth, int[] fifth)
            {
                percepts = new Perc[5] { new Perc(first), new Perc(second), new Perc(third), new Perc(fourth), new Perc(fifth) };
            }

            public TreeParityMachine() { }

            public int get_output(int[,] Ainputs)
            {
                output = 1;
                for (int i = 0; i < K; i++)
                {
                    int[] buffer = new int[8];
                    for (int j = 0; j < N; j++)
                    {
                        buffer[j] = Ainputs[i, j];
                    }
                    output *= percepts[i].get_output(buffer);
                }
                return output;
            }

            public void get_sync()
            {
                for (int i = 0; i < K; i++)
                {
                    percepts[i].weights(output);
                }
            }

            public List<int> get_weight()
            {
                List<int> list = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        list.Add(percepts[j].weight[i]);
                    }
                }
                return list;
            }
        }
        private void sync_Click(object sender, EventArgs e)
        {
            int avgNumbOfSteps = 0;
            long avgExecTime = 0;

            for (int realizations = 0; realizations < 10; realizations++)
            {
                rlztns.Text = realizations.ToString();
                Random random = new Random();
                TreeParityMachine first = new TreeParityMachine();
                TreeParityMachine second = new TreeParityMachine();

                for (int i = 0; i < 2; i++)
                {
                    int[] first_buf = new int[8];
                    int[] second_buf = new int[8];
                    int[] third_buf = new int[8];
                    int[] fourth_buf = new int[8];
                    int[] fifth_buf = new int[8];

                    for (int j = 0; j < 8; j++)
                    {
                        first_buf[j] = random.Next(-6, 6);
                        second_buf[j] = random.Next(-6, 6);
                        third_buf[j] = random.Next(-6, 6);
                        fourth_buf[j] = random.Next(-6, 6);
                        fifth_buf[j] = random.Next(-6, 6);
                    }

                    if (i == 0)
                    {
                        first = new TreeParityMachine(first_buf, second_buf, third_buf, fourth_buf, fifth_buf);
                    }

                    else
                    {
                        second = new TreeParityMachine(first_buf, second_buf, third_buf, fourth_buf, fifth_buf);
                    }
                }

                bool flag_boolean = true;
                int count = 0;
                Random new_random = new Random();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (flag_boolean)
                {
                    int[,] first_array = new int[5, 8];
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            int buffer = random.Next(0, 2);
                            if (buffer == 1)
                            {
                                first_array[i, j] = 1;
                            }
                            else
                            {
                                first_array[i, j] = -1;
                            }
                        }
                    }
                    count++;

                    if (first.get_output(first_array) == second.get_output(first_array))
                    {

                        first.get_sync();
                        second.get_sync();
                        List<int> first_weight = first.get_weight();
                        List<int> second_weight = second.get_weight();

                        bool isSimilarFlag = true;

                        for (int i = 0; i < first_weight.Count; i++)
                        {
                            Console.Write(first_weight[i] + " ");
                            if (first_weight[i] != second_weight[i])
                            {
                                isSimilarFlag = false;
                            }
                        }

                        if (isSimilarFlag)
                        {
                            stopwatch.Stop();
                            res_tb.Text += "Реализация №" + realizations;
                            res_tb.Text += "\nКол-во шагов: " + count + "\n";
                            res_tb.Text += "Вектор весов №1: ";

                            foreach (var a in first_weight)
                            {
                                res_tb.Text += a + " ";
                            }

                            res_tb.Text += "\nВектор весов №2: ";

                            foreach (var a in second_weight)
                            {
                                res_tb.Text += a + " ";
                            }

                            // Получаем время выполнения в миллисекундах
                            TimeSpan elapsed = stopwatch.Elapsed;
                            res_tb.Text += "\nВремя выполнения: " + $"{elapsed.TotalMilliseconds:F2} мс";
                            res_tb.Text += "\r\n--------------------------------------------------------------------------------------------\r\n";
                            avgNumbOfSteps += count;
                            avgExecTime += stopwatch.ElapsedMilliseconds;
                            flag_boolean = false;

                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }

            }

            avgSteps.Text += avgNumbOfSteps / 10;
            avgTime.Text += avgExecTime / 10 + " мс";
        }
    }
}
