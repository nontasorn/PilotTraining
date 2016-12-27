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
        DataTable dt;
        string ViewCourseID;

        int Max_Course_Head_ID;
        int CheckResult;

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
            Max_Course_ID();
            DataHead_Course();
        }

        private void btn_SelectModules_Click(object sender, EventArgs e)
        {
            dgv_SelectModules.Columns.Clear();
            pn_Modules.Visible = true;
            ModulesDetails();
            dgv_Modules.RowsDefaultCellStyle.BackColor = Color.White;
        }
        private void ModulesDetails()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("Training_Type_Name,");
            Sbd.Append("Location_Name,");
            Sbd.Append("Training_Type_ID_RUN ");
            Sbd.Append("FROM Training_Type T ");
            Sbd.Append("INNER JOIN Location L ");
            Sbd.Append("ON ");
            Sbd.Append("L.Location_ID = T.Location_ID ");

            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();
                chkColSelect.Name = "chkSelect";
                chkColSelect.TrueValue = true;
                chkColSelect.Width = 130;
                chkColSelect.DisplayIndex = 18;
                chkColSelect.FlatStyle = FlatStyle.Popup;
                dgv_Modules.Columns.Add(chkColSelect);

                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_Modules.DataSource = dt;
                dgv_Modules.ClearSelection();
                lbSumList.Text = "Count Modules :    " + dgv_Modules.Rows.Count.ToString();
                dgv_Modules_Header();
            }
            else
            {
                dgv_Modules.DataSource = null;

            }
            Sdr.Close();
        }

        private void dgv_Modules_Header()
        {
            if (dgv_Modules.RowCount >= 0)
            {
                dgv_Modules.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_Modules.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Modules.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);
                

                dgv_Modules.Columns[0].HeaderText = "Select";
                dgv_Modules.Columns[1].HeaderText = "Modules";
                dgv_Modules.Columns[2].HeaderText = "Location";

                dgv_Modules.Columns[3].Visible = false;
                

                dgv_Modules.Columns[0].Width = 100;
                dgv_Modules.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv_Modules.Columns[1].Width = 200;

                dgv_Modules.Columns[2].Width = 230;
                dgv_Modules.Columns[2].DefaultCellStyle.Format = "d MMMM yyyy";

                


                dgv_Modules.Columns[1].ReadOnly = true;
                dgv_Modules.Columns[2].ReadOnly = true;
                dgv_Modules.Columns[3].ReadOnly = true;
                
            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            dgv_Modules.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_Modules.ClearSelection();
        }

        private void btnOKSelect_Click(object sender, EventArgs e)
        {
            int countChk = 0;
            for (int i = 0; i <= dgv_Modules.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dgv_Modules.Rows[i].Cells["chkSelect"].Value) == true)
                {
                    countChk++;
                }
            }
            if (countChk == 0)
            {
                MessageBox.Show("Please select the modules", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Modules"));
            dt.Columns.Add(new DataColumn("Location"));
            dt.Columns.Add(new DataColumn("Modules ID"));


            for (int i = 0; i <= dgv_Modules.Rows.Count - 1; i++)
            {
                if ((Convert.ToBoolean(dgv_Modules.Rows[i].Cells["chkSelect"].Value) == true))
                {
                    DataRow drDgvSelect = dt.NewRow();
                    drDgvSelect["Modules"] = dgv_Modules.Rows[i].Cells[1].Value.ToString();
                    drDgvSelect["Location"] = dgv_Modules.Rows[i].Cells[2].Value.ToString();
                    drDgvSelect["Modules ID"] = dgv_Modules.Rows[i].Cells[3].Value.ToString();
                    dt.Rows.Add(drDgvSelect);
                }
            }
            dgv_SelectModules.DataSource = dt;
            dgv_SelectModules.ClearSelection();
            FormatDgvDetailStatement();


            pn_Modules.Visible = false;
            
        }

        private void FormatDgvDetailStatement()
        {
            if (dgv_SelectModules.RowCount >= 0)
            {
                dgv_SelectModules.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_SelectModules.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SelectModules.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);
                dgv_SelectModules.ReadOnly = false;

                dgv_SelectModules.Columns[0].Name = "Modules";
                dgv_SelectModules.Columns[1].Name = "Location";
                dgv_SelectModules.Columns[2].Visible = false;


                FixColumnWidth_dgv_SelectModules_Format();


                dgv_SelectModules.Columns[0].ReadOnly = true;
                dgv_SelectModules.Columns[1].ReadOnly = true;
                dgv_SelectModules.Columns[2].ReadOnly = true;

            }
        }

        private void FixColumnWidth_dgv_SelectModules_Format()
        {
            if (dgv_SelectModules.RowCount > 0)
            {

            int w = dgv_SelectModules.Width;
            dgv_SelectModules.Columns[0].Width = 500;
            dgv_SelectModules.Columns[1].Width = w -500;
            }
 


        }

        private void Course_Management_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_SelectModules_Format();
            FixColumnWidth_dgv_ViewCourse_Format();
        }

        private void Create_Course_Btn_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txt_CourseName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Course name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_CourseName.Focus();
                return;
            }

            if (txt_CourseDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Course Description", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_CourseDescription.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new course" + txt_CourseName.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sql;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Course_Head ");
                    Sbd.Append("(Course_Head_ID,Course_Name,Course_Description,Course_Create_By,Course_Create_Date,Course_Modified_By,Course_Modified_Date) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@Course_Head_ID,@Course_Name,@Course_Description,@Course_Create_By,@Course_Create_Date,@Course_Modified_By,@Course_Modified_Date)");                
                    sql = Sbd.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sql;
                    Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NChar).Value = textBox1.Text.Trim();
                    Cmd.Parameters.Add("@Course_Name", SqlDbType.NChar).Value = txt_CourseName.Text.Trim();
                    Cmd.Parameters.Add("@Course_Description", SqlDbType.NChar).Value = txt_CourseDescription.Text.Trim();
                    Cmd.Parameters.Add("@Course_Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Course_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Course_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Course_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Course_Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();

                    for (int i = 0; i <= dgv_SelectModules.Rows.Count - 1; i++)
                    {
                        Sbd.Remove(0, Sbd.Length);
                        Sbd.Append("INSERT INTO Course_Details ");
                        Sbd.Append("(Course_Head_ID, Training_Type_ID_RUN ) ");
                        Sbd.Append("VALUES ");
                        Sbd.Append("(@Course_Head_ID, @Training_Type_ID_RUN) ");

                        sql = Sbd.ToString();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = sql;
                        Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NChar).Value = textBox1.Text.Trim();
                        Cmd.Parameters.Add("@Training_Type_ID_RUN", SqlDbType.NChar).Value = dgv_SelectModules.Rows[i].Cells[0].Value.ToString();

                        Cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Course generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Course_ID();
                    DataHead_Course();
                    ClearDetails();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new course" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void Max_Course_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(Course_Head_ID,2,1)) AS MAX_Course_ID FROM Course_Head");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                Max_Course_Head_ID = 1;
            }
            else
            {
                Max_Course_Head_ID = Convert.ToInt32(id.ToString());
                Max_Course_Head_ID++;
            }
            //txtHandId.Text = HeadId.ToString();

            textBox1.Text = "C" + Max_Course_Head_ID;
            Cmd.Parameters.Clear();
        }
        private void ClearDetails()
        {
            txt_CourseDescription.Clear();
            txt_CourseName.Clear();
            dgv_SelectModules.Columns.Clear();
        }

        private void DataHead_Course()
        {

            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("C.Course_Name,");
            Sbd.Append("C.Course_Description,");
            Sbd.Append("U.Employee_SureName+'   '+U.Employee_LastName,");
            Sbd.Append("C.Course_Create_Date,");
            Sbd.Append("U2.Employee_SureName+'   '+U2.Employee_LastName,");
            Sbd.Append("C.Course_Modified_Date, "); 
            Sbd.Append("C.Course_Amend,");
            Sbd.Append("C.Course_Head_ID, ");
            Sbd.Append("FROM Course_Head C ");
            
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON C.Course_Create_By = U.Employee_ID ");
            Sbd.Append("INNER JOIN User_Login U2 ");
            Sbd.Append("ON C.Course_Create_By = U2.Employee_ID ");

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
                dgv_Course_View.DataSource = dt;
                CheckResult = dt.Rows.Count;
                dgv_ViewCourse_Format();
            }
            else
            {
                CheckResult = 0;
                dgv_Course_View.DataSource = null;

            }
            lbl_Course_Count.Text = "Courses : " + CheckResult.ToString();
            Sdr.Close();
        }

        private void dgv_ViewCourse_Format()
        {
            if (dgv_Course_View.RowCount > 0)
            {

                dgv_Course_View.Columns[0].HeaderText = "Course";
                dgv_Course_View.Columns[1].HeaderText = "Description";
                dgv_Course_View.Columns[2].HeaderText = "Create By";
                dgv_Course_View.Columns[3].HeaderText = "Create Date";
                dgv_Course_View.Columns[4].HeaderText = "Modified By";
                dgv_Course_View.Columns[5].HeaderText = "Modified Date";
                dgv_Course_View.Columns[6].HeaderText = "Amend";
                dgv_Course_View.Columns[7].Visible = false;


                FixColumnWidth_dgv_ViewCourse_Format();

                dgv_Course_View.Columns[3].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_Course_View.Columns[4].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
   

            }
        }

        private void FixColumnWidth_dgv_ViewCourse_Format()
        {
            int w = dgv_Course_View.Width;
            dgv_Course_View.Columns[0].Width = w-200-100-100-100-100-50;
            dgv_Course_View.Columns[1].Width = 200;
            dgv_Course_View.Columns[2].Width = 100;
            dgv_Course_View.Columns[3].Width = 100;
            dgv_Course_View.Columns[4].Width = 100;
            dgv_Course_View.Columns[5].Width = 100;
            dgv_Course_View.Columns[6].Width = 50;

        }

        private void dgv_Course_View_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ViewCourseID = dgv_Course_View.Rows[e.RowIndex].Cells[7].Value.ToString();
            ModulesDetail();
        }
        private void ModulesDetail()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT (T.Training_Type_ID) AS Modules ");
            Sbd.Append("FROM Course_Details D ");
            Sbd.Append("INNER JOIN Course_Head H ");
            Sbd.Append("ON H.Course_Head_ID	=	D.Course_Head_ID ");
            Sbd.Append("INNER JOIN Training_Type T ");
            Sbd.Append("ON D.Training_Type_ID_RUN = T.Training_Type_ID_RUN ");
            Sbd.Append("WHERE D.Course_Head_ID = @Course_Head_ID");
            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NChar).Value = ViewCourseID;
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);
                CheckResult = dt.Rows.Count;
                dgv_Course_Modules_View.DataSource = dt;

            }
            else
            {
                CheckResult = 0;
                dgv_Course_Modules_View.DataSource = null;

            }
            lbl_Course_Modules.Text = "Modules :" + CheckResult.ToString();
            Sdr.Close();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_Course();
        }
    }
}
