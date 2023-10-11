using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = this.input.Text;
            this.output.Text = str.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           System.Diagnostics.Process.Start("C:\\Users\\Nastya\\Source\\Repos\\laba\\laba\\Ex_3.exe");

        }

    }
}

