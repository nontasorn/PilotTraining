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
    public partial class MainTopic : Form
    {
        public MainTopic()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        int DetailId;
        int maxOrder;
        int amend;
        string strMainTopicId;
        string strMainTopicName;
        string strFormName;

        private void DetailsGroup_Load(object sender, EventArgs e)
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
            strloginId = DBConnString.sUserIdLogin;
            DataHead_Details();
            Max_Details_ID(); // Max Id details
            cmb_status();
            Max_Order(); // Max order details
            cmb_formname();

            Create_Tipic.Enabled = true;
            Edit_Topic.Enabled = false;
            MapingSubtopic.Enabled = false;
            

        }
        private void DataHead_Details()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubSubjectName, ");
            Sbd.Append("D.DetailGroupId,");
            Sbd.Append("D.DetailGroupName,");
            Sbd.Append("D.DetailsGroupOrder,");
            Sbd.Append("U.Employee_SureName+'   '+U.Employee_LastName AS DetailsGroupCreatedBy,");
            Sbd.Append("D.DetailsGroupCreatedDate,");
            Sbd.Append("U2.Employee_SureName+'   '+U2.Employee_LastName AS DetailsGroupModifiedBy,");
            Sbd.Append("D.DetailsGroupModifiedDate, ");
            Sbd.Append("D.amend, ");
            Sbd.Append("P.Para_Desc 'status' ");
            
            Sbd.Append("FROM DetailsGroup D ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON D.DetailsGroupCreatedBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON D.DetailsGroupCreatedBy = U2.Employee_ID ");
            Sbd.Append("INNER JOIN Parameter P ON ");
            Sbd.Append("P.Para_BPC = 'DetailsGroup' AND P.Para_Type = 'status' AND P.Para_Code = D.DetailsGroupStatus ");
            Sbd.Append("INNER JOIN SubSubject S ON D.SubSubjectId = S.SubSubjectId ");

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
                dgv_ViewTrainingDetails.DataSource = dt;
                dgv_ViewDetails_Format();
            }
            else
            {
                dgv_ViewTrainingDetails.DataSource = null;

            }
            Sdr.Close();
        }
        private void Max_Details_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(DetailGroupId,4,6)) AS DetailGroupId FROM DetailsGroup");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                DetailId = 1;
            }
            else
            {
                DetailId = Convert.ToInt32(id.ToString());
                DetailId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(DetailId.ToString()));
            lblDetailId.Text = "M" + strMax;
            Cmd.Parameters.Clear();

        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(DetailsGroupOrder) AS DetailsGroupOrder FROM DetailsGroup");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                maxOrder = 1;
            }
            else
            {
                maxOrder = Convert.ToInt32(id.ToString());
                maxOrder++;
            }
            txtOrder.Text = maxOrder.ToString();
            Cmd.Parameters.Clear();

        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code ,Para_Desc FROM Parameter WHERE Para_BPC = 'DetailsGroup' AND Para_Type = 'status' ORDER BY Para_Sort");

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

                comb_Status.BeginUpdate();
                comb_Status.DisplayMember = "Para_Desc";
                comb_Status.ValueMember = "Para_Code";
                comb_Status.DataSource = dtUser;
                comb_Status.EndUpdate();
                comb_Status.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void Create_Grade_Buton_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter description", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new detail   " + txtDescription.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO DetailsGroup ");
                    Sbd.Append("(DetailGroupId,DetailGroupName,DetailsGroupStatus,DetailsGroupOrder,DetailsGroupCreatedBy,DetailsGroupCreatedDate,DetailsGroupModifiedBy,DetailsGroupModifiedDate,amend,SubSubjectId ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@DetailGroupId,@DetailGroupName,@DetailsGroupStatus,@DetailsGroupOrder,@DetailsGroupCreatedBy,@DetailsGroupCreatedDate,@DetailsGroupModifiedBy,@DetailsGroupModifiedDate,@amend,@SubSubjectId)");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@DetailGroupId", SqlDbType.NChar).Value = lblDetailId.Text.Trim();
                    Cmd.Parameters.Add("@DetailGroupName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@DetailsGroupOrder", SqlDbType.NVarChar).Value = txtOrder.Text.Trim();
                    Cmd.Parameters.Add("@DetailsGroupStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@DetailsGroupCreatedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@DetailsGroupCreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@DetailsGroupModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@DetailsGroupModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@SubSubjectId", SqlDbType.NChar).Value = Comb_FormName.SelectedValue.ToString().Trim();
                    

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Detail generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_Details_ID();
                    DataHead_Details();
                    Max_Order(); // Max order details
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new details" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void dgv_ViewDetails_Format()
        {
            if (dgv_ViewTrainingDetails.RowCount > 0)
            {

                dgv_ViewTrainingDetails.Columns[0].HeaderText = "Form";
                dgv_ViewTrainingDetails.Columns[1].HeaderText = "#";
                dgv_ViewTrainingDetails.Columns[2].HeaderText = "Main topic";
                dgv_ViewTrainingDetails.Columns[3].HeaderText = "Order";
                dgv_ViewTrainingDetails.Columns[4].HeaderText = "Create By";
                dgv_ViewTrainingDetails.Columns[5].HeaderText = "Create Date";
                dgv_ViewTrainingDetails.Columns[6].HeaderText = "Modified By";
                dgv_ViewTrainingDetails.Columns[7].HeaderText = "Modified Date";
                dgv_ViewTrainingDetails.Columns[8].HeaderText = "Amend";
                dgv_ViewTrainingDetails.Columns[9].HeaderText = "Status";

                FixColumnWidth_dgv_ViewTrainingDetail_Format();

                dgv_ViewTrainingDetails.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingDetails.Columns[6].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingDetails.Columns[1].Visible = false;
            }
        }
        private void FixColumnWidth_dgv_ViewTrainingDetail_Format()
        {
            int w = dgv_ViewTrainingDetails.Width;
            dgv_ViewTrainingDetails.Columns[0].Width = 200;
            dgv_ViewTrainingDetails.Columns[1].Width = 50;
            dgv_ViewTrainingDetails.Columns[2].Width = w - 900;
            dgv_ViewTrainingDetails.Columns[3].Width = 100;
            dgv_ViewTrainingDetails.Columns[4].Width = 100;
            dgv_ViewTrainingDetails.Columns[5].Width = 100;
            dgv_ViewTrainingDetails.Columns[6].Width = 100;
            dgv_ViewTrainingDetails.Columns[7].Width = 100;
            dgv_ViewTrainingDetails.Columns[8].Width = 100;
            dgv_ViewTrainingDetails.Columns[9].Width = 100;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_Details();
            Max_Details_ID();
            txtDescription.Clear();
            Max_Order();
            cmb_status();
            cmb_formname();
            Create_Tipic.Enabled = true;
            Edit_Topic.Enabled = false;
            MapingSubtopic.Enabled = false;
        }

        private void dgv_ViewTrainingDetails_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            strFormName = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblDetailId.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            strMainTopicId = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtOrder.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            strMainTopicName = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            comb_Status.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[9].Value.ToString();
            Comb_FormName.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

            Create_Tipic.Enabled = false;
            Edit_Topic.Enabled = true;
            MapingSubtopic.Enabled = true;

        }

        private void Edit_Topic_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter description", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus(); 
                return;
            }


            if (MessageBox.Show("Are you sure to update main topic  " + txtDescription.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE DetailsGroup ");
                    Sbd.Append("SET DetailGroupName = @DetailGroupName,");
                    Sbd.Append("DetailsGroupStatus = @DetailsGroupStatus,");
                    Sbd.Append("DetailsGroupModifiedBy = @DetailsGroupModifiedBy,");
                    Sbd.Append("DetailsGroupModifiedDate = @DetailsGroupModifiedDate, ");
                    Sbd.Append("amend = @amend, ");
                    Sbd.Append("SubSubjectId = @SubSubjectId ");
                    Sbd.Append("WHERE DetailGroupId = @DetailGroupId");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@DetailGroupId", SqlDbType.NVarChar).Value = lblDetailId.Text.Trim();
                    Cmd.Parameters.Add("@DetailGroupName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@DetailsGroupStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@DetailsGroupModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@DetailsGroupModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.Parameters.Add("@SubSubjectId", SqlDbType.NChar).Value = Comb_FormName.SelectedValue.ToString();
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Details_ID();
                    DataHead_Details();
                    Max_Order(); // Max order details
                   
                    txtDescription.Text = "";
                    Create_Tipic.Enabled = true;
                    Edit_Topic.Enabled = false;
                    MapingSubtopic.Enabled = false;
                    cmb_formname();
                    cmb_status();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update main tipic successfull" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void MapingSubtopic_Click(object sender, EventArgs e)
        {
            if (lblDetailId.Text == null)
            {
                MessageBox.Show("Please choose the item");
            }
            else
            {

                Fundamental.Topic.MappingTopic frm = new Topic.MappingTopic();
                Close();

                frm.subjectId = strMainTopicId;
                frm.subjectname = strMainTopicName;
                frm.FormName = strFormName;
                frm.ShowDialog();

            }

        }

        private void MainTopic_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
        }
        private void Combo_Fromname(object sender, EventArgs e)
        { 

        }
        private void cmb_formname()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT SubSubjectId,SubSubjectName FROM SubSubject WHERE SubSubjectStatus = 'A' ");

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

                Comb_FormName.BeginUpdate();
                Comb_FormName.DisplayMember = "SubSubjectName";
                Comb_FormName.ValueMember = "SubSubjectId";
                Comb_FormName.DataSource = dtUser;
                Comb_FormName.EndUpdate();
                Comb_FormName.SelectedIndex = 0;

            }
            Sdr.Close();
        }
    }
}
