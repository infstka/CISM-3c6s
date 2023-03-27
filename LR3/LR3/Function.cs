using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Function
    {
        //проверка на простоту
        public static bool IsPrimeNumber(int n)
        {
            bool result = true;

            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {

                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        //решето эратосфена
        public static List<int> SieveOfEratosthenes(int a, int b)
        {
            List<int> list = new List<int>();
            int n = a;
            for (int i = 2; i <= b; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 2; j <= b; j++)
                {
                    list.Remove(list[i] * j);

                }
            }

            list.RemoveAll(num => num < a);

            return list;
        }

        //алгоритм евклида
        public static int Evklid_NOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }

        //алгоритм евклида для нод 3 чисел
        public static int Evklid_NOD_Three(int a, int b, int c)
        {
            return Evklid_NOD(Evklid_NOD(a, b), c);
        }
    }
}
