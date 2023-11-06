namespace _77
{
    partial class Ex_1_3
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
            this.start = new System.Windows.Forms.Button();
            this.output_res = new System.Windows.Forms.Label();
            this.output_mas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_n = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(414, 326);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(187, 68);
            this.start.TabIndex = 16;
            this.start.Text = "Посчитать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // output_res
            // 
            this.output_res.AutoSize = true;
            this.output_res.Location = new System.Drawing.Point(477, 243);
            this.output_res.Name = "output_res";
            this.output_res.Size = new System.Drawing.Size(0, 20);
            this.output_res.TabIndex = 15;
            // 
            // output_mas
            // 
            this.output_mas.AutoSize = true;
            this.output_mas.Location = new System.Drawing.Point(477, 183);
            this.output_mas.Name = "output_mas";
            this.output_mas.Size = new System.Drawing.Size(0, 20);
            this.output_mas.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество положительных элементов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите размер массива:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Массив:";
            // 
            // input_n
            // 
            this.input_n.Location = new System.Drawing.Point(481, 117);
            this.input_n.Name = "input_n";
            this.input_n.Size = new System.Drawing.Size(49, 26);
            this.input_n.TabIndex = 10;
            // 
            // Ex_1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.start);
            this.Controls.Add(this.output_res);
            this.Controls.Add(this.output_mas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_n);
            this.Name = "Ex_1_3";
            this.Size = new System.Drawing.Size(756, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label output_res;
        private System.Windows.Forms.Label output_mas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox input_n;
    }
}
