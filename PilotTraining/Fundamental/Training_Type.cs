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
        int amend;
        int trainingTypeId;
        string strtrainingTypeId;
        string strtrainingName;
        int CheckResult;


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
            Max_TrainingType_ID();
            DataHead_TrainingType();
            

            //  Btn management
            Create_TrainingType_Btn.Enabled = true;
            MappingTheSubject.Enabled = false;
            
            
        }
        private void Max_TrainingType_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(Training_Type_ID,6,5)) AS Training_Type_ID FROM Training_Type");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                trainingTypeId = 1;
            }
            else
            {
                trainingTypeId = Convert.ToInt32(id.ToString());
                trainingTypeId++;
            }
            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt16(trainingTypeId.ToString()));
            txt_Training_Type_ID.Text = "TRAIN" + strMax + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();

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
            Sbd.Append("T.Amend ");    
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
                    Sbd.Append("(Training_Type_ID,Training_Type_Name,Location_ID,Create_By,Create_Date,Modified_By,Modified_Date,Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@Training_Type_ID,@Training_Type_Name,@Location_ID,@Create_By,@Create_Date,@Modified_By,@Modified_Date,@Amend)");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                            
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
                    Max_TrainingType_ID();
                    DataHead_TrainingType();
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
            Create_TrainingType_Btn.Enabled = true;
            EditTrainingTypeBtn.Enabled = false;
        }

        private void Training_Type_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingType_Format();
        }

        private void Delete_TrainingType_Btn_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ViewTrainingType_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            Create_TrainingType_Btn.Enabled = false;
            MappingTheSubject.Enabled = true;

            if (e.RowIndex == -1)
            {
                return;
            }
            txt_Training_Type_ID.Text = dgv_ViewTrainingType.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Training_Type_Name.Text = dgv_ViewTrainingType.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Location.Text = dgv_ViewTrainingType.Rows[e.RowIndex].Cells[2].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewTrainingType.Rows[e.RowIndex].Cells[7].Value.ToString());
            EditTrainingTypeBtn.Enabled = true;
            strtrainingTypeId = dgv_ViewTrainingType.Rows[e.RowIndex].Cells[0].Value.ToString();
            strtrainingName = dgv_ViewTrainingType.Rows[e.RowIndex].Cells[1].Value.ToString();
            ShowTheSubject(); // View subject
        }

        private void EditTrainingTypeBtn_Click(object sender, EventArgs e)
        {
            if (txt_Training_Type_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Training Type Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Training_Type_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update Training Type  " + txt_Training_Type_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Training_Type ");
                    Sbd.Append("SET Training_Type_Name = @Training_Type_Name,");
                    Sbd.Append("Location_ID = @Location_ID,");
                    Sbd.Append("Modified_By = @Modified_By,");
                    Sbd.Append("Modified_Date = @Modified_Date,");
                    Sbd.Append("Amend = @Amend ");
                    Sbd.Append("WHERE Training_Type_ID = @Training_Type_ID");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Training_Type_ID", SqlDbType.NVarChar).Value = txt_Training_Type_ID.Text.Trim();
                    Cmd.Parameters.Add("@Training_Type_Name", SqlDbType.NVarChar).Value = txt_Training_Type_Name.Text.Trim();
                    Cmd.Parameters.Add("@Location_ID", SqlDbType.NChar).Value = comb_Location.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_TrainingType_ID();
                    DataHead_TrainingType();
                    txt_Training_Type_Name.Text = "";
                    Create_TrainingType_Btn.Enabled = true;
                    EditTrainingTypeBtn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Training Type" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void MappingTheSubject_Click(object sender, EventArgs e)
        {
            if (strtrainingTypeId == null)
            {
                MessageBox.Show("Please choose the item");
            }
            else
            {
                Fundamental.TrainingTypeMapping frm = new TrainingTypeMapping();
                Close();
                frm.trainingtypemapping = strtrainingTypeId.ToString();
                frm.trainingname = strtrainingName.ToString();
                frm.ShowDialog();

            }

        }
        private void ShowTheSubject()
        {
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("SubjectView " + strtrainingTypeId);
            if (dt.Rows.Count > 0)
            {
                dgv_ViewSubject.DataSource = dt;
                CheckResult = dt.Rows.Count;
                dgv_ViewSubject_Format();

            }
            else
            {
                CheckResult = 0;
                dgv_ViewSubject.DataSource = null;

            }
            lblCountSubject.Text = "Subject : "+ CheckResult.ToString();
        }

        private void dgv_ViewSubject_Format()
        {
            if (dgv_ViewSubject.RowCount > 0)
            {

                dgv_ViewSubject.Columns[0].HeaderText = "Subject #";
                dgv_ViewSubject.Columns[1].HeaderText = "Subject Name";
                dgv_ViewSubject.Columns[2].HeaderText = "Created By";
                dgv_ViewSubject.Columns[3].HeaderText = "Create Date";

                FixColumnWidth_dgv_ViewSubject_Format();

                dgv_ViewSubject.Columns[3].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

            }
        }
        private void FixColumnWidth_dgv_ViewSubject_Format()
        {
            int w = dgv_ViewSubject.Width;
            dgv_ViewSubject.Columns[0].Width = 200;
            dgv_ViewSubject.Columns[1].Width = w - 600;
            dgv_ViewSubject.Columns[2].Width = 200;
            dgv_ViewSubject.Columns[3].Width = 200;

        }
    }
}
