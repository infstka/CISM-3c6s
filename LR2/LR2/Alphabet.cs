using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Alphabet
    {        
        //32
        char[] polski = {'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś', 't', 'u',
            'w', 'y', 'z', 'ź', 'ż'};
        //30
        char[] bulgarian = {'а','б','в','г','д','е','ж','з','и','й','к','л','м','н',
            'о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ь','ю','я'};

        char[] binary = {'0', '1'};

        public char[] Polski { get => polski; set => polski = value; }
        public char[] Bulgarian { get => bulgarian; set => bulgarian = value; }
        public char[] Binary { get => binary; set => binary = value; }

        //энтропия шеннона
        public double EntropyShennon(String file, char[] alf)
        {
            double resEntropy = 0;
            int[] count = new int[alf.Length];
            double[] probability = new double[alf.Length];
            if (alf == polski || alf == bulgarian || alf == binary)
            {
                Console.WriteLine("Количество вхождений символа");
                
                for (int i = 0; i < alf.Length; i++)
                {
                    //кол-во символов
                    count[i] = file.Where(el => el == alf[i]).Count();

                    if (i < count.Length && count[i] != 0)
                        Console.WriteLine(alf[i] + " — " + count[i]);

                }

                Console.WriteLine("Вероятность вхождения символа");
                double sumProbability = 0;
                for (int i = 0; i < alf.Length; i++)
                {
                    if (count[i] != 0)
                    {
                        probability[i] = (double)count[i] / file.Length;
                        Console.WriteLine(alf[i] + " — " + probability[i]);
                        sumProbability += probability[i];
                        resEntropy += probability[i] * Math.Log(probability[i], 2);
                    }
                }
                Console.WriteLine("Сумма вероятностей:" + sumProbability);


            }
            return -resEntropy;
        }

        //энтропия бин алф
        public string GetBytes(String str)
        {
            String strB = "";
            for (int i = 0; i < str.Length; i++)
            {
                strB += Convert.ToString((int)str[i], 2) + " ";
            }
            return strB;
        }

        //кол-во информации
        public double countInf(double entropy, double N)
        {
            return entropy * N;
            //где N - кол-во символов
        }

        //кол-во информации с ошибочной передачей
        public double countInformationWithMistake(double entropy, int N, double p)
        {
            double q = 1 - p;
            double result = 0;
            result = -p * Math.Log(p) / Math.Log(2) - q * Math.Log(q) / Math.Log(2);
            //Console.WriteLine(result);
            return N * (1 - result);
        }

    }
}
