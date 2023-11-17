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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR_9_4
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
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
                        UserControl us = new Ex_3();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;

                    }
                case 3:
                    {
                        UserControl us = new Ex_4();
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
