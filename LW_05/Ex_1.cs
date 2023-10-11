using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_05
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
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
