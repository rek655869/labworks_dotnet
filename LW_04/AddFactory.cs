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
    public partial class AddFactory : Form
    {
        public AddFactory()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Factory fc = new Factory();

        private void button1_Click(object sender, EventArgs e)
        {
            fc.name = textBox1.Text;
            fc.address = textBox2.Text;
            try
            {
                fc.foundation_year = Int32.Parse(textBox3.Text);
                fc.employees = Int32.Parse(textBox4.Text);
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

            if (fc.name.Length == 0 || fc.address.Length == 0)
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
