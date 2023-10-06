using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            switch ( index ) {
                case 0: {
                        UserControl us = new Ex_1();
                        this.Controls.Clear();
                        this.Controls.Add(us);
                        us.Dock = DockStyle.Fill;
                        break; };
                case 1: { break; };
                case 2: { break; };
            }
        }

        private void button_console_Click(object sender, EventArgs e)
        {
            string pth = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\");
            System.Diagnostics.Process.Start(pth + @"\ConsoleApp\bin\Debug\ConsoleApp.exe");

        }
    }
}
