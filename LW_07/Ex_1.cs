using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW_6_App
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
        }
        public void function_mass_excersice1_1(int row, int col)
        {

            int[,] massive = new int[row, col];
            Random random = new Random();
            int count = 0;
            int min_el = 1000;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    massive[i, j] = random.Next(-5, 5);
                    textBox3.Text += massive[i, j] + "   ";
                    if (min_el > Math.Abs(massive[i, j]))
                        min_el = Math.Abs(massive[i, j]);
                }
                textBox3.Text += "\r\n";

            }
            textBox4.Text = Convert.ToString(min_el);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min_el == Math.Abs(massive[i, j]))
                    {
                        count++;
                        break;
                    }
                }
            }
            textBox5.Text = Convert.ToString(count);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                int row, col;
                row = Convert.ToInt32(textBox1.Text);
                col = Convert.ToInt32(textBox2.Text);
                function_mass_excersice1_1(row, col);
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, введите число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
