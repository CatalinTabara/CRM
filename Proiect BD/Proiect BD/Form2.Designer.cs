namespace Proiect_BD
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Box_Exit = new System.Windows.Forms.PictureBox();
            this.Box_Calendar = new System.Windows.Forms.PictureBox();
            this.Box_contacte = new System.Windows.Forms.PictureBox();
            this.Box_Home = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Panel();
            this.label_Home = new System.Windows.Forms.Label();
            this.label_Contacte = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_contacte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Contacte);
            this.panel1.Controls.Add(this.label_Home);
            this.panel1.Controls.Add(this.Box_Exit);
            this.panel1.Controls.Add(this.Box_Calendar);
            this.panel1.Controls.Add(this.Box_contacte);
            this.panel1.Controls.Add(this.Box_Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 433);
            this.panel1.TabIndex = 0;
            // 
            // Box_Exit
            // 
            this.Box_Exit.BackgroundImage = global::Proiect_BD.Properties.Resources.shutdown_button_png_image_98694;
            this.Box_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box_Exit.Location = new System.Drawing.Point(36, 380);
            this.Box_Exit.Name = "Box_Exit";
            this.Box_Exit.Size = new System.Drawing.Size(56, 41);
            this.Box_Exit.TabIndex = 4;
            this.Box_Exit.TabStop = false;
            // 
            // Box_Calendar
            // 
            this.Box_Calendar.BackgroundImage = global::Proiect_BD.Properties.Resources.button3_Image;
            this.Box_Calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Box_Calendar.Location = new System.Drawing.Point(36, 263);
            this.Box_Calendar.Name = "Box_Calendar";
            this.Box_Calendar.Size = new System.Drawing.Size(56, 41);
            this.Box_Calendar.TabIndex = 3;
            this.Box_Calendar.TabStop = false;
            // 
            // Box_contacte
            // 
            this.Box_contacte.BackgroundImage = global::Proiect_BD.Properties.Resources.button2_Image;
            this.Box_contacte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Box_contacte.Location = new System.Drawing.Point(36, 191);
            this.Box_contacte.Name = "Box_contacte";
            this.Box_contacte.Size = new System.Drawing.Size(56, 41);
            this.Box_contacte.TabIndex = 2;
            this.Box_contacte.TabStop = false;
            // 
            // Box_Home
            // 
            this.Box_Home.BackgroundImage = global::Proiect_BD.Properties.Resources.button1_Image;
            this.Box_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Box_Home.Location = new System.Drawing.Point(36, 120);
            this.Box_Home.Name = "Box_Home";
            this.Box_Home.Size = new System.Drawing.Size(56, 41);
            this.Box_Home.TabIndex = 1;
            this.Box_Home.TabStop = false;
            this.Box_Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proiect_BD.Properties.Resources.b1f80662e3a36e85f2ab0b03d4a36177;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(132, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(526, 433);
            this.Home.TabIndex = 1;
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.Location = new System.Drawing.Point(46, 164);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(35, 13);
            this.label_Home.TabIndex = 0;
            this.label_Home.Text = "Home";
            // 
            // label_Contacte
            // 
            this.label_Contacte.AutoSize = true;
            this.label_Contacte.Location = new System.Drawing.Point(46, 235);
            this.label_Contacte.Name = "label_Contacte";
            this.label_Contacte.Size = new System.Drawing.Size(36, 13);
            this.label_Contacte.TabIndex = 5;
            this.label_Contacte.Text = "Leads";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(659, 433);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_contacte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Box_Home;
        private System.Windows.Forms.PictureBox Box_contacte;
        private System.Windows.Forms.PictureBox Box_Calendar;
        private System.Windows.Forms.PictureBox Box_Exit;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Label label_Contacte;
        private System.Windows.Forms.Label label_Home;
    }
}