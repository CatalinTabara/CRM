using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD.Resources
{
    public partial class Form_AddPotential : Form
    {
        public Form_AddPotential()
        {
            InitializeComponent();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verify()
        {

            return false;
        }

        private void button_AddLead_Click(object sender, EventArgs e)
        {
            Model_CRM Context = new Model_CRM();
            Potential_client_ client_Potential = new Potential_client_();
            
            int ID = 0;
            try
            {
                if (verify())
                {
                    if (Context.Leads__Ponturi_.Count() == 0)
                    {
                        ID = 1;
                    }
                    else
                    {
                        ID = (int)Context.Leads__Ponturi_.Max(s => s.Lead_ID);
                        ID++;
                    }

                  
                   
                    // Lead.Contact = dateTimePicker1.;
                    Context.Potential_client_.Add(client_Potential);
                    Context.SaveChanges();
                    Context.Dispose();
                    MessageBox.Show("Lead added succesfuly!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    this.Close();
                }
                else
                {
                    throw new Exception("Complete marked fields and at least one contact field!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_AddPotential_Load(object sender, EventArgs e)
        {

        }
    }
}
