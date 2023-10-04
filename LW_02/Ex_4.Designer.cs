namespace LW_02
{
    partial class Ex_4
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
            this.button_V = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_V
            // 
            this.button_V.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_V.Location = new System.Drawing.Point(349, 23);
            this.button_V.Name = "button_V";
            this.button_V.Size = new System.Drawing.Size(153, 42);
            this.button_V.TabIndex = 9;
            this.button_V.Text = "Объём цилиндра";
            this.button_V.UseVisualStyleBackColor = true;
            this.button_V.Click += new System.EventHandler(this.button_V_Click);
            // 
            // button_S
            // 
            this.button_S.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_S.Location = new System.Drawing.Point(185, 23);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(153, 42);
            this.button_S.TabIndex = 8;
            this.button_S.Text = "Площадь круга";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(15, 23);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(153, 42);
            this.button_L.TabIndex = 7;
            this.button_L.Text = "Длина окружности";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 262);
            this.panel1.TabIndex = 10;
            // 
            // Ex_4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_V);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.button_L);
            this.Name = "Ex_4";
            this.Size = new System.Drawing.Size(522, 337);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_V;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Panel panel1;
    }
}
