using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LW_04
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SelectIndex(object sender, EventArgs e)
        {
            string pth = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\" + @"\ConsoleApp\bin\Debug\ConsoleApp.exe");

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
                        UserControl us = new Ex_5();
                        Controls.Clear();
                        Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
            }
        }
    }
}
