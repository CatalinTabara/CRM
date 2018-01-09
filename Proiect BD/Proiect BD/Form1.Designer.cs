namespace Proiect_BD
{
    partial class Form1
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
            this.username_login = new System.Windows.Forms.Label();
            this.pwd_login = new System.Windows.Forms.Label();
            this.textBox_login_user = new System.Windows.Forms.TextBox();
            this.textBox_login_pwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_login
            // 
            this.username_login.AutoSize = true;
            this.username_login.Location = new System.Drawing.Point(8, 25);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(58, 13);
            this.username_login.TabIndex = 0;
            this.username_login.Text = "Username:";
            // 
            // pwd_login
            // 
            this.pwd_login.AutoSize = true;
            this.pwd_login.Location = new System.Drawing.Point(10, 69);
            this.pwd_login.Name = "pwd_login";
            this.pwd_login.Size = new System.Drawing.Size(56, 13);
            this.pwd_login.TabIndex = 1;
            this.pwd_login.Text = "Password:";
            // 
            // textBox_login_user
            // 
            this.textBox_login_user.Location = new System.Drawing.Point(79, 22);
            this.textBox_login_user.Name = "textBox_login_user";
            this.textBox_login_user.Size = new System.Drawing.Size(143, 20);
            this.textBox_login_user.TabIndex = 2;
            this.textBox_login_user.TextChanged += new System.EventHandler(this.textBox_login_user_TextChanged);
            // 
            // textBox_login_pwd
            // 
            this.textBox_login_pwd.Location = new System.Drawing.Point(79, 66);
            this.textBox_login_pwd.Name = "textBox_login_pwd";
            this.textBox_login_pwd.PasswordChar = '*';
            this.textBox_login_pwd.Size = new System.Drawing.Size(143, 20);
            this.textBox_login_pwd.TabIndex = 3;
            this.textBox_login_pwd.TextChanged += new System.EventHandler(this.textBox_login_pwd_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.textBox_login_pwd);
            this.groupBox1.Controls.Add(this.textBox_login_user);
            this.groupBox1.Controls.Add(this.pwd_login);
            this.groupBox1.Controls.Add(this.username_login);
            this.groupBox1.Location = new System.Drawing.Point(184, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(137, 104);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(85, 25);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_BD.Properties.Resources.b1f80662e3a36e85f2ab0b03d4a36177;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(440, 187);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username_login;
        private System.Windows.Forms.Label pwd_login;
        private System.Windows.Forms.TextBox textBox_login_user;
        private System.Windows.Forms.TextBox textBox_login_pwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

