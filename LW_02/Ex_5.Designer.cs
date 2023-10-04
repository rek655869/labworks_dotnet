namespace LW_02
{
    partial class Ex_5
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_mc = new System.Windows.Forms.TextBox();
            this.input_fc = new System.Windows.Forms.TextBox();
            this.input_fr = new System.Windows.Forms.TextBox();
            this.input_ap = new System.Windows.Forms.CheckBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите среднюю грузоподъёмность (т):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите расход топлива (кг/ч):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите дальность полёта (км):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Наличие автопилота:";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(324, 30);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(100, 22);
            this.input_name.TabIndex = 6;
            // 
            // input_mc
            // 
            this.input_mc.Location = new System.Drawing.Point(324, 70);
            this.input_mc.Name = "input_mc";
            this.input_mc.Size = new System.Drawing.Size(100, 22);
            this.input_mc.TabIndex = 8;
            // 
            // input_fc
            // 
            this.input_fc.Location = new System.Drawing.Point(324, 110);
            this.input_fc.Name = "input_fc";
            this.input_fc.Size = new System.Drawing.Size(100, 22);
            this.input_fc.TabIndex = 9;
            // 
            // input_fr
            // 
            this.input_fr.Location = new System.Drawing.Point(324, 150);
            this.input_fr.Name = "input_fr";
            this.input_fr.Size = new System.Drawing.Size(100, 22);
            this.input_fr.TabIndex = 10;
            // 
            // input_ap
            // 
            this.input_ap.AutoSize = true;
            this.input_ap.Location = new System.Drawing.Point(367, 190);
            this.input_ap.Name = "input_ap";
            this.input_ap.Size = new System.Drawing.Size(18, 17);
            this.input_ap.TabIndex = 11;
            this.input_ap.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(30, 230);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(222, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вывести информацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ex_5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input_ap);
            this.Controls.Add(this.input_fr);
            this.Controls.Add(this.input_fc);
            this.Controls.Add(this.input_mc);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex_5";
            this.Size = new System.Drawing.Size(621, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_mc;
        private System.Windows.Forms.TextBox input_fc;
        private System.Windows.Forms.TextBox input_fr;
        private System.Windows.Forms.CheckBox input_ap;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}
