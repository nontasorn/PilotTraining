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
    public partial class Form_Details_Management : Form
    {
        public Form_Details_Management()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;

        string userId;
        int MElement_Id_Sys;
        string MElement_Id;

        private void Form_Details_Management_Load(object sender, EventArgs e)
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
            Max_MainElement_ID();
            InitializeDataGridView_MainElement();

        }
        private void Max_MainElement_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(MElement_Id,4,6)) AS MElement_Id FROM Main_Element");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                MElement_Id_Sys = 1;
            }
            else
            {
                MElement_Id_Sys = Convert.ToInt32(id.ToString());
                MElement_Id_Sys++;
            }

            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(MElement_Id_Sys.ToString()));
            MElement_Id = "EM" + strMax + '-' + DateTime.Now.ToString("yyyy");

           // MessageBox.Show(MElement_Id);
            Cmd.Parameters.Clear();
        }

        private void InitializeDataGridView_MainElement()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgv_MainElement.ColumnCount = 2;
            dgv_MainElement.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            //columnHeaderStyle.BackColor = Color.Beige;
            //columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv_MainElement.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgv_MainElement.Columns[0].Name = "Element Name";
            dgv_MainElement.Columns[1].Name = "Order";
            //dgv_MainElement.Columns[2].Name = "Type";
            
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Type";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 2;
            cmb.Items.Add("Active");
            cmb.Items.Add("Inactive");
            
            dgv_MainElement.Columns.Add(cmb);
            


            FixColumnWidth_dgv_MainElement_Format();



            
        }
        private void FixColumnWidth_dgv_MainElement_Format()
        {
            int w = dgv_MainElement.Width;
            dgv_MainElement.Columns[0].Width = 500;
            dgv_MainElement.Columns[1].Width = w - 600;
            dgv_MainElement.Columns[2].Width = 100;
            

        }

        private void dgv_MainElement_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_MainElement_Format();
        }

        private void Create_Element_Buton_Click(object sender, EventArgs e)
        {

        }
        
    }
}

