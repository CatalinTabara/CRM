﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD
{
    public partial class Form2 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("test");

        }

        private void Box_contacte_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void Box_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listPanel.Add(Home);
            listPanel.Add(panel_Leads);
            listPanel[0].BringToFront();
        }

        private void Box_Potential_Click(object sender, EventArgs e)
        {

        }
    }
}
