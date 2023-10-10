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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Remove(textBox1.Text.Length - 1).Split(' ');
            if (words.Length < 2 || words.Length > 30 )
            {
                MessageBox.Show(this,
                        "Количество слов должно быть от 2 до 30",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }
            foreach (string word in words)
            {
                if (word.Length < 2 || word.Length > 30)
                {
                    MessageBox.Show(this,
                        "В каждом слове должно быть от 2 до 30 букв",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            string last = words[words.Length - 1];  
            string text = "";

            foreach (string word in words)
            {
                if (word != last)
                {
                    char first = word[0];
                    string new_word = first + word.Replace(first.ToString(), "");
                    text += new_word + " ";
                }
            }
            label2.Text = text;
        }
    }
}
