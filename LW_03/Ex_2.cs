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
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.AutoSize = false;
                textBox2.Height = 85;
                if (textBox1.Modified) textBox2.Clear();
                double xn, xk, x, x1, i; //начало, конец, шаг
                int j;
                xn = -3;
                xk = 3;
                int count = 0;
                double sum = 0;
                x = Convert.ToDouble(textBox1.Text);
                for (i = xn; i <= xk; i += x)
                {
                    count++;
                }
                double[] mas = new double[count];
                x1 = xn;
                for (j = 0; j <= count - 1; j++)
                {
                    mas[j] = Math.Round(-2 + Math.Sqrt(2 * Math.Pow((x1 + 1), 2) * (5 - x1)), 1);
                    if (j != count - 1)
                    {
                        textBox2.Text += ((mas[j].ToString()) + ";  ");
                        x1 += x;
                    }

                    else
                    {
                        textBox2.Text += (mas[j].ToString());
                        x1 += x;
                    }
                    sum += mas[j];

                }
                textBox3.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
