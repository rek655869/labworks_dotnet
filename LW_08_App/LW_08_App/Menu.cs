using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_08_App
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        UserControl us = new Ex_1();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 1:
                    {
                        UserControl us = new Ex_2();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 2:
                    {
                        var p = new Process();
                        p.StartInfo.FileName = "LW_08_Console.exe";
                        p.Start();
                        break;
                    }
                case 3:
                    {
                        Application.Exit();
                        break;
                    }
            }
        }
    }
}
