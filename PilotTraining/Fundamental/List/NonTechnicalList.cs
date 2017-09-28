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
    public partial class NonTechnicalList : Form
    {
        public NonTechnicalList()
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
        string strMaxOrder;


        private void NonTechnicalList_Load(object sender, EventArgs e)
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
            Max_NonTechMain_ID();
            cmb_status();
            ShowNonTechList();
            
            Max_NonTechMain_ID();
            Max_Order();
        }
        private void Max_NonTechMain_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(NonTechMainList_Id,4,6)) AS NonTechMainList_Id FROM NonTech_Main_List");
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
            lblId.Text = "NT" + strMax;
            Cmd.Parameters.Clear();
           

        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(NonTechMainList_Order) AS MaxOrder FROM NonTech_Main_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (strMaxOrder == "")
            {
                MaxOrder = 1;
            }
            else
            {
                MaxOrder = Convert.ToInt32(id.ToString());
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
                    Sbd.Append("INSERT INTO NonTech_Main_List ");
                    Sbd.Append("(NonTechMainList_Id,NonTechMainList_Name,NonTechMainList_Order,NonTechMainList_Status,NonTechMainList_CreateBy,NonTechMainList_CreateDate,NonTechMainList_Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@NonTechMainList_Id,@NonTechMainList_Name,@NonTechMainList_Order,@NonTechMainList_Status,@NonTechMainList_CreateBy,@NonTechMainList_CreateDate,@NonTechMainList_Amend )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechMainList_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechMainList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechMainList_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@NonTechMainList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@NonTechMainList_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechMainList_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@NonTechMainList_Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_NonTechMain_ID();
                    Max_Order();
                    ShowNonTechList();
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void ShowNonTechList()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.NonTechMainList_Id, ");
            Sbd.Append("M.NonTechMainList_Name,");
            Sbd.Append("M.NonTechMainList_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.NonTechMainList_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy, ");
            Sbd.Append("M.NonTechMainList_ModifyDate,");
            Sbd.Append("M.NonTechMainList_Amend ");
            Sbd.Append("FROM NonTech_Main_List M ");
            Sbd.Append("INNER JOIN User_Login U ON ");
            Sbd.Append("M.NonTechMainList_CreateBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.NonTechMainList_ModifyBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC			= 'NonTechnicalSkill' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.NonTechMainList_Status ");
               

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

        private void dgv_ViewNonTechList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[0].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewNonTechList.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtOrder.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgv_ViewNonTechList.Rows[e.RowIndex].Cells[1].Value.ToString();
            Create_Btn.Enabled = false;
            Edit_Btn.Enabled = true;
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
                    Sbd.Append("UPDATE NonTech_Main_List ");
                    Sbd.Append("SET NonTechMainList_Name = @NonTechMainList_Name,");
                    Sbd.Append("NonTechMainList_Order = @NonTechMainList_Order,");
                    Sbd.Append("NonTechMainList_Status = @NonTechMainList_Status,");
                    Sbd.Append("NonTechMainList_ModifyBy = @NonTechMainList_ModifyBy,");
                    Sbd.Append("NonTechMainList_ModifyDate = @NonTechMainList_ModifyDate, ");
                    Sbd.Append("NonTechMainList_Amend = @NonTechMainList_Amend ");
                    Sbd.Append("WHERE NonTechMainList_Id = @NonTechMainList_Id");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@NonTechMainList_Id", SqlDbType.NVarChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@NonTechMainList_Order", SqlDbType.Int).Value = txtOrder.Text.Trim();
                    
                    Cmd.Parameters.Add("@NonTechMainList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@NonTechMainList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@NonTechMainList_ModifyBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@NonTechMainList_ModifyDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@NonTechMainList_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_NonTechMain_ID();
                    ShowNonTechList();
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

        private void NonTechnicalList_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewTrainingDetail_Format();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowNonTechList();
            Create_Btn.Enabled = true;
            Edit_Btn.Enabled = false;
        }
    }
}
