
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_BD.Resources;




namespace Proiect_BD
{
  

    public partial class Form1 : Form
    {
        string user,pwd;

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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_login_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox_login_user.Text;
            pwd = sha256(textBox_login_pwd.ToString());
            
            Model_CRM Context = new Model_CRM();
            
            Utilizatori aux = Context.Utilizatoris.Where(x => x.Username == user && x.Password == pwd).FirstOrDefault();
            Context.Dispose();
            if(aux!=null)
            {
                Form f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!","Error",MessageBoxButtons.OK);
            }

            
        }

        private void Login_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox_login_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }

        private void textBox_login_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox_login_pwd_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
