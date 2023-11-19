using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_10
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;
            string position = positionComboBox.SelectedItem?.ToString();
            string faculty = facultyComboBox.SelectedItem?.ToString();
            string gender = genderComboBox.SelectedItem?.ToString();

            try
            {
                ValidateInput(username, password, position, faculty, gender);

                // Создание нового файла с данными пользователя в папке employees
                string folderPath = "employees";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string userFilePath = Path.Combine(folderPath, "user.txt");
                using (StreamWriter writer = File.CreateText(userFilePath))
                {
                    writer.WriteLine($"Имя пользователя: {username}");
                    writer.WriteLine($"Должность: {position}");
                    writer.WriteLine($"Факультет: {faculty}");
                    writer.WriteLine($"Пол: {gender}");
                    // Другие данные пользователя могут быть добавлены сюда

                }



                MessageBox.Show("Пользователь успешно зарегистрирован!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void ValidateInput(string username, string password, string position, string faculty, string gender)
        {
            // Проверка наличия данных в полях
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(faculty) ||
                string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentException("Все поля должны быть заполнены");
            }

            // Проверка пароля
            if (!IsStrongPassword(password))
            {
                throw new ArgumentException("Пароль не соответствует требованиям");
            }
        }

        private bool IsStrongPassword(string password)
        {
            // Проверка пароля на условия (минимум 8 символов, цифры, заглавные и строчные буквы, спец. символы)
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(password) && !password.Contains(" ");
        }

        
    }
    
}
