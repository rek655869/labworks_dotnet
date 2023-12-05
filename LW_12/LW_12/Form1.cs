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
using static LW_12.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList; //чтобы нельзя было писать в combobox
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExam3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public interface IPassportInfo
        {
            int PassportNumber { get; set; }
            int PassportSeries {get; set; }
            string FirstName { get; set; }
            string SecondName { get; set; }
            string City { get; set; }
        }
        public class PassportInfo : IPassportInfo 
        {
            public int PassportNumber { get; set; }
            public int PassportSeries { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string City { get; set; }
        }

        public interface IEducationLevel
        {
            string EducationType { get; set; }
            int EducationYears { get; set; }
        }
        public class EducationLevel : IEducationLevel
        {
            public string EducationType { get; set; }
            public int EducationYears { get; set; }
        }

        public interface IExamInfo
        {
            string ExamName { get; set; }
            int Score { get; set; }
        }
        public class ExamInfo : IExamInfo
        { 
            public string ExamName { get; set; }
            public int Score { get; set; } 
        }

        public interface ISpecialization 
        {
            string SpecializationName { get; set; }
        }
        public class Specialization : ISpecialization
        {
            public string SpecializationName { get; set; }
        }

        public class Abiturient : IPassportInfo, IEducationLevel, IExamInfo, ISpecialization
        {
            public int PassportNumber { get; set; }
            public int PassportSeries { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string City { get; set; }
            public string EducationType { get; set; }
            public int EducationYears { get; set; }
            public string ExamName { get; set; }
            public int Score { get; set; }
            public string SpecializationName { get; set; }



        }
        private bool ValidateScores()
        {
            int score1 = int.Parse(textBox6.Text);
            int score2 = int.Parse(textBox7.Text);
            int score3 = int.Parse(textBox8.Text);

            if (score1 < 0 || score1 > 100 || score2 < 0 || score2 > 100 || score3 < 0 || score3 > 100)
            {
                MessageBox.Show("Введите баллы за экзамены от 0 до 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void SaveAbiturientToFile(Abiturient applicant) //просто чтобы информация где-то хранилась
        {
            string filePath = "Abiturients.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Паспортные данные:");
                    writer.WriteLine($"Номер: {applicant.PassportNumber}");
                    writer.WriteLine($"Серия: {applicant.PassportSeries}");
                    writer.WriteLine($"Имя: {applicant.FirstName}");
                    writer.WriteLine($"Город: {applicant.City}");
                    writer.WriteLine();
                    writer.WriteLine($"Уровень образования: {applicant.EducationType}");
                    writer.WriteLine();
                    writer.WriteLine($"Выбранные экзамены: {applicant.ExamName}");
                    writer.WriteLine($"Средний балл: {applicant.Score:F2}");
                    writer.WriteLine();
                    writer.WriteLine($"Выбранная специальность: {applicant.SpecializationName}");
                    writer.WriteLine("===============================================");
                }

                MessageBox.Show("Данные успешно сохранены в файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Получение паспортных данных
                int passportNumber = Convert.ToInt32(textBox1.Text);
                int passportSeries = Convert.ToInt32(textBox2.Text);
                string firstName = textBox3.Text;
                string secondName = textBox4.Text;
                string city = textBox5.Text;
                int sum_exam;
                string educationType = comboBox2.SelectedItem.ToString();
                // Получение выбранных экзаменов
                List<string> selectedExams = new List<string>
                {
                    textBox10.Text,
                    textBox11.Text,
                    comboBoxExam3.SelectedItem.ToString()
                };
                    // Получение баллов за экзамены
                    List<int> scores = new List<int>
                {
                    int.Parse(textBox6.Text),
                    int.Parse(textBox7.Text),
                    int.Parse(textBox8.Text)

                };
                if (!ValidateScores())
                    return;

                sum_exam = (int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text)) / 3;
                textBox9.Text = Convert.ToString(sum_exam);
                // Получение выбранной специальности
                string selectedSpecialization = comboBox6.SelectedItem.ToString();
                // Создание абитуриента с полученными данными
                Abiturient applicant = new Abiturient
                {
                    PassportNumber = passportNumber,
                    PassportSeries = passportSeries,
                    FirstName = firstName,
                    SecondName = secondName,
                    City = city,
                    EducationType = educationType,
                    ExamName = string.Join(", ", selectedExams),
                    Score = sum_exam, // Вычисление среднего балла
                    SpecializationName = selectedSpecialization

                };
                string message = $"Паспортные данные: \nНомер: {applicant.PassportNumber}\nСерия: {applicant.PassportSeries}\nИмя: {applicant.FirstName}\nГород: {applicant.City}\n\nУровень образования: {applicant.EducationType}\n\nВыбранные экзамены: {applicant.ExamName}\nСредний балл: {applicant.Score:F2}\n\nВыбранная специальность: {applicant.SpecializationName}";

                MessageBox.Show(message, "Информация об абитуриенте");
                SaveAbiturientToFile(applicant);
            }
            catch
            {
                MessageBox.Show("Вы ввели символ (в серии, номере, или баллах за экзамены) или не ввели ничего! Попробуйте еще раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
