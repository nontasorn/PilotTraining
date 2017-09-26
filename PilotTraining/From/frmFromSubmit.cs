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

namespace PilotTraining.From
{
    public partial class frmFromSubmit : Form
    {
        public frmFromSubmit()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        string strBRF,strPS;

        private void frmFromSubmit_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            string strConn;
            strConn = DBConnString.strConn;
            Conn = new SqlConnection();
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();
            strloginId = DBConnString.sUserIdLogin;
            University();
            //cmb_BRF();
            
        }
        private void cmb_BRF()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strBRF.ToString() + "'");


            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);

                cmbBRF.BeginUpdate();
                cmbBRF.DisplayMember = "UniversityCateList_Name";
                cmbBRF.ValueMember = "UniversityCateList_Id";
                cmbBRF.DataSource = dt;
                cmbBRF.EndUpdate();
                cmbBRF.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void University()
        {
            

            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("SELECT UnivesityMainList_Id,UnivesityMainList_Name,(SELECT count(UnivesityMainList_Id) AS Count FROM Univesity_Main_List)AS Count FROM Univesity_Main_List");
            if (dt.Rows.Count > 0)
            {
                

                int count = Convert.ToInt32(dt.Rows[0]["Count"].ToString());
                for (int i = 0; i < count; ++i)
                {

                    txtBRF.Text = dt.Rows[0]["UnivesityMainList_Name"].ToString();
                    strBRF = dt.Rows[0]["UnivesityMainList_Id"].ToString();
                    cmb_BRF();
                    txtPS.Text = dt.Rows[1]["UnivesityMainList_Name"].ToString();
                    txtMC.Text = dt.Rows[2]["UnivesityMainList_Name"].ToString();
                    txtAM.Text = dt.Rows[3]["UnivesityMainList_Name"].ToString();
                    txtCE.Text = dt.Rows[4]["UnivesityMainList_Name"].ToString();
                       
                }

                
               
            }
            else
            {
                //CheckResult = 0;
                //dgv_Search_Bill_Sale.DataSource = null;


            }
            //lblCheckSale.Text = "พบ : " + CheckResult.ToString() + " รายการ";
            //rdr.Close();
            //CalculatePayMoney();
        }
    }
}
