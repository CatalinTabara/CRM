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
    public partial class Form_Modify_User : Form
    {
        Utilizatori user;
        public Form_Modify_User(Utilizatori u)
        {
            InitializeComponent();
            
            this.user = u;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            Model_CRM Context = new Model_CRM();
            Utilizatori update_user = new Utilizatori();
            try
            {
                if (String.IsNullOrWhiteSpace(textBox_Password.Text)) throw new Exception("Give password!");
                else
                {
                    string pwd = sha256(textBox_Password.ToString());
                    if (user.Password==sha256(textBox_Password.ToString()))
                    {
                        if (!String.IsNullOrWhiteSpace(textBox_Nume.Text))
                        {
                            Context.Utilizatoris.Where(x => x.Employee_ID == user.Employee_ID).FirstOrDefault().Nume = textBox_Nume.Text;
                            Context.SaveChanges();
                        }
                        if (!String.IsNullOrWhiteSpace(textBox_Prenume.Text))
                        {
                            Context.Utilizatoris.Where(x => x.Employee_ID == user.Employee_ID).FirstOrDefault().Prenume = textBox_Prenume.Text;
                            Context.SaveChanges();
                        }
                        if (!String.IsNullOrWhiteSpace(textBox_Telefon.Text))
                        {
                            Context.Utilizatoris.Where(x => x.Employee_ID == user.Employee_ID).FirstOrDefault().Telefon = textBox_Telefon.Text;
                            Context.SaveChanges();
                        }
                        if(!String.IsNullOrWhiteSpace(textBox_NewPwd.Text) && !String.IsNullOrWhiteSpace(textBox_ConfPwd.Text))
                        {
                            if ((textBox_NewPwd == textBox_ConfPwd))
                            {
                                Context.Utilizatoris.Where(x => x.Employee_ID == user.Employee_ID).FirstOrDefault().Password = sha256(textBox_NewPwd.ToString());
                                Context.SaveChanges();
                            }
                            else
                            {
                                throw new Exception("The password doesn't match!");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Password is wrong!");
                    }
                }          
                
            }
            catch(Exception ex)
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
    }
}
