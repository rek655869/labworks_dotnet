namespace LW_03
{
    partial class Menu
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
            this.Exercises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exercises
            // 
            this.Exercises.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exercises.FormattingEnabled = true;
            this.Exercises.Items.AddRange(new object[] {
            "1. Среди заданных чисел найти количество четных чисел",
            "2. Целые числа в (A; В) и их количество",
            "3. Среднее арифметическое введённых чисел",
            "4. Найти сумму бесконечного ряда",
            "5. Значение функции в каждой точке отрезка и сумма",
            "6. Кол-во цифр в числе, которые больше кол-ва его десятков",
            "7. Найти сумму ряда от числа N"});
            this.Exercises.Location = new System.Drawing.Point(56, 47);
            this.Exercises.Name = "Exercises";
            this.Exercises.Size = new System.Drawing.Size(457, 24);
            this.Exercises.TabIndex = 6;
            this.Exercises.SelectedIndexChanged += new System.EventHandler(this.Exercises_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите одно из заданий:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Exercises);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(566, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Exercises;
        private System.Windows.Forms.Label label1;
    }
}
