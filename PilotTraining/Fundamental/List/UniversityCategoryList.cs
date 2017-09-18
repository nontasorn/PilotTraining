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

namespace PilotTraining.Fundamental.List
{
    public partial class UniversityCategoryList : Form
    {
        public UniversityCategoryList()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;

        int UniversityMainId;
        int amend;
        int MaxOrder;
        int UniversityCatId;

        private void UniversityCategoryList_Load(object sender, EventArgs e)
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
            cmb_MainTopic();
            cmb_status();
            Max_UniversityCate_ID();
            Max_Order();
            ShowUniversityCatList();
        }
        private void cmb_MainTopic()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UnivesityMainList_Id, UnivesityMainList_Name FROM Univesity_Main_List WHERE UnivesityMainList_Status = 'A' ORDER BY UnivesityMainList_Status ");

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

                cboMaintopic.BeginUpdate();
                cboMaintopic.DisplayMember = "UnivesityMainList_Name";
                cboMaintopic.ValueMember = "UnivesityMainList_Id";
                cboMaintopic.DataSource = dtUser;
                cboMaintopic.EndUpdate();
                cboMaintopic.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code ,Para_Desc FROM Parameter WHERE Para_BPC = 'UniversityList' AND Para_Type = 'status' ORDER BY Para_Sort");

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
        private void Max_UniversityCate_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(UniversityCateList_Id,4,6)) AS UniversityCateList_Id FROM Univesity_Category_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                UniversityCatId = 1;
            }
            else
            {
                UniversityCatId = Convert.ToInt32(id.ToString());
                UniversityCatId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(UniversityCatId.ToString()));
            lblId.Text = "UC" + strMax;
            Cmd.Parameters.Clear();

        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(UniversityCateList_Order) AS MaxOrder FROM Univesity_Category_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string strMaxOrder = Cmd.ExecuteScalar().ToString();

            if (strMaxOrder == "")
            {
                MaxOrder = 1;
            }
            else
            {
                MaxOrder = Convert.ToInt32(strMaxOrder.ToString());
                MaxOrder++;
            }

            txtOrder.Text = MaxOrder.ToString();
            Cmd.Parameters.Clear();


        }

        private void Create_Btn_Click(object sender, EventArgs e)
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


            if (MessageBox.Show("Are you sure to create    " + txtDescription.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Univesity_Category_List ");
                    Sbd.Append("(UniversityCateList_Id,UniversityCateList_Name,UniversityCateList_Order,UniversityCateList_CreateBy,UniversityCateList_CreateDate,UniversityCateList_Amend,UniversityCateList_Status,UnivesityMainList_Id) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@UniversityCateList_Id,@UniversityCateList_Name,@UniversityCateList_Order,@UniversityCateList_CreateBy,@UniversityCateList_CreateDate,@UniversityCateList_Amend,@UniversityCateList_Status,@UnivesityMainList_Id )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@UniversityCateList_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@UniversityCateList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@UniversityCateList_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@UniversityCateList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@UniversityCateList_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@UniversityCateList_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@UniversityCateList_Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@UnivesityMainList_Id", SqlDbType.NChar).Value = cboMaintopic.SelectedValue.ToString().Trim();

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_UniversityCate_ID();
                    ShowUniversityCatList();
                   
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void ShowUniversityCatList()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.UniversityCateList_Id, ");
            Sbd.Append("M.UniversityCateList_Name,");
            Sbd.Append("M.UniversityCateList_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.UniversityCateList_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy, ");
            Sbd.Append("M.UniversityCateList_ModifiedDate,");
            Sbd.Append("M.UniversityCateList_Amend, ");
            Sbd.Append("H.UnivesityMainList_Name ");
            Sbd.Append("FROM Univesity_Category_List M ");
            Sbd.Append("INNER JOIN User_Login U ON ");
            Sbd.Append("M.UniversityCateList_CreateBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.UniversityCateList_ModifiedBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC		= 'UniversityList' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.UniversityCateList_Status ");
            Sbd.Append("INNER JOIN Univesity_Main_List H ");
            Sbd.Append("ON H.UnivesityMainList_Id = M.UnivesityMainList_Id ");


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
                dgv_ViewUniversityCategoryList.DataSource = dt;
                dgv_ViewDetails_Format();
            }
            else
            {
                dgv_ViewUniversityCategoryList.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_ViewDetails_Format()
        {
            if (dgv_ViewUniversityCategoryList.RowCount > 0)
            {

                dgv_ViewUniversityCategoryList.Columns[0].HeaderText = "#";
                dgv_ViewUniversityCategoryList.Columns[1].HeaderText = "Main topic";
                dgv_ViewUniversityCategoryList.Columns[2].HeaderText = "Order";
                dgv_ViewUniversityCategoryList.Columns[3].HeaderText = "Status";
                dgv_ViewUniversityCategoryList.Columns[4].HeaderText = "Create By";
                dgv_ViewUniversityCategoryList.Columns[5].HeaderText = "Create Date";
                dgv_ViewUniversityCategoryList.Columns[6].HeaderText = "Modified By";
                dgv_ViewUniversityCategoryList.Columns[7].HeaderText = "Modified Date";
                dgv_ViewUniversityCategoryList.Columns[8].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewTrainingDetail_Format();

                dgv_ViewUniversityCategoryList.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewUniversityCategoryList.Columns[7].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

                dgv_ViewUniversityCategoryList.Columns[0].Visible = false;
                dgv_ViewUniversityCategoryList.Columns[9].Visible = false;
            }
        }
        private void FixColumnWidth_dgv_ViewTrainingDetail_Format()
        {
            int w = dgv_ViewUniversityCategoryList.Width;
            dgv_ViewUniversityCategoryList.Columns[0].Width = 100;
            dgv_ViewUniversityCategoryList.Columns[1].Width = w - 780;
            dgv_ViewUniversityCategoryList.Columns[2].Width = 100;
            dgv_ViewUniversityCategoryList.Columns[3].Width = 100;
            dgv_ViewUniversityCategoryList.Columns[4].Width = 120;
            dgv_ViewUniversityCategoryList.Columns[5].Width = 120;
            dgv_ViewUniversityCategoryList.Columns[6].Width = 120;
            dgv_ViewUniversityCategoryList.Columns[7].Width = 120;
            dgv_ViewUniversityCategoryList.Columns[8].Width = 100;
        }

        private void UniversityCategoryList_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
        }

        private void dgv_ViewUniversityCategoryList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            cboMaintopic.Text = dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblId.Text = dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[0].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtOrder.Text = dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Status.Text = dgv_ViewUniversityCategoryList.Rows[e.RowIndex].Cells[3].Value.ToString();
            Create_Btn.Enabled = false;
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please enter description", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update  " + txtDescription.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Univesity_Category_List ");
                    Sbd.Append("SET UniversityCateList_Name = @UniversityCateList_Name,");
                    Sbd.Append("UniversityCateList_Order = @UniversityCateList_Order,");
                    Sbd.Append("UniversityCateList_Status = @UniversityCateList_Status,");
                    Sbd.Append("UniversityCateList_ModifiedBy = @UniversityCateList_ModifiedBy,");
                    Sbd.Append("UniversityCateList_ModifiedDate = @UniversityCateList_ModifiedDate, ");
                    Sbd.Append("UniversityCateList_Amend = @UniversityCateList_Amend, ");
                    Sbd.Append("UnivesityMainList_Id = @UnivesityMainList_Id ");
                    Sbd.Append("WHERE UniversityCateList_Id = @UniversityCateList_Id");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@UniversityCateList_Id", SqlDbType.NVarChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@UniversityCateList_Order", SqlDbType.Int).Value = txtOrder.Text.Trim();

                    Cmd.Parameters.Add("@UniversityCateList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@UniversityCateList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@UniversityCateList_ModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@UniversityCateList_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@UniversityCateList_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.Parameters.Add("@UnivesityMainList_Id", SqlDbType.NChar).Value = cboMaintopic.SelectedValue.ToString();
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    ShowUniversityCatList();
                    Max_UniversityCate_ID();
                    Max_Order();
                    // Max_Order(); // Max order details

                    txtDescription.Text = "";
                    txtOrder.Text = "";
                    Create_Btn.Enabled = true;
                    Edit_Btn.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowUniversityCatList();
        }
    }
}
