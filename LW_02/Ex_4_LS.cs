using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_02
{
    public partial class Ex_4_LS : UserControl
    {
        private string str;
        private Func<double, double> func;
        public Ex_4_LS(string str1, Func<double, double> func1)
        {
            InitializeComponent();
            str = str1;
            func = func1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                r = double.Parse(this.input_r.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Проверьте введённые данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
                throw;
            }
            this.result.Text = string.Format(str, func(r));

        }
    }
}
