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


namespace PilotTraining.Fundamental.Topic
{
    public partial class Child_Topic : Form
    {
        public Child_Topic()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string userId; // User login
        int ChildsubtopicId;
        int maxOrder;
        int amend;
        private void ChildSub_Subject_Load(object sender, EventArgs e)
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
            Max_ChildSubTopic_ID();
            cmb_status();
            Max_Order();
            DataHead_Details();

        }
        private void Max_ChildSubTopic_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(ChildTopicId,4,6)) AS ChildTopicId FROM ChildTopic");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                ChildsubtopicId = 1;
            }
            else
            {
                ChildsubtopicId = Convert.ToInt32(id.ToString());
                ChildsubtopicId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(ChildsubtopicId.ToString()));
            lblSubTopicId.Text = "C" + strMax;
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
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(ChildTopicOrder) AS ChildTopicOrder FROM ChildTopic");
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
            Sbd.Append("S.ChildTopicId,");
            Sbd.Append("S.ChildTopicName,");
            Sbd.Append("S.ChildTopicOrder,");
            Sbd.Append("(U.Employee_SureName + '  ' +U.Employee_LastName) AS CreateBy,");
            Sbd.Append("S.ChildTopic_Create_Date,");
            Sbd.Append("(U2.Employee_SureName+' '+ U2.Employee_LastName) AS ModifiedBy,");
            Sbd.Append("S.ChildTopic_ModifiedDate,");
            Sbd.Append("S.ChildAmend ");
            Sbd.Append("FROM ChildTopic S ");

            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON ");
            Sbd.Append("U.Employee_ID = S.ChildTopic_CreatedBy ");
            Sbd.Append("INNER JOIN User_Login U2 ");
            Sbd.Append("ON ");
            Sbd.Append("U2.Employee_ID = S.ChildTopic_ModifiedBy ");
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
                    Sbd.Append("INSERT INTO ChildTopic ");
                    Sbd.Append("(ChildTopicId,ChildTopicName,ChildTopicStatus,ChildTopicOrder,ChildTopic_CreatedBy,ChildTopic_Create_Date,ChildTopic_ModifiedBy,ChildTopic_ModifiedDate,ChildAmend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@ChildTopicId,@ChildTopicName,@ChildTopicStatus,@ChildTopicOrder,@ChildTopic_CreatedBy,@ChildTopic_Create_Date,@ChildTopic_ModifiedBy,@ChildTopic_ModifiedDate,@ChildAmend)");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@ChildTopicId", SqlDbType.NChar).Value = lblSubTopicId.Text.Trim();
                    Cmd.Parameters.Add("@ChildTopicName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@ChildTopicOrder", SqlDbType.NVarChar).Value = txtOrder.Text.Trim();
                    Cmd.Parameters.Add("@ChildTopicStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@ChildTopic_CreatedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ChildTopic_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@ChildTopic_ModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ChildTopic_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@ChildAmend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Sub topic generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_ChildSubTopic_ID();
                    DataHead_Details();
                    Max_Order(); // Max order details
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new child topic" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
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
                    Sbd.Append("UPDATE ChildTopic ");
                    Sbd.Append("SET SubTopicName = @SubTopicName,");
                    Sbd.Append("ChildTopicStatus = @ChildTopicStatus,");
                    Sbd.Append("ChildTopic_ModifiedBy = @ChildTopic_ModifiedBy,");
                    Sbd.Append("ChildTopic_ModifiedDate = @ChildTopic_ModifiedDate, ");
                    Sbd.Append("ChildAmend = @ChildAmend ");
                    Sbd.Append("WHERE ChildTopicId = @ChildTopicId");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@ChildTopicId", SqlDbType.NVarChar).Value = lblSubTopicId.Text.Trim();
                    Cmd.Parameters.Add("@SubTopicName", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@ChildTopicStatus", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@ChildTopic_ModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ChildTopic_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@ChildAmend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully ", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_ChildSubTopic_ID();
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
