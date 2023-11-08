﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace LW_8__3
{
    public partial class Ex_3 : UserControl
    {
        public Ex_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create("file1.txt").Close();
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.CreateText("file2.txt").Close();
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream file3 = new FileStream("file3.txt", FileMode.CreateNew);
            file3.Close();
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream file4 = new FileStream("file4.txt", FileMode.Append);
            file4.Close();

            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = true;
        }
    }
}
