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
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;

 

using PilotTraining.Class;

namespace PilotTraining.TrainingManagement
{
    public partial class ScheduleOfSubject : Form
    {
        DateTimePicker dtp = new DateTimePicker();
         
        Rectangle _Rectangle;
        
      
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
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);


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
            }
        }
        private void dtp_TextChange(object sender, EventArgs e)
        {
            dgv_ShowSubject.CurrentCell.Value = dtp.Text.ToString();

        }

        private void dgv_ShowSubject_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgv_ShowSubject_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
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

                dgv_ShowSubject.Columns[2].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                 
                dgv_ShowSubject.Columns["Time"].DefaultCellStyle.Format = "hh:mm tt";
                dgv_ShowSubject.EditMode = DataGridViewEditMode.EditOnKeystroke;

                dgv_ShowSubject.Columns["Time"].ReadOnly = false;
               
                

            }
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ShowSubject.Width;
            
            dgv_ShowSubject.Columns[1].Width = w - 500;
            dgv_ShowSubject.Columns[2].Width = 400;
            
        }

        private void ScheduleOfSubject_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }

    }
}
