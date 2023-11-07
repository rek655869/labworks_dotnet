using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LW_08_App
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }
        void reading_file()
        {
            FileStream file = new FileStream("C:\\Users\\STALKER\\source\\repos\\LW_08_App\\poemfile.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            textBox2.Text = reader.ReadLine();
            textBox3.Text = reader.ReadLine();
            textBox4.Text = reader.ReadLine();
            textBox5.Text = reader.ReadLine();
            reader.Close();
            FileStream file1 = new FileStream("C:\\Users\\STALKER\\source\\repos\\LW_08_App\\poemfile.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            textBox1.Text = reader1.ReadToEnd();

            reader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reading_file();
        }
    }
}
