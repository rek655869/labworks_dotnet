using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            MenuItem_Click(this, EventArgs.Empty);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new Menu();
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
