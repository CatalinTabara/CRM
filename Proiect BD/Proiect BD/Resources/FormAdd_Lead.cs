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
    public partial class FormAdd_Lead : Form
    {
        Utilizatori user;
        public FormAdd_Lead(Utilizatori u)
        {
            user = u;
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verify()
        {
            if (String.IsNullOrWhiteSpace(textBox_Nume.Text))
                return false;
            else if (String.IsNullOrWhiteSpace(textBox_Prenume.Text))
                return false;
            else if (String.IsNullOrWhiteSpace(textBox_Telefon.Text) && String.IsNullOrWhiteSpace(textBox_email.Text) && String.IsNullOrWhiteSpace(textBox_companie.Text))
                return false;
            return true;
        }
        private void button_AddLead_Click(object sender, EventArgs e)
        {
            Model_CRM Context = new Model_CRM();
            Leads__Ponturi_ Lead=new Leads__Ponturi_();
            Form2 obj = (Form2)Application.OpenForms["Form2"];
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

                    Lead.Nume = textBox_Nume.Text;
                    Lead.Prenume = textBox_Prenume.Text;
                    Lead.Lead_ID = ID;
                    Lead.Nr_tel = Int32.Parse(textBox_Telefon.Text);
                    Lead.Email = textBox_email.Text;
                    Lead.Companie = textBox_companie.Text;
                   // Lead.Contact = dateTimePicker1.;
                    Context.Leads__Ponturi_.Add(Lead);
                    Context.SaveChanges();
                    Context.Dispose();
                    MessageBox.Show("Lead added succesfuly!","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj.loaddata();
                    
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

        private void textBox_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
