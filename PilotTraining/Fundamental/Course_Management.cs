﻿using System;
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
        int amend;

        internal string strCourseId // this value for edit
        {
            set { txtCourseId.Text = value; }
        }

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

           
            userId = DBConnString.sUserIdLogin;
            pn_Modules.Visible = false;
            Max_Course_ID();
            Create_Course_Btn.Enabled = true;
            Edit_Course_Btn.Enabled = false;
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
            Sbd.Append("S.SubjectName,");
            Sbd.Append("T.TrainingPart_Name, ");
            Sbd.Append("S.SubjectId ");
            Sbd.Append("FROM Subject S ");
            Sbd.Append("INNER JOIN TrainingPart T ");
            Sbd.Append("ON S.TrainingPart_Id = T.TrainingPart_Id ");
            Sbd.Append("WHERE S.SubjectStatus = 'A'");

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
                lbSumList.Text = "Count Subject :    " + dgv_Modules.Rows.Count.ToString();
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
                dgv_Modules.Columns[1].HeaderText = "Subject";
                dgv_Modules.Columns[2].HeaderText = "Part";

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
            dt.Columns.Add(new DataColumn("Subject"));
            dt.Columns.Add(new DataColumn("Part"));
            dt.Columns.Add(new DataColumn("Subject Id"));


            for (int i = 0; i <= dgv_Modules.Rows.Count - 1; i++)
            {
                if ((Convert.ToBoolean(dgv_Modules.Rows[i].Cells["chkSelect"].Value) == true))
                {
                    DataRow drDgvSelect = dt.NewRow();
                    drDgvSelect["Subject"] = dgv_Modules.Rows[i].Cells[1].Value.ToString();
                    drDgvSelect["Part"] = dgv_Modules.Rows[i].Cells[2].Value.ToString();
                    drDgvSelect["Subject Id"] = dgv_Modules.Rows[i].Cells[3].Value.ToString();
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

                dgv_SelectModules.Columns[0].Name = "Subject";
                dgv_SelectModules.Columns[1].Name = "Part";
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
            //FixColumnWidth_dgv_ViewCourseDetail_Format();
            FixColumnWidth_dgv_SelectModules_Format();
            
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
                    Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NChar).Value = txtCourseId.Text.Trim();
                    Cmd.Parameters.Add("@Course_Name", SqlDbType.NChar).Value = txt_CourseName.Text.Trim();
                    Cmd.Parameters.Add("@Course_Description", SqlDbType.NChar).Value = txt_CourseDescription.Text.Trim();
                    Cmd.Parameters.Add("@Course_Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Course_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Course_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Course_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Course_Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Head");

                    for (int i = 0; i <= dgv_SelectModules.Rows.Count - 1; i++)
                    {
                        Sbd.Remove(0, Sbd.Length);
                        Sbd.Append("INSERT INTO Course_Details ");
                        Sbd.Append("(Course_Head_ID, SubjectId ) ");
                        Sbd.Append("VALUES ");
                        Sbd.Append("(@Course_Head_ID, @SubjectId) ");

                        sql = Sbd.ToString();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = sql;
                        Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NVarChar).Value = txtCourseId.Text.Trim();
                        Cmd.Parameters.Add("@SubjectId", SqlDbType.NVarChar).Value = dgv_SelectModules.Rows[i].Cells[2].Value.ToString();

                        Cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Course generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Course_ID();
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
            Sbd.Append("SELECT MAX(SUBSTRING(Course_Head_ID,7,5)) AS MAX_Course_ID FROM Course_Head");
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

            /*txtCourseId.Text = "C" + Max_Course_Head_ID;
            Cmd.Parameters.Clear();
            */
            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt16(Max_Course_Head_ID.ToString()));
            txtCourseId.Text = "COURSE" + strMax + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();
        }
        private void ClearDetails()
        {
            txt_CourseDescription.Clear();
            txt_CourseName.Clear();
            dgv_SelectModules.Columns.Clear();
        }

        

        

        private void dgv_Course_View_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit_Course_Btn.Enabled = true;
            Create_Course_Btn.Enabled = false;
            if (e.RowIndex == -1)
            {
                return;
            }

        }
        

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            
        }
        
        

        private void dgv_SelectModules_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Create_Course_Btn.Enabled = false;
            Edit_Course_Btn.Enabled = true;
        }

        private void Edit_Course_Btn_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Course Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_CourseName.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update course  " + txt_CourseName.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Course_Head ");
                    Sbd.Append("SET Course_Name = @Course_Name,");
                    Sbd.Append("Course_Description = @Course_Description,");
                    Sbd.Append("Course_Modified_By = @Course_Modified_By,");
                    Sbd.Append("Course_Modified_Date = @Course_Modified_Date,");
                    Sbd.Append("Course_Amend = @Course_Amend ");
                    Sbd.Append("WHERE Course_Head_ID = @Course_Head_ID");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Course_Head_ID", SqlDbType.NVarChar).Value = txtCourseId.Text.Trim();
                    Cmd.Parameters.Add("@Course_Name", SqlDbType.NVarChar).Value = txt_CourseName.Text.Trim();
                    Cmd.Parameters.Add("@Course_Description", SqlDbType.NVarChar).Value = txt_CourseDescription.Text.Trim();
                    Cmd.Parameters.Add("@Course_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Course_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Course_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Course updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Course_ID();
                    txt_CourseDescription.Text = "";
                    txt_CourseName.Text = "";
                    Create_Course_Btn.Enabled = true;
                    Edit_Course_Btn.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update course" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
    }
}
