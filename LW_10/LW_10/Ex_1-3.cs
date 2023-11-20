using System;
using System.IO;
using System.Windows.Forms;

namespace LW_10
{
    public partial class Ex_1_3 : UserControl
    {
        public Ex_1_3()
        {
            InitializeComponent();
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
            StreamReader reader;
            try
            {
                reader = new StreamReader(Directory.GetCurrentDirectory() + $"\\employees\\{Login_input.Text}.txt");
                string pass = reader.ReadLine().Remove(0, 8);
                if (string.Compare(pass, password.Text) != 0)
                    throw new Exception("Неправильный пароль");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Пользователя с таким логином не существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panel2.Visible = !panel2.Visible;
            label14.Visible = !label14.Visible;
            string username = reader.ReadLine().Remove(0, 18);
            string position = reader.ReadLine().Remove(0, 11);
            string faculty = reader.ReadLine().Remove(0, 11);
            reader.Close();
            
            label14.Text = ($"    Успешная авторизация!\nВы зашли на аккаунт пользователя - \n{username}\n{position}\n{faculty}");
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
