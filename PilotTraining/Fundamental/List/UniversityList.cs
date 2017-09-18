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
    public partial class UniversityList : Form
    {
        public UniversityList()
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
        int MaxOrder;
        string strMaxOrder;
        int amend;

        private void UniversityList_Load(object sender, EventArgs e)
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
            Create_Btn.Enabled = true;
            Max_University_Main_ID();
            cmb_status();
            Max_Order();
            ShowUniversityList();
        }

        private void Max_University_Main_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(UnivesityMainList_Id,4,6)) AS UnivesityMainList_Id FROM Univesity_Main_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();
            if (id == "")
            {
                UniversityMainId = 1;
            }
            else
            {
                UniversityMainId = Convert.ToInt32(id.ToString());
                UniversityMainId++;
            }
            string strMax = "";
            strMax = String.Format("{0:000000}", Convert.ToInt16(UniversityMainId.ToString()));
            lblId.Text = "UL" + strMax;
            Cmd.Parameters.Clear();
        }
        private void Max_Order()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(UnivesityMainList_Order) AS MaxOrder FROM Univesity_Main_List");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (strMaxOrder == null)
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
                    Sbd.Append("INSERT INTO Univesity_Main_List ");
                    Sbd.Append("(UnivesityMainList_Id,UnivesityMainList_Name,UnivesityMainList_Order,UnivesityMainList_Status,UnivesityMainList_CreateBy,UnivesityMainList_CreateDate,UnivesityMainList_Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@UnivesityMainList_Id,@UnivesityMainList_Name,@UnivesityMainList_Order,@UnivesityMainList_Status,@UnivesityMainList_CreateBy,@UnivesityMainList_CreateDate,@UnivesityMainList_Amend )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@UnivesityMainList_Id", SqlDbType.NChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@UnivesityMainList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@UnivesityMainList_Order", SqlDbType.Int).Value = Convert.ToInt64(txtOrder.Text.Trim());
                    Cmd.Parameters.Add("@UnivesityMainList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString().Trim();


                    Cmd.Parameters.Add("@UnivesityMainList_CreateBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@UnivesityMainList_CreateDate", SqlDbType.DateTime).Value = DateTime.Now;

                    Cmd.Parameters.Add("@UnivesityMainList_Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    Max_University_Main_ID();
                    //ShowNonTechList();
                    txtDescription.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void ShowUniversityList()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("M.UnivesityMainList_Id, ");
            Sbd.Append("M.UnivesityMainList_Name,");
            Sbd.Append("M.UnivesityMainList_Order,");
            Sbd.Append("P.Para_Desc AS Status,");
            Sbd.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS CreateBy,");
            Sbd.Append("M.UnivesityMainList_CreateDate,");
            Sbd.Append("(U2.Employee_SureName+' '+U2.Employee_LastName) AS ModifyBy, ");
            Sbd.Append("M.UnivesityMainList_ModifyDate,");
            Sbd.Append("M.UnivesityMainList_Amend ");
            Sbd.Append("FROM Univesity_Main_List M ");
            Sbd.Append("INNER JOIN User_Login U ON ");
            Sbd.Append("M.UnivesityMainList_CreateBy = U.Employee_ID ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON M.UnivesityMainList_ModifyBy = U2.Employee_ID  ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC			= 'UniversityList' ");
            Sbd.Append("AND P.Para_Type		= 'status' ");
            Sbd.Append("AND P.Para_Code		= M.UnivesityMainList_Status ");


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
                dgv_ViewUniversityList.DataSource = dt;
                dgv_ViewDetails_Format();
            }
            else
            {
                dgv_ViewUniversityList.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_ViewDetails_Format()
        {
            if (dgv_ViewUniversityList.RowCount > 0)
            {

                dgv_ViewUniversityList.Columns[0].HeaderText = "#";
                dgv_ViewUniversityList.Columns[1].HeaderText = "Main topic";
                dgv_ViewUniversityList.Columns[2].HeaderText = "Order";
                dgv_ViewUniversityList.Columns[3].HeaderText = "Status";
                dgv_ViewUniversityList.Columns[4].HeaderText = "Create By";
                dgv_ViewUniversityList.Columns[5].HeaderText = "Create Date";
                dgv_ViewUniversityList.Columns[6].HeaderText = "Modified By";
                dgv_ViewUniversityList.Columns[7].HeaderText = "Modified Date";
                dgv_ViewUniversityList.Columns[8].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewTrainingDetail_Format();

                dgv_ViewUniversityList.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewUniversityList.Columns[7].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");

                dgv_ViewUniversityList.Columns[0].Visible = false;
            }
        }
        private void FixColumnWidth_dgv_ViewTrainingDetail_Format()
        {
            int w = dgv_ViewUniversityList.Width;
            dgv_ViewUniversityList.Columns[0].Width = 100;
            dgv_ViewUniversityList.Columns[1].Width = w - 780;
            dgv_ViewUniversityList.Columns[2].Width = 100;
            dgv_ViewUniversityList.Columns[3].Width = 100;
            dgv_ViewUniversityList.Columns[4].Width = 120;
            dgv_ViewUniversityList.Columns[5].Width = 120;
            dgv_ViewUniversityList.Columns[6].Width = 120;
            dgv_ViewUniversityList.Columns[7].Width = 120;
            dgv_ViewUniversityList.Columns[8].Width = 100;
        }

        private void UniversityList_Resize(object sender, EventArgs e)
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
                    Sbd.Append("UPDATE Univesity_Main_List ");
                    Sbd.Append("SET UnivesityMainList_Name = @UnivesityMainList_Name,");
                    Sbd.Append("UnivesityMainList_Order = @UnivesityMainList_Order,");
                    Sbd.Append("UnivesityMainList_Status = @UnivesityMainList_Status,");
                    Sbd.Append("UnivesityMainList_ModifyBy = @UnivesityMainList_ModifyBy,");
                    Sbd.Append("UnivesityMainList_ModifyDate = @UnivesityMainList_ModifyDate, ");
                    Sbd.Append("UnivesityMainList_Amend = @UnivesityMainList_Amend ");
                    Sbd.Append("WHERE UnivesityMainList_Id = @UnivesityMainList_Id");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;

                    Cmd.Parameters.Add("@UnivesityMainList_Id", SqlDbType.NVarChar).Value = lblId.Text.Trim();
                    Cmd.Parameters.Add("@UnivesityMainList_Order", SqlDbType.Int).Value = txtOrder.Text.Trim();

                    Cmd.Parameters.Add("@UnivesityMainList_Name", SqlDbType.NVarChar).Value = txtDescription.Text.Trim();
                    Cmd.Parameters.Add("@UnivesityMainList_Status", SqlDbType.NChar).Value = comb_Status.SelectedValue.ToString();
                    Cmd.Parameters.Add("@UnivesityMainList_ModifyBy", SqlDbType.NChar).Value = strloginId;
                    Cmd.Parameters.Add("@UnivesityMainList_ModifyDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@UnivesityMainList_Amend", SqlDbType.Int).Value = amend + 1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_University_Main_ID();
                    ShowUniversityList();
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

        private void dgv_ViewUniversityList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
                lblId.Text = dgv_ViewUniversityList.Rows[e.RowIndex].Cells[0].Value.ToString();
                amend = Convert.ToInt32(dgv_ViewUniversityList.Rows[e.RowIndex].Cells[8].Value.ToString());
                txtOrder.Text = dgv_ViewUniversityList.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dgv_ViewUniversityList.Rows[e.RowIndex].Cells[1].Value.ToString();
                Create_Btn.Enabled = false;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowUniversityList();
        }



    }
}
