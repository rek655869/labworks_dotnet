namespace LW_02
{
    partial class Ex_3
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
            this.result = new System.Windows.Forms.Label();
            this.input_x = new System.Windows.Forms.TextBox();
            this.input_y = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задайте координату x:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задайте координату y:";
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(30, 110);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 8;
            // 
            // input_x
            // 
            this.input_x.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_x.Location = new System.Drawing.Point(206, 30);
            this.input_x.Name = "input_x";
            this.input_x.Size = new System.Drawing.Size(100, 22);
            this.input_x.TabIndex = 9;
            // 
            // input_y
            // 
            this.input_y.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_y.Location = new System.Drawing.Point(206, 70);
            this.input_y.Name = "input_y";
            this.input_y.Size = new System.Drawing.Size(100, 22);
            this.input_y.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(182, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ex_3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_y);
            this.Controls.Add(this.input_x);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex_3";
            this.Size = new System.Drawing.Size(513, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox input_x;
        private System.Windows.Forms.TextBox input_y;
        private System.Windows.Forms.Button button1;
    }
}
