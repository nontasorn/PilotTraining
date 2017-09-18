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
    public partial class NonTechnicalCategoryList : Form
    {
        public NonTechnicalCategoryList()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        
        int NonTechMainId;
        int amend;
        int MaxOrder;
        

        private void NonTechnicalCategoryList_Load(object sender, EventArgs e)
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
            ShowNonTechCatList();
            Max_NonTechCate_ID();
            cmb_MainTopic();
            Max_Order();
            cmb_status();
        }
        private void Max_NonTechCate_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(NonTechCateList_Id,4,6)) AS NonTechCateList_Id FROM NonTech_Category_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                NonTechMainId = 1;
            }
            else
            {
                NonTechMainId = Convert.ToInt32(id.ToString());
                NonTechMainId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(NonTechMainId.ToString()));
            lblId.Text = "NC" + strMax;
            Cmd.Parameters.Clear();

        }
        private void cmb_MainTopic()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechMainList_Id, NonTechMainList_Name FROM NonTech_Main_List WHERE NonTechMainList_Status = 'A' ORDER BY NonTechMainList_Order ");

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
                cboMaintopic.DisplayMember = "NonTechMainList_Name";
                cboMaintopic.ValueMember = "NonTechMainList_Id";
                cboMaintopic.DataSource = dtUser;
                cboMaintopic.EndUpdate();
                cboMaintopic.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(NonTechCateList_Order) AS MaxOrder FROM NonTech_Category_List");
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
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code ,Para_Desc FROM Parameter WHERE Para_BPC = 'NonTechnicalSkill' AND Para_Type = 'status' ORDER BY Para_Sort");

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
                    Sbd.Append("INSERT INTO NonTech_Category_List ");
                    Sbd.Append("(NonTechCateList_Id,NonTechCateList_Name,NonTechCateList_Order,NonTechCateList_Status,NonTechCateList_CreateBy,NonTechCateList_CreateDate,NonTechCateList_Amend,NonTechMainList_Id) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@NonTechCateList_Id,@NonTechCateList_Name,@NonTechCateList_Order,@NonTechCateList_Status,@NonTechCateList_CreateBy,@NonTechCateList_CreateDate,@NonTechCateList_Amend,@NonTechMainList_Id )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechCateList_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechCateList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechCateList_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@NonTechCateList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@NonTechCateList_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechCateList_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@NonTechCateList_Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@NonTechMainList_Id", SqlDbType.NChar).Value = cboMaintopic.SelectedValue.ToString().Trim();
                    
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_NonTechCate_ID();
                    ShowNonTechCatList();
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void ShowNonTechCatList()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.NonTechCateList_Id, ");
            Sbd.Append("M.NonTechCateList_Name,");
            Sbd.Append("M.NonTechCateList_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.NonTechCateList_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy, ");
            Sbd.Append("M.NonTechCateList_ModifiedBy,");
            Sbd.Append("M.NonTechCateList_Amend, ");
            Sbd.Append("H.NonTechMainList_Name ");
            Sbd.Append("FROM NonTech_Category_List M ");
            Sbd.Append("INNER JOIN User_Login U ON ");
            Sbd.Append("M.NonTechCateList_CreateBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.NonTechCateList_ModifiedBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC		= 'NonTechnicalSkill' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.NonTechCateList_Status ");
            Sbd.Append("INNER JOIN NonTech_Main_List H ");
            Sbd.Append("ON H.NonTechMainList_Id = M.NonTechMainList_Id ");


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
                dgv_ViewNonTechList.DataSource = dt;
                dgv_ViewDetails_Format();
            }
            else
            {
                dgv_ViewNonTechList.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_ViewDetails_Format()
        {
            if (dgv_ViewNonTechList.RowCount > 0)
            {

                dgv_ViewNonTechList.Columns[0].HeaderText = "#";
                dgv_ViewNonTechList.Columns[1].HeaderText = "Main topic";
                dgv_ViewNonTechList.Columns[2].HeaderText = "Order";
                dgv_ViewNonTechList.Columns[3].HeaderText = "Status";
                dgv_ViewNonTechList.Columns[4].HeaderText = "Create By";
                dgv_ViewNonTechList.Columns[5].HeaderText = "Create Date";
                dgv_ViewNonTechList.Columns[6].HeaderText = "Modified By";
                dgv_ViewNonTechList.Columns[7].HeaderText = "Modified Date";
                dgv_ViewNonTechList.Columns[8].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewTrainingDetail_Format();

                dgv_ViewNonTechList.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewNonTechList.Columns[7].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

                dgv_ViewNonTechList.Columns[0].Visible = false;
                dgv_ViewNonTechList.Columns[9].Visible = false;
            }
        }
        private void FixColumnWidth_dgv_ViewTrainingDetail_Format()
        {
            int w = dgv_ViewNonTechList.Width;
            dgv_ViewNonTechList.Columns[0].Width = 100;
            dgv_ViewNonTechList.Columns[1].Width = w - 780;
            dgv_ViewNonTechList.Columns[2].Width = 100;
            dgv_ViewNonTechList.Columns[3].Width = 100;
            dgv_ViewNonTechList.Columns[4].Width = 120;
            dgv_ViewNonTechList.Columns[5].Width = 120;
            dgv_ViewNonTechList.Columns[6].Width = 120;
            dgv_ViewNonTechList.Columns[7].Width = 120;
            dgv_ViewNonTechList.Columns[8].Width = 100;
        }

        private void NonTechnicalCategoryList_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
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
                    Sbd.Append("UPDATE NonTech_Category_List ");
                    Sbd.Append("SET NonTechCateList_Name = @NonTechCateList_Name,");
                    Sbd.Append("NonTechCateList_Order = @NonTechCateList_Order,");
                    Sbd.Append("NonTechCateList_Status = @NonTechCateList_Status,");
                    Sbd.Append("NonTechCateList_ModifiedBy = @NonTechCateList_ModifiedBy,");
                    Sbd.Append("NonTechCateList_ModifiedDate = @NonTechCateList_ModifiedDate, ");
                    Sbd.Append("NonTechCateList_Amend = @NonTechCateList_Amend, ");
                    Sbd.Append("NonTechMainList_Id = @NonTechMainList_Id ");
                    Sbd.Append("WHERE NonTechCateList_Id = @NonTechCateList_Id");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechCateList_Id", SqlDbType.NVarChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechCateList_Order", SqlDbType.Int).Value = txtOrder.Text.Trim();

                    Cmd.Parameters.Add("@NonTechCateList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechCateList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@NonTechCateList_ModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechCateList_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@NonTechCateList_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.Parameters.Add("@NonTechMainList_Id", SqlDbType.NChar).Value = cboMaintopic.SelectedValue.ToString();
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    ShowNonTechCatList();
                    Max_NonTechCate_ID();            
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

        private void dgv_ViewNonTechList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            cboMaintopic.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblId.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[0].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewNonTechList.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtOrder.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Status.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[3].Value.ToString();
            Create_Btn.Enabled = false;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowNonTechCatList();
        }
    }
}
