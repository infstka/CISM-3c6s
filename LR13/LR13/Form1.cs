using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int a_1(int a, int n)
        {
            int res = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (((a * i) % n) == 1) return (i);
            }
            return (res);
        }

        private void exec_task1_Click(object sender, EventArgs e)
        {
            int k = 9;
            int l = 7;

            int xx;
            double yy;
            string result = "";

            result += "Точки ЭК:\r\n";
            for (xx = 106; xx < 140; xx++)
            {
                yy = Math.Pow(xx, 3) - xx + 1;
                yy = yy % 751;
                result += $"({xx},{yy}); ";
            }

            Point P = new Point(56, 332);
            Point Q = new Point(69, 241);
            Point R = new Point(83, 373);


            Point p1 = P * k;
            Point p2 = P + Q;
            Point p3 = p1 + (Q * l) + (-R);
            Point p4 = P + (-Q) + R;

            result += $"\r\n\r\nkP: ({p1.x}, {p1.y})\r\n";
            result += $"P+Q: ({p2.x}, {p2.y})\r\n";
            result += $"kP+lQ-R: ({p3.x}, {p3.y})\r\n";
            result += $"P-Q+R: ({p4.x}, {p4.y})\r\n";

            task1.Text = result;
        }

        private void exec_task2_Click(object sender, EventArgs e)
        {
            Point[] M = new Point[3];
            Point[] C = new Point[6];
            Point[] M2 = new Point[3];

            Point G = new Point(0, 1);

            int d = 12;
            int k = 11;
            int j = 0;
            Point Q_ = G * d;
            string result = "";

            result += $"Секретный ключ: {d}\r\n";
            result += $"Открытый ключ: ({Q_.x}, {Q_.y})\r\n";

            // Зашифрование
            //ФИО
            Point m1 = new Point(210, 31); 
            Point m2 = new Point(198, 224); 
            Point m3 = new Point(205, 372); 
            M[0] = m1;
            M[1] = m2;
            M[2] = m3;

            for (int i = 0; i < 3; i++)
            {
                C[j] = G * k;
                j++;
                C[j] = M[i] + Q_ * k;
                j++;
            }

            //    //Расшифрование
            M2[0] = C[1] + ((-C[0]) * d);
            M2[1] = C[3] + ((-C[2]) * d);
            M2[2] = C[5] + ((-C[4]) * d);

            result += $"Исходный текст:\r\n({M[0].x}, {M[0].y}), ({M[1].x}, {M[1].y}), ({M[2].x}, {M[2].y})\r\n";
            result += $"Шифр:\r\n({C[0].x}, {C[0].y}), ({C[1].x}, {C[1].y}), ({C[2].x}, {C[2].y}),\r\n" +
                      $"({C[3].x}, {C[3].y}), ({C[4].x}, {C[4].y}), ({C[5].x}, {C[5].y})\r\n";
            result += $"Расшифрованный текст:\r\n({M2[0].x}, {M2[0].y}), ({M2[1].x}, {M2[1].y}), ({M2[2].x}, {M2[2].y})\r\n";

            task2.Text = result;
        }

        private void exec_task3_Click(object sender, EventArgs e)
        {
            int d = 4;
            int k = 11;
            Point G_ = new Point(416, 55);
            int q = 13;
            Point Q_sign = G_ * d;
            //Г
            int H = 192 % 13; 
            Point kG = G_ * k;

            // Генерация ЭЦП
            int r = (int)kG.x % q;
            if (r == 0)
            {
                task3.Text = "Замените параметр k";
                return;
            }

            int t = a_1(k, q);

            int s = (H * t + d * r) % q;
            if (s == 0)
            {
                task3.Text = "Замените параметр k";
                return;
            }

            string result = "";
            result += $"Открытый ключ Q: ({Q_sign.x}, {Q_sign.y})\r\n";
            result += $"kG: ({kG.x}, {kG.y})\r\n";
            result += $"Хэш: {H}\r\n";
            result += $"Отправляем получателю (r,s) = ({r},{s})\r\n";

            // Верификация ЭЦП
            if (r < 1 || s > q)
            {
                result += "Верификация провалена";
            }
            else
            {
                int w = a_1(s, q);
                int u1 = (w * H) % q;
                int u2 = (w * r) % q;

                Point ver = G_ * u1 + Q_sign * u2;
                int v = (int)ver.x % q;
                if (v != r)
                {
                    result += "Верификация пройдена";
                }
            }

            task3.Text = result;
        }
    }

    class Point
    {
        static int p = 751;
        public static int a = -1;
        public static int b = 1;
        public long x;
        public long y;

        public Point(long x, long y)
        {
            this.x = x;
            this.y = y;
        }

        public static long GetLambda(Point p1, Point p2)
        {
            long lambda;

            if (p1 == p2)
            {
                long a, b;
                long g = gcd(2 * p1.y, Point.p, out a, out b);

                lambda = ((3 * p1.x * p1.x + Point.a) * a);
            }
            else
            {
                long a, b;
                long dx = p2.x - p1.x;
                dx = (dx % Point.p + Point.p) % Point.p;
                long dy = p2.y - p1.y;
                dy = (dy % Point.p + Point.p) % Point.p;
                long g = gcd(dx, Point.p, out a, out b);

                lambda = (dy * a);
            }
            lambda = (lambda % Point.p + Point.p) % Point.p;

            return lambda;
        }

        static long gcd(long a, long b, out long x, out long y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            long x1, y1;
            long d = gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        // P + Q

        public static Point operator +(Point p1, Point p2)
        {
            long x;
            long y;
            long lambda = Point.GetLambda(p1, p2);

            if (p1.x == p2.x && p2.y == -(p1.y))
            {
                return new Point(0, 0);
            }

            x = lambda * lambda - p1.x - p2.x;
            x = (x % Point.p + Point.p) % Point.p;
            y = lambda * (p1.x - x) - p1.y;
            y = (y % Point.p + Point.p) % Point.p;

            return new Point(x, y);
        }

        // P * k

        public static Point operator *(Point p1, int multiplier)
        {
            Point tmp = p1;

            for (int i = 1; i < multiplier; ++i)
            {
                tmp += p1;
            }

            return new Point(tmp.x, tmp.y);
        }

        // - P

        public static Point operator -(Point a)
        {
            return a * (Point.p - 1);
        }

        // P == Q

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        // P != Q

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.x != p2.x && p1.y != p2.y;
        }


        public static int FindOrder(Point G)
        {
            Point tmp;

            for (int i = 1; i < 70000; i++)
            {
                tmp = G;
                tmp *= i;

                if (tmp == new Point(0, 0))
                    return i;
            }

            return -1;
        }
    }
}
