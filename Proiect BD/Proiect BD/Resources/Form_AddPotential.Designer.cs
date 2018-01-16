namespace Proiect_BD.Resources
{
    partial class Form_AddPotential
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
            this.button_AddPotential = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddPotential
            // 
            this.button_AddPotential.Location = new System.Drawing.Point(112, 96);
            this.button_AddPotential.Name = "button_AddPotential";
            this.button_AddPotential.Size = new System.Drawing.Size(75, 23);
            this.button_AddPotential.TabIndex = 15;
            this.button_AddPotential.Text = "Add";
            this.button_AddPotential.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 96);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(31, 52);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 16;
            this.label_ID.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(112, 49);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(73, 20);
            this.textBox_ID.TabIndex = 17;
            // 
            // Form_AddPotential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(240, 152);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_AddPotential);
            this.Controls.Add(this.button_Cancel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddPotential";
            this.Text = "Form_AddLead";
            this.Load += new System.EventHandler(this.Form_AddPotential_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_AddPotential;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}