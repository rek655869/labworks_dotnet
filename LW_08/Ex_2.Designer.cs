namespace LW_08
{
    partial class Ex_2
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
            this.folderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FileDialog = new System.Windows.Forms.Button();
            this.btn_createFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задайте имя папки:";
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(269, 22);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(194, 22);
            this.folderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите расположение:";
            // 
            // btn_FileDialog
            // 
            this.btn_FileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FileDialog.Location = new System.Drawing.Point(269, 58);
            this.btn_FileDialog.Name = "btn_FileDialog";
            this.btn_FileDialog.Size = new System.Drawing.Size(134, 33);
            this.btn_FileDialog.TabIndex = 3;
            this.btn_FileDialog.Text = "Обзор...";
            this.btn_FileDialog.UseVisualStyleBackColor = true;
            this.btn_FileDialog.Click += new System.EventHandler(this.btn_FileDialog_Click);
            // 
            // btn_createFolder
            // 
            this.btn_createFolder.Location = new System.Drawing.Point(126, 130);
            this.btn_createFolder.Name = "btn_createFolder";
            this.btn_createFolder.Size = new System.Drawing.Size(169, 33);
            this.btn_createFolder.TabIndex = 4;
            this.btn_createFolder.Text = "Создать папку";
            this.btn_createFolder.UseVisualStyleBackColor = true;
            this.btn_createFolder.Click += new System.EventHandler(this.btn_createFolder_Click);
            // 
            // Ex_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_createFolder);
            this.Controls.Add(this.btn_FileDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.label1);
            this.Name = "Ex_2";
            this.Size = new System.Drawing.Size(521, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FileDialog;
        private System.Windows.Forms.Button btn_createFolder;
    }
}
