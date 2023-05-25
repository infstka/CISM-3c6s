using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR11
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void encode_button_Click(object sender, EventArgs e)
        {
            output_textbox.Text = "";
            byte[] hash = Encoding.ASCII.GetBytes(input_textbox.Text);
            MD5 md5 = new MD5CryptoServiceProvider();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            byte[] hashenc = md5.ComputeHash(hash);

            foreach (var b in hashenc)
            {
                output_textbox.Text += b.ToString("x2");
            }
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            execTime_textbox.Text = $"{elapsed.TotalMilliseconds:F2} мс"; ;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            output_textbox.Text = "";
            execTime_textbox.Text = "";
        }
    }
}
