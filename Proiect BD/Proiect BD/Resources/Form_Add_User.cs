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
    public partial class Form_Add_User : Form
    {
        public Form_Add_User()
        {
            InitializeComponent();
        }


        private void Form_Add_User_Load(object sender, EventArgs e)
        {

        }
        private bool verify_register()
        {
            if (string.IsNullOrWhiteSpace(textBox_Add_Password.Text))
                return false;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return false;
            if (string.IsNullOrWhiteSpace(textBox_Add_Username.Text))
                return false;
            if (string.IsNullOrWhiteSpace(comboBox_Add_Grad.Text))
                return false;
            return true;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            try {
                if (verify_register())
                {
                    if (textBox_Add_Password.Text == textBox1.Text)
                    {
                        int ID = 0;
                        Model_CRM Context = new Model_CRM();
                        Utilizatori user = new Utilizatori();

                        if (Context.Utilizatoris.Count() == 0)
                        {
                            ID = 1;
                        }
                        else
                        {
                            ID = (int)Context.Utilizatoris.Max(s => s.Employee_ID);
                            ID++;
                        }

                        if(String.IsNullOrWhiteSpace(textBox_Add_Username.Text)==false && textBox_Add_Username.Text!=user.Username)
                        {
                            Utilizatori aux = Context.Utilizatoris.Where(x => x.Username == textBox_Add_Username.Text).FirstOrDefault();
                            if(aux==null) user.Username = textBox_Add_Username.Text;
                            else
                            {
                                throw new Exception("Username already used!");
                            }
                        }
                       

                        user.Employee_ID = ID;
                        user.Nume = textBox_Add_Nume.Text;
                        user.Prenume = textBox_Add_Prenume.Text;
                        
                        user.Password = sha256(textBox_Add_Password.ToString());
                        user.Grad = comboBox_Add_Grad.Text;
                        user.Telefon = textBox_Add_Phone.Text;


                        Context.Utilizatoris.Add(user);
                        Context.SaveChanges();
                        Context.Dispose();
                        MessageBox.Show("User was added succesfuly!", "Congrats!", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Passwords don't match!");
                    }
                }
                else
                {
                    throw new Exception("You must complete all marked fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        static string sha256(string randomString)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString), 0, Encoding.UTF8.GetByteCount(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
