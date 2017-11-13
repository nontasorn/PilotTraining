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
            
            
            LoadTopic();
            LoadTechnicalSkill();
            LoadUTSkill();
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
                dgvTopic.Columns[3].HeaderText = "";
                dgvTopic.Columns[4].HeaderText = ""; 
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
            dgvTopic.Columns[2].Width = 522;
            dgvTopic.Columns[3].Width = 150;
            dgvTopic.Columns[4].Width = 150;
           
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

                dgvTechnicalSkillHead_Format();


            }
            else
            {

                //CheckResult = 0;
                dgvNonTechnicalSkill.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";

        }

        private void dgvTechnicalSkillHead_Format()
        {
            if (dgvNonTechnicalSkill.RowCount > 0)
            {
                dgvNonTechnicalSkill.Columns[0].HeaderText = "";
                dgvNonTechnicalSkill.Columns[1].HeaderText = "";
                dgvNonTechnicalSkill.Columns[2].HeaderText = "PF";
                dgvNonTechnicalSkill.Columns[3].HeaderText = "PM";
                dgvNonTechnicalSkill.Columns[4].HeaderText = "";
                dgvNonTechnicalSkill.Columns[5].HeaderText = "";
                dgvNonTechnicalSkill.Columns[6].HeaderText = "PF";
                dgvNonTechnicalSkill.Columns[7].HeaderText = "PM";
                
                FixColumnWidth_dgvTechnicalSkill_Format();
                dgvNonTechnicalSkill.Columns[0].Visible = false;
                dgvNonTechnicalSkill.Columns[4].Visible = false;
                
            }
        }

        private void FixColumnWidth_dgvTechnicalSkill_Format()
        {
            int w = dgvNonTechnicalSkill.Width;
           
            dgvNonTechnicalSkill.Columns[1].Width = 414;
            dgvNonTechnicalSkill.Columns[2].Width = 100;
            dgvNonTechnicalSkill.Columns[3].Width = 100;
            
            dgvNonTechnicalSkill.Columns[5].Width = 414;
            dgvNonTechnicalSkill.Columns[6].Width = 100;
            dgvNonTechnicalSkill.Columns[7].Width = 100;
        }

        private void LoadUTSkill()
        {

            dt = Class.DBConnString.clsDB.QueryDataTable("UT_Skill");


            if (dt.Rows.Count > 0)
            {
                dgvUT.DataSource = dt;
                //CheckResult = dt.Rows.Count;
                //strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                //strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();

                dgvUTSkillHead_Format();


            }
            else
            {

                //CheckResult = 0;
                dgvUT.DataSource = null;
            }
            //Count.Text = CheckResult.ToString() + "  รายการ";

        }

        private void dgvUTSkillHead_Format()
        {
            if (dgvUT.RowCount > 0)
            {
                dgvUT.Columns[0].HeaderText = "";
                dgvUT.Columns[1].HeaderText = "";
                dgvUT.Columns[2].HeaderText = "";
                dgvUT.Columns[3].HeaderText = "";
                dgvUT.Columns[4].HeaderText = "";
                dgvUT.Columns[5].HeaderText = "";
                dgvUT.Columns[6].HeaderText = "";
                dgvUT.Columns[7].HeaderText = "";

                FixColumnWidth_dgvUTSkill_Format();
                dgvUT.Columns[0].Visible = false;
                dgvUT.Columns[4].Visible = false;

            }
        }

        private void FixColumnWidth_dgvUTSkill_Format()
        {
            int w = dgvUT.Width;

            dgvUT.Columns[1].Width = 414;
            dgvUT.Columns[2].Width = 100;
            dgvUT.Columns[3].Width = 100;

            dgvUT.Columns[5].Width = 414;
            dgvUT.Columns[6].Width = 100;
            dgvUT.Columns[7].Width = 100;
        }

        private void dgvNonTechnicalSkill_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgvTechnicalSkill_Format();
        }

        private void groupBox3_Resize(object sender, EventArgs e)
        {
            FixColumnWidth_dgvTechnicalSkill_Format();
        }

        private void dgvNonTechnicalSkill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int iRow = e.RowIndex;
            DataGridViewRow r = dgvNonTechnicalSkill.Rows[iRow];
            string cellValue1 = r.Cells[4].Value.ToString();
           //MessageBox.Show(cellValue1);
            if (cellValue1 == "")
            {
                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                r.DefaultCellStyle.Font = new Font(dgvNonTechnicalSkill.Font, FontStyle.Bold);
                //r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            if ((e.ColumnIndex == this.dgvNonTechnicalSkill.Columns["PF"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.dgvNonTechnicalSkill.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //MessageBox.Show(e.Value.ToString());
                if (e.Value.ToString() == "0.00")
                {
                    cell.ToolTipText = "very bad";

                }
                else
                {
                    MessageBox.Show("no");
                }
                
            }


            


        }

        private void dgvUT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int iRow = e.RowIndex;
            DataGridViewRow r = dgvUT.Rows[iRow];
            string cellValue1 = r.Cells[4].Value.ToString();
            //MessageBox.Show(cellValue1);
            if (cellValue1 == "")
            {
                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                r.DefaultCellStyle.Font = new Font(dgvUT.Font, FontStyle.Bold);
                //r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            if ((e.ColumnIndex == this.dgvUT.Columns["PF"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.dgvUT.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (e.Value.Equals("0.00"))
                {
                    cell.ToolTipText = "very bad";
                }

            }


        }


    }
}
