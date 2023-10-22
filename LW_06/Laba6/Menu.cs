using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
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
                        var p = new Process();
                        p.StartInfo.FileName = "ConsoleApp_Laba6.exe";
                        p.Start();
                        break;
                    }
                case 1:
                    {
                        UserControl us = new Ex_1();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 2:
                    {
                        UserControl us = new Ex_2();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;

                    }
                case 3:
                    {
                        UserControl us = new Ex_3();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 4:
                    {
                        Application.Exit();
                        break;

                    }


            }
        }
    }
}
