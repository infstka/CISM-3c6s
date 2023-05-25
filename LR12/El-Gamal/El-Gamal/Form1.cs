using System;
using System.Windows.Forms;
using System.Numerics;
using System.Diagnostics;

namespace El_Gamal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtP.Text = "2137";
            txtG.Text = "2127";
            txtX.Text = "1116";
            txtK.Text = "7";
            txtH.Text = "2119";
        }

        private int CalculateInverse(int a, int n)
        {
            for (int i = 1; i < n; i++)
            {
                if ((a * i) % n == 1)
                    return i;
            }
            return 0;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // Создаем объект Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Начинаем измерение времени
            stopwatch.Start();

            int p, g, x, k, H;

            if (!int.TryParse(txtP.Text, out p) || !int.TryParse(txtG.Text, out g) ||
                !int.TryParse(txtX.Text, out x) || !int.TryParse(txtK.Text, out k) ||
                !int.TryParse(txtH.Text, out H))
            {
                MessageBox.Show("Invalid input! Please enter valid integer values.");
                return;
            }

            int y = (int)BigInteger.ModPow(g, x, p);
            int m = p - 1;
            int k_1 = CalculateInverse(k, m);
            BigInteger a = BigInteger.ModPow(g, k, p);
            BigInteger b = (k_1 * (H - (x * a) % m) % m) % m;

            txtY.Text = y.ToString();
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            // Останавливаем измерение времени
            stopwatch.Stop();

            // Получаем время выполнения в миллисекундах
            TimeSpan elapsed = stopwatch.Elapsed;

            execTime.Text = $"{elapsed.TotalMilliseconds:F2} мс";
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int p, g, y, H;
            BigInteger a, b;

            if (!int.TryParse(txtP.Text, out p) || !int.TryParse(txtG.Text, out g) ||
                !int.TryParse(txtY.Text, out y) || !int.TryParse(txtH.Text, out H) ||
                !BigInteger.TryParse(txtA.Text, out a) || !BigInteger.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Invalid input! Please enter valid integer values.");
                return;
            }

            BigInteger ya = BigInteger.ModPow(y, a, p);
            BigInteger ab = BigInteger.ModPow(a, b, p);
            BigInteger pr1 = (ya * ab) % p;
            BigInteger pr2 = BigInteger.ModPow(g, H, p);

            if (pr1 == pr2)
            {
                MessageBox.Show("Verification passed successfully.");
            }
            else
            {
                MessageBox.Show("Verification failed. The signature is not valid.");
            }
        }
    }
}
