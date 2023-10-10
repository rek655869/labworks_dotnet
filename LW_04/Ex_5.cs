using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_04
{
    public partial class Ex_5 : UserControl
    {
        public Ex_5()
        {
            InitializeComponent();
        }

        public static List<Helicopter> helicopters = new List<Helicopter>();
        public static List<Factory> factories = new List<Factory>();
        public static List<Teacher> teachers = new List<Teacher>();

        private void Select(object sender, EventArgs e)
        {
            string name = treeView1.SelectedNode.Name;
            switch (name)
            {
                case "Helicopters":
                    {
                        AddHelicopter f = new AddHelicopter();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            Helicopter hel = f.h;
                            treeView1.Nodes[name].Nodes.Add(hel.model, hel.model);
                            helicopters.Add(hel);
                        }
                        break;
                    }
                case "Factories":
                    {
                        AddFactory f = new AddFactory();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            Factory fac = f.fc;
                            treeView1.Nodes[name].Nodes.Add(fac.name, fac.name);
                            factories.Add(fac);
                        }
                        break;
                    }
                case "Teachers":
                    {
                        AddTeacher f = new AddTeacher();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            Teacher th = f.th;
                            treeView1.Nodes[name].Nodes.Add(th.name, th.name);
                            teachers.Add(th);
                        }
                        break;
                    }
                default:
                    {
                        foreach(Helicopter h in helicopters) 
                        {
                            if (name == h.model)
                            {
                                groupBox1.Controls.Clear();
                                Label txt = new Label();
                                txt.Anchor = AnchorStyles.None;
                                txt.AutoSize = true;
                                txt.Dock = DockStyle.Fill;
                                txt.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, (byte)(204));
                                txt.Name = "label10";
                                txt.Size = new Size(89, 20);

                                txt.Text = string.Format("\nМодель: {0}\n\n" +
                                                         "Максимальная скорость (км/ч): {1:g6}\n\n" +
                                                         "Год выпуска: {2}\n\n" + 
                                                         "Максимальная высота полёта (м): {3:g6}\n\n" +
                                                         "Вместимость пассажиров: {4}", 
                                    h.model, h.max_speed, h.year, h.max_height, h.capacity);

                                groupBox1.Controls.Add(txt);
                                return;
                            }
                        }

                        foreach (Factory fc in factories)
                        {
                            if (name == fc.name)
                            {
                                groupBox1.Controls.Clear();
                                Label txt = new Label();
                                txt.Anchor = AnchorStyles.None;
                                txt.AutoSize = true;
                                txt.Dock = DockStyle.Fill;
                                txt.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, (byte)(204));
                                txt.Name = "label10";
                                txt.Size = new Size(89, 20);

                                txt.Text = string.Format("\nНазвание: {0}\n\n" +
                                                         "Адрес: {1}\n\n" +
                                                         "Год основания: {2}\n\n" +
                                                         "Количество сотрудников: {3}",
                                    fc.name, fc.address, fc.foundation_year, fc.employees);

                                groupBox1.Controls.Add(txt);
                                return;
                            }
                        }

                        foreach (Teacher th in teachers)
                        {
                            if (name == th.name)
                            {
                                groupBox1.Controls.Clear();
                                Label txt = new Label();
                                txt.Anchor = AnchorStyles.None;
                                txt.AutoSize = true;
                                txt.Dock = DockStyle.Fill;
                                txt.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, (byte)(204));
                                txt.Name = "label10";
                                txt.Size = new Size(89, 20);

                                txt.Text = string.Format("\nФИО: {0}\n\n" +
                                                         "Предмет: {1}\n\n" +
                                                         "Стаж (лет): {2}",
                                    th.name, th.subject, th.experience);

                                groupBox1.Controls.Add(txt);
                                return;
                            }
                        }
                        break;
                    }
            }
        }
    }
}
