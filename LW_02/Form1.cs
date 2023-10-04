using System;
using System.Drawing;
using System.Windows.Forms;

namespace LW_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainPanel.Controls.Add(variant);
        }

        private void ex_1_click(object sender, EventArgs e)
        {
            UserControl us = new Ex_1();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void ex_2_click(object sender, EventArgs e)
        {
            UserControl us = new Ex_2();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void ex_3_click(object sender, EventArgs e)
        {
            UserControl us = new Ex_3();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void ex_4_Click(object sender, EventArgs e)
        {
            UserControl us = new Ex_4();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void ex_5_Click(object sender, EventArgs e)
        {
            UserControl us = new Ex_5();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
