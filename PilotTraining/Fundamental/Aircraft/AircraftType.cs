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

namespace PilotTraining.Fundamental.Aircraft
{
    public partial class AircraftType : Form
    {
        public AircraftType()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;

        string userId; // User login
        int AircraftId;
        int Amend;

        private void AircraftType_Load(object sender, EventArgs e)
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
            cmb_status();
            Max_AircraftTypeId();
            DataHead_AircraftType();

        }
        private void cmb_status()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Para_Code,Para_Desc FROM Parameter WHERE Para_BPC = 'AircraftType' AND  Para_Type = 'status' ORDER BY Para_Sort");

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
        private void Max_AircraftTypeId()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(AircraftType,5,3)) AS AircraftType FROM AircraftType");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                AircraftId = 1;
            }
            else
            {
                AircraftId = Convert.ToInt32(id.ToString());
                AircraftId++;
            }
            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt16(AircraftId.ToString()));
            lblAircraftTypeId.Text = "AC" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();

        }

        private void Create_AircraftType_Click(object sender, EventArgs e)
        {

            if (txtAircraftTypeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter type name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAircraftTypeName.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new type name " + txtAircraftTypeName.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO AircraftType ");
                    Sbd.Append("(AircraftType,TypeName,Status,CreateBy,CreateDate,Amend ) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@AircraftType,@TypeName,@Status,@CreateBy,@CreateDate,@Amend )");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@AircraftType", SqlDbType.NVarChar).Value = lblAircraftTypeId.Text.Trim();
                    Cmd.Parameters.Add("@TypeName", SqlDbType.NVarChar).Value = txtAircraftTypeName.Text.Trim();
                    Cmd.Parameters.Add("@Status", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@CreateBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = 0;
                    
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Aircraft type generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();


                    // show all data on gridview
                    txtAircraftTypeName.Text = "";
                    Max_AircraftTypeId();
                    DataHead_AircraftType();
                    Edit_AircraftType.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new Subject" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
        private void DataHead_AircraftType()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT A.TypeName,");
            Sbd.Append("P.Para_Desc Status,");
            Sbd.Append("(U.Employee_SureName +' ' +U.Employee_LastName) AS CreatedBy,");
            Sbd.Append("A.CreateDate, ");
            Sbd.Append("(U2.Employee_SureName +' ' +U2.Employee_LastName) AS ModifiedBy,");
            Sbd.Append("A.ModifiedDate,");
            Sbd.Append("A.Amend,");
            Sbd.Append("A.AircraftType ");
            Sbd.Append("FROM AircraftType A ");
            Sbd.Append("INNER JOIN Parameter P ");
            Sbd.Append("ON P.Para_BPC = 'AircraftType' ");
            Sbd.Append("AND P.Para_Code = A.Status ");
            Sbd.Append("AND P.Para_Type = 'status' ");            
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON U.Employee_ID = A.CreateBy ");
            Sbd.Append("LEFT JOIN User_Login U2 ");
            Sbd.Append("ON U2.Employee_ID = A.ModifiedBy ");
            Sbd.Append("WHERE P.Para_Code = 'A' ");


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
                dgv_ViewAircraftType.DataSource = dt;
                dgv_View_Format();
            }
            else
            {
                dgv_ViewAircraftType.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_View_Format()
        {
            if (dgv_ViewAircraftType.RowCount > 0)
            {

                dgv_ViewAircraftType.Columns[0].HeaderText = "Aircraft Tye";
                dgv_ViewAircraftType.Columns[1].HeaderText = "Status";
                dgv_ViewAircraftType.Columns[2].HeaderText = "Created By";
                dgv_ViewAircraftType.Columns[3].HeaderText = "Created Date";
                dgv_ViewAircraftType.Columns[4].HeaderText = "Modified By";
                dgv_ViewAircraftType.Columns[5].HeaderText = "Modified Date";
                dgv_ViewAircraftType.Columns[6].HeaderText = "Amend";
                dgv_ViewAircraftType.Columns[7].Visible = false;
                FixColumnWidth_dgv_ViewFormat();


            }
        }
        private void FixColumnWidth_dgv_ViewFormat()
        {
            int w = dgv_ViewAircraftType.Width;
            dgv_ViewAircraftType.Columns[0].Width = w- 600;
            dgv_ViewAircraftType.Columns[1].Width = 100;
            dgv_ViewAircraftType.Columns[2].Width = 100;
            dgv_ViewAircraftType.Columns[3].Width = 100;
            dgv_ViewAircraftType.Columns[4].Width = 100;
            dgv_ViewAircraftType.Columns[5].Width = 100;
            dgv_ViewAircraftType.Columns[6].Width = 100;
        }

        private void AircraftType_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewFormat();
        }

        private void dgv_ViewAircraftType_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

                Create_AircraftType.Enabled = false;
                Edit_AircraftType.Enabled = true;
                if (e.RowIndex == -1)
                {
                    return;
                }

                lblAircraftTypeId.Text = dgv_ViewAircraftType.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtAircraftTypeName.Text = dgv_ViewAircraftType.Rows[e.RowIndex].Cells[0].Value.ToString();
                comb_status.Text = dgv_ViewAircraftType.Rows[e.RowIndex].Cells[1].Value.ToString();
                Amend = Convert.ToInt32(dgv_ViewAircraftType.Rows[e.RowIndex].Cells[6].Value.ToString());

        }

        private void Edit_AircraftType_Click(object sender, EventArgs e)
        {

            if (txtAircraftTypeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter type name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAircraftTypeName.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new type name " + txtAircraftTypeName.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("update AircraftType ");
                    Sbd.Append("set TypeName = @TypeName,");
                    Sbd.Append("Status = @Status,");
                    Sbd.Append("ModifiedBy = @ModifiedBy,");
                    Sbd.Append("ModifiedDate = @ModifiedDate,");
                    Sbd.Append("Amend = @Amend ");
                    Sbd.Append("where AircraftType = @AircraftType");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@AircraftType", SqlDbType.NVarChar).Value = lblAircraftTypeId.Text.Trim();
                    Cmd.Parameters.Add("@TypeName", SqlDbType.NVarChar).Value = txtAircraftTypeName.Text.Trim();
                    Cmd.Parameters.Add("@Status", SqlDbType.NChar).Value = comb_status.SelectedValue.ToString().Trim();
                    Cmd.Parameters.Add("@ModifiedBy", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@ModifiedDate", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Amend", SqlDbType.Int).Value = Amend+1;

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Aircraft type updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();


                    // show all data on gridview
                    txtAircraftTypeName.Text = "";
                    Max_AircraftTypeId();
                    DataHead_AircraftType();
                    Edit_AircraftType.Enabled = false;
                    Create_AircraftType.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update aircraft type" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            DataHead_AircraftType();
        }
    }
}
