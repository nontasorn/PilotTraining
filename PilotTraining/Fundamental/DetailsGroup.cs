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
    public partial class DetailsGroup : Form
    {
        public DetailsGroup()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        int DetailId;

        private void DetailsGroup_Load(object sender, EventArgs e)
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
            strloginId = DBConnString.sUserIdLogin;
            DataHead_Details();
            Max_Details_ID();
            cmb_status();
        }
        private void DataHead_Details()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("D.DetailGroupId,");
            Sbd.Append("D.DetailGroupName,");
            Sbd.Append("D.DetailsGroupOrder,");
            Sbd.Append("U.Employee_SureName+'   '+U.Employee_LastName AS DetailsGroupCreatedBy,");
            Sbd.Append("D.DetailsGroupCreatedDate,");
            Sbd.Append("U2.Employee_SureName+'   '+U2.Employee_LastName AS DetailsGroupModifiedBy,");
            Sbd.Append("D.DetailsGroupModifiedDate ");
            Sbd.Append("FROM DetailsGroup D ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON D.DetailsGroupCreatedBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON D.DetailsGroupCreatedBy = U2.Employee_ID");

            string sqlProduct = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sqlProduct;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_ViewTrainingDetails.DataSource = dt;
                //dgv_ViewGrade_Format();
            }
            else
            {
                dgv_ViewTrainingDetails.DataSource = null;

            }
            Sdr.Close();
        }
        private void Max_Details_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(DetailGroupId,4,6)) AS DetailGroupId FROM DetailsGroup");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                DetailId = 1;
            }
            else
            {
                DetailId = Convert.ToInt32(id.ToString());
                DetailId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(DetailId.ToString()));
            lblDetailId.Text = "D" + strMax;
            Cmd.Parameters.Clear();

        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code ,Para_Desc FROM Parameter WHERE Para_BPC = 'DetailsGroup' AND Para_Type = 'status' ORDER BY Para_Sort");

            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dtUser = new DataTable();
                dtUser.Load(Sdr);

                comb_Status.BeginUpdate();
                comb_Status.DisplayMember = "Para_Desc";
                comb_Status.ValueMember = "Para_Code";
                comb_Status.DataSource = dtUser;
                comb_Status.EndUpdate();
                comb_Status.SelectedIndex = 0;

            }
            Sdr.Close();
        }
    }
}
