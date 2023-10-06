using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_03
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class Calculator
    {
        static double factorial(int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }

        public static double EndlessSeries(double eps)
        {
            double s = 0, x = 1;
            for (int i = 1; x >= eps; i++)
            {
                x = 1 / (Math.Sqrt(factorial(i)));
                s += x;
            }
            return s;
        }
    }
}
