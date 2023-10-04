namespace LW_02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.мЕНЮToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ex_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ex_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ex_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ex_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.variant = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menu_ex_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мЕНЮToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // мЕНЮToolStripMenuItem
            // 
            this.мЕНЮToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ex_1,
            this.menu_ex_2,
            this.menu_ex_3,
            this.menu_ex_4,
            this.menu_ex_5});
            this.мЕНЮToolStripMenuItem.Name = "мЕНЮToolStripMenuItem";
            this.мЕНЮToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.мЕНЮToolStripMenuItem.Text = "МЕНЮ";
            // 
            // menu_ex_1
            // 
            this.menu_ex_1.Name = "menu_ex_1";
            this.menu_ex_1.Size = new System.Drawing.Size(494, 26);
            this.menu_ex_1.Text = "1. Вычислить формулы";
            this.menu_ex_1.Click += new System.EventHandler(this.ex_1_click);
            // 
            // menu_ex_2
            // 
            this.menu_ex_2.Name = "menu_ex_2";
            this.menu_ex_2.Size = new System.Drawing.Size(494, 26);
            this.menu_ex_2.Text = "2. Длина стороны и площадь треугольника";
            this.menu_ex_2.Click += new System.EventHandler(this.ex_2_click);
            // 
            // menu_ex_3
            // 
            this.menu_ex_3.Name = "menu_ex_3";
            this.menu_ex_3.Size = new System.Drawing.Size(494, 26);
            this.menu_ex_3.Text = "3. Проверка точки на принадлежность единичной окр-ти";
            this.menu_ex_3.Click += new System.EventHandler(this.ex_3_click);
            // 
            // menu_ex_4
            // 
            this.menu_ex_4.Name = "menu_ex_4";
            this.menu_ex_4.Size = new System.Drawing.Size(494, 26);
            this.menu_ex_4.Text = "4. Длина окр-ти, площадь круга, объём цилиндра";
            this.menu_ex_4.Click += new System.EventHandler(this.ex_4_Click);
            // 
            // variant
            // 
            this.variant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variant.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variant.Location = new System.Drawing.Point(0, 30);
            this.variant.Name = "variant";
            this.variant.Size = new System.Drawing.Size(686, 423);
            this.variant.TabIndex = 2;
            this.variant.Text = "Вариант №9";
            this.variant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(686, 453);
            this.MainPanel.TabIndex = 3;
            // 
            // menu_ex_5
            // 
            this.menu_ex_5.Name = "menu_ex_5";
            this.menu_ex_5.Size = new System.Drawing.Size(494, 26);
            this.menu_ex_5.Text = "5. Грузовой самолёт";
            this.menu_ex_5.Click += new System.EventHandler(this.ex_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 453);
            this.Controls.Add(this.variant);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem мЕНЮToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ex_1;
        private System.Windows.Forms.ToolStripMenuItem menu_ex_2;
        private System.Windows.Forms.Label variant;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem menu_ex_3;
        private System.Windows.Forms.ToolStripMenuItem menu_ex_4;
        private System.Windows.Forms.ToolStripMenuItem menu_ex_5;
    }
}

