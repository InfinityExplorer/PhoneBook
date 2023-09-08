namespace PhoneBook
{
    partial class LoginForm
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
            this.Entrance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PasBox = new System.Windows.Forms.TextBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrance
            // 
            this.Entrance.Location = new System.Drawing.Point(315, 320);
            this.Entrance.Name = "Entrance";
            this.Entrance.Size = new System.Drawing.Size(135, 44);
            this.Entrance.TabIndex = 0;
            this.Entrance.Text = "Вход";
            this.Entrance.UseVisualStyleBackColor = true;
            this.Entrance.Click += new System.EventHandler(this.Entrance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(238, 117);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(304, 26);
            this.LogBox.TabIndex = 3;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // PasBox
            // 
            this.PasBox.Location = new System.Drawing.Point(238, 199);
            this.PasBox.Name = "PasBox";
            this.PasBox.PasswordChar = '*';
            this.PasBox.Size = new System.Drawing.Size(304, 26);
            this.PasBox.TabIndex = 4;
            this.PasBox.TextChanged += new System.EventHandler(this.PasBox_TextChanged);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(536, 320);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(187, 44);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Администрирование";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.PasBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrance);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PasBox;
        private System.Windows.Forms.Button btn_admin;
    }
}