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
    public partial class SubjectDeatil : Form
    {
        public SubjectDeatil()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        int SubjectId;
        string userId; // User login
        int amend;
        string strSubjectId;
        string strSubjectName;
        private void Subject_Load(object sender, EventArgs e)
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
            Max_Subject_ID();
            cmb_status();
            DataHead_Subject();
            Create_Subject.Enabled = true;
            Edit_Subject.Enabled = false;
            cmb_TrainingPart();
            
        }
        private void Max_Subject_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(SubjectId,5,5)) AS SubjectId FROM Subject");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                SubjectId = 1;
            }
            else
            {
                SubjectId = Convert.ToInt32(id.ToString());
                SubjectId++;
            }
            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt16(SubjectId.ToString()));
            lblSubjectId.Text = "SUBJ" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();

        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code,Para_Desc FROM Parameter WHERE Para_BPC = 'Subject' AND Para_Type = 'status' ORDER BY Para_Sort");

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

                comb_status.BeginUpdate();
                comb_status.DisplayMember = "Para_Desc";
                comb_status.ValueMember = "Para_Code";
                comb_status.DataSource = dtUser;
                comb_status.EndUpdate();
                comb_status.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void cmb_TrainingPart()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT TrainingPart_Id,TrainingPart_Name FROM TrainingPart");

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

                cboTrainingPart.BeginUpdate();
                cboTrainingPart.DisplayMember = "TrainingPart_Name";
                cboTrainingPart.ValueMember = "TrainingPart_Id";
                cboTrainingPart.DataSource = dtUser;
                cboTrainingPart.EndUpdate();
                cboTrainingPart.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void Create_Subject_Click(object sender, EventArgs e)
        {

            if (txt_Subject_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Subject_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new Subject " + txt_Subject_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Subject ");
                    Sbd.Append("(SubjectId,SubjectName,SubjectStatus,SubjectCreateBy,SubjectCreateDatetime,SubjectModifiedBy,SubjectModifiedDatetime,Amend,TrainingPart_Id ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@SubjectId,@SubjectName,@SubjectStatus,@SubjectCreateBy,@SubjectCreateDatetime,@SubjectModifiedBy,@SubjectModifiedDatetime,@Amend,@TrainingPart_Id )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@SubjectId", SqlDbType.NChar).Value = lblSubjectId.Text.Trim();

                    Cmd.Parameters.Add("@SubjectName", SqlDbType.NVarChar).Value = txt_Subject_Name.Text.Trim();
                    Cmd.Parameters.Add("@SubjectStatus", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@SubjectCreateBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubjectCreateDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@SubjectModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubjectModifiedDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@TrainingPart_Id", SqlDbType.NChar).Value = cboTrainingPart.SelectedValue.ToString().Trim();
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();


                    // show all data on gridview
                    txt_Subject_Name.Text = "";
                    Max_Subject_ID();
                    DataHead_Subject();
                    Edit_Subject.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new Subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void DataHead_Subject()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubjectId,");
            Sbd.Append("S.SubjectName,");
            Sbd.Append("T.TrainingPart_Name,");
            Sbd.Append("P.Para_Desc AS SubjectStatus,");
            Sbd.Append("(U.Employee_SureName+'  '+U.Employee_LastName) AS SubjectCreateBy,");
            Sbd.Append("S.SubjectCreateDatetime,");
            Sbd.Append("(U2.Employee_SureName+'  '+U2.Employee_LastName)  AS SubjectModifiedBy,");
            Sbd.Append("S.SubjectModifiedDatetime,");
            Sbd.Append("S.Amend ");
            Sbd.Append("FROM Subject S ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON U.Employee_ID = S.SubjectCreateBy ");
            Sbd.Append("INNER JOIN User_Login U2 ");
            Sbd.Append("ON U2.Employee_ID = S.SubjectModifiedBy ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC	= 'Subject' ");
            Sbd.Append("AND P.Para_Type	= 'status' ");
            Sbd.Append("AND P.Para_Code	= S.SubjectStatus ");
            Sbd.Append("INNER JOIN TrainingPart T ON T.TrainingPart_Id = S.TrainingPart_Id ");


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
                dgv_ViewSubject.DataSource = dt;
                dgv_View_Format();
            }
            else
            {
                dgv_ViewSubject.DataSource = null;

            }
            Sdr.Close();
        }

        private void dgv_View_Format()
        {
            if (dgv_ViewSubject.RowCount > 0)
            {

                dgv_ViewSubject.Columns[0].HeaderText = "Subject Id";
                dgv_ViewSubject.Columns[1].HeaderText = "Subject Name";
                dgv_ViewSubject.Columns[2].HeaderText = "Training Part";
                dgv_ViewSubject.Columns[3].HeaderText = "Status";
                dgv_ViewSubject.Columns[4].HeaderText = "Create By";
                dgv_ViewSubject.Columns[5].HeaderText = "Create Date";
                dgv_ViewSubject.Columns[6].HeaderText = "Modified By";
                dgv_ViewSubject.Columns[7].HeaderText = "Modified Date";
                dgv_ViewSubject.Columns[8].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewFormat();

                dgv_ViewSubject.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewSubject.Columns[6].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

            }
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ViewSubject.Width;
            dgv_ViewSubject.Columns[0].Width = 100;
            dgv_ViewSubject.Columns[1].Width = w - 700;
            dgv_ViewSubject.Columns[2].Width = 100;
            dgv_ViewSubject.Columns[3].Width = 100;
            dgv_ViewSubject.Columns[4].Width = 100;
            dgv_ViewSubject.Columns[5].Width = 100;
            dgv_ViewSubject.Columns[6].Width = 100;
            dgv_ViewSubject.Columns[7].Width = 100;
            dgv_ViewSubject.Columns[8].Width = 100;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_Subject();
            Edit_Subject.Enabled = false;
            Create_Subject.Enabled = true;
        }

        private void dgv_ViewSubject_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Create_Subject.Enabled = false;
            Edit_Subject.Enabled = true;
            if (e.RowIndex == -1)
            {
                return;
            }
            lblSubjectId.Text = dgv_ViewSubject.Rows[e.RowIndex].Cells[0].Value.ToString();
            strSubjectId = dgv_ViewSubject.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Subject_Name.Text = dgv_ViewSubject.Rows[e.RowIndex].Cells[1].Value.ToString();
            strSubjectName = dgv_ViewSubject.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_status.Text = dgv_ViewSubject.Rows[e.RowIndex].Cells[3].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewSubject.Rows[e.RowIndex].Cells[8].Value.ToString());
            

        }

        private void Edit_Subject_Click(object sender, EventArgs e)
        {


            if (txt_Subject_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Subject_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update Subject  " + txt_Subject_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Subject ");
                    Sbd.Append("SET SubjectName = @SubjectName,");
                    Sbd.Append("SubjectStatus = @SubjectStatus,");                
                    Sbd.Append("SubjectModifiedBy = @SubjectModifiedBy,");
                    Sbd.Append("SubjectModifiedDatetime = @SubjectModifiedDatetime,");
                    Sbd.Append("Amend = @Amend, ");
                    Sbd.Append("TrainingPart_Id = @TrainingPart_Id ");
                    Sbd.Append("WHERE SubjectId = @SubjectId");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@SubjectId", SqlDbType.NVarChar).Value = lblSubjectId.Text.Trim();
                    Cmd.Parameters.Add("@SubjectName", SqlDbType.NVarChar).Value = txt_Subject_Name.Text.Trim();
                    Cmd.Parameters.Add("@SubjectStatus", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@TrainingPart_Id", SqlDbType.NChar).Value = cboTrainingPart.SelectedValue.ToString();
                    Cmd.Parameters.Add("@SubjectModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubjectModifiedDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Subject_ID();
                    DataHead_Subject();
                    txt_Subject_Name.Text = "";
                    Create_Subject.Enabled = true;
                    Edit_Subject.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Subject_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }

        private void SubSubjectMappingbtn_Click(object sender, EventArgs e)
        {
            if (strSubjectId == null)
            {
                MessageBox.Show("Please choose the item");
            }
            else
            {
                Fundamental.MappingSubject frm = new MappingSubject();
                Close();
                frm.subjectId = strSubjectId.ToString();
                frm.subjectname = strSubjectName.ToString();
                frm.ShowDialog();

            }

        }
        

        
        }
    }

