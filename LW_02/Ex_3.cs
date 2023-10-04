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
    public partial class Ex_3 : UserControl
    {
        public Ex_3()
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
            z = Calculator.check_point(x, y);
            if (z <= 1)
                this.result.Text = string.Format("Точка принадлежит единичной окружности, т.к. гипотенуза {0:g6}", z);
             else
                this.result.Text = string.Format("Точка НЕ принадлежит единичной окружности, т.к. гипотенуза {0:g6}", z);
        }
    }
}
