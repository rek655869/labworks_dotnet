using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laba6
{
    public partial class Ex_3 : UserControl
    {
        public Ex_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                textBox16.Clear();
                textBox11.Clear();
                SortedList plane = new SortedList();
                string name, arrival, departure, autopilot;
                int traffic, fuel;
                name = Convert.ToString(textBox1.Text);
                traffic = Convert.ToInt32(textBox2.Text);
                fuel = Convert.ToInt32(textBox3.Text);
                arrival = Convert.ToString(textBox4.Text);
                departure = Convert.ToString(textBox5.Text);
                if (checkBox1.Checked == true)
                {
                    autopilot = "присутствует";
                    plane.Add("Название", name);
                    plane.Add("Средняя грузноподъемность", traffic);
                    plane.Add("Топливо", fuel);
                    plane.Add("Отправление", arrival);
                    plane.Add("Прибытие", departure);
                    plane.Add("Автопилот", autopilot);
                }
                if (checkBox1.Checked == false)
                {
                    autopilot = "отсутствует";
                    plane.Add("Название", name);
                    plane.Add("Средняя грузноподъемность", traffic);
                    plane.Add("Топливо", fuel);
                    plane.Add("Отправление", arrival);
                    plane.Add("Прибытие", departure);
                    plane.Add("Автопилот", autopilot);
                }
                ICollection с = plane.Keys;
                for (int i = 0; i < plane.Count; i++)
                {
                    textBox16.Text += plane.GetKey(i) + " - " + plane.GetByIndex(i) + '\r' + '\n';
                }
                SortedList plane2 = new SortedList();
                string name1, arrival1, departure1, autopilot1;
                int traffic1, fuel1;
                name1 = Convert.ToString(textBox6.Text);
                traffic1 = Convert.ToInt32(textBox7.Text);
                fuel1 = Convert.ToInt32(textBox8.Text);
                arrival1 = Convert.ToString(textBox9.Text);
                departure1 = Convert.ToString(textBox10.Text);
                if (checkBox2.Checked == true)
                {
                    autopilot1 = "присутствует";
                    plane2.Add("Название", name1);
                    plane2.Add("Средняя грузноподъемность", traffic1);
                    plane2.Add("Топливо", fuel1);
                    plane2.Add("Отправление", arrival1);
                    plane2.Add("Прибытие", departure1);
                    plane2.Add("Автопилот", autopilot1);
                }
                if (checkBox2.Checked == false)
                {
                    autopilot1 = "отсутствует";
                    plane2.Add("Название", name1);
                    plane2.Add("Средняя грузноподъемность", traffic1);
                    plane2.Add("Топливо", fuel1);
                    plane2.Add("Отправление", arrival1);
                    plane2.Add("Прибытие", departure1);
                    plane2.Add("Автопилот", autopilot1);
                }
                ICollection с2 = plane2.Keys;
                for (int i = 0; i < plane2.Count; i++)
                {
                    textBox11.Text += plane2.GetKey(i) + " - " + plane2.GetByIndex(i) + '\r' + '\n';
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели что-то не так, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox16.Clear();
                textBox11.Clear();
            }
            

            



        }
    }
}
