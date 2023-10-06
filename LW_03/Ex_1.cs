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
            input_TextChanged(this, EventArgs.Empty);
        }

        private void input_TextChanged(object sender, EventArgs e)
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
            this.result.Text = string.Format("{0:g6}", Calculator.EndlessSeries(eps));
        }
    }
}
