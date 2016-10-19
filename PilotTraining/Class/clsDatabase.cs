using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PilotTraining.Class
{
    class clsDatabase
    {
        private SqlConnection objConn;
        private SqlCommand objCmd;
        private SqlTransaction Trans;
        private String strConnString;
        private String strIP;

        public clsDatabase(String StrConn, String StrIP)
        {
            strConnString = StrConn;
            strIP = StrIP;
        }

        public SqlDataReader QueryDataReader(String strSQL)
        {
            SqlDataReader dtReader;
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            objCmd = new SqlCommand(strSQL, objConn);
            dtReader = objCmd.ExecuteReader();
            return dtReader; //*** Return DataReader ***//
        }

        public DataSet QueryDataSet(String strSQL)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            dtAdapter.SelectCommand = objCmd;
            dtAdapter.Fill(ds);
            return ds;   //*** Return DataSet ***//
        }

        public DataTable QueryDataTable(String strSQL)
        {
            SqlDataAdapter dtAdapter;
            DataTable dt = new DataTable();
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            dtAdapter = new SqlDataAdapter(strSQL, objConn);
            dtAdapter.Fill(dt);
            return dt; //*** Return DataTable ***//
        }

        public Boolean QueryExecuteNonQuery(String strSQL)
        {
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            try
            {
                objCmd = new SqlCommand();
                objCmd.Connection = objConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = strSQL;

                objCmd.ExecuteNonQuery();
                return true; //*** Return True ***//
            }
            catch (Exception ex)
            {
                MessageBox.Show("พบข้อผิดพลาด เนื่องจาก " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; //*** Return False ***//
            }
        }

        public String QueryExecuteScalar(String strSQL)
        {
            Object obj;
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            try
            {
                objCmd = new SqlCommand();
                objCmd.Connection = objConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = strSQL;

                obj = objCmd.ExecuteScalar();  //*** Return Scalar ***//
                return obj.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("พบข้อผิดพลาด เนื่องจาก " + ex.Message + "\n\n" + "{" + strSQL + "}", "SQL ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; //*** Return Nothing ***//
            }
        }

        public void TransStart()
        {
            objConn = new SqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();
            Trans = objConn.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void TransExecute(String strSQL)
        {
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.Transaction = Trans;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strSQL;
            objCmd.ExecuteNonQuery();
        }

        public void TransRollBack()
        {
            Trans.Rollback();
        }

        public void TransCommit()
        {
            Trans.Commit();
        }

        public Boolean ExecuteTransaction(String strSQL1, String strSQL2)
        {
            //*** Start Transaction ***//
            TransStart();//clsDB.TransStart();

            try
            {
                TransExecute(strSQL1); //*** Execute Query 1 ***//

                TransExecute(strSQL2); //*** Execute Query 2 ***//

                //*** Commit Transaction ***//
                TransCommit();
                return true;
            }
            catch (Exception ex)
            {
                //*** RollBack Transaction ***//
                TransRollBack();
                MessageBox.Show("พบข้อผิดพลาด เนื่องจาก " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public Boolean ExecuteTransaction(String[] strSQL)
        {
            //*** Start Transaction ***//
            TransStart();//clsDB.TransStart();

            try
            {
                for (int i = 0; i < strSQL.Length; i++)
                {
                    TransExecute(strSQL[i]); //*** Execute Query [i] ***//
                }
                //*** Commit Transaction ***//
                TransCommit();
                return true;
            }
            catch (Exception ex)
            {
                //*** RollBack Transaction ***//
                TransRollBack();
                MessageBox.Show("พบข้อผิดพลาด เนื่องจาก " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public Boolean IsConnected()
        {
            if (IsServer() == false)
            {
                MessageBox.Show("ไม่พบ Server !!!", "Server ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                objConn = new SqlConnection();
                objConn.ConnectionString = strConnString;
                if (objConn.State == ConnectionState.Open) objConn.Close();
                objConn.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("พบข้อผิดพลาด เนื่องจาก " + ex.Message, "SQL ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; //*** Return Nothing ***//
            }
        }

        public void Close()
        {
            objConn.Close();
            objConn = null;
        }

        private Boolean IsServer()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IAsyncResult result = socket.BeginConnect(strIP, 1433, null, null);
            bool success = result.AsyncWaitHandle.WaitOne(1000, true);
            if (!success) return false;
            return true;
        }
    }
}

