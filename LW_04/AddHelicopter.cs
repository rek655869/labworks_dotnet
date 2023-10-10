using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_04
{
    public partial class AddHelicopter : Form
    {
        public AddHelicopter()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public Helicopter h = new Helicopter();

        private void button1_Click(object sender, EventArgs e)
        {
            h.model = textBox1.Text;
            try
            {
                h.max_speed = Double.Parse(textBox2.Text);
                h.year = Int32.Parse(textBox3.Text);
                h.max_height = Double.Parse(textBox4.Text);
                h.capacity = Int32.Parse(textBox5.Text);
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

            if (h.model.Length == 0)
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
