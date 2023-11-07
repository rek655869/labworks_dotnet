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
    public partial class Ex_5 : UserControl
    {
        public Ex_5()
        {
            InitializeComponent();
        }
        void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        void exercise_3(int count)
        {
            int elemnt_swap;
            int[] massive = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                massive[i] = random.Next(20);
                textBox2.Text += massive[i] + "  ";
            }
            elemnt_swap = Convert.ToInt32(textBox3.Text);
            if (elemnt_swap == 1 || elemnt_swap > count)
            {
                MessageBox.Show("КРОМЕ 1 и числа больше количества элементов массива", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elemnt_swap = Convert.ToInt32(textBox3.Text);
            }
            for (int i = 0; i < count; i++)
            {
                if (i == elemnt_swap - 1)
                {
                    swap(ref massive[i], ref massive[i - 1]);
                }
            }
            for (int i = 0; i < count; i++)
            {
                textBox4.Text += massive[i] + "  ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                textBox4.Clear();
                int col_el = Convert.ToInt32(textBox1.Text);
                if (col_el < 2)
                {
                    MessageBox.Show("Введите количество элементов в массиве больше 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    col_el = Convert.ToInt32(Console.ReadLine());
                }
                exercise_3(col_el);
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или не ввели ничего, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
