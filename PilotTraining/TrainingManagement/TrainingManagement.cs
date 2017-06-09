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
        SqlTransaction Tr;
        int AssignId;

        AutoCompleteStringCollection AcPilot = new AutoCompleteStringCollection();
        AutoCompleteStringCollection AcTeacher = new AutoCompleteStringCollection();

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
            Max_Assign_ID();
            NameAcPilotName(); // selelct pilot name        
            NameAcTeacherName(); // select teacher name
            Data_Subject();

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
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT DISTINCT Employee_ID, (Employee_SureName+'  '+Employee_LastName) AS PilotName ");
            Sbd.Append("FROM User_Login WHERE Employee_Status = 'N' AND Employee_Rule = 'USER'");
            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            SqlDataReader dr;
            Cmd = new SqlCommand(sql, Conn);
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
       
        private void Assign_Course_btn_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txt_Pilot.Text.Trim() == "")
            {
                MessageBox.Show("Please enter pilot name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pilot.Focus();
                return;
            }

            if (txtRemarks.Text.Trim() == "")
            {
                MessageBox.Show("Please enter remarks", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRemarks.Focus();
                return;
            }

            if (txtTrainingById.Text.Trim() == "")
            {
                MessageBox.Show("Please enter train by", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTrainingBy.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure to assign course" + txt_Pilot.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Assign_Course ");
                    Sbd.Append("(Assign_Course_ID,");
                    Sbd.Append("Assign_Pilot,");
                    Sbd.Append("Assign_Course,");
                    Sbd.Append("Assign_Course_Start_Date,");
                    Sbd.Append("Assign_Course_End_Date,");
                    Sbd.Append("Assign_By,");
                    Sbd.Append("Assign_Date,");
                    Sbd.Append("Assign_Modified_By,");
                    Sbd.Append("Assign_Modified_Date,");
                    Sbd.Append("Assign_Remarks, ");
                    Sbd.Append("Assign_Amend, ");
                    Sbd.Append("Assign_TrainingBy) ");
                    
                    Sbd.Append("VALUES ");

                    Sbd.Append("(@Assign_Course_ID,");
                    Sbd.Append("@Assign_Pilot,");
                    Sbd.Append("@Assign_Course,");
                    Sbd.Append("@Assign_Course_Start_Date,");
                    Sbd.Append("@Assign_Course_End_Date,");
                    Sbd.Append("@Assign_By,");
                    Sbd.Append("@Assign_Date,");
                    Sbd.Append("@Assign_Modified_By,");
                    Sbd.Append("@Assign_Modified_Date,");
                    Sbd.Append("@Assign_Remarks, ");
                    Sbd.Append("@Assign_Amend,");
                    Sbd.Append("@Assign_TrainingBy) ");
                    
                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    
                    Cmd.Parameters.Add("@Assign_Course_ID", SqlDbType.NVarChar).Value = txtAssignID.Text.Trim();
                    
                    Cmd.Parameters.Add("@Assign_Pilot", SqlDbType.NChar).Value = txt_Pilot_Id.Text.Trim();
                    Cmd.Parameters.Add("@Assign_Course", SqlDbType.NChar).Value = comb_Training.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Assign_Course_Start_Date", SqlDbType.DateTime).Value = DT_Start.Value.ToShortDateString();
                    
                    Cmd.Parameters.Add("@Assign_Course_End_Date", SqlDbType.DateTime).Value = DT_End.Value.ToShortDateString();
                    Cmd.Parameters.Add("@Assign_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Assign_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Assign_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Assign_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Assign_Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@Assign_Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text.Trim();
                    Cmd.Parameters.Add("@Assign_TrainingBy", SqlDbType.NChar).Value = txtTrainingById.Text.Trim();
                    
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Assign course successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    ClearDetails();
                    Max_Assign_ID(); // Assign max ID
                    //DataHead_Grade(); // show all grade details

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to assign course" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Max_Assign_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(Assign_Course_ID,4,6)) AS MAX_Course_ID FROM Assign_Course");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                AssignId = 1;
            }
            else
            {
                AssignId = Convert.ToInt32(id.ToString());
                AssignId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(AssignId.ToString()));
            txtAssignID.Text = "ASS" + strMax + '-'+DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();
            
        }
        private void ClearDetails()
        {
            txt_Pilot_Id.Clear();
            txt_Pilot.Clear();
            txtRemarks.Clear();
        }

        private void NameAcTeacherName()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT DISTINCT Employee_ID, (Employee_SureName+'  '+Employee_LastName) AS TeacherName ");
            Sbd.Append("FROM User_Login WHERE Employee_Status = 'N' AND Employee_Rule = 'TEACHER'");
            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            SqlDataReader dr;
            Cmd = new SqlCommand(sql, Conn);
            dr = Cmd.ExecuteReader();

            // ตรวจสอบว่ามีข้อมูล EmployerName ในตารางหรือไม่
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow drw in dt.Rows)
                {
                    AcTeacher.Add(drw["TeacherName"].ToString());
                }
            }
            dr.Close();
            txtTrainingBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTrainingBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTrainingBy.AutoCompleteCustomSource = AcTeacher;
        }
        // txtTrainingBy >> teacher
        private void txtTrainingBy_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in dt.Rows)
                {
                    if (drw["TeacherName"].ToString() != "" && drw["TeacherName"].ToString() == txtTrainingBy.Text.Trim())
                    {
                        txtTrainingById.Text = drw["Employee_ID"].ToString();
                        return;
                    }
                    txtTrainingById.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void Data_Subject()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("A.Assign_Pilot,");
            Sbd.Append("(U.Employee_SureName+'  '+ U.Employee_LastName) AS Pilot,");
            Sbd.Append("C.Course_Name,");
            Sbd.Append("(U1.Employee_SureName+'  '+ U1.Employee_LastName) AS TrainingBy,");
            Sbd.Append("A.Assign_Course_Start_Date,");
            Sbd.Append("A.Assign_Remarks, ");
            Sbd.Append("A.Assign_TrainingBy, ");
            Sbd.Append("A.Assign_Course_ID ");
            Sbd.Append("FROM Assign_Course A ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON A.Assign_Pilot = U.Employee_ID ");
            Sbd.Append("INNER JOIN Course_Head C ");
            Sbd.Append("ON C.Course_Head_ID = A.Assign_Course ");
            Sbd.Append("INNER JOIN User_Login U1 ");
            Sbd.Append("ON U1.Employee_ID = A.Assign_TrainingBy ");

            


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
                dgv_ViewAssignCourse.DataSource = dt;
                dgv_View_Format();
            }
            else
            {
                dgv_ViewAssignCourse.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_View_Format()
        {
            if (dgv_ViewAssignCourse.RowCount > 0)
            {
                dgv_ViewAssignCourse.Columns[0].HeaderText = "Pilot";
                dgv_ViewAssignCourse.Columns[1].HeaderText = "Pilot Name";
                dgv_ViewAssignCourse.Columns[2].HeaderText = "Course";
                dgv_ViewAssignCourse.Columns[3].HeaderText = "Train By";
                dgv_ViewAssignCourse.Columns[4].HeaderText = "Train Date";
                dgv_ViewAssignCourse.Columns[5].HeaderText = "Remarks";
                dgv_ViewAssignCourse.Columns[6].Visible = false;
                dgv_ViewAssignCourse.Columns[7].Visible = false;

                FixColumnWidth_dgv_ViewFormat();

                dgv_ViewAssignCourse.Columns[4].DefaultCellStyle.Format = ("dd/MM/yyyy");
                

            }
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ViewAssignCourse.Width;
            dgv_ViewAssignCourse.Columns[0].Width = 100;
            dgv_ViewAssignCourse.Columns[1].Width = 200;
            dgv_ViewAssignCourse.Columns[2].Width = w - 800;
            dgv_ViewAssignCourse.Columns[3].Width = 200;
            dgv_ViewAssignCourse.Columns[4].Width = 200;
            dgv_ViewAssignCourse.Columns[5].Width = 100;
            
        }

        private void TrainingManagement_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }

        private void Edit_Assign_Course_btn_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ViewAssignCourse_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dgv_ViewAssignCourse_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txt_Pilot_Id.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Pilot.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Training.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            txtTrainingBy.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[3].Value.ToString();
            DT_Start.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRemarks.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAssignID.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAssignID.Text = dgv_ViewAssignCourse.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Data_Subject();
            txt_Pilot_Id.Clear();
            txt_Pilot.Clear();
            txtTrainingById.Clear();
            txtRemarks.Clear();
            
        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            string strAssignID = txtAssignID.Text;
            if (txtAssignID.Text == null)
            {
                MessageBox.Show("Please choose the item");
            }
            else
            {
                PilotTraining.TrainingManagement.ScheduleOfSubject frm = new ScheduleOfSubject();
               // Close();
                frm.AssignCourseId = strAssignID;
                frm.ShowDialog();

            }

        }

        
    }
}
