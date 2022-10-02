namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTab1 = new System.Windows.Forms.Button();
            this.buttonTab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTab1
            // 
            this.buttonTab1.Location = new System.Drawing.Point(12, 19);
            this.buttonTab1.Name = "buttonTab1";
            this.buttonTab1.Size = new System.Drawing.Size(102, 36);
            this.buttonTab1.TabIndex = 7;
            this.buttonTab1.Text = "Заголовок";
            this.buttonTab1.UseVisualStyleBackColor = true;
            this.buttonTab1.Click += new System.EventHandler(this.buttonTab1_Click);
            // 
            // buttonTab2
            // 
            this.buttonTab2.Location = new System.Drawing.Point(150, 19);
            this.buttonTab2.Name = "buttonTab2";
            this.buttonTab2.Size = new System.Drawing.Size(102, 36);
            this.buttonTab2.TabIndex = 7;
            this.buttonTab2.Text = "Позиции";
            this.buttonTab2.UseVisualStyleBackColor = true;
            this.buttonTab2.Click += new System.EventHandler(this.buttonTab2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 67);
            this.Controls.Add(this.buttonTab2);
            this.Controls.Add(this.buttonTab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTab1;
        private System.Windows.Forms.Button buttonTab2;
    }
}