using LW_11.Classes;
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

namespace LW_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string folder;
            Person person;
            switch (level.SelectedIndex)
            {
                case 0: 
                    {
                        person = new Employee();
                        folder = "employees";
                        break;
                    }
                case 1:
                    {
                        person = new Abiturient();
                        folder = "abiturients";
                        break;
                    }
                case 2:  
                    {
                        person = new Person();
                        folder = "persons";
                        break;
                    }
                default:
                    {
                        person = new Person();
                        folder = "";
                        break;
                    }
            }

            StreamReader reader;
            try
            {
                reader = new StreamReader(Directory.GetCurrentDirectory() + $"\\users\\{folder}\\{login.Text}.txt");
                person.Name = login.Text;
                person.Load(reader);
                string message;
                if (!person.Login(login.Text, password.Text, out message))
                    throw new Exception(message);

                Form form2 = new Form2(person);
                form2.Name = login.Text;
                form2.Show();
                Hide();
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
        }
    }
}
