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
    public partial class Ex_4 : UserControl
    {
        public Ex_4()
        {
            InitializeComponent();
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            UserControl us = new Ex_4_LS("Длина окружности составляет {0:g6}", Calculator.len_circle);
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            UserControl us = new Ex_4_LS("Площадь круга составляет {0:g6}", Calculator.area_circle);
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void button_V_Click(object sender, EventArgs e)
        {
            UserControl us = new Ex_4_V();
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
