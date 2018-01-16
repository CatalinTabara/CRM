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
    public partial class Form_Delete_Lead : Form
    {
        public Form_Delete_Lead()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int ID = 0;
            Model_CRM Context = new Model_CRM();
            Leads__Ponturi_ user = new Leads__Ponturi_();
            try
            {
                ID = Convert.ToInt32(Context.Leads__Ponturi_.Max(s => s.Lead_ID));
                if (ID > Convert.ToInt32(textBox_ID.Text))
                {
                    int E_ID = Convert.ToInt32(textBox_ID.Text);
                    var itemToRemove = Context.Leads__Ponturi_.SingleOrDefault(x => x.Lead_ID == E_ID);

                    if (itemToRemove != null)
                    {
                        Context.Leads__Ponturi_.Remove(itemToRemove);
                        Context.SaveChanges();
                    }
                    MessageBox.Show("Lead deleted succesfuly!", "Succes", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    throw new Exception("Incorrect ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
