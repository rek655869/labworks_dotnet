using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba6
{
    public partial class Ex_2 : UserControl
    {
        private int panelCount1 = 0;
        private int panelCount2 = 0;
        public Ex_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            panelCount1++;

            if (panelCount1 == 2)
            {
                panel3.Visible = true;
            }
            if (panelCount1 == 3)
            {

                panel1.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            panelCount2++;
            if (panelCount2 == 1)
            {
                textBox16.Clear();
                panel1.Visible = false;
            }
            if (panelCount2 == 2)
            {
                textBox16.Clear();
                panel3.Visible = false;

            }
            if (panelCount2 == 3)
            {
                textBox16.Clear();
                panel4.Visible = false;
                textBox16.Text = "В коллекции не осталось самолётов";


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string autopilot;
                List<Plan> plan = new List<Plan>();
                if (panel4.Visible == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        autopilot = "присутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox1.Text),
                            Traffic = Convert.ToInt32(textBox2.Text),
                            Fuel = Convert.ToInt32(textBox3.Text),
                            Arrival = Convert.ToString(textBox4.Text),
                            Departure = Convert.ToString(textBox5.Text),
                            Autopilot = autopilot
                        });
                    }


                    if (checkBox1.Checked == false)
                    {
                        autopilot = "отсутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox1.Text),
                            Traffic = Convert.ToInt32(textBox2.Text),
                            Fuel = Convert.ToInt32(textBox3.Text),
                            Arrival = Convert.ToString(textBox4.Text),
                            Departure = Convert.ToString(textBox5.Text),
                            Autopilot = autopilot
                        });
                    }

                    foreach (Plan plan1 in plan)
                    {
                        textBox16.Text += "Самолет: " + "название - " + plan1.Name + "  грузоподъемность - " + plan1.Traffic + "  расход топлива - " + plan1.Fuel + "  отправление - " + plan1.Arrival + "  прибытие - " + plan1.Departure + "  автопилот - " + plan1.Autopilot + "\r" + "\n";
                    }
                }

                if (panel3.Visible == true)
                {
                    if (checkBox2.Checked == true)
                    {
                        autopilot = "присутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox6.Text),
                            Traffic = Convert.ToInt32(textBox7.Text),
                            Fuel = Convert.ToInt32(textBox8.Text),
                            Arrival = Convert.ToString(textBox9.Text),
                            Departure = Convert.ToString(textBox10.Text),
                            Autopilot = autopilot
                        });
                    }


                    if (checkBox2.Checked == false)
                    {
                        autopilot = "отсутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox6.Text),
                            Traffic = Convert.ToInt32(textBox7.Text),
                            Fuel = Convert.ToInt32(textBox8.Text),
                            Arrival = Convert.ToString(textBox9.Text),
                            Departure = Convert.ToString(textBox10.Text),
                            Autopilot = autopilot
                        });
                    }
                    textBox16.Clear();

                    foreach (Plan plan2 in plan)
                    {
                        textBox16.Text += "Самолет: " + "название - " + plan2.Name + "  грузоподъемность - " + plan2.Traffic + "  расход топлива - " + plan2.Fuel + "  отправление - " + plan2.Arrival + "  прибытие - " + plan2.Departure + "  автопилот - " + plan2.Autopilot + "\r" + "\n";
                    }
                }
                if (panel1.Visible == true)
                {
                    if (checkBox3.Checked == true)
                    {
                        autopilot = "присутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox11.Text),
                            Traffic = Convert.ToInt32(textBox12.Text),
                            Fuel = Convert.ToInt32(textBox13.Text),
                            Arrival = Convert.ToString(textBox14.Text),
                            Departure = Convert.ToString(textBox15.Text),
                            Autopilot = autopilot
                        });
                    }



                    if (checkBox3.Checked == false)
                    {
                        autopilot = "отсутствует";
                        plan.Add(new Plan()
                        {
                            Name = Convert.ToString(textBox11.Text),
                            Traffic = Convert.ToInt32(textBox12.Text),
                            Fuel = Convert.ToInt32(textBox13.Text),
                            Arrival = Convert.ToString(textBox14.Text),
                            Departure = Convert.ToString(textBox15.Text),
                            Autopilot = autopilot
                        });
                    }
                    textBox16.Clear();

                    foreach (Plan plan3 in plan)
                    {
                        textBox16.Text += "Самолет: " + "название - " + plan3.Name + "  грузоподъемность - " + plan3.Traffic + "  расход топлива - " + plan3.Fuel + "  отправление - " + plan3.Arrival + "  прибытие - " + plan3.Departure + "  автопилот - " + plan3.Autopilot + "\r" + "\n";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели что-то не так, попробуйте ещё раз!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
             
 

        }
        class Plan
        { 
            public string Name { get; set; }//название
            public int Traffic { get; set; }//грузоподъёмность
            public int Fuel { get; set; }//топливо
            public string Arrival { get; set; }//прибытие
            public string Departure { get; set; }//отбытие
            public string Autopilot { get; set; }//наличие автопилота

        }

    }
}
