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

namespace LW_10_1
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
           
            
        }
        class Employee
        {
            public string Surname;
            public string Name;
            public string Middlename;
            public string Post;
            public string Faculty;
            private int Money;
            private int Age;
            public string Login;
            public string Password;
            public int Code;
            public int Key;

            public Employee(string surname,string name, string middlename, string post, string faculty, string login, string password, int code, int key)
            {
                this.Surname = surname;
                this.Name = name;
                this.Middlename = middlename;
                this.Post = post;
                this.Faculty = faculty;           
                this.Login = login;
                this.Password = password;
                this.Code = code;
                this.Key = key;
            }
            
        }

        Employee e = new Employee("      Иванов", " Иван", " Иванович - ", "     Доцент ", " ФИТКБ ВГТУ ", "abcd", "1234", 1234, 1234);
        
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = !panel2.Visible;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel3.Visible = !panel3.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel8.Visible = !panel8.Visible;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel5.Visible = !panel5.Visible;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
            panel4.Visible = !panel4.Visible;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
            panel4.Visible = !panel4.Visible;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
            panel10.Visible = !panel10.Visible;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel8.Visible = !panel8.Visible;
            panel9.Visible = !panel9.Visible;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel9.Visible = !panel9.Visible;
            panel2.Visible = !panel2.Visible;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel9.Visible = !panel9.Visible;
            panel3.Visible = !panel3.Visible;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
            panel5.Visible = !panel5.Visible;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
            panel8.Visible = !panel8.Visible;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel10.Visible = !panel10.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.e.Login = Convert.ToString(Login_input.Text);
                this.e.Password = Convert.ToString(password.Text);
                if (this.e.Password != "1234" || this.e.Login != "abcd")
                {
                    MessageBox.Show("Вы ввели неправильный логин или пароль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel2.Visible = !panel2.Visible;
                    label14.Visible = !label14.Visible;
                    label14.Text = ("     Успешная авторизация!\nВы зашли на аккаунт пользователя - \n" + this.e.Surname + this.e.Name + this.e.Middlename + " \n" + this.e.Post + this.e.Faculty);
                }
            }
                
                  
            catch
            {
                MessageBox.Show("Вы не ввели ничего, введите логин и пароль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel11.Visible = !panel11.Visible;
        }

        private void button24_Click(object sender, EventArgs e)
        {

            panel2.Visible = !panel2.Visible;
            panel11.Visible = !panel11.Visible;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.e.Code = Convert.ToInt32(textBox1.Text);
              
                if (this.e.Code != 1234)
                {
                    MessageBox.Show("Вы ввели неправильный код!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel3.Visible = !panel3.Visible;
                    label14.Visible = !label14.Visible;
                    label14.Text = ("     Успешная авторизация!\nВы зашли на аккаунт пользователя - \n" + this.e.Surname + this.e.Name + this.e.Middlename + " \n" + this.e.Post + this.e.Faculty);
                }
            }


            catch
            {
                MessageBox.Show("Вы не ввели ничего, введите код авторизации!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                this.e.Key = Convert.ToInt32(textBox2.Text);

                if (this.e.Key != 1234)
                {
                    MessageBox.Show("Вы ввели неправильный ключ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel8.Visible = !panel8.Visible;
                    label14.Visible = !label14.Visible;
                    label14.Text = ("     Успешная авторизация!\nВы зашли на аккаунт пользователя - \n" + this.e.Surname + this.e.Name + this.e.Middlename + " \n" + this.e.Post + this.e.Faculty);
                }
            }


            catch
            {
                MessageBox.Show("Вы не ввели ничего, введите ключ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void button17_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            richTextBox1.Visible = !richTextBox1.Visible;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel8.Visible = !panel8.Visible;
            panel10.Visible = !panel10.Visible;
        }
    }
                    
}