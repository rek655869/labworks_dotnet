using LW_6_App;
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

namespace LW_07
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string pth = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\" + @"\ConsoleApp\bin\Debug\ConsoleApp.exe");
            Control panel = Parent;

            if (!checkBox1.Checked) 
            {
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
                            UserControl us = new Ex_2();
                            panel.Controls.Clear();
                            panel.Controls.Add(us);
                            us.Dock = DockStyle.Fill;
                            break;
                        }  
                    case 2:
                        {
                            UserControl us = new Ex_3();
                            panel.Controls.Clear();
                            panel.Controls.Add(us);
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
                            UserControl us = new Ex_5();
                            Controls.Clear();
                            Controls.Add(us);
                            us.Dock = DockStyle.Fill;
                            break;
                        } 
                        
                }
            }
            else
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        {
                            Process.Start(pth, "1");
                            break;
                        }
                    case 1:
                        {
                            Process.Start(pth, "2");
                            break;
                        }
                    case 2:
                        {
                            Process.Start(pth, "3");
                            break;
                        }
                    case 3:
                        {
                            Process.Start(pth, "4");
                            break;
                        }
                    case 4:
                        {
                            Process.Start(pth, "5");
                            break;
                        }
                }    
            }
        }
    }
}
