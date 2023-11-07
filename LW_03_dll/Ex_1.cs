using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_03
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            double eps;
            try
            {
                eps = double.Parse(this.input.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Ожидается целое число или число с плавающей точкой. Проверьте введённые данные.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            this.res.Text = string.Format("{0:g6}", EndlessSeries(eps));
        }
    }
}
