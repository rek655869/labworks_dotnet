using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW_04
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Teacher th = new Teacher();

        private void button1_Click(object sender, EventArgs e)
        {
            th.name = textBox1.Text;
            th.subject = textBox2.Text;
            try
            {
                th.experience = Int32.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(this,
                        "Проверьте корректность заполнения полей",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }

            if (th.name.Length == 0 || th.subject.Length == 0)
            {
                MessageBox.Show(this,
                        "Все поля должны быть заполнены",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
