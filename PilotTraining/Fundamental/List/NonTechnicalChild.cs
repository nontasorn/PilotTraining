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
    public partial class NonTechnicalChild : Form
    {
        public NonTechnicalChild()
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

        private void NonTechnicalChild_Load(object sender, EventArgs e)
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
            Create_Btn.Enabled = true;
            Edit_Btn.Enabled = false;

            strloginId = DBConnString.sUserIdLogin;
            Max_NonTechChild();
            cmb_SubCateTopic();
            Max_Order();
            cmb_status();
            ShowNonTechChild();
        }
        private void Max_NonTechChild()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(NonTechSecChild_Id,4,6)) AS NonTechSecChild_Id FROM NonTech_Child");
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
            lblId.Text = "NC" + strMax;
            Cmd.Parameters.Clear();

        }
        private void cmb_SubCateTopic()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechSecSubList_Id, (NonTechSecSubList_Name+' | '+NonTechCateList_Name) AS NonTechSecSubList_Name  FROM NonTech_SubCategory_List S ");
            Sbd.Append("INNER JOIN NonTech_Category_List C ON C.NonTechCateList_Id = S.NonTechCateList_Id ");
            Sbd.Append("ORDER BY NonTechSecSubList_Id ");

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
                cboSubtopic.DisplayMember = "NonTechSecSubList_Name";
                cboSubtopic.ValueMember = "NonTechSecSubList_Id";
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
            //Sbd.Append("SELECT MAX(NonTechSecSubList_Order) AS NonTechSecSubList_Order FROM NonTech_SubCategory_List");
            Sbd.Append("SELECT MAX(NonTechSecChild_Order) AS MaxOrder FROM NonTech_Child WHERE (NonTechSecSubList_Id IN (SELECT NonTechSecSubList_Id FROM NonTech_SubCategory_List WHERE  NonTechSecSubList_Id = ");
            Sbd.Append("'" + cboSubtopic.SelectedValue.ToString() + "'))");
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
        private void ShowNonTechChild()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.NonTechSecChild_Id,");
            Sbd.Append("M.NonTechSecChild_Name,");
            Sbd.Append("M.NonTechSecChild_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.NonTechSecChild_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy,");
            Sbd.Append("M.NonTechSecChild_ModifiedDate,");
            Sbd.Append("M.NonTechSecChild_Amend,");
            Sbd.Append("H.NonTechSecSubList_Name ");
            Sbd.Append("FROM NonTech_Child M ");
            Sbd.Append("INNER JOIN User_Login U ON  ");
            Sbd.Append("M.NonTechSecChild_CreateBy = U.Employee_ID  ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.NonTechSecChild_ModifiedBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P  ");
            Sbd.Append("ON P.Para_BPC		= 'NonTechnicalSkill' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.NonTechSecChild_Status ");
            Sbd.Append("INNER JOIN NonTech_SubCategory_List H ");
            Sbd.Append("ON H.NonTechSecSubList_Id = M.NonTechSecSubList_Id ");
            Sbd.Append("ORDER BY M.NonTechSecChild_Id");

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

        private void NonTechnicalChild_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
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
                    Sbd.Append("INSERT INTO NonTech_Child ");
                    Sbd.Append("(NonTechSecChild_Id,NonTechSecChild_Name,NonTechSecChild_Order,NonTechSecChild_CreateBy,NonTechSecChild_CreateDate,NonTechSecChild_Amend,NonTechSecChild_Status,NonTechSecSubList_Id) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@NonTechSecChild_Id,@NonTechSecChild_Name,@NonTechSecChild_Order,@NonTechSecChild_CreateBy,@NonTechSecChild_CreateDate,@NonTechSecChild_Amend,@NonTechSecChild_Status,@NonTechSecSubList_Id )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechSecChild_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecChild_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechSecChild_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@NonTechSecChild_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@NonTechSecChild_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechSecChild_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@NonTechSecChild_Amend", SqlDbType.Int).Value = 0;
                    Cmd.Parameters.Add("@NonTechSecSubList_Id", SqlDbType.NChar).Value = cboSubtopic.SelectedValue.ToString().Trim();

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_NonTechChild();
                    Max_Order();
                    ShowNonTechChild();
                    txtDescription.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create  " + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void cboSubtopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Max_Order();
        }

    }
}
