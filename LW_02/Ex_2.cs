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
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, angle;
            try
            {
                x = double.Parse(this.input_x.Text);
                y = double.Parse(this.input_y.Text);
                angle = double.Parse(this.input_angle.Text);
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
            if (angle < 0 || angle > 360)
            {
                MessageBox.Show(
                     "Угол не может быть меньше 0 или больше 360",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            this.result.Text = string.Format(
                "Значение третьей стороны: {0:g6}\n\n" +
                "Площадь треугольника: {0:g6}", 
                Calculator.get_third(x, y, angle), 
                Calculator.get_area(x, y, angle));
        }
    }
}
