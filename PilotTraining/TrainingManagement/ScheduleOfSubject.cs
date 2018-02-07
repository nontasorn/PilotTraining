using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PilotTraining.Class;



namespace PilotTraining.TrainingManagement
{
    public partial class ScheduleOfSubject : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        DateTimePicker timepicker = new DateTimePicker();
             
        Rectangle _Rectangle;
        Rectangle _Rec;
        
      
        public ScheduleOfSubject()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        DataTable dt;
        string userId; // User login
        string strAssign;
        string strAssign_CourseId;
        int MaxSchedile;
        string strSchedule;


        internal string AssignCourseId // this value for edit
        {
            set { txtAssignID.Text = value; }
        }

        private void ScheduleOfSubject_Load(object sender, EventArgs e)
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
            showdata();
            ShowSubject();

            dgv_ShowSubject.Controls.Add(dtp);
            dtp.Visible = false;
            //dtp.CustomFormat = "dd/MM/YYYY";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);


            dgv_ShowSubject.Controls.Add(timepicker);
            timepicker.ShowUpDown = true;
            timepicker.CustomFormat = "hh:mm tt";           
           timepicker.Format = DateTimePickerFormat.Custom;
           timepicker.TextChanged += new EventHandler(timepicker_MouseDown);
           Max_Schedule_ID();
           

        }
        private void showdata()
        {
            string sql = "ViewAssignCourse " + "'"+txtAssignID.Text.Trim()+"'";       // store procedure and the parameter
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable(sql);
            txt_Pilot_Id.Text = dt.Rows[0]["Assign_Pilot"].ToString();
            txt_Pilot.Text = dt.Rows[0]["PilotName"].ToString();
            txtCourse.Text = dt.Rows[0]["Course_Name"].ToString();
            DT_Start.Text = dt.Rows[0]["Assign_Course_Start_Date"].ToString();
            DT_End.Text = dt.Rows[0]["Assign_Course_End_Date"].ToString();
            strAssign_CourseId = dt.Rows[0]["Assign_Course"].ToString();
            
        }

        private void ShowSubject()
        {
            dgv_ShowSubject.Columns.Clear();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("ViewSubject", Conn); // Change from STATEMENT_SHOWDEBTOR_FOR_CLEAR to STATEMENT
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CourseId", SqlDbType.NVarChar).Value = strAssign_CourseId;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ds");

            
            /*
            DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();    
            chkColSelect.Name = "chkSelect";
            chkColSelect.TrueValue = true;
            chkColSelect.Width = 130;
            chkColSelect.DisplayIndex = 18;
            chkColSelect.FlatStyle = FlatStyle.Popup;
            dgv_ShowSubject.Columns.Add(chkColSelect);
            */
            /*
            GridDateTimeColumn dateTimeColumn = new GridDateTimeColumn();
            dateTimeColumn.Name = "DateTimeColumn";
            dateTimeColumn.HeaderText = "Set date";
            dateTimeColumn.FieldName = "SetDate";
            dateTimeColumn.FormatString = "{0:D}";
            dateTimeColumn.column.add(dateTimeColumn);
                */

            //var combocolumn = new DataGridViewComboBoxColumn();

            

            dgv_ShowSubject.DataSource = ds.Tables["ds"];
            
            dgv_View_Format();
            dgv_ShowSubject.ClearSelection();
            //lbSumList.Text = "จำนวน " + dgvStatement.Rows.Count.ToString() + " รายการ ";
        }

        private void dgv_ShowSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (dgv_ShowSubject.Columns[e.ColumnIndex].Name)
            {
                case "Schedule":
                    _Rectangle = dgv_ShowSubject.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Rectangle.Width,_Rectangle.Height);
                    dtp.Location = new Point(_Rectangle.X,_Rectangle.Y);
                    dtp.Visible = true;

                    break;

                case "Time" :
                                     
                    _Rec = dgv_ShowSubject.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    timepicker.Size = new Size(_Rec.Width, _Rec.Height);
                    timepicker.Location = new Point(_Rec.X, _Rec.Y);
                    timepicker.Visible = true;
                     

                    break;
               

            }


        }
        private void dtp_TextChange(object sender, EventArgs e)
        {
            dgv_ShowSubject.CurrentCell.Value = dtp.Text.ToString();

        }
        private void timepicker_MouseDown(object sender, EventArgs e)
        {
            dgv_ShowSubject.CurrentCell.Value = timepicker.Text.ToString();
        }
      
        private void timepicker_TextChange(object sender, EventArgs e)
        {
            dgv_ShowSubject.CurrentCell.Value = timepicker.Text.ToString();

        }
   
        private void dgv_ShowSubject_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
            timepicker.Visible = false;
        }

        private void dgv_ShowSubject_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
            timepicker.Visible = false;
        }

        private void dgv_View_Format()
        {
            if (dgv_ShowSubject.RowCount > 0)
            {

                dgv_ShowSubject.Columns[0].HeaderText = "Subject #";
                dgv_ShowSubject.Columns[1].HeaderText = "Subject Name";
                dgv_ShowSubject.Columns[2].HeaderText = "Schedule";
                dgv_ShowSubject.Columns[3].HeaderText = "Time";
                
                dgv_ShowSubject.Columns[0].Visible = false;
                FixColumnWidth_dgv_ViewFormat();

                dgv_ShowSubject.Columns[2].DefaultCellStyle.Format = ("dd/MM/yyyy");
                dgv_ShowSubject.EditMode = DataGridViewEditMode.EditOnKeystroke;

                
               
                

            }
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ShowSubject.Width;
            
            dgv_ShowSubject.Columns[1].Width = w - 490;
            dgv_ShowSubject.Columns[2].Width = 300;
            dgv_ShowSubject.Columns[3].Width = 190;
        }

        private void ScheduleOfSubject_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }
        private void Max_Schedule_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(AssignScheduleHead_Id,3,5)) AS AssignScheduleHead_Id FROM Assign_Schedule");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                MaxSchedile = 1;
            }
            else
            {
                MaxSchedile = Convert.ToInt32(id.ToString());
                MaxSchedile++;
            }
            //txtHandId.Text = HeadId.ToString();

            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt32(MaxSchedile.ToString()));
            strSchedule = "SC" + strMax + '-' + DateTime.Now.ToString("yyyy");
            //MessageBox.Show(strSchedule);
            Cmd.Parameters.Clear();
        }

        private void Create_Schedule_btn_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */


            if (MessageBox.Show("Are you sure to create the schedule    " + txtCourse.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sql;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Assign_Schedule ");
                    Sbd.Append("(AssignScheduleHead_Id,AssignCourseId,ScheduleCreateBy,ScheduleCreateDate,ScheduleModifiedBy,ScheduleModifiedDate,Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@AssignScheduleHead_Id,@AssignCourseId,@ScheduleCreateBy,@ScheduleCreateDate,@ScheduleModifiedBy,@ScheduleModifiedDate,@Amend)");
                    sql = Sbd.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sql;
                    Cmd.Parameters.Add("@AssignScheduleHead_Id", SqlDbType.NVarChar).Value = strSchedule.Trim();
                    Cmd.Parameters.Add("@AssignCourseId", SqlDbType.NVarChar).Value = txtAssignID.Text.Trim();
                    Cmd.Parameters.Add("@ScheduleCreateBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ScheduleCreateDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@ScheduleModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ScheduleModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    
                    for (int i = 0; i <= dgv_ShowSubject.Rows.Count - 1; i++)
                    {
                        Sbd.Remove(0, Sbd.Length);
                        Sbd.Append("INSERT INTO Assign_Schedule_Details ");
                        Sbd.Append("(AssignScheduleHead_Id,SubjectId,ScheduleDate,ScheduleTime,ScheduleMeridiem ) ");
                        Sbd.Append("VALUES ");
                        Sbd.Append("(@AssignScheduleHead_Id,@SubjectId,@ScheduleDate,@ScheduleTime,@ScheduleMeridiem) ");


                        sql = Sbd.ToString();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = sql;
                        Cmd.Parameters.Add("@AssignScheduleHead_Id", SqlDbType.NVarChar).Value = strSchedule.Trim();
                        Cmd.Parameters.Add("@SubjectId", SqlDbType.NVarChar).Value = dgv_ShowSubject.Rows[i].Cells[0].Value.ToString();
                        Cmd.Parameters.Add("@ScheduleDate", SqlDbType.Date).Value = dgv_ShowSubject.Rows[i].Cells[2].Value.ToString();                 
                        Cmd.Parameters.Add("@ScheduleTime", SqlDbType.NVarChar).Value =  dgv_ShowSubject.Rows[i].Cells[3].Value.ToString();
                        string strMeridiem =  dgv_ShowSubject.Rows[i].Cells[3].Value.ToString();
                        string substrMeridiem = strMeridiem.Substring(5,3);
                        Cmd.Parameters.Add("@ScheduleMeridiem", SqlDbType.Char).Value = substrMeridiem.Trim();
                        
                        
                        


                        Cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Create the schedule successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Schedule_ID();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create the schedule  " + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        
    }
}
