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
using System.Globalization;
using System.Threading;

namespace PilotTraining.From
{
    public partial class frmFromSubmit : Form
    {
        public frmFromSubmit()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;
        StringBuilder Sbd;
        SqlDataReader Sdr;
        SqlTransaction Tr;
        string strloginId;
        string strBRF, strPS, strMC, strAM, strCE;
        string strCO, strLM;
        string strSubCO;
        string strTopic1, strTopic2;

        private void frmFromSubmit_Load(object sender, EventArgs e)
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
            University();
            NonTechNical();
            LoadTopic();
            LoadTopic();
        }
        private void cmb_BRF()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strBRF.ToString()+"'");


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

                cmbBRF.BeginUpdate();
                cmbBRF.DisplayMember = "UniversityCateList_Name";
                cmbBRF.ValueMember = "UniversityCateList_Id";
                cmbBRF.DataSource = dt;
                cmbBRF.EndUpdate();
                cmbBRF.SelectedIndex = 0;

            }
            Sdr.Close();
        }
        private void cmb_PS()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strPS.ToString() + "'");


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

                cmbPS.BeginUpdate();
                cmbPS.DisplayMember = "UniversityCateList_Name";
                cmbPS.ValueMember = "UniversityCateList_Id";
                cmbPS.DataSource = dt;
                cmbPS.EndUpdate();
                cmbPS.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_MC()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strMC.ToString() + "'");


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

                cmbMC.BeginUpdate();
                cmbMC.DisplayMember = "UniversityCateList_Name";
                cmbMC.ValueMember = "UniversityCateList_Id";
                cmbMC.DataSource = dt;
                cmbMC.EndUpdate();
                cmbMC.SelectedIndex = 0;

            }
            Sdr.Close();
        }


        private void cmb_AM()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strAM.ToString() + "'");


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

                cmbAM.BeginUpdate();
                cmbAM.DisplayMember = "UniversityCateList_Name";
                cmbAM.ValueMember = "UniversityCateList_Id";
                cmbAM.DataSource = dt;
                cmbAM.EndUpdate();
                cmbAM.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_CE()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT UniversityCateList_Id,UniversityCateList_Name,UnivesityMainList_Id FROM Univesity_Category_List WHERE UnivesityMainList_Id = " + "'" + strCE.ToString() + "'");


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

                cmbCE.BeginUpdate();
                cmbCE.DisplayMember = "UniversityCateList_Name";
                cmbCE.ValueMember = "UniversityCateList_Id";
                cmbCE.DataSource = dt;
                cmbCE.EndUpdate();
                cmbCE.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        

        private void University()
        {           
           DataTable dt = Class.DBConnString.clsDB.QueryDataTable("SELECT UnivesityMainList_Id,UnivesityMainList_Name,(SELECT count(UnivesityMainList_Id) AS Count FROM Univesity_Main_List)AS Count FROM Univesity_Main_List");
            if (dt.Rows.Count > 0)
            {               
                int count = Convert.ToInt32(dt.Rows[0]["Count"].ToString());
                for (int i = 0; i < count; ++i)
                {

                    txtBRF.Text = dt.Rows[0]["UnivesityMainList_Name"].ToString();
                    strBRF = dt.Rows[0]["UnivesityMainList_Id"].ToString();
                    cmb_BRF();

                    txtPS.Text = dt.Rows[1]["UnivesityMainList_Name"].ToString();
                    strPS = dt.Rows[1]["UnivesityMainList_Id"].ToString();
                    cmb_PS();

                    txtMC.Text = dt.Rows[2]["UnivesityMainList_Name"].ToString();
                    strMC = dt.Rows[2]["UnivesityMainList_Id"].ToString();
                    cmb_MC();


                    txtAM.Text = dt.Rows[3]["UnivesityMainList_Name"].ToString();
                    strAM = dt.Rows[3]["UnivesityMainList_Id"].ToString();
                    cmb_AM();

                    txtCE.Text = dt.Rows[4]["UnivesityMainList_Name"].ToString();
                    strCE = dt.Rows[4]["UnivesityMainList_Id"].ToString();
                    cmb_CE();
                }                         
            }

        }
        private void NonTechNical()
        {
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("SELECT NonTechMainList_Id,NonTechMainList_Name,(SELECT count(NonTechMainList_Id) AS Count FROM NonTech_Main_List)AS Count FROM NonTech_Main_List");
            if (dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0]["Count"].ToString());
                for (int i = 0; i < count; ++i)
                {

                    txtCO.Text = dt.Rows[0]["NonTechMainList_Name"].ToString();
                    strCO = dt.Rows[0]["NonTechMainList_Id"].ToString();
                    cmb_CO();

                    txtLM.Text = dt.Rows[1]["NonTechMainList_Name"].ToString();
                    strLM = dt.Rows[1]["NonTechMainList_Id"].ToString();
                    cmb_LM();

                    txtSA.Text = dt.Rows[2]["NonTechMainList_Name"].ToString();
                    //strMC = dt.Rows[2]["NonTechMainList_Id"].ToString();
                    //cmb_MC();


                    txtDM.Text = dt.Rows[3]["NonTechMainList_Name"].ToString();
                    //strAM = dt.Rows[3]["NonTechMainList_Id"].ToString();
                    //cmb_AM();

                   
                }
            }

        }
        private void cmb_CO()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechCateList_Id,NonTechCateList_Name,NonTechMainList_Id FROM NonTech_Category_List WHERE NonTechMainList_Id = " + "'" + strCO.ToString() + "'");


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

                cmbCO.BeginUpdate();
                cmbCO.DisplayMember = "NonTechCateList_Name";
                cmbCO.ValueMember = "NonTechCateList_Id";
                cmbCO.DataSource = dt;
                cmbCO.EndUpdate();
                cmbCO.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmb_LM()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechCateList_Id,NonTechCateList_Name,NonTechMainList_Id FROM NonTech_Category_List WHERE NonTechMainList_Id = " + "'" + strLM.ToString() + "'");


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

                cmbLM.BeginUpdate();
                cmbLM.DisplayMember = "NonTechCateList_Name";
                cmbLM.ValueMember = "NonTechCateList_Id";
                cmbLM.DataSource = dt;
                cmbLM.EndUpdate();
                cmbLM.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cmbCO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_SubCO()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT NonTechSecSubList_Id,NonTechSecSubList_Name,NonTechCateList_Id FROM NonTech_SubCategory_List WHERE NonTechCateList_Id = " + "'" + strSubCO.ToString() + "'");


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

                cmbSubCO.BeginUpdate();
                cmbSubCO.DisplayMember = "NonTechSecSubList_Name";
                cmbSubCO.ValueMember = "NonTechSecSubList_Id";
                cmbSubCO.DataSource = dt;
                cmbSubCO.EndUpdate();
                cmbSubCO.SelectedIndex = 0;

            }
           
            Sdr.Close();
        }

        private void cmbCO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                strSubCO = cmbCO.SelectedValue.ToString();
                if (strSubCO != null)
                {
                    //MessageBox.Show(strSubCO.ToString());
                    cmb_SubCO();
                }
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        // order enter textbox
        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                textBox15.Focus();
        }
        private void DataHead()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("AranalysisReport ");

            if (dt.Rows.Count > 0)
            {
                dgvTopic.DataSource = dt;
                //HeadData();                              
            }
            else
            {
                //CheckResult = 0;
                dgvTopic.DataSource = null;

            }

        }
        private void LoadTopic()
        {
            string strsubjectName = "VFR";

            DataTable dt = Class.DBConnString.clsDB.QueryDataTable("ShowTrainingForn " + "'" + strsubjectName + "'");
            
            if (dt.Rows.Count > 0)
            {
                dgvTopic.DataSource = dt;
                //CheckResult = dt.Rows.Count;

                strTopic1 = dt.Rows[0]["TopicId"].ToString();
                strTopic2 = dt.Rows[0]["MappingId"].ToString();

                dgvTopicHead_Format();

               
            }
            else
            {
                
                //CheckResult = 0;
                dgvTopic.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";
        }
        private void dgvTopicHead_Format()
        {
            if (dgvTopic.RowCount > 0)
            {
                

                dgvTopic.Columns[0].HeaderText = "";
                dgvTopic.Columns[1].HeaderText = "";
                dgvTopic.Columns[2].HeaderText = "";
                


                FixColumnWidth_dgv_ViewScheduleHead_Format();


                
                dgvTopic.Columns[0].Visible = false;
                dgvTopic.Columns[1].Visible = false;

            }
        }
       
        private void FixColumnWidth_dgv_ViewScheduleHead_Format()
        {
            int w = dgvTopic.Width;
            dgvTopic.Columns[0].Width = 0;
            dgvTopic.Columns[1].Width = 0;
            dgvTopic.Columns[2].Width = 300;
            

        }

        private void dgvTopic_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int iRow = e.RowIndex;
            DataGridViewRow r = dgvTopic.Rows[iRow];
            string cellValue1 = r.Cells[0].Value.ToString();
            string cellValue2 = r.Cells[1].Value.ToString();
            if (cellValue1 == cellValue2)
            { 
                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                r.DefaultCellStyle.Font = new Font(dgvTopic.Font,FontStyle.Bold);
                r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }
    }
}
