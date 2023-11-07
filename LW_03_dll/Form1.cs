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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainMenu_Click(this, EventArgs.Empty);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            UserControl us = new Menu();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
