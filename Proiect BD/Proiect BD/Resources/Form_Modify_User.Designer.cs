namespace Proiect_BD.Resources
{
    partial class Form_Modify_User
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.label_Prenume = new System.Windows.Forms.Label();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.label_ConfPassword = new System.Windows.Forms.Label();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.textBox_Prenume = new System.Windows.Forms.TextBox();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.textBox_NewPwd = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_ConfPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(65, 202);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(156, 202);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(75, 23);
            this.button_Modify.TabIndex = 1;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Nume.Location = new System.Drawing.Point(17, 33);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(35, 13);
            this.Nume.TabIndex = 2;
            this.Nume.Text = "Nume";
            // 
            // label_Prenume
            // 
            this.label_Prenume.AutoSize = true;
            this.label_Prenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Prenume.Location = new System.Drawing.Point(17, 58);
            this.label_Prenume.Name = "label_Prenume";
            this.label_Prenume.Size = new System.Drawing.Size(49, 13);
            this.label_Prenume.TabIndex = 3;
            this.label_Prenume.Text = "Prenume";
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Telefon.Location = new System.Drawing.Point(17, 84);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(43, 13);
            this.label_Telefon.TabIndex = 4;
            this.label_Telefon.Text = "Telefon";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Password.Location = new System.Drawing.Point(17, 110);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "Password";
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_NewPassword.Location = new System.Drawing.Point(17, 136);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(78, 13);
            this.label_NewPassword.TabIndex = 7;
            this.label_NewPassword.Text = "New Password";
            // 
            // label_ConfPassword
            // 
            this.label_ConfPassword.AutoSize = true;
            this.label_ConfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_ConfPassword.Location = new System.Drawing.Point(17, 162);
            this.label_ConfPassword.Name = "label_ConfPassword";
            this.label_ConfPassword.Size = new System.Drawing.Size(91, 13);
            this.label_ConfPassword.TabIndex = 8;
            this.label_ConfPassword.Text = "Confirm Password";
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(142, 30);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nume.TabIndex = 9;
            // 
            // textBox_Prenume
            // 
            this.textBox_Prenume.Location = new System.Drawing.Point(142, 55);
            this.textBox_Prenume.Name = "textBox_Prenume";
            this.textBox_Prenume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenume.TabIndex = 10;
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Location = new System.Drawing.Point(142, 81);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(100, 20);
            this.textBox_Telefon.TabIndex = 11;
            // 
            // textBox_NewPwd
            // 
            this.textBox_NewPwd.Location = new System.Drawing.Point(142, 133);
            this.textBox_NewPwd.Name = "textBox_NewPwd";
            this.textBox_NewPwd.PasswordChar = '*';
            this.textBox_NewPwd.Size = new System.Drawing.Size(100, 20);
            this.textBox_NewPwd.TabIndex = 12;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(142, 107);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 13;
            // 
            // textBox_ConfPwd
            // 
            this.textBox_ConfPwd.Location = new System.Drawing.Point(142, 159);
            this.textBox_ConfPwd.Name = "textBox_ConfPwd";
            this.textBox_ConfPwd.PasswordChar = '*';
            this.textBox_ConfPwd.Size = new System.Drawing.Size(100, 20);
            this.textBox_ConfPwd.TabIndex = 14;
            // 
            // Form_Modify_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(271, 248);
            this.Controls.Add(this.textBox_ConfPwd);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_NewPwd);
            this.Controls.Add(this.textBox_Telefon);
            this.Controls.Add(this.textBox_Prenume);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.label_ConfPassword);
            this.Controls.Add(this.label_NewPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Telefon);
            this.Controls.Add(this.label_Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Modify_User";
            this.Text = "Form_Modify_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label_Prenume;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_ConfPassword;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.TextBox textBox_Prenume;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_NewPwd;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_ConfPwd;
    }
}