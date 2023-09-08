namespace PhoneBook
{
    partial class AdminForm
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
            this.btn_userAdd = new System.Windows.Forms.Button();
            this.listBox_lvlAccess = new System.Windows.Forms.ListBox();
            this.btn_userDelete = new System.Windows.Forms.Button();
            this.box_userLog = new System.Windows.Forms.TextBox();
            this.box_userPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_userAdd
            // 
            this.btn_userAdd.Location = new System.Drawing.Point(476, 348);
            this.btn_userAdd.Name = "btn_userAdd";
            this.btn_userAdd.Size = new System.Drawing.Size(163, 70);
            this.btn_userAdd.TabIndex = 0;
            this.btn_userAdd.Text = "Добавить";
            this.btn_userAdd.UseVisualStyleBackColor = true;
            this.btn_userAdd.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // listBox_lvlAccess
            // 
            this.listBox_lvlAccess.FormattingEnabled = true;
            this.listBox_lvlAccess.ItemHeight = 20;
            this.listBox_lvlAccess.Items.AddRange(new object[] {
            "Менеджер",
            "Редактор",
            "Оператор"});
            this.listBox_lvlAccess.Location = new System.Drawing.Point(303, 260);
            this.listBox_lvlAccess.Name = "listBox_lvlAccess";
            this.listBox_lvlAccess.Size = new System.Drawing.Size(249, 24);
            this.listBox_lvlAccess.TabIndex = 1;
            // 
            // btn_userDelete
            // 
            this.btn_userDelete.Location = new System.Drawing.Point(209, 348);
            this.btn_userDelete.Name = "btn_userDelete";
            this.btn_userDelete.Size = new System.Drawing.Size(163, 70);
            this.btn_userDelete.TabIndex = 2;
            this.btn_userDelete.Text = "Удалить";
            this.btn_userDelete.UseVisualStyleBackColor = true;
            this.btn_userDelete.Click += new System.EventHandler(this.btn_userDelete_Click);
            // 
            // box_userLog
            // 
            this.box_userLog.Location = new System.Drawing.Point(303, 116);
            this.box_userLog.Name = "box_userLog";
            this.box_userLog.Size = new System.Drawing.Size(317, 26);
            this.box_userLog.TabIndex = 3;
            // 
            // box_userPass
            // 
            this.box_userPass.Location = new System.Drawing.Point(303, 196);
            this.box_userPass.Name = "box_userPass";
            this.box_userPass.Size = new System.Drawing.Size(317, 26);
            this.box_userPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_userPass);
            this.Controls.Add(this.box_userLog);
            this.Controls.Add(this.btn_userDelete);
            this.Controls.Add(this.listBox_lvlAccess);
            this.Controls.Add(this.btn_userAdd);
            this.Name = "AdminForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_userAdd;
        private System.Windows.Forms.ListBox listBox_lvlAccess;
        private System.Windows.Forms.Button btn_userDelete;
        private System.Windows.Forms.TextBox box_userLog;
        private System.Windows.Forms.TextBox box_userPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}