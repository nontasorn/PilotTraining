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
using System.IO;
using PilotTraining.Class;
using System.Security.Cryptography;

namespace PilotTraining
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlTransaction Tr;  //
        StringBuilder Sb;
        SqlDataReader Sdr;
        DataTable Dt;
        DateTime Today;

        string PwdWithEncrypt;
        string CurrentAuthentication;
        bool IsChange = false;

        string CUserName = "";
        MemoryStream ms;
        DESCryptoServiceProvider desCrypt;
        CryptoStream cs;

        private void Login_Load(object sender, EventArgs e)
        {
            DB_Online.Checked = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DB_Online.Checked == true)
            {
                DBConnString.strConn = "Data Source=ISARA-NB;Initial Catalog=PilotTraining; Persist Security Info=True;User ID=sa;Password=1234";
                DBConnString.clsDB = new clsDatabase(DBConnString.strConn, DBConnString.sServer);
                string strConn;
                strConn = DBConnString.strConn;
                Conn = new SqlConnection();
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
                Conn.ConnectionString = strConn;
                Conn.Open();

                if (!DBConnString.clsDB.IsConnected()) return;
                if ((txtUserName.Text.Trim() == "") || (txtPassword.Text.Trim() == ""))
                {
                    txtUserName.Focus();
                    return;
                }

                bool CurrentLogin = false;
                CurrentLogin = EmpLogin(txtUserName.Text, txtPassword.Text);

                if (CurrentLogin == true)
                {
                    DBConnString.UserName = txtUserName.Text.Trim();
                    DBConnString.UserAuthentication = CurrentAuthentication;

                    //Close();
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                               
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials", "Pilot Training Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    CurrentAuthentication = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();
                    txtPassword.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Error");
            }

           
        }
        private bool EmpLogin(string _UserName, string _Password)
        {
            Sb = new StringBuilder();
            Sb.Append("SELECT Employee_ID,Employee_Password,Employee_SureName,Employee_LastName");
            Sb.Append(" FROM User_Login");
            Sb.Append(" WHERE (Employee_ID=@UserName)");
            Sb.Append(" AND (Employee_Password=@Password)");
            Sb.Append(" AND (Employee_Status='N')");
            string sqlLogin;
            sqlLogin = Sb.ToString();

            byte[] CurrentIV = new byte[] { 51, 52, 53, 54, 55, 56, 57, 58 };
            byte[] CurrentKey = { };
            if (_UserName.Length == 8)
            {
                CurrentKey = Encoding.ASCII.GetBytes(_UserName);
            }
            else if (_UserName.Length > 8)
            {
                CurrentKey = Encoding.ASCII.GetBytes(_UserName.Substring(0, 8));
            }
            else
            {
                string AddString = _UserName.Substring(0, 1);
                int TotalLoop = 8 - Convert.ToInt32(_UserName.Length);
                string tmpKey = _UserName;

                for (int i = 1; i <= TotalLoop; i++)
                {
                    tmpKey = tmpKey + AddString;
                }
                CurrentKey = Encoding.ASCII.GetBytes(tmpKey);
            }

            desCrypt = new DESCryptoServiceProvider();
            desCrypt.IV = CurrentIV;
            desCrypt.Key = CurrentKey;

            ms = new MemoryStream();
            ms.Position = 0;

            ICryptoTransform ce = desCrypt.CreateEncryptor();
            cs = new CryptoStream(ms, ce, CryptoStreamMode.Write);
            byte[] arrByte = Encoding.ASCII.GetBytes(_Password);
            cs.Write(arrByte, 0, arrByte.Length);
            cs.FlushFinalBlock();
            cs.Close();

            PwdWithEncrypt = Convert.ToBase64String(ms.ToArray());

            Cmd = new SqlCommand();
            Cmd.CommandText = sqlLogin;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Cmd.Parameters.Clear();
            Cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = _UserName;
            Cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PwdWithEncrypt;
            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                Sdr.Read();
                //CurrentAuthentication = Sdr.GetString(Sdr.GetOrdinal("Auth"));
                //   string UserName = dr.GetString(dr.GetOrdinal("UserId"));
                string UserName = Sdr.GetString(Sdr.GetOrdinal("Employee_ID"));
                string SureName = Sdr.GetString(Sdr.GetOrdinal("Employee_SureName"));
                string LastName = Sdr.GetString(Sdr.GetOrdinal("Employee_LastName"));
                DBConnString.sUserIdLogin = UserName;
                DBConnString.sUserlogin = SureName + " " + LastName;
                return true;
            }
            else
            {
                Sdr.Close();
                return false;
            }
        }
    }
}
