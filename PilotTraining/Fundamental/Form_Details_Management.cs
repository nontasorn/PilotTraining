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

            cmb_Grade_Type();// combo list of grade type
            cmb_Modules(); // como list of Modules
        }

        private void cmb_Grade_Type()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Grade_Type_ID,Grade_Type_Name FROM Grade_Type");

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

                cbo_GradeType.BeginUpdate();
                cbo_GradeType.DisplayMember = "Grade_Type_Name";
                cbo_GradeType.ValueMember = "Grade_Type_ID";
                cbo_GradeType.DataSource = dtUser;
                cbo_GradeType.EndUpdate();
                cbo_GradeType.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_Modules()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Training_Type_ID_RUN,Training_Type_ID FROM Training_Type");

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

                comb_Modules.BeginUpdate();
                comb_Modules.DisplayMember = "Training_Type_ID";
                comb_Modules.ValueMember = "Training_Type_ID_RUN";
                comb_Modules.DataSource = dtUser;
                comb_Modules.EndUpdate();
                comb_Modules.SelectedIndex = 0;

            }
            Sdr.Close();
        }
    }
}
