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

namespace LW_08_App
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
        }
        void exercise1(int numbers)
        {
            FileStream file = new FileStream("file.txt", FileMode.OpenOrCreate); //создаем файл
            StreamWriter writer = new StreamWriter(file); //создаем потоковый писатель
            Random random = new Random();

            double[] massive = new double[numbers]; //массив дробных чисел

            for (int i = 0; i < numbers; i++)
            {
                if (i > numbers)
                    break;
                if (i == numbers - 1)
                {
                    massive[i] = Math.Round(random.NextDouble() + random.Next(-10, 10), 2);
                    writer.Write(massive[i] + " ");
                }
                else
                {
                    massive[i] = Math.Round(random.NextDouble() + random.Next(-10, 10), 2);
                    massive[i + 1] = random.Next(-10, 10);
                    writer.Write(massive[i] + " ");
                    writer.Write(massive[i + 1] + " ");
                    i++;
                }
            }
            writer.WriteLine();
            writer.Close();
            FileStream file1 = new FileStream("file.txt", FileMode.Open); //открываем файл
            StreamReader reader = new StreamReader(file1);
            BinaryReader reader2 = new BinaryReader(file1);
            string number = reader.ReadLine();
            double[] massive_read = new double[numbers];
            double sum = 0;
            foreach (var numberr in number.Split()) //в переменную numberr записываем числа, которые отделены друг от друга пробелом
            {
                if (numberr == "") //если числа заканчиваются,то цикл прекращается
                    break;

                if (Double.Parse(numberr) % 2 != 0) //проверяем четность
                {
                    sum += Double.Parse(numberr); //находим сумму
                }
                textBox2.Text += (numberr + " ");

            }
            textBox3.Text = Convert.ToString(sum);
            reader.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                textBox3.Clear();
                int numbers;
                numbers = Convert.ToInt32(textBox1.Text);
                exercise1(numbers);
            }
            catch
            {
                MessageBox.Show("Вы ввели символ или ничего не ввели!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
