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
        DataTable dtTopicDefault = new DataTable();
        DataTable dtTopicAdd = new DataTable();
        DataTable dt;

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
            
            LoadTopic();
            LoadTopic();
            LoadTechnicalSkill();
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
       
        

        

        private void cmbCO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

       
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        // order enter textbox
        /*private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                textBox15.Focus();
        }
         * */
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
            /*
            string strsubjectName = "VFR";

            
            SqlCommand cmd = new SqlCommand("ShowTrainingForn", Conn); // Change from STATEMENT_SHOWDEBTOR_FOR_CLEAR to STATEMENT
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubjectName", SqlDbType.NVarChar).Value = strsubjectName;

            DataTable master = new DataTable();
            DataTable child = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(master);

            
            SqlCommand cmd2 = new SqlCommand("ShowTrainingFormAdditional", Conn); // Change from STATEMENT_SHOWDEBTOR_FOR_CLEAR to STATEMENT
            cmd.CommandType = CommandType.StoredProcedure;
            

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da.Fill(child);

            DataSet ds = new DataSet();
           


            //Add two DataTables  in Dataset 

            ds.Tables.Add(master);
            ds.Tables.Add(child);



            // Create a Relation in Memory 

            /*DataRelation relation = new DataRelation("", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0], true);

            ds.Relations.Add(relation);*/

            // Set DataSource
            //dgvTopic.DataSource = ds.Tables[0];
            



            
            string strsubjectName = "VFR";

            dtTopicDefault = Class.DBConnString.clsDB.QueryDataTable("ShowTrainingForn " + "'" + strsubjectName + "'");
            dtTopicAdd = Class.DBConnString.clsDB.QueryDataTable("ShowTrainingFormAdditional");          

            if (dtTopicDefault.Rows.Count > 0)
            {
                dgvTopic.DataSource = dtTopicDefault;
                //CheckResult = dt.Rows.Count;
                strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();

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
            dgvTopic.Columns[0].Width = 100;
            dgvTopic.Columns[1].Width = 100;
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

        /*

        private void textBox15_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox15, "Tooltip text"); 
        }
         * */

        private void cmbSubCO_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            //toolTip1.SetToolTip(cmbSubCO, "Establishes atmosphere for open communication and participation");
            int i;
            
            //strings with different lengths 
            string[] arr = { "b1", "book1", "gudbooks", "bok2", "Books", "braveBooks", "dontumindit", "myStuff", "haythatscool,iloveit", "Really" };
            int maxlen = 0;
 
            // calculating maximum length only for 1st cell items
            // that is items on all even places in array
            for (i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    if (maxlen < arr[i].Length)
                        maxlen = arr[i].Length;

            }
            //MessageBox.Show(maxlen.ToString());
            // Minimum No of Tabs which wil be added to maximum length cell
            int minimumTabSpace = 2;
 
            //getting Number of Tabs To overcome maxlength text
            int noOftabs = (maxlen / 8) + minimumTabSpace;
            string ToolTipText = "";
 


            for (i = 0; i < arr.Length; i++)
            {                
                ToolTipText += arr[i];
                if (i % 2 != 0)
                {
                    //Insering New Line After every Two Cells
                    ToolTipText += Environment.NewLine;
                }
                else
                {
                    //Determining no. of Tabs for each Row
                    //and inserting after 1st cell of each Row
                    int j;
                    for (j = 0; j < noOftabs - (arr[i].Length / 8) ; j++)
                        ToolTipText += "\t";
                    
                }
            }
            toolTip1.SetToolTip(cmbSubCO, ToolTipText);
        */
            
            
        }

        private void cmbSubLM_MouseMove(object sender, MouseEventArgs e)
        {

            toolTip1.ToolTipTitle = "GOOD PRACTICE";


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoadTechnicalSkill()
        {

            dt = Class.DBConnString.clsDB.QueryDataTable("ShowNonTechnicalSkill");
            

            if (dt.Rows.Count > 0)
            {
                dgvNonTechnicalSkill.DataSource = dt;
                //CheckResult = dt.Rows.Count;
                //strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                //strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();

                //dgvTopicHead_Format();


            }
            else
            {

                //CheckResult = 0;
                dgvNonTechnicalSkill.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";

        }
    }
}
