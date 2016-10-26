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
    public partial class Training_Type : Form
    {
        public Training_Type()
        {
            InitializeComponent();
        }


        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId; // User login


        private void Training_Type_Load(object sender, EventArgs e)
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
            cmb_Training_Type(); //  Training Type
            DataHead_TrainingType();

            //  Btn management
            Create_TrainingType_Btn.Enabled = true;
            
            
        }
        private void cmb_Training_Type()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Location_ID,Location_Name FROM Location");

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

                comb_Location.BeginUpdate();
                comb_Location.DisplayMember = "Location_Name";
                comb_Location.ValueMember = "Location_ID";
                comb_Location.DataSource = dtUser;
                comb_Location.EndUpdate();
                comb_Location.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void DataHead_TrainingType()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("T.Training_Type_ID,");
            Sbd.Append("T.Training_Type_Name,");
            Sbd.Append("L.Location_Name,");
            Sbd.Append("(U.Employee_SureName+'   '+U.Employee_LastName) AS Create_By,");
            Sbd.Append("T.Create_Date,");
            Sbd.Append("(U.Employee_SureName+'   '+U.Employee_LastName) AS Modified_By,");
            Sbd.Append("T.Modified_Date, ");
            Sbd.Append("T.Amend,");
            Sbd.Append("T.Training_Type_ID_RUN ");
            Sbd.Append("FROM Training_Type T ");
            Sbd.Append("LEFT JOIN Location L ");
            Sbd.Append("ON T.Location_ID = L.Location_ID ");
            Sbd.Append("LEFT JOIN User_Login U ");
            Sbd.Append("ON T.Create_By = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON T.Modified_By	= U2.Employee_ID");


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
                dgv_ViewTrainingType.DataSource = dt;
                dgv_ViewTrainingType_Format();
            }
            else
            {
                dgv_ViewTrainingType.DataSource = null;

            }
            Sdr.Close();
        }

        private void dgv_ViewTrainingType_Format()
        {
            if (dgv_ViewTrainingType.RowCount > 0)
            {

                dgv_ViewTrainingType.Columns[0].HeaderText = "Training Type ID";
                dgv_ViewTrainingType.Columns[1].HeaderText = "Training Type Name";
                dgv_ViewTrainingType.Columns[2].HeaderText = "Location";
                dgv_ViewTrainingType.Columns[3].HeaderText = "Create By";
                dgv_ViewTrainingType.Columns[4].HeaderText = "Create Date";
                dgv_ViewTrainingType.Columns[5].HeaderText = "Modified By";
                dgv_ViewTrainingType.Columns[6].HeaderText = "Modified Date";
                dgv_ViewTrainingType.Columns[7].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewTrainingType_Format();

                dgv_ViewTrainingType.Columns[4].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingType.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingType.Columns[8].Visible = false;

            }
        }
        private void FixColumnWidth_dgv_ViewTrainingType_Format()
        {
            int w = dgv_ViewTrainingType.Width;
            dgv_ViewTrainingType.Columns[0].Width = 150;
            dgv_ViewTrainingType.Columns[1].Width = w - 150 - 100 - 100 - 150 - 150 - 150 - 120;
            dgv_ViewTrainingType.Columns[2].Width = 100;
            dgv_ViewTrainingType.Columns[3].Width = 150;
            dgv_ViewTrainingType.Columns[4].Width = 150;
            dgv_ViewTrainingType.Columns[5].Width = 150;
            dgv_ViewTrainingType.Columns[6].Width = 150;
            dgv_ViewTrainingType.Columns[7].Width = 120;

        }

        private void Create_TrainingType_Btn_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txt_Training_Type_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Training Type ID", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Training_Type_ID.Focus();
                return;
            }

            if (txt_Training_Type_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter training Type Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Training_Type_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new Training Type" + txt_Training_Type_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Training_Type ");
                    Sbd.Append("(Training_Type_ID_RUN,Training_Type_ID,Training_Type_Name,Location_ID,Create_By,Create_Date,Modified_By,Modified_Date,Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@Training_Type_ID_RUN,@Training_Type_ID,@Training_Type_Name,@Location_ID,@Create_By,@Create_Date,@Modified_By,@Modified_Date,@Amend)");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    String Training_Loc;
                    Training_Loc = comb_Location.SelectedValue.ToString().Trim()+ '_' + txt_Training_Type_ID.Text.Trim();

                    Cmd.Parameters.Add("@Training_Type_ID_RUN", SqlDbType.NChar).Value = Training_Loc;
                    
                    Cmd.Parameters.Add("@Training_Type_ID", SqlDbType.NChar).Value = txt_Training_Type_ID.Text.Trim();
                    Cmd.Parameters.Add("@Training_Type_Name", SqlDbType.NVarChar).Value = txt_Training_Type_Name.Text.Trim();
                    Cmd.Parameters.Add("@Location_ID", SqlDbType.NChar).Value = comb_Location.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Training Type generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    DataHead_TrainingType();
                    txt_Training_Type_ID.Text = "";
                    txt_Training_Type_Name.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new Training Type" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_TrainingType();
        }

        private void Training_Type_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingType_Format();
        }

        private void Delete_TrainingType_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
