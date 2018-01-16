namespace Proiect_BD.Resources
{
    partial class Form_Delete_Lead
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
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(23, 20);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(24, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = " ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(76, 17);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(26, 20);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 60);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(52, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(76, 60);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(52, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form_Delete_Lead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(148, 95);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Delete_Lead";
            this.Text = "Form_Delete_Lead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Delete;
    }
}