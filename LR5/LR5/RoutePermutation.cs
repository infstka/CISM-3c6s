using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class RoutePermutation
    {
        public static (char[,] table, int rows, int cols, string result) Encrypt(string text, int rows)
        {
            text = text.Replace("\n", "").Replace("\r", "");
            int cols = Convert.ToInt32(Math.Floor(Convert.ToDouble(text.Length - 1) / rows) + 1);

            // создаем таблицу и заполняем пробелами
            char[,] table = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    table[i, j] = ' ';
                }
            }

            // заполняем таблицу шифруемым сообщением горизонтально слева направо
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index < text.Length)
                    {
                        table[i, j] = text[index];
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // считываем текст из таблицы змейкой
            string encrypted = "";
            int x = 0;
            int y = 0;
            bool directionUp = true;

            for (int step = 0; step < rows * cols; step++)
            {
                encrypted += table[x, y];
                if (directionUp)
                {
                    if (x == 0 || y == cols - 1)
                    {
                        directionUp = false;
                        if (y == cols - 1)
                        {
                            x++;
                        }
                        else
                        {
                            y++;
                        }
                    }
                    else
                    {
                        x--;
                        y++;
                    }
                }
                else
                {
                    if (y == 0 || x == rows - 1)
                    {
                        directionUp = true;
                        if (x == rows - 1)
                        {
                            y++;
                        }
                        else
                        {
                            x++;
                        }
                    }
                    else
                    {
                        x++;
                        y--;
                    }
                }
            }

            //encrypted = encrypted.Replace("\n", "").Replace("\r", "");

            return (table, rows, cols, encrypted);
        }

        public static string Decrypt(string encrypted, int rows)
        {
            int cols = Convert.ToInt32(Math.Floor(Convert.ToDouble(encrypted.Length - 1) / rows) + 1);

            char[,] table = new char[rows, cols];
            int x = 0;
            int y = 0;
            bool directionUp = true;

            // fill the table with placeholder characters
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    table[i, j] = ' ';
                }
            }

            // write the characters from the encrypted string into the table
            for (int i = 0; i < encrypted.Length; i++)
            {
                table[x, y] = encrypted[i];
                if (directionUp)
                {
                    if (x == 0 || y == cols - 1)
                    {
                        directionUp = false;
                        if (y == cols - 1)
                        {
                            x++;
                        }
                        else
                        {
                            y++;
                        }
                    }
                    else
                    {
                        x--;
                        y++;
                    }
                }
                else
                {
                    if (y == 0 || x == rows - 1)
                    {
                        directionUp = true;
                        if (x == rows - 1)
                        {
                            y++;
                        }
                        else
                        {
                            x++;
                        }
                    }
                    else
                    {
                        x++;
                        y--;
                    }
                }
            }

            string decrypted = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    decrypted += table[i, j];
                }
            }

            return decrypted.Trim();
        }

    }
}
