﻿using System;
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
    public partial class MappingTopic : Form
    {
        public MappingTopic()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        DataTable dt;
        string userId; // User login
        int MaxMapping;
        string strMaxMapping;

        internal string subjectname // this value for edit
        {
            set { txtMainTopic.Text = value; }
        }
        internal string subjectId // this value for edit
        {
            set { txtMainTopicId.Text = value; }
        }

        private void MappingTopic_Load(object sender, EventArgs e)
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
            pn_SubTopic.Visible = false;
            
            Max_Mapping_ID();
        }
        private void Max_Mapping_ID()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT MAX(SUBSTRING(TopicMappingId,3,5)) AS TopicMappingId FROM MainTopicMapping");
            String sqlMaxStatementIndex;
            sqlMaxStatementIndex = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.CommandText = sqlMaxStatementIndex;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;
            string id = Cmd.ExecuteScalar().ToString();

            if (id == "")
            {
                MaxMapping = 1;
            }
            else
            {
                MaxMapping = Convert.ToInt32(id.ToString());
                MaxMapping++;
            }
            //txtHandId.Text = HeadId.ToString();

            string strMax = "";
            strMax = String.Format("{0:00000}", Convert.ToInt32(MaxMapping.ToString()));
            txtMappingId.Text = "TM" + strMax + '-' + DateTime.Now.ToString("yyyy");
            Cmd.Parameters.Clear();
        }

        private void btn_SelectSubTopic_Click(object sender, EventArgs e)
        {
            dgv_SelectSubTopic.Columns.Clear();
            pn_SubTopic.Visible = true;
            SubTopicDetails();
            dgv_SubTopic.RowsDefaultCellStyle.BackColor = Color.White;
        }
        private void SubTopicDetails()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);
            Sbd.Append("SELECT ");
            Sbd.Append("S.SubTopicName,");
            Sbd.Append("P.Para_Desc 'TopicStatus',");
            Sbd.Append("S.SubTopicId ");
            Sbd.Append("FROM SubTopic S ");
            Sbd.Append("INNER JOIN Parameter P ON P.Para_BPC		= 'DetailsGroup' AND P.Para_Type	= 'status' AND P.Para_Code	= S.SubTopicStatus ");

            Sbd.Append("WHERE S.SubTopicStatus <> 'I' ");

            string sql = Sbd.ToString();
            Cmd = new SqlCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn;

            Sdr = Cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                DataGridViewCheckBoxColumn chkColSelect = new DataGridViewCheckBoxColumn();
                chkColSelect.Name = "chkSelect";
                chkColSelect.TrueValue = true;
                chkColSelect.Width = 130;
                chkColSelect.DisplayIndex = 18;
                chkColSelect.FlatStyle = FlatStyle.Popup;
                dgv_SubTopic.Columns.Add(chkColSelect);
                
                DataTable dt = new DataTable();
                dt.Load(Sdr);
                dgv_SubTopic.DataSource = dt;
                dgv_SubTopic.ClearSelection();
                lbSumList.Text = "Count Sub-Topic :     " + dgv_SubTopic.Rows.Count.ToString();
                dgv_Header();
            }
            else
            {
                dgv_SubTopic.DataSource = null;

            }
            Sdr.Close();
        }
        private void dgv_Header()
        {
            if (dgv_SubTopic.RowCount >= 0)
            {
                dgv_SubTopic.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14F, GraphicsUnit.Pixel);
                dgv_SubTopic.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SubTopic.DefaultCellStyle.Font = new Font("Tahoma", 15F, GraphicsUnit.Pixel);


                dgv_SubTopic.Columns[0].HeaderText = "Select";
                dgv_SubTopic.Columns[1].HeaderText = "Name";
                dgv_SubTopic.Columns[2].HeaderText = "Status";
                dgv_SubTopic.Columns[3].Visible = false;
                dgv_SubTopic.Columns[0].Width = 100;
                dgv_SubTopic.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_SubTopic.Columns[1].Width = 300;
                dgv_SubTopic.Columns[2].Width = 200;

                dgv_SubTopic.Columns[1].ReadOnly = true;
                dgv_SubTopic.Columns[2].ReadOnly = true;
                dgv_SubTopic.Columns[3].ReadOnly = true;

            }
        }
    }
}
