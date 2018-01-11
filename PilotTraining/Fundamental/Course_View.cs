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
    public partial class Course_View : Form
    {
        public Course_View()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId;
        int CheckResult;
        string ViewCourseID;
        int amend;

        private void Course_View_Load(object sender, EventArgs e)
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
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            userId = DBConnString.sUserIdLogin;
            DataHead_Course();
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
            Sbd.Append("C.Course_Head_ID ");
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
            lblCheckResult.Text = "Total Courses : " + CheckResult.ToString();
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
            dgv_Course_View.Columns[0].Width = w - 300 - 100 - 100 - 100 - 100 - 100;
            dgv_Course_View.Columns[1].Width = 300;
            dgv_Course_View.Columns[2].Width = 100;
            dgv_Course_View.Columns[3].Width = 100;
            dgv_Course_View.Columns[4].Width = 100;
            dgv_Course_View.Columns[5].Width = 100;
            dgv_Course_View.Columns[6].Width = 100;

        }

        private void Course_View_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewCourse_Format();
        }

        private void dgv_Course_View_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            ViewCourseID = dgv_Course_View.Rows[e.RowIndex].Cells[7].Value.ToString();
            amend = Convert.ToInt32(dgv_Course_View.Rows[e.RowIndex].Cells[6].Value.ToString());

            ModulesDetail();
        }
        private void ModulesDetail()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT S.SubjectId,");
            Sbd.Append("S.SubjectName,");
            Sbd.Append("P.TrainingPart_Name ");
            Sbd.Append("FROM Course_Details D ");
            Sbd.Append("INNER JOIN Course_Head H  ");
            Sbd.Append("ON H.Course_Head_ID = D.Course_Head_ID ");
            Sbd.Append("INNER JOIN Subject S ");
            Sbd.Append("ON S.SubjectId = D.SubjectId ");
            Sbd.Append("INNER JOIN TrainingPart P ");
            Sbd.Append("ON P.TrainingPart_Id = S.TrainingPart_Id ");
            Sbd.Append("WHERE H.Course_Head_ID = @Course_Head_ID");
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
                dgv_ViewCourseDetail_Format();


            }
            else
            {
                CheckResult = 0;
                dgv_Course_Modules_View.DataSource = null;

            }
            //lbl_Course_Modules.Text = "Modules :" + CheckResult.ToString();
            Sdr.Close();
        }
        private void dgv_ViewCourseDetail_Format()
        {
            if (dgv_Course_Modules_View.RowCount > 0)
            {

                dgv_Course_Modules_View.Columns[0].HeaderText = "Subject";
                dgv_Course_Modules_View.Columns[1].HeaderText = "Description";
                dgv_Course_Modules_View.Columns[2].HeaderText = "Part";
                dgv_Course_Modules_View.Columns[0].Visible = false;

                FixColumnWidth_dgv_ViewCourseDetail_Format();

            }
        }
        private void FixColumnWidth_dgv_ViewCourseDetail_Format()
        {
            int w = dgv_Course_Modules_View.Width;
            //dgv_Course_Modules_View.Columns[0].Width = w - 300 - 300;
            dgv_Course_Modules_View.Columns[1].Width = w-400;
            dgv_Course_Modules_View.Columns[2].Width = 400;

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_Course();
        }

        private void dgv_Course_View_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewCourse_Format();
        }

        private void Edit_Course_Btn_Click(object sender, EventArgs e)
        {
            if (ViewCourseID == null)
            {
                MessageBox.Show("Please choose the item");
            }
            else
            {
                Fundamental.Course_Edit frm = new Course_Edit();
                //Close();

                frm.strCourseId = ViewCourseID;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Show();
                //frm.ShowDialog();

            }

         }
        

    }
}
