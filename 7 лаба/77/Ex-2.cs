using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _77
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        static int Ex_2_u(ref int a, ref int b)
        {
            if (a > (b - a))
                return a;
            else return (b - a);
        }
        static int Ex_2_v(ref int a, ref int b)
        {
            if (a * b < (a + b))
                return a * b;
            else return (a + b);
        }

        static double Ex__2(in int u, in int v, out double k)
        {
            if ((u + Math.Pow(v, 2)) < 3.14)
                k = (u + Math.Pow(v, 2));
            else k = 3.14;
            return k;
        }
            private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(this.input_a.Text);
                b = int.Parse(this.input_b.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Ошибка! \nВведите число.",
                    " ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            int u = Ex_2_u(ref a, ref b);
            int v = Ex_2_v(ref a, ref b);
            Ex__2(in u, in v, out double result);
            output_k.Text = Convert.ToString(result);

        }
    }

    
    }


