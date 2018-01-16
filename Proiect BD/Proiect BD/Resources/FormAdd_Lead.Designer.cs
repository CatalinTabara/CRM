namespace Proiect_BD.Resources
{
    partial class FormAdd_Lead
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
            this.button_AddLead = new System.Windows.Forms.Button();
            this.label_Nume = new System.Windows.Forms.Label();
            this.label_Prenume = new System.Windows.Forms.Label();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Companie = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.textBox_Prenume = new System.Windows.Forms.TextBox();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_companie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(25, 208);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_AddLead
            // 
            this.button_AddLead.Location = new System.Drawing.Point(148, 208);
            this.button_AddLead.Name = "button_AddLead";
            this.button_AddLead.Size = new System.Drawing.Size(75, 23);
            this.button_AddLead.TabIndex = 1;
            this.button_AddLead.Text = "Add";
            this.button_AddLead.UseVisualStyleBackColor = true;
            this.button_AddLead.Click += new System.EventHandler(this.button_AddLead_Click);
            // 
            // label_Nume
            // 
            this.label_Nume.AutoSize = true;
            this.label_Nume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Nume.Location = new System.Drawing.Point(17, 24);
            this.label_Nume.Name = "label_Nume";
            this.label_Nume.Size = new System.Drawing.Size(39, 13);
            this.label_Nume.TabIndex = 2;
            this.label_Nume.Text = "Nume*";
            // 
            // label_Prenume
            // 
            this.label_Prenume.AutoSize = true;
            this.label_Prenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Prenume.Location = new System.Drawing.Point(17, 50);
            this.label_Prenume.Name = "label_Prenume";
            this.label_Prenume.Size = new System.Drawing.Size(53, 13);
            this.label_Prenume.TabIndex = 3;
            this.label_Prenume.Text = "Prenume*";
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Telefon.Location = new System.Drawing.Point(17, 76);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(43, 13);
            this.label_Telefon.TabIndex = 4;
            this.label_Telefon.Text = "Telefon";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Email.Location = new System.Drawing.Point(17, 102);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email";
            // 
            // label_Companie
            // 
            this.label_Companie.AutoSize = true;
            this.label_Companie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Companie.Location = new System.Drawing.Point(17, 128);
            this.label_Companie.Name = "label_Companie";
            this.label_Companie.Size = new System.Drawing.Size(54, 13);
            this.label_Companie.TabIndex = 6;
            this.label_Companie.Text = "Companie";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_Data.Location = new System.Drawing.Point(17, 157);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(83, 13);
            this.label_Data.TabIndex = 7;
            this.label_Data.Text = "Data Contactarii";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd mm yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(148, 21);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nume.TabIndex = 9;
            // 
            // textBox_Prenume
            // 
            this.textBox_Prenume.Location = new System.Drawing.Point(148, 47);
            this.textBox_Prenume.Name = "textBox_Prenume";
            this.textBox_Prenume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenume.TabIndex = 10;
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Location = new System.Drawing.Point(148, 73);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(100, 20);
            this.textBox_Telefon.TabIndex = 11;
            this.textBox_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefon_KeyPress);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(148, 99);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 12;
            // 
            // textBox_companie
            // 
            this.textBox_companie.Location = new System.Drawing.Point(148, 125);
            this.textBox_companie.Name = "textBox_companie";
            this.textBox_companie.Size = new System.Drawing.Size(100, 20);
            this.textBox_companie.TabIndex = 13;
            // 
            // FormAdd_Lead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(302, 249);
            this.Controls.Add(this.textBox_companie);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_Telefon);
            this.Controls.Add(this.textBox_Prenume);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.label_Companie);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Telefon);
            this.Controls.Add(this.label_Prenume);
            this.Controls.Add(this.label_Nume);
            this.Controls.Add(this.button_AddLead);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdd_Lead";
            this.Text = "FormAdd_Lead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_AddLead;
        private System.Windows.Forms.Label label_Nume;
        private System.Windows.Forms.Label label_Prenume;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Companie;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.TextBox textBox_Prenume;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_companie;
    }
}