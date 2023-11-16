using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LW_09_3
{
    public partial class Ex_3 : UserControl
    {
        public Ex_3()
        {
            InitializeComponent();
                    
        }

        private DialogResult result;
        private string path;

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Введите расположение создаваемой папки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(Path.Combine("copied_file" + Path.GetExtension(path)), FileMode.Create)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            writer.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            MessageBox.Show("Файл успешно скопирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = Directory.GetCurrentDirectory();
            opd.FileName = Path.Combine("copied_file" + Path.GetExtension(path));
            result = opd.ShowDialog();
        }
    }
}
