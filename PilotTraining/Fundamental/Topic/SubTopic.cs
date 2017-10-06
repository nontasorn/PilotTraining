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
    public partial class SubTopic : Form
    {
        public SubTopic()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        int subtopicId;
        int maxOrder;
        int amend;


        private void SubTopic_Load(object sender, EventArgs e)
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
            Create_Tipic.Enabled = true;
            Edit_Topic.Enabled = false;
            Max_SubTipc_ID();
            cmb_status();
            Max_Order();
            DataHead_Details();
        }

        private void Max_SubTipc_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(SubTopicId,4,6)) AS SubTopicId FROM SubTopic");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                subtopicId = 1;
            }
            else
            {
                subtopicId = Convert.ToInt32(id.ToString());
                subtopicId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(subtopicId.ToString()));
            lblSubTopicId.Text = "S" + strMax;
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

        private void Create_Tipic_Click(object sender, EventArgs e)
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


            if (MessageBox.Show("Are you sure to create sub topic   " + txtDescription.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO SubTopic ");
                    Sbd.Append("(SubTopicId,SubTopicName,SubTopicStatus,SubTopicOrder,SubTopic_CreatedBy,SubTopic_Create_Date,SubTopic_ModifiedBy,SubTopic_ModifiedDate,amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@SubTopicId,@SubTopicName,@SubTopicStatus,@SubTopicOrder,@SubTopic_CreatedBy,@SubTopic_Create_Date,@SubTopic_ModifiedBy,@SubTopic_ModifiedDate,@amend)");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@SubTopicId", SqlDbType.NChar).Value = lblSubTopicId.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicOrder", SqlDbType.NVarChar).Value = txtOrder.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@SubTopic_CreatedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@SubTopic_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@SubTopic_ModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@SubTopic_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Sub topic generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_SubTipc_ID();
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
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SubTopicOrder) AS SubTopicOrder FROM SubTopic");
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
        private void DataHead_Details()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            

            Sbd.Append("SELECT ");
            Sbd.Append("S.SubTopicId,");
            Sbd.Append("S.SubTopicName,");
            Sbd.Append("S.SubTopicOrder,");
            Sbd.Append("(U.Employee_SureName + '  ' +U.Employee_LastName) AS CreateBy,");
            Sbd.Append("S.SubTopic_Create_Date,");
            Sbd.Append("(U2.Employee_SureName+' '+ U2.Employee_LastName) AS ModifiedBy,");
            Sbd.Append("S.SubTopic_ModifiedDate,");
            Sbd.Append("S.amend ");
            Sbd.Append("FROM SubTopic S ");

            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON ");
            Sbd.Append("U.Employee_ID = S.SubTopic_CreatedBy ");
            Sbd.Append("INNER JOIN User_Login U2 ");
            Sbd.Append("ON ");
            Sbd.Append("U2.Employee_ID = S.SubTopic_ModifiedBy ");
            Sbd.Append("ORDER BY SubTopicOrder ");



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
        private void dgv_ViewDetails_Format()
        {
            if (dgv_ViewTrainingDetails.RowCount > 0)
            {

                dgv_ViewTrainingDetails.Columns[0].HeaderText = "#";
                dgv_ViewTrainingDetails.Columns[1].HeaderText = "Main topic";
                dgv_ViewTrainingDetails.Columns[2].HeaderText = "Order";
                dgv_ViewTrainingDetails.Columns[3].HeaderText = "Create By";
                dgv_ViewTrainingDetails.Columns[4].HeaderText = "Create Date";
                dgv_ViewTrainingDetails.Columns[5].HeaderText = "Modified By";
                dgv_ViewTrainingDetails.Columns[6].HeaderText = "Modified Date";
                dgv_ViewTrainingDetails.Columns[7].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewTrainingDetail_Format();

                dgv_ViewTrainingDetails.Columns[4].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingDetails.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewTrainingDetails.Columns[0].Visible = false;
            }
        }
        private void FixColumnWidth_dgv_ViewTrainingDetail_Format()
        {
            int w = dgv_ViewTrainingDetails.Width;
            dgv_ViewTrainingDetails.Columns[0].Width = 100;
            dgv_ViewTrainingDetails.Columns[1].Width = w - 600;
            dgv_ViewTrainingDetails.Columns[2].Width = 100;
            dgv_ViewTrainingDetails.Columns[3].Width = 100;
            dgv_ViewTrainingDetails.Columns[4].Width = 100;
            dgv_ViewTrainingDetails.Columns[5].Width = 100;
            dgv_ViewTrainingDetails.Columns[6].Width = 100;
            dgv_ViewTrainingDetails.Columns[7].Width = 100;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_Details();
            Edit_Topic.Enabled = false;
            Create_Tipic.Enabled = true;
        }

        private void SubTopic_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
        }

        private void dgv_ViewTrainingDetails_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSubTopicId.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[7].Value.ToString());
            txtOrder.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgv_ViewTrainingDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            Create_Tipic.Enabled = false;
            Edit_Topic.Enabled = true;
        }

        private void Edit_Topic_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter description ", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    Sbd.Append("UPDATE SubTopic ");
                    Sbd.Append("SET SubTopicName = @SubTopicName,");
                    Sbd.Append("SubTopicStatus = @SubTopicStatus,");
                    Sbd.Append("SubTopic_ModifiedBy = @SubTopic_ModifiedBy,");
                    Sbd.Append("SubTopic_ModifiedDate = @SubTopic_ModifiedDate, ");
                    Sbd.Append("amend = @amend ");
                    Sbd.Append("WHERE SubTopicId = @SubTopicId");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@SubTopicId", SqlDbType.NVarChar).Value = lblSubTopicId.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@SubTopic_ModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@SubTopic_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully ", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_SubTipc_ID();
                    DataHead_Details();
                    Max_Order(); // Max order details

                    txtDescription.Text = "";
                    Create_Tipic.Enabled = true;
                    Edit_Topic.Enabled = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update main tipic successfull" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

    }
}
