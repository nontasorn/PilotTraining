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
    public partial class Sub_Subject : Form
    {
        public Sub_Subject()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId; // User login
        int SubSubjectId;
        int amend;

        private void Sub_Subject_Load(object sender, EventArgs e)
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
            Max_SubSubject_ID();
            cmb_status();
            DataHead_SubSubject();
            cmb_AircraftType();
        }
        private void Max_SubSubject_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(SubSubjectId,5,5)) AS SubSubjectId FROM SubSubject");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                SubSubjectId = 1;
            }
            else
            {
                SubSubjectId = Convert.ToInt32(id.ToString());
                SubSubjectId++;
            }
            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt16(SubSubjectId.ToString()));
            lblSubSubjectId.Text = "SUBS" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();

        }
        private void cmb_AircraftType()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT AircraftType,TypeName FROM AircraftType WHERE Status = 'A'");

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

                comb_AircraftType.BeginUpdate();
                comb_AircraftType.DisplayMember = "TypeName";
                comb_AircraftType.ValueMember = "AircraftType";
                comb_AircraftType.DataSource = dtUser;
                comb_AircraftType.EndUpdate();
                comb_AircraftType.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code,Para_Desc FROM Parameter WHERE Para_BPC = 'SubSubject' AND Para_Type = 'status' ORDER BY Para_Sort");

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

        private void Create_SubSubject_Click(object sender, EventArgs e)
        {

            if (txt_SubSubject_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_SubSubject_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new Subject " + txt_SubSubject_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO SubSubject ");
                    Sbd.Append("(SubSubjectId,SubSubjectName,SubSubjectStatus,SubSubjectCreateBy,SubSubjectCreateDatetime,SubSubjectModifiedBy,SubSubjectModifiedDatetime,Amend,AircraftType ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@SubSubjectId,@SubSubjectName,@SubSubjectStatus,@SubSubjectCreateBy,@SubSubjectCreateDatetime,@SubSubjectModifiedBy,@SubSubjectModifiedDatetime,@Amend,@AircraftType  )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@SubSubjectId", SqlDbType.NChar).Value = lblSubSubjectId.Text.Trim();

                    Cmd.Parameters.Add("@SubSubjectName", SqlDbType.NVarChar).Value = txt_SubSubject_Name.Text.Trim();
                    Cmd.Parameters.Add("@SubSubjectStatus", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@SubSubjectCreateBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubSubjectCreateDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@SubSubjectModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubSubjectModifiedDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@AircraftType", SqlDbType.NChar).Value = comb_AircraftType.SelectedValue.ToString().Trim();
                    
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();


                    // show all data on gridview
                    txt_SubSubject_Name.Text = "";
                    Max_SubSubject_ID();
                    DataHead_SubSubject();
                    Edit_SubSubject.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new Subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void DataHead_SubSubject()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubSubjectId,");
            Sbd.Append("S.SubSubjectName,");
            Sbd.Append("P.Para_Desc AS SubjectStatus,");
            Sbd.Append("A.TypeName,");
            Sbd.Append("(U.Employee_SureName+'  '+U.Employee_LastName) AS SubSubjectCreateBy,");
            Sbd.Append("S.SubSubjectCreateDatetime,");
            Sbd.Append("(U2.Employee_SureName+'  '+U2.Employee_LastName)  AS SubSubjectModifiedBy,");
            Sbd.Append("S.SubSubjectModifiedDatetime,");
            Sbd.Append("S.Amend ");
            Sbd.Append("FROM SubSubject S ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON U.Employee_ID = S.SubSubjectCreateBy ");
            Sbd.Append("INNER JOIN User_Login U2 ");
            Sbd.Append("ON U2.Employee_ID = S.SubSubjectModifiedBy ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC	= 'SubSubject' ");
            Sbd.Append("AND P.Para_Type	= 'status' ");
            Sbd.Append("AND P.Para_Code	= S.SubSubjectStatus ");
            Sbd.Append("LEFT JOIN AircraftType A ON A.AircraftType = S.AircraftType");


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
                dgv_ViewSubSubject.DataSource = dt;
                dgv_View_Format();
            }
            else
            {
                dgv_ViewSubSubject.DataSource = null;

            }
            Sdr.Close();
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ViewSubSubject.Width;
            dgv_ViewSubSubject.Columns[0].Width = 100;
            dgv_ViewSubSubject.Columns[1].Width = w - 800;
            dgv_ViewSubSubject.Columns[2].Width = 100; 
            dgv_ViewSubSubject.Columns[3].Width = 100;
            dgv_ViewSubSubject.Columns[4].Width = 100;
            dgv_ViewSubSubject.Columns[5].Width = 100;
            dgv_ViewSubSubject.Columns[6].Width = 100;
            dgv_ViewSubSubject.Columns[7].Width = 100;
            dgv_ViewSubSubject.Columns[8].Width = 100;
         
        }

        private void dgv_View_Format()
        {
            if (dgv_ViewSubSubject.RowCount > 0)
            {

                dgv_ViewSubSubject.Columns[0].HeaderText = "Subject Id";
                dgv_ViewSubSubject.Columns[1].HeaderText = "Subject Name";
                dgv_ViewSubSubject.Columns[2].HeaderText = "Status";
                dgv_ViewSubSubject.Columns[3].HeaderText = "Aircraft Type";
                dgv_ViewSubSubject.Columns[4].HeaderText = "Create By";
                dgv_ViewSubSubject.Columns[5].HeaderText = "Create Date";
                dgv_ViewSubSubject.Columns[6].HeaderText = "Modified By";
                dgv_ViewSubSubject.Columns[7].HeaderText = "Modified Date";
                dgv_ViewSubSubject.Columns[8].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewFormat();

                dgv_ViewSubSubject.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewSubSubject.Columns[7].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_SubSubject();
            Edit_SubSubject.Enabled = false;
            Create_SubSubject.Enabled = true;
        }

        private void Sub_Subject_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }

        private void dgv_ViewSubSubject_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Create_SubSubject.Enabled = false;
            if (e.RowIndex == -1)
            {
                return;
            }
            lblSubSubjectId.Text = dgv_ViewSubSubject.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_SubSubject_Name.Text = dgv_ViewSubSubject.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_status.Text = dgv_ViewSubSubject.Rows[e.RowIndex].Cells[2].Value.ToString();

            Edit_SubSubject.Enabled = true;
            amend = Convert.ToInt32(dgv_ViewSubSubject.Rows[e.RowIndex].Cells[8].Value.ToString());


        }

        private void Edit_SubSubject_Click(object sender, EventArgs e)
        {


            if (txt_SubSubject_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject Name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_SubSubject_Name.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update Subject  " + txt_SubSubject_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE SubSubject ");
                    Sbd.Append("SET SubSubjectName = @SubSubjectName,");
                    Sbd.Append("SubSubjectStatus = @SubSubjectStatus,");
                    Sbd.Append("SubSubjectModifiedBy = @SubSubjectModifiedBy,");
                    Sbd.Append("SubSubjectModifiedDatetime = @SubSubjectModifiedDatetime,");
                    Sbd.Append("Amend = @Amend ");
                    Sbd.Append("WHERE SubSubjectId = @SubSubjectId");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@SubSubjectId", SqlDbType.NVarChar).Value = lblSubSubjectId.Text.Trim();
                    Cmd.Parameters.Add("@SubSubjectName", SqlDbType.NVarChar).Value = txt_SubSubject_Name.Text.Trim();
                    Cmd.Parameters.Add("@SubSubjectStatus", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString();

                    Cmd.Parameters.Add("@SubSubjectModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@SubSubjectModifiedDatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_SubSubject_ID();
                    DataHead_SubSubject();
                    txt_SubSubject_Name.Text = "";
                    Create_SubSubject.Enabled = true;
                    Edit_SubSubject.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void dgv_ViewSubSubject_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }
    }
}
