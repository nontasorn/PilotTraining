using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PilotTraining.Class;
using System.Data.SqlClient;

namespace PilotTraining.Fundamental
{
    public partial class Course_Management : Form
    {
        public Course_Management()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId;

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            DialogResult Dlr;
            Dlr = MessageBox.Show("Are you sure to close this window", "ยกเลิกการทำงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dlr == DialogResult.Yes)
            {
                
                dgv_Modules.Columns.Clear();
                pn_Modules.Visible = false;
            }
        }

        private void Course_Management_Load(object sender, EventArgs e)
        {
            string strConn;
            strConn = DBConnString.strConn;
            Conn = new SqlConnection();
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();
            userId = DBConnString.sUserIdLogin;
            pn_Modules.Visible = false;
        }

        private void btn_SelectModules_Click(object sender, EventArgs e)
        {
            pn_Modules.Visible = true;
            ModulesDetails();
        }
        private void ModulesDetails()
        {
            /*dgv_Modules.Columns.Clear();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("STATEMENT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;



            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ds");


            DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();
            chkColSelect.Name = "chkSelect";
            chkColSelect.TrueValue = true;
            chkColSelect.Width = 130;
            chkColSelect.DisplayIndex = 18;
            chkColSelect.FlatStyle = FlatStyle.Popup;
            dgv_Modules.Columns.Add(chkColSelect);

            dgv_Modules.DataSource = ds.Tables["ds"];
            //SetDgvStatement();
            dgv_Modules.ClearSelection();
            lbSumList.Text = "Count Modules :    " + dgv_Modules.Rows.Count.ToString();
             * 
             * */

            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT * FROM Training_Type");       

            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_Modules.DataSource = dt;
                //dgv_ViewGrade_Format();
            }
            else
            {
                dgv_Modules.DataSource = null;

            }
            Sdr.Close();
        }
    }
}
