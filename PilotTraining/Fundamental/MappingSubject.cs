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
    public partial class MappingSubject : Form
    {
        public MappingSubject()
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
        int MaxMapping;
        string strMaxMapping;

        private void MappingSubject_Load(object sender, EventArgs e)
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
            pn_SubSubject.Visible = false;
            Max_Mapping_ID();
        }
        internal string subjectname // this value for edit
        {
            set { txtSubject.Text = value; }
        }
        internal string subjectId // this value for edit
        {
            set { txtSubjectId.Text = value; }
        }
        private void Max_Mapping_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(SubjectMappingId,3,5)) AS SubjectMappingId FROM SubjectMapping");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                MaxMapping = 1;
            }
            else
            {
                MaxMapping = Convert.ToInt32(id.ToString());
                MaxMapping++;
            }
            //txtHandId.Text = HeadId.ToString();

            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt32(MaxMapping.ToString()));
            txtMappingId.Text = "SM" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();
        }

        private void btn_SelectSubject_Click(object sender, EventArgs e)
        {
            dgv_SelectSubSubject.Columns.Clear();
            pn_SubSubject.Visible = true;
            subjectDetails();
            dgv_SubSubject.RowsDefaultCellStyle.BackColor = Color.White;
        }
        private void subjectDetails()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubSubjectName,");
            Sbd.Append("P.Para_Desc AS SubjectStatus,");
            Sbd.Append("S.SubSubjectId ");
            Sbd.Append("FROM SubSubject S ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC = 'SubSubject' AND P.Para_Type = 'status' AND P.Para_Code = S.SubSubjectStatus ");
            Sbd.Append("WHERE S.SubSubjectStatus <> 'I' ");

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
                dgv_SubSubject.Columns.Add(chkColSelect);

                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_SubSubject.DataSource = dt;
                dgv_SubSubject.ClearSelection();
                lbSumList.Text = "Count Sub-Subject :     " + dgv_SubSubject.Rows.Count.ToString();
                dgv_Header();
            }
            else
            {
                dgv_SubSubject.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_Header()
        {
            if (dgv_SubSubject.RowCount >= 0)
            {
                dgv_SubSubject.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_SubSubject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SubSubject.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);


                dgv_SubSubject.Columns[0].HeaderText = "Select";
                dgv_SubSubject.Columns[1].HeaderText = "Name";
                dgv_SubSubject.Columns[2].HeaderText = "Status";
                dgv_SubSubject.Columns[3].Visible = false;
                dgv_SubSubject.Columns[0].Width = 100;
                dgv_SubSubject.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SubSubject.Columns[1].Width = 300;
                dgv_SubSubject.Columns[2].Width = 200;

                dgv_SubSubject.Columns[1].ReadOnly = true;
                dgv_SubSubject.Columns[2].ReadOnly = true;
                dgv_SubSubject.Columns[3].ReadOnly = true;

            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            dgv_SubSubject.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_SubSubject.ClearSelection();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            {
                DialogResult Dlr;
                Dlr = MessageBox.Show("Are you sure to close this window", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dlr == DialogResult.Yes)
                {

                    dgv_SubSubject.Columns.Clear();
                    pn_SubSubject.Visible = false;
                }
            }
        }

        private void btnOKSelect_Click(object sender, EventArgs e)
        {
            {
                int countChk = 0;
                for (int i = 0; i <= dgv_SubSubject.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dgv_SubSubject.Rows[i].Cells["chkSelect"].Value) == true)
                    {
                        countChk++;
                    }
                }
                if (countChk == 0)
                {
                    MessageBox.Show("Please select the Sub-Subject", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt = new DataTable();
                dt.Columns.Add(new DataColumn("Sub-Subject Name"));
                dt.Columns.Add(new DataColumn("Status"));
                dt.Columns.Add(new DataColumn("Sub-Subject Id"));


                for (int i = 0; i <= dgv_SubSubject.Rows.Count - 1; i++)
                {
                    if ((Convert.ToBoolean(dgv_SubSubject.Rows[i].Cells["chkSelect"].Value) == true))
                    {
                        DataRow drDgvSelect = dt.NewRow();
                        drDgvSelect["Sub-Subject Name"] = dgv_SubSubject.Rows[i].Cells[1].Value.ToString();
                        drDgvSelect["Status"] = dgv_SubSubject.Rows[i].Cells[2].Value.ToString();
                        drDgvSelect["Sub-Subject Id"] = dgv_SubSubject.Rows[i].Cells[3].Value.ToString();
                        dt.Rows.Add(drDgvSelect);
                    }
                }
                dgv_SelectSubSubject.DataSource = dt;
                dgv_SelectSubSubject.ClearSelection();
                FormatDgvSelect();


                pn_SubSubject.Visible = false;

            }
        }

        private void FormatDgvSelect()
        {
            if (dgv_SelectSubSubject.RowCount >= 0)
            {
                dgv_SelectSubSubject.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_SelectSubSubject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SelectSubSubject.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);
                dgv_SelectSubSubject.ReadOnly = false;

                dgv_SelectSubSubject.Columns[0].Name = "Subject";
                dgv_SelectSubSubject.Columns[1].Name = "Status";
                dgv_SelectSubSubject.Columns[2].Visible = false;


                FixColumnWidth_dgv_Select_Format();


                dgv_SelectSubSubject.Columns[0].ReadOnly = true;
                dgv_SelectSubSubject.Columns[1].ReadOnly = true;
                dgv_SelectSubSubject.Columns[2].ReadOnly = true;

            }
        }
        private void FixColumnWidth_dgv_Select_Format()
        {
            if (dgv_SelectSubSubject.RowCount > 0)
            {

                int w = dgv_SelectSubSubject.Width;
                dgv_SelectSubSubject.Columns[0].Width = 500;
                dgv_SelectSubSubject.Columns[1].Width = w - 500;
            }
        }

        private void Create_Mapping_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */


            if (MessageBox.Show("Are you sure to map the subject    " + txtSubject.Text.Trim() +   " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sql;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO SubjectMapping ");
                    Sbd.Append("(SubjectMappingId,SubjectId,MappingCreatedBy,MappingCreatedDate,MappingModifiedBy,MappingModifiedDate,Amend) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@SubjectMappingId,@SubjectId,@MappingCreatedBy,@MappingCreatedDate,@MappingModifiedBy,@MappingModifiedDate,@Amend)");
                    sql = Sbd.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sql;
                    Cmd.Parameters.Add("@SubjectMappingId", SqlDbType.NChar).Value = txtMappingId.Text.Trim();
                    Cmd.Parameters.Add("@SubjectId", SqlDbType.NChar).Value = txtSubjectId.Text.Trim();
                    Cmd.Parameters.Add("@MappingCreatedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@MappingCreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@MappingModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@MappingModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();

                    for (int i = 0; i <= dgv_SelectSubSubject.Rows.Count - 1; i++)
                    {
                        Sbd.Remove(0, Sbd.Length);
                        Sbd.Append("INSERT INTO SubjectMappingDetail ");
                        Sbd.Append("(SubjectMappingId, SubSubjectId ) ");
                        Sbd.Append("VALUES ");
                        Sbd.Append("(@SubjectMappingId, @SubSubjectId) ");

                        sql = Sbd.ToString();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = sql;
                        Cmd.Parameters.Add("@SubjectMappingId", SqlDbType.NChar).Value = txtMappingId.Text.Trim();
                        Cmd.Parameters.Add("@SubSubjectId", SqlDbType.NChar).Value = dgv_SelectSubSubject.Rows[i].Cells[2].Value.ToString();

                        Cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("mapping successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Mapping_ID();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to map the subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
    }
}
