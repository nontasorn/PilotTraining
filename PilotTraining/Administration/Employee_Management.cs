using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using PilotTraining.Class;

namespace PilotTraining.Administration
{
    public partial class Employee_Management : Form
    {
        public Employee_Management()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        SqlTransaction Tr;
        StringBuilder Sb;
        SqlDataReader Sdr;
        string userId;
        int amend;
        char status;
        string EmployeeID;

        // parameter of permission tab
        string per_Employee_ID;



        private void Employee_Management_Load(object sender, EventArgs e)
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
            txt_Create_Password.PasswordChar = '*';
            txt_Create_Reenter_Password.PasswordChar = '*';
            ShowAllUserName(); // Show all user

            txtReset_Password.PasswordChar = '*'; ;
            txtReseT_Reenter_Password.PasswordChar = '*';

            cmb_Rules();// combobox of permission
        }

        // ---- Tab Create User

        private void ClearAllDataCreateUser()
        {
            txt_Create_Employee_ID.Text = "";
            txt_Create_Employee_Code.Text = "";
            txt_Create_First_Name.Text = "";
            txt_Create_Last_Name.Text = "";
            txt_Create_Password.Text = "";
            txt_Create_Reenter_Password.Text = "";
        }

        private void Clear_User_Btn_Click(object sender, EventArgs e)
        {
            ClearAllDataCreateUser();
        }

        private void Create_User_Btn_Click(object sender, EventArgs e)
        {
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์เพิ่มผู้ใช้ใหม่ กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txt_Create_Employee_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee ID", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Employee_ID.Focus();
                return;
            }

            if (txt_Create_Employee_Code.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee Code", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Employee_Code.Focus();
                return;
            }

            if (txt_Create_First_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter first name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_First_Name.Focus();
                return;
            }

            if (txt_Create_Last_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter last name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Last_Name.Focus();
                return;
            }

            if (txt_Create_Password.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your password", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Password.Focus();
                return;
            }

            if (txt_Create_Password.Text.Trim() != txt_Create_Reenter_Password.Text.Trim())
            {
                MessageBox.Show("These password don't match", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Create_Reenter_Password.Focus();
                txt_Create_Reenter_Password.SelectAll();
                return;
            }

            if (MessageBox.Show("คุณต้องการเพิ่ม UserName ใหม่ ใช่หรือไม่?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                Tr = Conn.BeginTransaction();
                byte[] CurrentIV = new byte[] { 51, 52, 53, 54, 55, 56, 57, 58 };
                byte[] CurrentKey;

                if (txt_Create_Employee_ID.Text.Length == 8)
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txt_Create_Employee_ID.Text);
                }
                else if (txt_Create_Employee_ID.Text.Length > 8) 
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txt_Create_Employee_ID.Text.Substring(0, 8));
                }
                else
                {
                    string AddString = txt_Create_Employee_ID.Text.Substring(0, 1);
                    int TotalLoop = 8 - Convert.ToInt32(txt_Create_Employee_ID.Text.Length);
                    string tmpKey = txt_Create_Employee_ID.Text;
                    for (int i = 1; i <= TotalLoop; i++)
                    {
                        tmpKey = tmpKey + AddString;
                    }
                    CurrentKey = Encoding.ASCII.GetBytes(tmpKey);
                }

                DESCryptoServiceProvider desCrypt = new DESCryptoServiceProvider();
                desCrypt.IV = CurrentIV;
                desCrypt.Key = CurrentKey;

                MemoryStream ms = new MemoryStream();
                ms.Position = 0;

                ICryptoTransform Ict = desCrypt.CreateEncryptor();
                CryptoStream cs = new CryptoStream(ms, Ict, CryptoStreamMode.Write);

                byte[] arrByte = Encoding.ASCII.GetBytes(txt_Create_Password.Text);
                cs.Write(arrByte, 0, arrByte.Length);
                cs.FlushFinalBlock();
                cs.Close();

                string PwdWithEncrypt;
                PwdWithEncrypt = Convert.ToBase64String(ms.ToArray());
                try
                {
                    Sb = new StringBuilder();
                    Sb.Append("INSERT INTO User_Login (Employee_ID,Employee_SureName,Employee_LastName,Employee_Code,Employee_Status,Employee_Password,Employee_Create_By,Employee_Create_Date,Employee_Modified_By,Employee_Modified_Date,Employee_Amend)");
                    Sb.Append(" VALUES (@Employee_ID,@Employee_SureName,@Employee_LastName,@Employee_Code,@Employee_Status,@Employee_Password,@Employee_Create_By,@Employee_Create_Date,@Employee_Modified_By,@Employee_Modified_Date,@Employee_Amend)");
                    string sqlAdd;
                    sqlAdd = Sb.ToString();


                    Cmd = new SqlCommand();
                    Cmd.CommandText = sqlAdd;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Conn;
                    Cmd.Transaction = Tr;
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.Add("@Employee_ID", SqlDbType.NChar).Value = txt_Create_Employee_ID.Text.Trim();
                    Cmd.Parameters.Add("@Employee_SureName", SqlDbType.NVarChar).Value = txt_Create_First_Name.Text.Trim();
                    Cmd.Parameters.Add("@Employee_LastName", SqlDbType.NVarChar).Value = txt_Create_Last_Name.Text.Trim();
                    Cmd.Parameters.Add("@Employee_Code", SqlDbType.NChar).Value = txt_Create_Employee_Code.Text.Trim();
                    Cmd.Parameters.Add("@Employee_Status", SqlDbType.Char).Value = 'N'; // N = Normal
                    Cmd.Parameters.Add("@Employee_Password", SqlDbType.NVarChar).Value = PwdWithEncrypt;
                    Cmd.Parameters.Add("@Employee_Create_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Employee_Create_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Employee_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Employee_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Employee_Amend", SqlDbType.Int).Value = 0;
                   
                    Cmd.ExecuteNonQuery();
                    Tr.Commit();
                    ShowAllUserName();

                    MessageBox.Show("เพิ่ม UserName ใหม่ เรียบร้อยแล้ว !!!", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllDataCreateUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("คุณป้อน UserName ซ้ำกับของเดิมที่มีอยู่ !!! " + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Tr.Rollback();
                }
                
            }
            txt_Create_Employee_ID.Focus();
        }
        private void ShowAllUserName()
        {
            Sb = new StringBuilder();
            Sb.Append("SELECT U.Employee_Code,");
            Sb.Append("U.Employee_ID,");
            Sb.Append("(U.Employee_SureName+' '+U.Employee_LastName) AS Name,");
            Sb.Append("R.Login_Rule_Name,");
            Sb.Append("U.Employee_Status,");
            Sb.Append("U.Employee_Amend ");
            Sb.Append("FROM User_Login U ");
            Sb.Append("INNER JOIN LoginRule R ON R.Login_Rule_ID = U.Employee_Rule");
            string sqlShow;
            sqlShow = Sb.ToString();

            Cmd = new SqlCommand();
            Cmd.CommandText = sqlShow;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);

                dgv_ViewUser.DataSource = dt;
                dgv_permission.DataSource = dt;

                dgv_ViewUser_Format();
            }
            else
            {
                dgv_ViewUser.DataSource = null;
                dgv_permission.DataSource = null;
                //BtnSetPermission.Enabled = false;
            }
            Sdr.Close();
        }

        private void FixColumnWidth_dgv_ViewUser_Format()
        {
            int w = dgv_ViewUser.Width;
            dgv_ViewUser.Columns[0].Width = 200;
            dgv_ViewUser.Columns[1].Width = 200;
            dgv_ViewUser.Columns[2].Width = w-50-200-200-100-100-92;
            dgv_ViewUser.Columns[3].Width = 100;
            dgv_ViewUser.Columns[4].Width = 100;
            dgv_ViewUser.Columns[5].Width = 92;

            int x = dgv_ViewUser.Width;
            dgv_permission.Columns[0].Width = 200;
            dgv_permission.Columns[1].Width = 200;
            dgv_permission.Columns[2].Width = x - 220-200 - 200 - 100- -100- 92;
            dgv_permission.Columns[3].Width = 100;
            dgv_permission.Columns[4].Width = 100;
            dgv_permission.Columns[5].Width = 92;

            

        }
        private void dgv_ViewUser_Format()
        {
            if (dgv_ViewUser.RowCount > 0)
            {

                dgv_ViewUser.Columns[0].HeaderText = "Employee Code";
                dgv_ViewUser.Columns[1].HeaderText = "Employee ID";
                dgv_ViewUser.Columns[2].HeaderText = "Name";
                dgv_ViewUser.Columns[3].HeaderText = "Rule";
                dgv_ViewUser.Columns[4].HeaderText = "Status";
                dgv_ViewUser.Columns[5].HeaderText = "Amend";

                //dgv_ViewUser.Columns[4].Visible = false;

                dgv_permission.Columns[0].HeaderText = "Employee Code";
                dgv_permission.Columns[1].HeaderText = "Employee ID";
                dgv_permission.Columns[2].HeaderText = "Name";
                dgv_permission.Columns[3].HeaderText = "Rule";
                dgv_permission.Columns[4].HeaderText = "Status";
                dgv_permission.Columns[5].HeaderText = "Amend";
                FixColumnWidth_dgv_ViewUser_Format();

            }

            
        }

        private void Employee_Management_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgv_ViewUser_Format();
        }

        private void Reset_Password_Btn_Click(object sender, EventArgs e)
        {
           
            /*
            if (clsCash.IsPermissionId("P01") == false)
            {
                MessageBox.Show("คุณไม่มีสิทธิ์แก้ไขรหัสพนักงาน กรุณาติดต่อผู้ดูแลระบบ...");
                return;
            }
             * */

            if (txtReset_Employee_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee ID", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtReset_Employee_ID.Focus();
                return;
            }
            if (txtReset_Password.Text.Trim() == "") 
            {
                MessageBox.Show("Please enter your password", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtReset_Employee_ID.Focus();
                return;
            }
            if (txtReset_Password.Text.Trim() != txtReseT_Reenter_Password.Text.Trim())
            {
                MessageBox.Show("These password don't match", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtReset_Password.Focus();
                txtReseT_Reenter_Password.SelectAll();
                return;
            }

            if (MessageBox.Show("Are you sure to edit?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Tr = Conn.BeginTransaction();
                byte[] CurrentIV = new byte[] { 51, 52, 53, 54, 55, 56, 57, 58 };
                byte[] CurrentKey;

                if (txtReset_Employee_ID.Text.Length == 8)
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txtReset_Employee_ID.Text);
                }
                else if (txtReset_Employee_ID.Text.Length > 8)
                {
                    CurrentKey = Encoding.ASCII.GetBytes(txtReset_Employee_ID.Text.Substring(0, 8));
                }
                else
                {
                    string AddString = txtReset_Employee_ID.Text.Substring(0, 1);
                    int TotalLoop = 8 - Convert.ToInt32(txtReset_Employee_ID.Text.Length);
                    string tmpKey = txtReset_Employee_ID.Text;
                    for (int i = 1; i <= TotalLoop; i++)
                    {
                        tmpKey = tmpKey + AddString;
                    }
                    CurrentKey = Encoding.ASCII.GetBytes(tmpKey);
                }

                DESCryptoServiceProvider desCrypt = new DESCryptoServiceProvider();
                desCrypt.IV = CurrentIV;
                desCrypt.Key = CurrentKey;

                MemoryStream ms = new MemoryStream();
                ms.Position = 0;

                ICryptoTransform Ict = desCrypt.CreateEncryptor();
                CryptoStream cs = new CryptoStream(ms, Ict, CryptoStreamMode.Write);

                byte[] arrByte = Encoding.ASCII.GetBytes(txtReset_Password.Text.Trim());
                cs.Write(arrByte, 0, arrByte.Length);
                cs.FlushFinalBlock();
                cs.Close();

                string PwdWithEncrypt;
                PwdWithEncrypt = Convert.ToBase64String(ms.ToArray());
                try
                {
                    Sb = new StringBuilder();
                    Sb.Append("UPDATE User_Login");
                    Sb.Append(" SET Employee_Password=@Password");
                    Sb.Append(" WHERE (Employee_ID=@UserName)");
                    string sqlEdit;
                    sqlEdit = Sb.ToString();

                    Cmd = new SqlCommand();
                    Cmd.CommandText = sqlEdit;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Conn;
                    Cmd.Transaction = Tr;
                    Cmd.Parameters.Clear();

                    Cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PwdWithEncrypt;

                    Cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtReset_Employee_ID.Text.Trim();

                    int result = Cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        Tr.Rollback();
                        MessageBox.Show("Invalid employee Id", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtReset_Employee_ID.Focus();
                        txtReset_Employee_ID.SelectAll();
                    }
                    else
                    {
                        Tr.Commit();
                        txtReset_Employee_ID.Text = "";

                        MessageBox.Show("Completed to reset your password", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtReset_Employee_ID.Clear();
                        txtReset_Password.Clear();
                        txtReseT_Reenter_Password.Clear();
                        txtReset_Employee_ID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    Tr.Rollback();
                    MessageBox.Show("Error" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtReset_Employee_ID.Focus();
        }

        private void Change_User_Status_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to update user yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sb = new StringBuilder();
                    Sb.Remove(0, Sb.Length);
                    Sb.Append("UPDATE User_Login ");
                    Sb.Append("SET Employee_Status = @Employee_Status,");
                    Sb.Append("Employee_Modified_By = @Employee_Modified_By,");
                    Sb.Append("Employee_Modified_Date =  @Employee_Modified_Date,");
                    Sb.Append("Employee_Amend  = @Employee_Amend ");
                    Sb.Append("WHERE Employee_ID = @Employee_ID");
                    sqlSaveStHead = Sb.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Employee_ID", SqlDbType.NChar).Value = EmployeeID.ToString();
                    if (status == 'N')
                    {
                        Cmd.Parameters.Add("@Employee_Status", SqlDbType.NChar).Value = 'R';
                    }
                    else
                    {
                        Cmd.Parameters.Add("@Employee_Status", SqlDbType.NChar).Value = 'N';
                    }
                    Cmd.Parameters.Add("@Employee_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Employee_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Employee_Amend", SqlDbType.Int).Value = amend + 1;

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    ShowAllUserName(); // refresh

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update user" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void dgv_ViewUser_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
             amend = Convert.ToInt32(dgv_ViewUser.Rows[e.RowIndex].Cells[4].Value.ToString());
             status = Convert.ToChar(dgv_ViewUser.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
             EmployeeID = dgv_ViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();

             txt_Edit_Emplyee_Code.Text = dgv_ViewUser.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
             
            
            string[] name = dgv_ViewUser.Rows[e.RowIndex].Cells[2].Value.ToString().Trim().Split("".ToArray());
            foreach(string x in name) 
            {
                txt_Edit_Employee_Name.Text = name[0].ToString();
                txt_Edit_Employee_LastName.Text = name[1].ToString();
            }



             
        }

        private void btn_Refresh_Employee_Click(object sender, EventArgs e)
        {
            ShowAllUserName();// Refresh
        }

        private void Search_Employee_Btn_Click(object sender, EventArgs e)
        {
            Sb = new StringBuilder();
            Sb.Append("SELECT Employee_Code,Employee_ID,(Employee_SureName+' '+Employee_LastName) AS Name, Employee_Status,Employee_Amend FROM User_Login ");
            Sb.Append("WHERE Employee_ID LIKE \'%");
            Sb.Append(txtSearch_Employee.Text.Trim());
            Sb.Append("%\' OR Employee_SureName LIKE \'%");
            Sb.Append( txtSearch_Employee.Text.Trim());
            Sb.Append("%\' OR Employee_LastName LIKE \'%");
            Sb.Append( txtSearch_Employee.Text.Trim());
            Sb.Append("%\' ");
            string sqlShow;
            sqlShow = Sb.ToString();

            Cmd = new SqlCommand();
            Cmd.CommandText = sqlShow;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dtUserLogin = new DataTable();
                dtUserLogin.Load(Sdr);

                dgv_ViewUser.DataSource = dtUserLogin;

                dgv_ViewUser_Format();
            }
            else
            {
                dgv_ViewUser.DataSource = null;
                //BtnSetPermission.Enabled = false;
            }
            Sdr.Close();
        }

        private void btn_Edit_Employee_Details_Click(object sender, EventArgs e)
        {

            if (txt_Edit_Emplyee_Code.Text == "")
            {
                MessageBox.Show("Please enter employee Code", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Edit_Emplyee_Code.Focus();
                return;
            }

            if (txt_Edit_Employee_Name.Text == "")
            {
                MessageBox.Show("Please enter first name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Edit_Employee_Name.Focus();
                return;
            }

            if (txt_Edit_Employee_LastName.Text == "")
            {
                MessageBox.Show("Please enter last name", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Edit_Employee_LastName.Focus();
                return;
            }


            if (MessageBox.Show("Are you sure to update employee information  " + EmployeeID + " yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sb = new StringBuilder();
                    Sb.Remove(0, Sb.Length);
                    Sb.Append("UPDATE User_Login ");
                    Sb.Append("SET Employee_Code = @Employee_Code,");
                    Sb.Append("Employee_SureName = @Employee_SureName,");
                    Sb.Append("Employee_LastName = @Employee_LastName ");
                    Sb.Append("WHERE Employee_ID = @Employee_ID");

                    sqlSaveStHead = Sb.ToString();


                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Employee_Code", SqlDbType.NChar).Value = EmployeeID;
                    Cmd.Parameters.Add("@Employee_SureName", SqlDbType.NVarChar).Value = txt_Edit_Employee_Name.Text.Trim();
                    Cmd.Parameters.Add("@Employee_LastName", SqlDbType.NVarChar).Value = txt_Edit_Employee_LastName.Text.Trim();
                    Cmd.Parameters.Add("@Employee_ID", SqlDbType.NChar).Value = txt_Edit_Emplyee_Code.Text.Trim();

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update employee information" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }

        private void bun_refresh_permission_Click(object sender, EventArgs e)
        {
            ShowAllUserName();// Refresh
        }

        private void btn_search_permission_Click(object sender, EventArgs e)
        {
            Sb = new StringBuilder();
            Sb.Append("SELECT Employee_Code,Employee_ID,(Employee_SureName+' '+Employee_LastName) AS Name, Employee_Status,Employee_Amend FROM User_Login ");
            Sb.Append("WHERE Employee_ID LIKE \'%");
            Sb.Append(txt_permission_search.Text.Trim());
            Sb.Append("%\' OR Employee_SureName LIKE \'%");
            Sb.Append(txt_permission_search.Text.Trim());
            Sb.Append("%\' OR Employee_LastName LIKE \'%");
            Sb.Append(txt_permission_search.Text.Trim());
            Sb.Append("%\' ");
            string sqlShow;
            sqlShow = Sb.ToString();

            Cmd = new SqlCommand();
            Cmd.CommandText = sqlShow;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);

                dgv_permission.DataSource = dt;
                

                dgv_ViewUser_Format();
            }
            else
            {
                dgv_permission.DataSource = null;
                //BtnSetPermission.Enabled = false;
            }
            Sdr.Close();
        }

        // Permission

        private void cmb_Rules()
        {
            Sb = new StringBuilder();
            Sb.Remove(0, Sb.Length);

            Sb.Append("SELECT Login_Rule_ID,Login_Rule_Name FROM LoginRule");

            string sqlIni = Sb.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);


                cbo_Rules.BeginUpdate();

                cbo_Rules.ComboBox.DisplayMember = "Login_Rule_Name";
                cbo_Rules.ComboBox.ValueMember = "Login_Rule_ID";
                cbo_Rules.ComboBox.DataSource = dt;
                cbo_Rules.EndUpdate();
                cbo_Rules.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void dgv_permission_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            per_Employee_ID = dgv_permission.Rows[e.RowIndex].Cells[1].Value.ToString();
                     
        }

        private void btn_update_permission_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to update user rule yes/no?", "Pilot Training Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Tr = Conn.BeginTransaction();
                try
                {
                    string sqlSaveStHead;
                    Sb = new StringBuilder();
                    Sb.Remove(0, Sb.Length);
                    Sb.Append("UPDATE User_Login ");
                    Sb.Append("SET Employee_Rule = @Employee_Rule,");
                    Sb.Append("Employee_Modified_By = @Employee_Modified_By,");
                    Sb.Append("Employee_Modified_Date =  @Employee_Modified_Date,");
                    Sb.Append("Employee_Amend  = @Employee_Amend ");
                    Sb.Append("WHERE Employee_ID = @Employee_ID");
                    sqlSaveStHead = Sb.ToString();

                    Cmd.Parameters.Clear();
                    Cmd.Transaction = Tr;
                    Cmd.CommandText = sqlSaveStHead;
                    Cmd.Parameters.Add("@Employee_ID", SqlDbType.NChar).Value = per_Employee_ID.Trim();
                    Cmd.Parameters.Add("@Employee_Rule", SqlDbType.NChar).Value = cbo_Rules.ComboBox.SelectedValue.ToString();
                    Cmd.Parameters.Add("@Employee_Modified_By", SqlDbType.NChar).Value = userId;
                    Cmd.Parameters.Add("@Employee_Modified_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    Cmd.Parameters.Add("@Employee_Amend", SqlDbType.Int).Value = amend + 1;

                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("User rule updated successfully", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Tr.Commit();
                    ShowAllUserName(); // refresh

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update user rule" + ex.Message, "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
        }
    }
}
