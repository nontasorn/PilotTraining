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
    public partial class NonTechnicalSubList : Form
    {
        public NonTechnicalSubList()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        int NonTechSubId;
        int MaxOrder;
        int amend;

        private void NonTechnicalSubList_Load(object sender, EventArgs e)
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

            Max_NonTechSubCate_ID();
            cmb_CateTopic();
            Max_Order();
            ShowNonTechSubList();
            cmb_status();
        }
        private void Max_NonTechSubCate_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(NonTechSecSubList_Id,4,6)) AS NonTechSecSubList_Id FROM NonTech_SubCategory_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                NonTechSubId = 1;
            }
            else
            {
                NonTechSubId = Convert.ToInt32(id.ToString());
                NonTechSubId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(NonTechSubId.ToString()));
            lblId.Text = "NS" + strMax;
            Cmd.Parameters.Clear();

        }
        private void cmb_CateTopic()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechCateList_Id, NonTechCateList_Name FROM NonTech_Category_List ORDER BY NonTechCateList_Order");

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

                cboSubtopic.BeginUpdate();
                cboSubtopic.DisplayMember = "NonTechCateList_Name";
                cboSubtopic.ValueMember = "NonTechCateList_Id";
                cboSubtopic.DataSource = dtUser;
                cboSubtopic.EndUpdate();
                cboSubtopic.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(NonTechSecSubList_Order) AS NonTechSecSubList_Order FROM NonTech_SubCategory_List");
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
        private void ShowNonTechSubList()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.NonTechSecSubList_Id, ");
            Sbd.Append("M.NonTechSecSubList_Name,");
            Sbd.Append("M.NonTechSecSubList_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.NonTechSecSubList_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy, ");
            Sbd.Append("M.NonTechSecSubList_ModifiedDate,");
            Sbd.Append("M.NonTechSecSubList_Amend, ");
            Sbd.Append("H.NonTechCateList_Name ");
            Sbd.Append("FROM NonTech_SubCategory_List M ");
            Sbd.Append("INNER JOIN User_Login U ON ");
            Sbd.Append("M.NonTechSecSubList_CreateBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.NonTechSecSubList_ModifiedBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC		= 'NonTechnicalSkill' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.NonTechSecSubList_Status ");
            Sbd.Append("INNER JOIN NonTech_Category_List H ");
            Sbd.Append("ON H.NonTechCateList_Id = M.NonTechCateList_Id ");


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
                    Sbd.Append("INSERT INTO NonTech_SubCategory_List ");
                    Sbd.Append("(NonTechSecSubList_Id,NonTechSecSubList_Name,NonTechSecSubList_Order,NonTechSecSubList_CreateBy,NonTechSecSubList_CreateDate,NonTechSecSubList_Amend,NonTechSecSubList_Status,NonTechCateList_Id) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@NonTechSecSubList_Id,@NonTechSecSubList_Name,@NonTechSecSubList_Order,@NonTechSecSubList_CreateBy,@NonTechSecSubList_CreateDate,@NonTechSecSubList_Amend,@NonTechSecSubList_Status,@NonTechCateList_Id )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechSecSubList_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecSubList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecSubList_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@NonTechSecSubList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@NonTechSecSubList_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechSecSubList_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@NonTechSecSubList_Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@NonTechCateList_Id", SqlDbType.NChar).Value = cboSubtopic.SelectedValue.ToString().Trim();

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_NonTechSubCate_ID();
                    
                    ShowNonTechSubList();
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create  " + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowNonTechSubList();
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
                    Sbd.Append("UPDATE NonTech_SubCategory_List ");
                    Sbd.Append("SET NonTechSecSubList_Name = @NonTechSecSubList_Name,");
                    Sbd.Append("NonTechSecSubList_Order = @NonTechSecSubList_Order,");
                    Sbd.Append("NonTechSecSubList_Status = @NonTechSecSubList_Status,");
                    Sbd.Append("NonTechSecSubList_ModifiedBy = @NonTechSecSubList_ModifiedBy,");
                    Sbd.Append("NonTechSecSubList_ModifiedDate = @NonTechSecSubList_ModifiedDate, ");
                    Sbd.Append("NonTechSecSubList_Amend = @NonTechSecSubList_Amend, ");
                    Sbd.Append("NonTechCateList_Id = @NonTechCateList_Id ");
                    Sbd.Append("WHERE NonTechSecSubList_Id = @NonTechSecSubList_Id");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechSecSubList_Id", SqlDbType.NVarChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecSubList_Order", SqlDbType.Int).Value = txtOrder.Text.Trim();

                    Cmd.Parameters.Add("@NonTechSecSubList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecSubList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@NonTechSecSubList_ModifiedBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechSecSubList_ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@NonTechSecSubList_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.Parameters.Add("@NonTechCateList_Id", SqlDbType.NChar).Value = cboSubtopic.SelectedValue.ToString();
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    ShowNonTechSubList();
                    Max_NonTechSubCate_ID();
                   
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
            cboSubtopic.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblId.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[0].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewNonTechList.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtOrder.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Status.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[3].Value.ToString();
            Create_Btn.Enabled = false;
            Edit_Btn.Enabled = true;
        }
    }
}
