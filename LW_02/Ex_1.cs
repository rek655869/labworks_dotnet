using System;
using System.Windows.Forms;

namespace LW_02
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            try
            {
                x = double.Parse(this.input_x.Text);
                y = double.Parse(this.input_y.Text);
                z = double.Parse(this.input_z.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Проверьте введённые данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            this.result.Text = string.Format("Значение a: {0:g6}\n\nЗначение b: {0:g6}", Calculator.func_a(x, y), Calculator.func_b(x, z));
        }
    }
}
