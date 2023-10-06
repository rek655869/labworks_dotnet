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
            this.button_console = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exercises
            // 
            this.Exercises.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exercises.FormattingEnabled = true;
            this.Exercises.Items.AddRange(new object[] {
            "Найти сумму бесконечного ряда",
            "Значение функции в каждой точке отрезка и сумма",
            "Кол-во цифр, которое больше кол-ва десятков в числе",
            "Найти сумму ряда от числа N"});
            this.Exercises.Location = new System.Drawing.Point(90, 164);
            this.Exercises.Name = "Exercises";
            this.Exercises.Size = new System.Drawing.Size(393, 24);
            this.Exercises.TabIndex = 6;
            this.Exercises.SelectedIndexChanged += new System.EventHandler(this.Exercises_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Или выберите одно из заданий:";
            // 
            // button_console
            // 
            this.button_console.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_console.Location = new System.Drawing.Point(180, 24);
            this.button_console.Name = "button_console";
            this.button_console.Size = new System.Drawing.Size(210, 57);
            this.button_console.TabIndex = 4;
            this.button_console.Text = "Запустить консоль";
            this.button_console.UseVisualStyleBackColor = true;
            this.button_console.Click += new System.EventHandler(this.button_console_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Exercises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_console);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(566, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Exercises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_console;
    }
}
