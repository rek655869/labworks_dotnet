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

namespace Laba6
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
        }

        public static List<int> numbers = new List<int>() { 44, 22, 15, 17, 19, 26, 1, 2, 46 };
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            for (int i = 0; i < numbers.Count; i++)
            {
                textBox1.Text += (numbers[i] + " ");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;
                textBox2.Text = "Напишите элемент для добавления";

            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;
                textBox2.Text = "Напишите элемент для удаления";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox8.Visible = false;
                textBox2.Text = "Напишите расположение элемента";
                textBox5.Text = "Элемент, который хотите вставить";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = true;
                textBox7.Text = "Сортировка";
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;
                textBox2.Text = "Сортировка";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = true;
                textBox2.Text = "Элемент";
                textBox8.Text = "Получення позиция";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox6.Clear();
                textBox8.Clear();
                for (int i = 0; i < numbers.Count; i++)
                {
                    textBox1.Text += (numbers[i] + " ");
                }
                textBox7.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox8.Visible = false;
                textBox2.Text = "Напишите позицию элемента";
                textBox5.Text = "Элемент с этим индексом";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    textBox8.Text = "Полученная коллекция";
                    int add;
                    add = Int32.Parse(textBox3.Text);
                    numbers.Add(add);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        textBox4.Text += (numbers[i] + " ");
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox8.Text = "Полученная коллекция";
                    int remove;
                    remove = Int32.Parse(textBox3.Text);
                    int proverka = -100;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (remove == numbers[i])
                        {
                            proverka = numbers[i];
                        }
                    }
                    if  (proverka == -100)
                    {
                        MessageBox.Show("Вы ввели что-то не так, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBox4.Clear();
                    remove = Int32.Parse(textBox3.Text);
                    numbers.Remove(remove);
                    
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        textBox4.Text += (numbers[i] + " ");
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox8.Text = "Полученная коллекция";
                    int insert;
                    int index;
                    insert = Int32.Parse(textBox3.Text) - 1;
                    index = Int32.Parse(textBox6.Text);
                    numbers.Insert(insert, index);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        textBox4.Text += (numbers[i] + " ");
                    }

                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textBox8.Text = "Полученная коллекция";
                    numbers.Sort();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        textBox4.Text += (numbers[i] + " ");
                    }

                }
                if (comboBox1.SelectedIndex == 4)
                {
                    int index;
                    index = Int32.Parse(textBox3.Text);
                    int index_elementa = numbers.IndexOf(index) + 1;
                    if (index_elementa == 0)
                    {
                        MessageBox.Show("Вы ввели что-то не так, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBox4.Clear();
                    index = Int32.Parse(textBox3.Text);
                    index_elementa = numbers.IndexOf(index) + 1;
                    string output = Convert.ToString(index_elementa);
                    textBox4.Text = output;


                }
                if (comboBox1.SelectedIndex == 5)
                {
                    textBox8.Text = "Полученная коллекция";
                    int remove;
                    remove = Int32.Parse(textBox3.Text) - 1;
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (i == remove)
                        {
                            textBox6.Text = Convert.ToString(numbers[i]);
                            numbers.RemoveAt(i);
                        }

                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        textBox4.Text += (numbers[i] + " ");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Вы ввели что-то не так, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}