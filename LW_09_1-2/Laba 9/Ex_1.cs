using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_9
{
    public partial class Ex_1 : UserControl
    {
        public Ex_1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            double x, sum = 0, k;
            var rand = new Random();

          try
            {

                using (FileStream File = new FileStream("file.bin", FileMode.OpenOrCreate))
                {
                    using (BinaryWriter writer = new BinaryWriter(File, Encoding.Default))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            x = rand.Next(-100, 100) + rand.NextDouble();
                            writer.Write(x);
                            x = rand.Next(-100, 100);
                            writer.Write(x);
                        }
                    }
                }


                using (FileStream File = new FileStream("file.bin", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(File, Encoding.Default))
                    {


                        for (int i = 0; i < 10; i++)
                        {
                            k = reader.ReadDouble();
                            this.label2.Text += Convert.ToString(Math.Round(k, 2)) + "  ";
                            k = Convert.ToDouble(k);
                            if (Math.Round(k) % 2 == -1 || Math.Round(k) % 2 == 1)
                                sum += k;
                           
                        }
                      
                        this.label4.Text = Convert.ToString(Math.Round(sum, 2));
              
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show(
                   "Ошибка!",
                   " ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                return;
            }



        }
    }
}
