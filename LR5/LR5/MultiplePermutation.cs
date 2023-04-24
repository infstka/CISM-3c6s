using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR5
{
    internal class MultiplePermutation
    {
        public static string Encrypt(string message, string k1, string k2)
        {
            // Строим таблицу
            int rows = k1.Length;
            int cols = k2.Length;
            char[,] table = new char[rows, cols];

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index < message.Length)
                    {
                        table[i, j] = message[index++];
                    }
                    else
                    {
                        table[i, j] = ' ';
                    }
                }
            }

            // Сортируем строки по нумерации букв в ключевом слове k1
            List<int> k1Numbers = new List<int>();
            foreach (char c in k1)
            {
                k1Numbers.Add(c - 'a' + 1); // Ставим числа в соответствие буквам слова k1
            }

            int[] sortedRowIndexes = Enumerable.Range(0, rows).OrderBy(i => k1Numbers[i]).ToArray();

            char[,] sortedRowsTable = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sortedRowsTable[i, j] = table[sortedRowIndexes[i], j];
                }
            }

            // Сортируем столбцы по нумерации букв в ключевом слове k2
            List<int> k2Numbers = new List<int>();
            foreach (char c in k2)
            {
                k2Numbers.Add(c - 'a' + 1); // Ставим числа в соответствие буквам слова k2
            }

            int[] sortedColIndexes = Enumerable.Range(0, cols).OrderBy(j => k2Numbers[j]).ToArray();

            char[,] sortedTable = new char[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    sortedTable[i, j] = sortedRowsTable[i, sortedColIndexes[j]];
                }
            }

            // Считываем по колонкам
            StringBuilder result = new StringBuilder();
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    result.Append(sortedTable[i, j]);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string encryptedMessage, string k1, string k2)
        {
            // создаем таблицу и по колонкам записываем в неё зашифрованное сообщение
            int rows = k1.Length;
            int cols = k2.Length;
            char[,] table = new char[rows, cols];

            int index = 0;
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    table[i, j] = encryptedMessage[index++];
                }
            }

            // сортируем колонки по ключевому слову k2 
            List<int> k2Numbers = new List<int>();
            foreach (char c in k2)
            {
                k2Numbers.Add(c - 'a' + 1);
            }

            int[] sortedColIndexes = Enumerable.Range(0, cols).OrderBy(j => k2Numbers[j]).ToArray();

            char[,] sortedTable = new char[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    sortedTable[i, sortedColIndexes[j]] = table[i, j];
                }
            }

            List<int> k1Numbers = new List<int>();
            foreach (char c in k1)
            {
                k1Numbers.Add(c - 'a' + 1);
            }

            int[] sortedRowIndexes = Enumerable.Range(0, rows).OrderBy(i => k1Numbers[i]).ToArray();

            char[,] sortedRowsTable = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sortedRowsTable[sortedRowIndexes[i], j] = sortedTable[i, j];
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.Append(sortedRowsTable[i, j]);
                }
            }

            return result.ToString().TrimEnd();
        }

    }
}
