using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_08
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        private DialogResult result;
        private string pathToFolder;

        private void btn_FileDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathToFolder = fbd.SelectedPath;
                Label path = new Label();
                path.Text = fbd.SelectedPath;
                path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
                path.Location = new Point(btn_FileDialog.Location.X + 130, 52);
                path.AutoSize = true;
                Controls.Add(path);
            }    
        }

        private void btn_createFolder_Click(object sender, EventArgs e)
        {
            string bad_symbols = "+=[]:*?;«,./\\<>|' ";
            if (folderName.Text.Length == 0)
            {
                MessageBox.Show("Введите имя создаваемой папки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char bad_symb in bad_symbols)
            {
                foreach(char ch in folderName.Text)
                {
                    if (ch == bad_symb)
                    {
                        MessageBox.Show($"Недопустимый символ: {bad_symb}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }    
                }
            }
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Введите расположение создаваемой папки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string name = pathToFolder + "\\" + folderName.Text;
            if (Directory.Exists(name))
            {
                MessageBox.Show("Папка с таким названием в данном расположении уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Directory.CreateDirectory(name);
            MessageBox.Show("Папка успешно создана", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = name;
            opd.ShowDialog();
        }
    }
}
