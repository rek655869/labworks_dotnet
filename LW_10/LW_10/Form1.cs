﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1_Click(null, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Size = new Size(600, 300);
            UserControl menu = new Menu();
            menu.Location = new Point((panel1.ClientSize.Width - menu.Width) / 2, 10);
            panel1.Controls.Add(menu);
        }
    }
}
