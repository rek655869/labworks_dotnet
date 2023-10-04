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
    public partial class Ex_4_V : UserControl
    {
        public Ex_4_V()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, h;
            try
            {
                r = double.Parse(this.input_r.Text);
                h = double.Parse(this.input_h.Text);
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
            this.result.Text = string.Format("Объём цилиндра составляет {0:g6}", Calculator.vol_cylinder(r, h));
        }
    }
}
