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
    public partial class ViewSchedule : Form
    {
        public ViewSchedule()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        string userId; // User login
        string Assign_Course_ID;

        private void ViewSchedule_Load(object sender, EventArgs e)
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
            ScheduleHead();

        }
        private void ScheduleHead()
        {
            string strEmployeeCode  = txtSearchEmployeeCode.Text.Trim();
            string strPilotName     = txtSearchPilotName.Text.Trim();
            
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("ViewScheduleHead " + "'" + strEmployeeCode + "'"+",'"+strPilotName+"'");
            if (dt.Rows.Count > 0)
            {
                dgv_ShowScheduleHead.DataSource = dt;
                //CheckResult = dt.Rows.Count;
                dgv_ViewScheduleHead_Format();
            }
            else
            {
                //CheckResult = 0;
                dgv_ShowScheduleHead.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";
        }

        private void dgv_ViewScheduleHead_Format()
        {
            if (dgv_ShowScheduleHead.RowCount > 0)
            {

                dgv_ShowScheduleHead.Columns[0].HeaderText = "Employee Code";
                dgv_ShowScheduleHead.Columns[1].HeaderText = "Employee Id";
                dgv_ShowScheduleHead.Columns[2].HeaderText = "Pilot Name";
                dgv_ShowScheduleHead.Columns[3].HeaderText = "Course";
                dgv_ShowScheduleHead.Columns[4].HeaderText = "Start Date";
                dgv_ShowScheduleHead.Columns[5].HeaderText = "Status";


                FixColumnWidth_dgv_ViewScheduleHead_Format();

                
                dgv_ShowScheduleHead.Columns[3].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ShowScheduleHead.Columns[6].Visible = false;

            }
        }
        private void FixColumnWidth_dgv_ViewScheduleHead_Format()
        {
            int w = dgv_ShowScheduleHead.Width;
            dgv_ShowScheduleHead.Columns[0].Width = 150;
            dgv_ShowScheduleHead.Columns[1].Width = 100;
            dgv_ShowScheduleHead.Columns[2].Width = 200;
            dgv_ShowScheduleHead.Columns[3].Width = w - 688;
            dgv_ShowScheduleHead.Columns[4].Width = 100;
            dgv_ShowScheduleHead.Columns[5].Width = 100;

        }

        private void dgv_ShowSubject_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Assign_Course_ID = dgv_ShowScheduleHead.Rows[e.RowIndex].Cells[6].Value.ToString();
                //DocumentType = dgvHead.Rows[e.RowIndex].Cells[9].Value.ToString();
                DataDetail();
        }
        private void DataDetail()
        {
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("ViewScheduleDetail " + "'"+Assign_Course_ID+"'");
            if (dt.Rows.Count > 0)
            {
                dgv_ShowScheduleDetails.DataSource = dt;
                //CheckResult = dt.Rows.Count;
                dgv_ViewScheduleDetails_Format();
            }
            else
            {
                //CheckResult = 0;
                dgv_ShowScheduleDetails.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";
        }
        private void dgv_ViewScheduleDetails_Format()
        {
            if (dgv_ShowScheduleDetails.RowCount > 0)
            {

                dgv_ShowScheduleDetails.Columns[0].HeaderText = "Subject";
                dgv_ShowScheduleDetails.Columns[1].HeaderText = "Schedule Date";
                dgv_ShowScheduleDetails.Columns[2].HeaderText = "Schedule Time";

                FixColumnWidth_dgv_ViewScheduleDetails_Format();
                
                dgv_ShowScheduleHead.Columns[1].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                

            }
        }
        private void FixColumnWidth_dgv_ViewScheduleDetails_Format()
        {
            int w = dgv_ShowScheduleDetails.Width;
            dgv_ShowScheduleDetails.Columns[0].Width = w - 400;
            dgv_ShowScheduleDetails.Columns[1].Width = 200;
            dgv_ShowScheduleDetails.Columns[2].Width = 200;
            
        }

        private void ViewSchedule_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewScheduleHead_Format();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ScheduleHead(); //  Show the schedule head
        }
        
    }
}
