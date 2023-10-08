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
    public partial class Ex_4 : UserControl
    {
        public Ex_4()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int n;
                if (textBox1.Modified) textBox2.Clear();
                n = Int32.Parse(textBox1.Text);
                if (n != 0)
                {
                    int k = 1;
                    double sum = 0;
                    double res;
                    int n1 = n;
                    while (k <= n)
                    {
                        res = Math.Pow(k, n1);
                        sum += res;
                        k++;
                        n1--;
                    }

                    textBox2.Text = sum.ToString();
                }
                if (n == 0)
                {
                    MessageBox.Show("Вы ввели 0, введите число больше 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
