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
    public partial class TrainingTypeMapping : Form
    {
        public TrainingTypeMapping()
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

        internal string trainingname // this value for edit
        {
            set { txt_TrainingType.Text = value; }
        }
        internal string trainingtypemapping // this value for edit
        {
            set { txtTrainingTypeId.Text = value; }
        }
        
        private void TrainingTypeMapping_Load(object sender, EventArgs e)
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
            pn_Subject.Visible = false;
            Max_Mapping_ID();
        }

        private void btn_SelectSubject_Click(object sender, EventArgs e)
        {
            dgv_SelectSubject.Columns.Clear();
            pn_Subject.Visible = true;
            subjectDetails();
            dgv_Subject.RowsDefaultCellStyle.BackColor = Color.White;
        }
        private void subjectDetails()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubjectName,");
            Sbd.Append("P.Para_Desc AS SubjectStatus,");
            Sbd.Append("S.SubjectId ");
            Sbd.Append("FROM Subject S ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC = 'Subject' AND P.Para_Type = 'status' AND P.Para_Code = S.SubjectStatus ");
            Sbd.Append("WHERE S.SubjectStatus <> 'I' ");

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
                dgv_Subject.Columns.Add(chkColSelect);

                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_Subject.DataSource = dt;
                dgv_Subject.ClearSelection();
                lbSumList.Text = "Count Subject :    " + dgv_Subject.Rows.Count.ToString();
                dgv_Modules_Header();
            }
            else
            {
                dgv_Subject.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_Modules_Header()
        {
            if (dgv_Subject.RowCount >= 0)
            {
                dgv_Subject.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_Subject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Subject.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);


                dgv_Subject.Columns[0].HeaderText = "Select";
                dgv_Subject.Columns[1].HeaderText = "Subject Name";
                dgv_Subject.Columns[2].HeaderText = "Status";
                dgv_Subject.Columns[3].Visible = false;
                dgv_Subject.Columns[0].Width = 100;
                dgv_Subject.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Subject.Columns[1].Width = 300;
                dgv_Subject.Columns[2].Width = 200;
                
                dgv_Subject.Columns[1].ReadOnly = true;
                dgv_Subject.Columns[2].ReadOnly = true;
                dgv_Subject.Columns[3].ReadOnly = true;

            }
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            {
                DialogResult Dlr;
                Dlr = MessageBox.Show("Are you sure to close this window", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dlr == DialogResult.Yes)
                {

                    dgv_Subject.Columns.Clear();
                    pn_Subject.Visible = false;
                }
            }
        }

        private void btnOKSelect_Click(object sender, EventArgs e)
        {
            {
                int countChk = 0;
                for (int i = 0; i <= dgv_Subject.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dgv_Subject.Rows[i].Cells["chkSelect"].Value) == true)
                    {
                        countChk++;
                    }
                }
                if (countChk == 0)
                {
                    MessageBox.Show("Please select the Subject", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt = new DataTable();
                dt.Columns.Add(new DataColumn("Subject Name"));
                dt.Columns.Add(new DataColumn("Status"));
                dt.Columns.Add(new DataColumn("Subject Id"));


                for (int i = 0; i <= dgv_Subject.Rows.Count - 1; i++)
                {
                    if ((Convert.ToBoolean(dgv_Subject.Rows[i].Cells["chkSelect"].Value) == true))
                    {
                        DataRow drDgvSelect = dt.NewRow();
                        drDgvSelect["Subject Name"] = dgv_Subject.Rows[i].Cells[1].Value.ToString();
                        drDgvSelect["Status"] = dgv_Subject.Rows[i].Cells[2].Value.ToString();
                        drDgvSelect["Subject Id"] = dgv_Subject.Rows[i].Cells[3].Value.ToString();
                        dt.Rows.Add(drDgvSelect);
                    }
                }
                dgv_SelectSubject.DataSource = dt;
                dgv_SelectSubject.ClearSelection();
                FormatDgvSelect();


                pn_Subject.Visible = false;

            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            dgv_Subject.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_Subject.ClearSelection();
        }
        private void FormatDgvSelect()
        {
            if (dgv_SelectSubject.RowCount >= 0)
            {
                dgv_SelectSubject.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_SelectSubject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SelectSubject.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);
                dgv_SelectSubject.ReadOnly = false;

                dgv_SelectSubject.Columns[0].Name = "Subject";
                dgv_SelectSubject.Columns[1].Name = "Status";
                dgv_SelectSubject.Columns[2].Visible = false;


                FixColumnWidth_dgv_Select_Format();


                dgv_SelectSubject.Columns[0].ReadOnly = true;
                dgv_SelectSubject.Columns[1].ReadOnly = true;
                dgv_SelectSubject.Columns[2].ReadOnly = true;

            }
        }
        private void FixColumnWidth_dgv_Select_Format()
        {
            if (dgv_SelectSubject.RowCount > 0)
            {

                int w = dgv_SelectSubject.Width;
                dgv_SelectSubject.Columns[0].Width = 500;
                dgv_SelectSubject.Columns[1].Width = w - 500;
            }
        }
        private void Max_Mapping_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(MappingId,4,5)) AS MappingId FROM TrainingMapping");
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
            txtMappingId.Text = "MAP" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();
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


            if (MessageBox.Show("Are you sure to map the subject" + txt_TrainingType.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sql;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO TrainingMapping ");
                    Sbd.Append("(MappingId,Training_Type_ID,Mapping_By,Mapping_Datetime,Mapping_ModifiedBy,Mapping_ModifiedDate,Amend) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@MappingId,@Training_Type_ID,@Mapping_By,@Mapping_Datetime,@Mapping_ModifiedBy,@Mapping_ModifiedDate,@Amend)");
                    sql = Sbd.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sql;
                    Cmd.Parameters.Add("@MappingId", SqlDbType.NChar).Value = txtMappingId.Text.Trim();
                    Cmd.Parameters.Add("@Training_Type_ID", SqlDbType.NChar).Value = txtTrainingTypeId.Text.Trim();
                    Cmd.Parameters.Add("@Mapping_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Mapping_Datetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Mapping_ModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Mapping_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();

                    for (int i = 0; i <= dgv_SelectSubject.Rows.Count - 1; i++)
                    {
                        Sbd.Remove(0, Sbd.Length);
                        Sbd.Append("INSERT INTO TrainingMapping_Detail ");
                        Sbd.Append("(MappingId, SubjectId ) ");
                        Sbd.Append("VALUES ");
                        Sbd.Append("(@MappingId, @SubjectId) ");

                        sql = Sbd.ToString();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = sql;
                        Cmd.Parameters.Add("@MappingId", SqlDbType.NChar).Value = txtMappingId.Text.Trim();
                        Cmd.Parameters.Add("@SubjectId", SqlDbType.NChar).Value = dgv_SelectSubject.Rows[i].Cells[2].Value.ToString();

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
