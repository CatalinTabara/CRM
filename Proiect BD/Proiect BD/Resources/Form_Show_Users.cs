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
            // TODO: This line of code loads data into the 'cRMDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.cRMDataSet.Utilizatori);
            // TODO: This line of code loads data into the 'cRMDataSet1.Utilizatori' table. You can move, or remove it, as needed.
            //this.utilizatoriTableAdapter.Fill(this.cRMDataSet1.Utilizatori);
            //using (SqlConnection con = new SqlConnection())
            //{

            //        string cs = ConfigurationManager.ConnectionStrings["Model_CRM"].ConnectionString;
            //        con.ConnectionString = cs;

            //        string query = "select * from Utilizatori";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        dataGridView1.DataSource = dt;


            //}

            try
            {
                Model_CRM context = new Model_CRM();

                List<Utilizatori> list = context.Utilizatoris.ToList();

                dataGridView1.DataSource = context.Utilizatoris.ToList();

                ////using (var context = new LinkedinEntities5())
                //{
                //    var results = context.Relatie;
                //    foreach (var it in results)
                //    {
                //        if (it.ID_client_receive == id_client_logat && it.ID_status == 1)
                //        {
                //            dataGridView1.DataSource = context.ClientDupaID(it.ID_client_send);
                //            DataGridViewComboBoxColumn choose = new DataGridViewComboBoxColumn();
                //            choose.Name = "Choose";
                //            choose.HeaderText = "Choose";
                //            choose.Items.Add("Accept");
                //            choose.Items.Add("Decline");
                //            dataGridView1.Columns.Insert(2, choose);
                //            DataGridViewButtonColumn Respond = new DataGridViewButtonColumn();
                //            Respond.Name = "Respond";
                //            Respond.Text = "Respond";
                //            dataGridView1.Columns.Insert(3, Respond);
                //        }
                //    }
                //}
                context.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
