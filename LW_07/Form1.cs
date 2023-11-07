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

namespace LW_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuItem_Click(this, EventArgs.Empty);
        }


        private void MenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Size = new Size(600, 300);
            UserControl menu = new Menu();
            menu.Location = new Point((panel1.ClientSize.Width - menu.Width) / 2, 30);
            panel1.Controls.Add(menu);
        }
    }
   
}
