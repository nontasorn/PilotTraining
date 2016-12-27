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
    public partial class GradManagement : Form
    {
        public GradManagement()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        int GradeMaxId;
        string GradeId; // for edit
        string userId;
        int amend;

        private void GradManagement_Load(object sender, EventArgs e)
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
            DataHead_Grade(); // show all grade details
            cmb_Grade_Type();// combo list of grade type
            Max_Grade_ID(); // Grade ID
            ClearDetails(); // Clear details

            Edit_Grade_Button.Enabled = false;
            Delete_Grade_Button.Enabled = false;
            
        }
        private void ClearDetails()
        {
            txt_Grade_Name.Text = "";
            txt_Grade_Rate.Text = "";
            cmb_Grade_Type();
        }

        private void DataHead_Grade()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("GT.Grade_Type_Name,");
            Sbd.Append("G.Grade_Name,");
            Sbd.Append("G.Grade_Rate,");
            Sbd.Append("U.Employee_SureName+'   '+U.Employee_LastName,");
            Sbd.Append("G.Grade_Create_Date,");
            Sbd.Append("U.Employee_SureName+'   '+U.Employee_LastName,");
            Sbd.Append("G.Grade_Modified_Date,");
            Sbd.Append("G.Grade_Amend, ");
            Sbd.Append("G.Grade_Run_ID ");
            Sbd.Append("FROM Grade G ");
            Sbd.Append("INNER JOIN Grade_Type GT ");
            Sbd.Append("ON GT.Grade_Type_ID	= G.Grade_Type_ID ");
            Sbd.Append("INNER JOIN User_Login U ");
            Sbd.Append("ON G.Grade_Create_By = U.Employee_ID ");
            Sbd.Append("ORDER BY G.Grade_Type_ID,G.Grade_Rate");

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
                dgv_ViewGrade.DataSource = dt;
                dgv_ViewGrade_Format();
            }
            else
            {
                dgv_ViewGrade.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_ViewGrade_Format()
        {
            if (dgv_ViewGrade.RowCount > 0)
            {

                dgv_ViewGrade.Columns[0].HeaderText = "Grade Type";
                dgv_ViewGrade.Columns[1].HeaderText = "Grade Name";
                dgv_ViewGrade.Columns[2].HeaderText = "Grade Rate";
                dgv_ViewGrade.Columns[3].HeaderText = "Create By";
                dgv_ViewGrade.Columns[4].HeaderText = "Create Date";
                dgv_ViewGrade.Columns[5].HeaderText = "Modified By";
                dgv_ViewGrade.Columns[6].HeaderText = "Modified Date";
                dgv_ViewGrade.Columns[7].HeaderText = "Amend";

                FixColumnWidth_dgv_ViewGrade_Format();

                dgv_ViewGrade.Columns[4].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewGrade.Columns[5].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm:ss");
                dgv_ViewGrade.Columns[8].Visible = false;

            }
        }
        private void FixColumnWidth_dgv_ViewGrade_Format()
        {
            int w = dgv_ViewGrade.Width;
            dgv_ViewGrade.Columns[0].Width = 200;
            dgv_ViewGrade.Columns[1].Width = w - 200 - 100 - 100 - 100 - 100 - 100 -100;
            dgv_ViewGrade.Columns[2].Width = 100;
            dgv_ViewGrade.Columns[3].Width = 100;
            dgv_ViewGrade.Columns[4].Width = 100;
            dgv_ViewGrade.Columns[5].Width = 100;
            dgv_ViewGrade.Columns[6].Width = 100;
            dgv_ViewGrade.Columns[7].Width = 100;

        }

        private void GradManagement_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewGrade_Format();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Create_Grade_Buton.Enabled = true;
            Edit_Grade_Button.Enabled = false;
            Delete_Grade_Button.Enabled = false;
            DataHead_Grade();
            Max_Grade_ID();
            ClearDetails();
        }

        private void cmb_Grade_Type()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT Grade_Type_ID,Grade_Type_Name FROM Grade_Type");

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

                comb_Grade_Type.BeginUpdate();
                comb_Grade_Type.DisplayMember = "Grade_Type_Name";
                comb_Grade_Type.ValueMember = "Grade_Type_ID";
                comb_Grade_Type.DataSource = dtUser;
                comb_Grade_Type.EndUpdate();
                comb_Grade_Type.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void txt_Grade_Rate_KeyPress(object sender, KeyPressEventArgs e) // don't enter string / enter only number
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != 46) && (e.KeyChar != 8)) // 46 คือ . 8 คือ backspace
            {
                e.Handled = true;
            }
        }
        private void Max_Grade_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(Grade_Run_ID) AS Grade_Run_ID FROM Grade");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                GradeMaxId = 1;
            }
            else
            {
                GradeMaxId = Convert.ToInt32(id.ToString());
                GradeMaxId++;
            }
            //txtHandId.Text = HeadId.ToString();

            //txtGradeID.Text = "G" + GradeMaxId.ToString();
            Cmd.Parameters.Clear();
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

            if (txt_Grade_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter grade name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Grade_Name.Focus();
                return;
            }

            if (txt_Grade_Rate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter grade rate", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Grade_Rate.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to create new grade" + txt_Grade_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();                                         
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("INSERT INTO Grade ");
                    Sbd.Append("(Grade_Run_ID, Grade_ID, Grade_Type_ID, Grade_Name, Grade_Rate, Grade_Create_By,Grade_Create_Date, Grade_Modified_By, Grade_Modified_Date, Grade_Amend) ");
                    Sbd.Append(" VALUES ");
                    Sbd.Append(" (@Grade_Run_ID, @Grade_ID, @Grade_Type_ID, @Grade_Name, @Grade_Rate, @Grade_Create_By,@Grade_Create_Date, @Grade_Modified_By, @Grade_Modified_Date, @Grade_Amend)");

                    sqlSaveStHead = Sbd.ToString();

                  
                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Grade_Run_ID", SqlDbType.Int).Value = GradeMaxId;
                    Cmd.Parameters.Add("@Grade_ID", SqlDbType.NChar).Value = "G"+GradeMaxId.ToString();
                    Cmd.Parameters.Add("@Grade_Type_ID", SqlDbType.NChar).Value = comb_Grade_Type.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Grade_Name", SqlDbType.NVarChar).Value = txt_Grade_Name.Text.Trim();
                    Cmd.Parameters.Add("@Grade_Rate", SqlDbType.Int).Value = Convert.ToInt32(txt_Grade_Rate.Text);
                    Cmd.Parameters.Add("@Grade_Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Grade_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Grade_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Grade_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Grade_Amend", SqlDbType.Int).Value = 0;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Grade generated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Grade_ID(); // Grade Max ID 
                    DataHead_Grade(); // show all grade details
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create new grade" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void dgv_ViewGrade_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Create_Grade_Buton.Enabled = false;
            if (e.RowIndex == -1)
            {
                return;
            }
            GradeId = dgv_ViewGrade.Rows[e.RowIndex].Cells[8].Value.ToString();
            Delete_Grade_Button.Enabled = true;
            Edit_Grade_Button.Enabled = true;
            txt_Grade_Name.Text     =       dgv_ViewGrade.Rows[e.RowIndex].Cells[1].Value.ToString();
            comb_Grade_Type.Text    =       dgv_ViewGrade.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Grade_Rate.Text     =       dgv_ViewGrade.Rows[e.RowIndex].Cells[2].Value.ToString();
            amend = Convert.ToInt32(dgv_ViewGrade.Rows[e.RowIndex].Cells[7].Value.ToString());


            
        }

        private void Edit_Grade_Button_Click(object sender, EventArgs e)
        {
            
            if (txt_Grade_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter grade name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Grade_Name.Focus();
                return;
            }

            if (txt_Grade_Rate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter grade rate", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Grade_Rate.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update grade" + txt_Grade_Name.Text.Trim() + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sbd = new StringBuilder();
                    Sbd.Remove(0, Sbd.Length);
                    Sbd.Append("UPDATE Grade ");
                    Sbd.Append("SET Grade_Type_ID = @Grade_Type_ID,");
                    Sbd.Append("Grade_Name = @Grade_Name,");
                    Sbd.Append("Grade_Rate = @Grade_Rate,");
                    Sbd.Append("Grade_Modified_By = @Grade_Modified_By,");
                    Sbd.Append("Grade_Modified_Date = @Grade_Modified_Date,");
                    Sbd.Append("Grade_Amend = @Grade_Amend ");
                    Sbd.Append("WHERE Grade_Run_ID = @Grade_Run_ID");

                    sqlSaveStHead = Sbd.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Grade_Run_ID", SqlDbType.Int).Value = GradeId;
                    Cmd.Parameters.Add("@Grade_Type_ID", SqlDbType.NChar).Value = comb_Grade_Type.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Grade_Name", SqlDbType.NVarChar).Value = txt_Grade_Name.Text.Trim();
                    Cmd.Parameters.Add("@Grade_Rate", SqlDbType.Int).Value = Convert.ToInt32(txt_Grade_Rate.Text);
                    Cmd.Parameters.Add("@Grade_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Grade_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Grade_Amend", SqlDbType.Int).Value = amend+1;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Grade updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                    Max_Grade_ID(); // Grade Max ID 
                    DataHead_Grade(); // show all grade details
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update grade" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void Delete_Grade_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete grade", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();

                try
                {
                    Sbd = new StringBuilder();
                    Sbd.Append("DELETE Grade");
                    Sbd.Append(" WHERE (Grade_Run_ID=@Grade_Run_ID)");
                    string sqlDelete;
                    sqlDelete = Sbd.ToString();

                    Cmd.CommandText = sqlDelete;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Conn;
                    Cmd.Transaction = Tr;
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.Add("@Grade_Run_ID", SqlDbType.Int).Value = GradeId;
                    int result;
                    result = Cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        Tr.Rollback();
                        MessageBox.Show("Invalid the data", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Tr.Commit();
                        MessageBox.Show("Grade deleted successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Max_Grade_ID(); // Grade Max ID 
                    DataHead_Grade(); // show all grade details
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    Tr.Rollback();
                    MessageBox.Show("Unable to delete grade" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

    }
}
