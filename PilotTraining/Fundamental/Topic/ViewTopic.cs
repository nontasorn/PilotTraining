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

namespace PilotTraining.Fundamental.Topic
{
    public partial class ViewTopic : Form
    {
        public ViewTopic()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        private void ViewTopic_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            cmb_toolcmbFormName();
        }
        private void cmb_toolcmbFormName()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT SubSubjectId,SubSubjectName,* FROM SubSubject WHERE SubSubjectStatus <> 'I'");


            string sqlIni = Sbd.ToString();
            Cmd = new SqlCommand();

            Cmd.CommandText = sqlIni;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            Sdr = Cmd.ExecuteReader();

            if (Sdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Sdr);

                toolcmbFormName.BeginUpdate();

                toolcmbFormName.ComboBox.DisplayMember = "SubSubjectName";
                toolcmbFormName.ComboBox.ValueMember = "SubSubjectId";
                toolcmbFormName.ComboBox.DataSource = dt;
                toolcmbFormName.EndUpdate();
                toolcmbFormName.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void DataHead_Details()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT S.SubSubjectName,D.DetailGroupName,SubTopicName,MapType ");
            Sbd.Append("FROM SubSubject  S ");
            Sbd.Append("INNER JOIN DetailsGroup D ");
            Sbd.Append("ON S.SubSubjectId = D.SubSubjectId ");
            Sbd.Append("LEFT JOIN MainTopicMapping M ");
            Sbd.Append("ON M.DetailGroupId = D.DetailGroupId ");
            Sbd.Append("LEFT JOIN MainTopicMappingDetail T ");
            Sbd.Append("ON T.TopicMappingId = M.TopicMappingId ");
            Sbd.Append("LEFT  JOIN SubTopic B ");
            Sbd.Append("ON B.SubTopicId = T.SubTopicId ");
            Sbd.Append("ORDER BY S.SubSubjectId,D.DetailsGroupOrder,B.SubTopicOrder ");
            

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
                dgv_ViewMainTopic.DataSource = dt;
                //dgv_ViewDetails_Format();
            }
            else
            {
                dgv_ViewMainTopic.DataSource = null;

            }
            Sdr.Close();
        }

        private void toolcmbFormName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataHead_Details();
        }
    }
}
