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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sync_Click(object sender, EventArgs e)
        {
            int avgNumbOfSteps = 0;
            long avgExecTime = 0;
            for (int realizations = 0; realizations < 10; realizations++)
            {
                rlztns.Text = realizations.ToString();
                Random rnd = new Random();
                TPM first = new TPM();
                TPM second = new TPM();
                for (int i = 0; i < 2; i++)
                {
                    int[] firstBuffer = new int[8];
                    int[] secondBuffer = new int[8];
                    int[] thirdBuffer = new int[8];
                    int[] fourthBuffer = new int[8];
                    int[] fifthBuffer = new int[8];

                    for (int j = 0; j < 8; j++)
                    {
                        firstBuffer[j] = rnd.Next(-6, 6);
                        secondBuffer[j] = rnd.Next(-6, 6);
                        thirdBuffer[j] = rnd.Next(-6, 6);
                        fourthBuffer[j] = rnd.Next(-6, 6);
                        fifthBuffer[j] = rnd.Next(-6, 6);
                    }
                    if (i == 0)
                    {
                        first = new TPM(firstBuffer, secondBuffer, thirdBuffer, fourthBuffer, fifthBuffer);
                    }
                    else
                    {
                        second = new TPM(firstBuffer, secondBuffer, thirdBuffer, fourthBuffer, fifthBuffer);
                    }
                }
                bool flag = true;
                int stepcounter = 0;
                Random local = new Random();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (flag)
                {

                    int[,] firstArray = new int[5, 8];
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            int buffer = local.Next(0, 2);
                            if (buffer == 1)
                            {
                                firstArray[i, j] = 1;
                            }
                            else
                            {
                                firstArray[i, j] = -1;
                            }
                        }
                    }
                    stepcounter++;
                    if (first.GetOutput(firstArray) == second.GetOutput(firstArray))
                    {

                        first.Synchronize();
                        second.Synchronize();
                        List<int> firstWeights = first.getWeights();
                        List<int> secondWeights = second.getWeights();
                        bool similarFlag = true;
                        for (int i = 0; i < firstWeights.Count; i++)
                        {
                            Console.Write(firstWeights[i] + " ");
                            if (firstWeights[i] != secondWeights[i])
                            {
                                similarFlag = false;
                            }
                        }
                        if (similarFlag)
                        {
                            stopwatch.Stop();
                            res_tb.Text += "Реализация №" + realizations;
                            res_tb.Text += "\nКол-во шагов: " + stepcounter + "\n";
                            res_tb.Text += "Вектор весов №1: ";
                            foreach (var a in firstWeights)
                            {
                                res_tb.Text += a + " ";
                            }
                            res_tb.Text += "\nВектор весов №2: ";
                            foreach (var a in secondWeights)
                            {
                                res_tb.Text += a + " ";
                            }

                            // Получаем время выполнения в миллисекундах
                            TimeSpan elapsed = stopwatch.Elapsed;
                            res_tb.Text += "\nВремя выполнения: " + $"{elapsed.TotalMilliseconds:F2} мс";
                            res_tb.Text += "\r\n--------------------------------------------------------------------------------------------\r\n";
                            avgNumbOfSteps += stepcounter;
                            avgExecTime += stopwatch.ElapsedMilliseconds;
                            flag = false;

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
