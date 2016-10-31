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

namespace PilotTraining.TrainingManagement
{
    public partial class TrainingManagement : Form
    {
        public TrainingManagement()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        string userId;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        DataTable dt;

        AutoCompleteStringCollection AcPilot = new AutoCompleteStringCollection();

        private void TrainingManagement_Load(object sender, EventArgs e)
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
            cmb_Course();
            NameAcPilotName(); // selelct pilot name

        }
        private void cmb_Course()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Course_Head_ID,Course_Name FROM Course_Head");

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

                comb_Training.BeginUpdate();
                comb_Training.DisplayMember = "Course_Name";
                comb_Training.ValueMember = "Course_Head_ID";
                comb_Training.DataSource = dtUser;
                comb_Training.EndUpdate();
                comb_Training.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void NameAcPilotName()
        {
            string sqlNameAcCustomer = "SELECT DISTINCT B.Employee_ID, (B.Employee_SureName+'  'B.Employee_LastName) AS PilotName " +
                                       "FROM User_Login B WHERE Employee_Status = 'N' AND B.Employee_Rule = 'ADMINUSER'";

            SqlDataReader dr;
            Cmd = new SqlCommand(sqlNameAcCustomer, Conn);
            dr = Cmd.ExecuteReader();

            // ตรวจสอบว่ามีข้อมูล EmployerName ในตารางหรือไม่
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow drw in dt.Rows)
                {
                    AcPilot.Add(drw["PilotName"].ToString());
                }
            }
            dr.Close();
            txt_Pilot.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Pilot.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Pilot.AutoCompleteCustomSource = AcPilot;
        }

        private void txt_Pilot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in dt.Rows)
                {
                    if (drw["PilotName"].ToString() != "" && drw["PilotName"].ToString() == txt_Pilot.Text.Trim())
                    {
                        txt_Pilot_Id.Text = drw["Employee_ID"].ToString();
                        return;
                    }
                    txt_Pilot_Id.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
