using System;
using System.Windows.Forms;

namespace Ex_7
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            uint x;
            uint y;
            try
            {

                x = Convert.ToUInt32(this.input_x.Text);

            }
            catch 
            {
                MessageBox.Show(
                    "Введите натуральное число!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            y = x / 10 % 10;
            do
            {
                if (x % 10 > y)
                    k++;
                x /= 10;
            }
            while (x != 0);
            this.result.Text = string.Format("{0}", k);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.input_x.Text = string.Empty;
            this.result.Text = string.Empty;
        }
    }
}
