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
    public partial class Ex_5 : UserControl
    {
        public Ex_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            СargoPlane plane = new СargoPlane();
            plane.name = input_name.Text;
            try
            {
                plane.middle_cargo = double.Parse(input_mc.Text);
                plane.fuel_consumption = double.Parse(input_fc.Text);
                plane.flight_range = double.Parse(input_fr.Text);
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
            plane.autopilot = input_ap.Checked;
            result.MaximumSize = this.Parent.Size;
            result.Text = plane.info();
        }
    }
}
