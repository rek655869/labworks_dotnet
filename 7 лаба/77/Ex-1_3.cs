using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _77
{
    public partial class Ex_1_3 : UserControl
    {
        public Ex_1_3()
        {
            InitializeComponent();
        }

         void Ex_1(int n)
        {
            int res = 0;
            int[] mas = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = random.Next(-10, 10);

                output_mas.Text += mas[i] + " ";
                if (mas[i] > 0)
                    res++;
            }
            output_res.Text = Convert.ToString(res);
        }
        private void start_Click(object sender, EventArgs e)
        {
           
            int n;
            try
            {
                n = int.Parse(this.input_n.Text);

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

            Ex_1(n);

        }
    }
}
