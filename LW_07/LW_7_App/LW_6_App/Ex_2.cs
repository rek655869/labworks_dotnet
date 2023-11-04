using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace LW_6_App
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }
        static void exercise_1_2(out double a, out double b, double x, double y, double z)
        {
            a = Math.Pow(x, 2) / (8 + Math.Pow(x, 2) / 3 + Math.Pow(y, 2) / 6);
            b = x * (Math.Pow(Math.Cos(z + x), 3) + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Clear();
                textBox5.Clear();
                double x, y, z, a, b;
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                exercise_1_2(out a, out b, x, y, z);
                textBox4.Text = Convert.ToString(Math.Round(a, 3));
                textBox5.Text = Convert.ToString(Math.Round(b, 3));
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
