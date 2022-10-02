namespace Client
{
    partial class TableViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check_row = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delRowsButton = new System.Windows.Forms.Button();
            this.addRowsButton = new System.Windows.Forms.Button();
            this.saveNewRowsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_row});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 48;
            this.dataGridView1.Size = new System.Drawing.Size(812, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateCell);
            // 
            // check_row
            // 
            this.check_row.FalseValue = "";
            this.check_row.FillWeight = 20F;
            this.check_row.HeaderText = "";
            this.check_row.IndeterminateValue = "";
            this.check_row.Name = "check_row";
            this.check_row.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check_row.Width = 5;
            // 
            // delRowsButton
            // 
            this.delRowsButton.Location = new System.Drawing.Point(12, 332);
            this.delRowsButton.Name = "delRowsButton";
            this.delRowsButton.Size = new System.Drawing.Size(118, 36);
            this.delRowsButton.TabIndex = 2;
            this.delRowsButton.Text = "Удалить выбранные строки";
            this.delRowsButton.UseVisualStyleBackColor = true;
            this.delRowsButton.Click += new System.EventHandler(this.DeleteRows);
            // 
            // addRowsButton
            // 
            this.addRowsButton.Location = new System.Drawing.Point(136, 332);
            this.addRowsButton.Name = "addRowsButton";
            this.addRowsButton.Size = new System.Drawing.Size(118, 36);
            this.addRowsButton.TabIndex = 3;
            this.addRowsButton.Text = "Добавить строку";
            this.addRowsButton.UseVisualStyleBackColor = true;
            this.addRowsButton.Click += new System.EventHandler(this.AddRows);
            // 
            // saveNewRowsButton
            // 
            this.saveNewRowsButton.Location = new System.Drawing.Point(260, 332);
            this.saveNewRowsButton.Name = "saveNewRowsButton";
            this.saveNewRowsButton.Size = new System.Drawing.Size(118, 36);
            this.saveNewRowsButton.TabIndex = 4;
            this.saveNewRowsButton.Text = "Сохранить новые строки";
            this.saveNewRowsButton.UseVisualStyleBackColor = true;
            this.saveNewRowsButton.Click += new System.EventHandler(this.saveNewRowsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Строка поиска";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(393, 357);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Цех-производитель";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(523, 357);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Tag = "position";
            this.radioButton2.Text = "Марка стали";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(619, 357);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Tag = "position";
            this.radioButton3.Text = "Диаметр";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(696, 357);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Tag = "position";
            this.radioButton4.Text = "Стенка";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(830, 380);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveNewRowsButton);
            this.Controls.Add(this.addRowsButton);
            this.Controls.Add(this.delRowsButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TableViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delRowsButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_row;
        private System.Windows.Forms.Button addRowsButton;
        private System.Windows.Forms.Button saveNewRowsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}