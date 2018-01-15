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
    public partial class Form_Delete_User : Form
    {
        public Form_Delete_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            int ID = 0;
            Model_CRM Context = new Model_CRM();
            Utilizatori user = new Utilizatori();
            try
            {
                ID = Context.Utilizatoris.Max(s => s.Employee_ID);
                if(ID> Convert.ToInt32(textBox1.Text))
                {
                    int E_ID = Convert.ToInt32(textBox1.Text);
                    var itemToRemove = Context.Utilizatoris.SingleOrDefault(x => x.Employee_ID == E_ID); //returns a single item.

                    if (itemToRemove != null)
                    {
                        Context.Utilizatoris.Remove(itemToRemove);
                        Context.SaveChanges();
                    }
                    MessageBox.Show("User deleted succesfuly!", "Succes", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    throw new Exception("Incorrect ID!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
