namespace PhoneBook
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.New = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.contactsGridView = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FatherBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(1242, 9);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(184, 54);
            this.New.TabIndex = 0;
            this.New.Text = "Новый";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(1242, 69);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(184, 54);
            this.Change.TabIndex = 1;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1242, 129);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(184, 54);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1242, 225);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(184, 54);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(43, 29);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(81, 20);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(156, 23);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(1067, 26);
            this.SurnameBox.TabIndex = 5;
            // 
            // contactsGridView
            // 
            this.contactsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGridView.Location = new System.Drawing.Point(12, 285);
            this.contactsGridView.Name = "contactsGridView";
            this.contactsGridView.RowHeadersWidth = 62;
            this.contactsGridView.RowTemplate.Height = 28;
            this.contactsGridView.Size = new System.Drawing.Size(1414, 489);
            this.contactsGridView.TabIndex = 6;
            this.contactsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.contactsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsGridView_CellDoubleClick);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(156, 69);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(1067, 26);
            this.NameBox.TabIndex = 7;
            // 
            // FatherBox
            // 
            this.FatherBox.Location = new System.Drawing.Point(156, 118);
            this.FatherBox.Name = "FatherBox";
            this.FatherBox.Size = new System.Drawing.Size(1067, 26);
            this.FatherBox.TabIndex = 8;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(156, 168);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(1067, 26);
            this.NumberBox.TabIndex = 9;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(59, 75);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(40, 20);
            this.Namelabel.TabIndex = 10;
            this.Namelabel.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Отчество";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер телефона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 797);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.FatherBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.contactsGridView);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.New);
            this.Name = "Form1";
            this.Text = "Телефонная книжка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.DataGridView contactsGridView;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox FatherBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

