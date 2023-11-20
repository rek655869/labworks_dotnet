using System;
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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Control panel = Parent;
            switch (listBox1.SelectedIndex)
                {
                case 0:
                    {
                        UserControl us = new Ex_2();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                    
                case 1:
                    {
                        UserControl us = new Ex_1_3();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
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
