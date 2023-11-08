using LW_08_App;
using LW_8__3;
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

namespace LW_08
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pth = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\" + @"\ConsoleApp\bin\Debug\ConsoleApp.exe");
            Control panel = Parent;

            switch (listBox1.SelectedIndex)
                {
                case 0:
                    {

                        UserControl us = new Ex_1();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 1:
                    {
                        Process.Start(pth);
                        break;
                    }
                case 2:
                    {
                        UserControl us = new Ex_2();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 3:
                    {
                        UserControl us = new Ex_3();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 4:
                    {
                        UserControl us = new Ex_4();
                        panel.Controls.Clear();
                        panel.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                }
        }
    }
}
