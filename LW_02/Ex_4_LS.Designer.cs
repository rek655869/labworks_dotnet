﻿namespace LW_02
{
    partial class Ex_4_LS
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
            this.input_r = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите радиус: ";
            // 
            // input_r
            // 
            this.input_r.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_r.Location = new System.Drawing.Point(175, 30);
            this.input_r.Name = "input_r";
            this.input_r.Size = new System.Drawing.Size(100, 22);
            this.input_r.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(175, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(30, 70);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 8;
            // 
            // Ex_4_L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_r);
            this.Controls.Add(this.label1);
            this.Name = "Ex_4_L";
            this.Size = new System.Drawing.Size(507, 214);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_r;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}
