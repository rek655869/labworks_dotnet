using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW_5_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                if (listBox1.SelectedIndex == 0)
                {
                    var p = new Process();
                    p.StartInfo.FileName = "LW_05.exe";
                    p.Start();
                }
                if (listBox1.SelectedIndex == 1)
                {
                    panel1.Visible = true;
                    

                }
                if (listBox1.SelectedIndex != 1)
                {
                    panel1.Visible = false;


                }
                if (listBox1.SelectedIndex == 2)
                    {
                        Application.Exit();
                    }
            
            
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            string s1, s2;
            s1 = textBox1.Text;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Вы ничего не ввели, введите строку с пробелами!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (!(String.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int count = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == ' ')
                        count += 1;
                }
                if (count == 0)
                {
                    MessageBox.Show("Вы ввели строку без пробелов, введите строку с пробелами!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    s2 = s1.Replace(" ", "");
                    textBox2.Text = s2;
                }
               
            }


        }
    }
}
