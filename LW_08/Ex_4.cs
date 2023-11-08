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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW_08
{
    public partial class Ex_4 : UserControl
    {
        public Ex_4()
        {
            InitializeComponent();
        }

        void reading_file()
        {
            FileStream file = new FileStream("poemfile.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            textBox2.Text = reader.ReadLine();
            textBox3.Text = reader.ReadLine();
            textBox4.Text = reader.ReadLine();
            textBox5.Text = reader.ReadLine();
            reader.Close();
            FileStream file1 = new FileStream("poemfile.txt", FileMode.Open);
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
