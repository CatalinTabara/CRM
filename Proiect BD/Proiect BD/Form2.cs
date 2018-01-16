using Proiect_BD.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using System.Data.SqlClient;

namespace Proiect_BD
{
    public partial class Form2 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        private Timer Timer = new Timer();
        Utilizatori user;

        public Form2(Utilizatori u)
        {
            this.user = u;
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;

            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
           
        }

        public void loaddata()
        {
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
     
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }     
            
        private void Box_contacte_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;


        }
            
        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Box_Potential_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_User_Click(object sender, EventArgs e)
        {
            Form f3 = new Form_Add_User();
           
           // this.Hide();
            f3.ShowDialog();
        }

        private void Box_Calendar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Show_Users_Click(object sender, EventArgs e)
        {
            Form f4 = new Form_Show_Users();
            f4.ShowDialog();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet._Leads__Ponturi_' table. You can move, or remove it, as needed.
            this.leads__Ponturi_TableAdapter.Fill(this.cRMDataSet._Leads__Ponturi_);
            // TODO: This line of code loads data into the 'cRMDataSet_Leads._Leads__Ponturi_' table. You can move, or remove it, as needed.
            // this.leads__Ponturi_TableAdapter.Fill(this.cRMDataSet_Leads._Leads__Ponturi_);

        }

        private void button_Delete_User_Click(object sender, EventArgs e)
        {
            Form f5 = new Form_Delete_User();
            f5.ShowDialog();
        }


        private void Box_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            label_Timer.Text = DateTime.Now.ToString("HH:mm:ss");
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.Refresh();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button_Modify_User_Click(object sender, EventArgs e)
        {
            Form f6 = new Form_Modify_User(user);
            f6.ShowDialog();
        }

        private void Export()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string cs = "Server=.;                             Database=CRM;                            Trusted_Connection=true";
                conn.ConnectionString = cs;
               
                string query = "Select * from [Leads (Ponturi)]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
                wbook.Worksheets.Add(dt, "test");

                wbook.SaveAs(user.Username+ ".xlsx");
                wbook.Dispose();
            }


            //    ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
            //wbook.Worksheets.Add(dt, "test");

            //wbook.SaveAs(txt_Username.Text + ".xlsx");
            //wbook.Dispose();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void button_AddLead_Click(object sender, EventArgs e)
        {
            Form f7 = new FormAdd_Lead(user);
            f7.ShowDialog();
        }

        private void button_DeleteLead_Click(object sender, EventArgs e)
        {
            Form f8 = new Form_Delete_Lead();
            f8.ShowDialog();
        }
    }
}
