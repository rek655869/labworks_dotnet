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

namespace LR_9_4
{
    public partial class Ex_2 : UserControl
    {
        public Ex_2()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                var rand = new Random();
                double k, y = 0;
                y = Convert.ToDouble(textBox1.Text);

                int offset = rand.Next(0, 10);
                using (FileStream File = new FileStream("file.bin", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(File, Encoding.Default))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            k = reader.ReadDouble();
                            if (i == offset)
                                this.label2.Text += Convert.ToString(Math.Round(y, 2)) + "  ";

                            this.label2.Text += Convert.ToString(Math.Round(k, 2)) + "  ";
                        }
                        textBox1.Text = " ";
                    }

                }
            }
            catch (FormatException)
            {

                MessageBox.Show(
                "Ошибка!\nВведите число!",
                   " ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            }
        }
    }
}
