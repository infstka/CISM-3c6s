using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    class Program
    {
        public static readonly int n = 253; //11 23
        public static readonly int x = 5;
        public static readonly int length = 13;

        public static int BBSnext(int prev, int index)
        {
            int res = (prev * prev) % n;
            return res;
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI());
        }
    }
}