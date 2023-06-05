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
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }


        class EC_Point
        {
            static int p = 751;
            public static int a = -1;
            public static int b = 1;
            public long x;
            public long y;

            public EC_Point(long x, long y)
            {
                this.x = x;
                this.y = y;
            }

            public static long calc_lambda(EC_Point p1, EC_Point p2)
            {
                long lambda;

                if (p1 == p2)
                {
                    long a, b;
                    long g = gcd(2 * p1.y, EC_Point.p, out a, out b);

                    lambda = ((3 * p1.x * p1.x + EC_Point.a) * a);
                }
                else
                {
                    long a, b;
                    long dx = p2.x - p1.x;
                    dx = (dx % EC_Point.p + EC_Point.p) % EC_Point.p;
                    long dy = p2.y - p1.y;
                    dy = (dy % EC_Point.p + EC_Point.p) % EC_Point.p;
                    long g = gcd(dx, EC_Point.p, out a, out b);

                    lambda = (dy * a);
                }
                lambda = (lambda % EC_Point.p + EC_Point.p) % EC_Point.p;

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

            public static EC_Point operator +(EC_Point p1, EC_Point p2)
            {
                long x;
                long y;
                long lambda = EC_Point.calc_lambda(p1, p2);

                if (p1.x == p2.x && p2.y == -(p1.y))
                {
                    return new EC_Point(0, 0);
                }

                x = lambda * lambda - p1.x - p2.x;
                x = (x % EC_Point.p + EC_Point.p) % EC_Point.p;
                y = lambda * (p1.x - x) - p1.y;
                y = (y % EC_Point.p + EC_Point.p) % EC_Point.p;

                return new EC_Point(x, y);
            }

            public static EC_Point operator *(EC_Point p1, int multiplier)
            {
                EC_Point tmp = p1;

                for (int i = 1; i < multiplier; ++i)
                {
                    tmp += p1;
                }

                return new EC_Point(tmp.x, tmp.y);
            }

            public static EC_Point operator -(EC_Point a)
            {
                return a * (EC_Point.p - 1);
            }

            public static bool operator ==(EC_Point p1, EC_Point p2)
            {
                return p1.x == p2.x && p1.y == p2.y;
            }


            public static bool operator !=(EC_Point p1, EC_Point p2)
            {
                return p1.x != p2.x && p1.y != p2.y;
            }

            public static int get_order(EC_Point G)
            {
                EC_Point tmp;

                for (int i = 1; i < 70000; i++)
                {
                    tmp = G;
                    tmp *= i;

                    if (tmp == new EC_Point(0, 0))
                        return i;
                }

                return -1;
            }
        }

        public static int a(int a, int n)
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

            EC_Point P = new EC_Point(56, 332);
            EC_Point Q = new EC_Point(69, 241);
            EC_Point R = new EC_Point(83, 373);


            EC_Point p1 = P * k;
            EC_Point p2 = P + Q;
            EC_Point p3 = p1 + (Q * l) + (-R);
            EC_Point p4 = P + (-Q) + R;

            result += $"\r\n\r\nkP: ({p1.x}, {p1.y})\r\n";
            result += $"P+Q: ({p2.x}, {p2.y})\r\n";
            result += $"kP+lQ-R: ({p3.x}, {p3.y})\r\n";
            result += $"P-Q+R: ({p4.x}, {p4.y})\r\n";

            task1.Text = result;
        }

        private void exec_task2_Click(object sender, EventArgs e)
        {
            EC_Point[] M = new EC_Point[3];
            EC_Point[] C = new EC_Point[6];
            EC_Point[] M2 = new EC_Point[3];

            EC_Point G = new EC_Point(0, 1);

            int d = 12;
            int k = 11;
            int j = 0;
            EC_Point Q_ = G * d;
            string result = "";

            result += $"Секретный ключ: {d}\r\n";
            result += $"Открытый ключ: ({Q_.x}, {Q_.y})\r\n";

            EC_Point m1 = new EC_Point(210, 31); 
            EC_Point m2 = new EC_Point(198, 224); 
            EC_Point m3 = new EC_Point(205, 372); 
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
            EC_Point G_ = new EC_Point(416, 55);
            int q = 13;
            EC_Point Q_sign = G_ * d;
            int H = 192 % 13; 
            EC_Point kG = G_ * k;

            int r = (int)kG.x % q;
            if (r == 0)
            {
                task3.Text = "Замените параметр k";
                return;
            }

            int t = a(k, q);

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
            result += $"Отправка r,s = ({r},{s})\r\n";

            if (r < 1 || s > q)
            {
                result += "Верификация провалена";
            }
            else
            {
                int w = a(s, q);
                int u1 = (w * H) % q;
                int u2 = (w * r) % q;

                EC_Point ver = G_ * u1 + Q_sign * u2;
                int v = (int)ver.x % q;
                if (v != r)
                {
                    result += "Верификация пройдена";
                }
            }

            task3.Text = result;
        }
    }
}
