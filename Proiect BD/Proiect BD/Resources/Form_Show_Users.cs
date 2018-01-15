using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Proiect_BD.Resources
{
    public partial class Form_Show_Users : Form
    {
        public Form_Show_Users()
        {
            InitializeComponent();
        }

        private void Form_Show_Users_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
               
                    string cs = ConfigurationManager.ConnectionStrings["cRMDataSet"].ConnectionString;
                    con.ConnectionString = cs;
                    string query = "select * from Utilizatori";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
               
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
