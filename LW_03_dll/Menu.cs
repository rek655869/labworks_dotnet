using System;
using System.Windows.Forms;
using System.IO;

namespace LW_03
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Exercises.SelectedIndex;
            string pth = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\" + @"\ConsoleApp\bin\Debug\ConsoleApp.exe");
            switch ( index ) {
                case 0:
                    { // Среди заданных чисел найти количество четных чисел.
                        System.Diagnostics.Process.Start(pth, "1");
                        break; 
                    };
                case 1:
                    { // Целые числа в (A; В) и их количество
                        System.Diagnostics.Process.Start(pth, "2");
                        break; 
                    };
                case 2:
                    { // Среднее арифметическое введённых чисел
                        System.Diagnostics.Process.Start(pth, "3");
                        break; 
                    };
                case 3:
                    {
                        UserControl us = new Ex_1();
                        this.Controls.Clear();
                        this.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 4:
                    {
                        UserControl us = new Ex_2();
                        this.Controls.Clear();
                        this.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 5:
                    {
                        UserControl us = new Ex_3();
                        this.Controls.Clear();
                        this.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
                case 6:
                    {
                        UserControl us = new Ex_4();
                        this.Controls.Clear();
                        this.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break;
                    }
            }
        }

    }
}
