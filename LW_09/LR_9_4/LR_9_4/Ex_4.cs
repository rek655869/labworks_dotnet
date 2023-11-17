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

namespace LR_9_4
{
    public partial class Ex_4 : UserControl
    {
        public Ex_4()
        {
            InitializeComponent();
        }
        private DialogResult result;
        private string path;



        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            result = opd.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = opd.FileName;
                Label l_path = new Label();
                l_path.Text = path;
                l_path.Font = new Font("Microsoft Sans Serif", 9F);
                l_path.Location = new Point(button1.Location.X + 130, label1.Location.Y);
                l_path.AutoSize = true;
                Controls.Add(l_path);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Выберите какой-то файл", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                string create, record, access;

                create = Convert.ToString(File.GetCreationTime(path));//создание
                record = Convert.ToString(File.GetLastWriteTime(path));//последняя запись
                access = Convert.ToString(File.GetLastAccessTime(path));//последний доступ
                MessageBox.Show("Информация о файле выведена на экран. " +
                    "А также создан новый файл, в который внесена информация о считанном файле, закройте это окно!" +
                    "", "Файл успешно прочитан!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BinaryWriter writer = new BinaryWriter(File.Open(Path.Combine("new_file" + Path.GetExtension(path)), FileMode.Create));
                writer.Write("Время создания файла - " + create + "\r\n");
                writer.Write("Время последней записи файла - " + access + "\r\n");
                writer.Write("Время последнего доступа файла - " + record);
                OpenFileDialog opd = new OpenFileDialog();
                opd.InitialDirectory = Directory.GetCurrentDirectory();
                opd.FileName = Path.Combine("new_file" + Path.GetExtension(path));
                result = opd.ShowDialog();
                panel1.Visible = true;
                textBox1.Text = create;
                textBox2.Text = access;
                textBox3.Text = record;


            }
        }
    }
}

