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
using System.Globalization;
using System.Threading;

using PilotTraining.Class;



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
        SqlDataAdapter masterDataAdapter;
        SqlDataAdapter detailsDataAdapter;

        string strloginId;      
        string strTopic1, strTopic2;
        decimal sum;
        AutoCompleteStringCollection AcPilotName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection AcPMPilotName = new AutoCompleteStringCollection();

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
            cmb_Form();
            LoadTopic();
            LoadTechnicalSkill();
            LoadUTSkill();
            ACPFPilotName();
            ACPMPilotName();
            txtEmergencyTime.TextBox.Text = DateTime.Now.ToString("HH:mm:ss");
            dtTrainingDate.Value = DateTime.Now;
            
        }
        private void ACPFPilotName()
        {
            string sqlNameAcCustomer = "SELECT Employee_ID,(Employee_SureName+'  '+Employee_LastName) AS PilotName FROM User_Login WHERE Employee_Rule = 'USER' ";
            SqlDataReader dr;
            Cmd = new SqlCommand(sqlNameAcCustomer, Conn);
            dr = Cmd.ExecuteReader();

            // ตรวจสอบว่ามีข้อมูล EmployerName ในตารางหรือไม่
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow drw in dt.Rows)
                {
                    AcPilotName.Add(drw["PilotName"].ToString());
                }
            }
            dr.Close();
            txtSearchPF.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchPF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchPF.AutoCompleteCustomSource = AcPilotName;
        }
        private void ACPMPilotName()
        {
            string sqlNameAcCustomer = "SELECT Employee_ID,(Employee_SureName+'  '+Employee_LastName) AS PilotName FROM User_Login WHERE Employee_Rule = 'USER' ";
            SqlDataReader dr;
            Cmd = new SqlCommand(sqlNameAcCustomer, Conn);
            dr = Cmd.ExecuteReader();

            // ตรวจสอบว่ามีข้อมูล EmployerName ในตารางหรือไม่
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow drw in dt.Rows)
                {
                    AcPMPilotName.Add(drw["PilotName"].ToString());
                }
            }
            dr.Close();
            txtSearchPM.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchPM.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchPM.AutoCompleteCustomSource = AcPMPilotName;
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
       
        private void LoadTopic()
        {

            string strsubjectName = cboTrainingFormName.ComboBox.SelectedValue.ToString();
            

            dtTopicDefault = Class.DBConnString.clsDB.QueryDataTable("ShowMainTopic " + "'" + strsubjectName + "'");
            dtTopicAdd = Class.DBConnString.clsDB.QueryDataTable("ShowAdditionalTopic");


            if (dtTopicDefault.Rows.Count > 0)
            {
                dgvTopic.DataSource = dtTopicDefault;
                
                //CheckResult = dt.Rows.Count;
                strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();


                // add combo box to datagridview
                string selectQueryStringItem = "SELECT FhaseOfFlightId,FhaseOfFlightName FROM PhaseOfFlight";

                SqlDataAdapter sqlDataAdapterItem = new SqlDataAdapter(selectQueryStringItem, Conn);
                SqlCommandBuilder sqlCommandBuilderItem = new SqlCommandBuilder(sqlDataAdapterItem);

                DataTable dataTableItem = new DataTable();
                sqlDataAdapterItem.Fill(dataTableItem);
                BindingSource bindingSourceItem = new BindingSource();
                bindingSourceItem.DataSource = dataTableItem;
                //Adding  Item ComboBox

                DataGridViewComboBoxColumn ColumnItem = new DataGridViewComboBoxColumn();
                ColumnItem.DataPropertyName = "FhaseOfFlightId";
                ColumnItem.HeaderText = "FhaseOfFlightName";
                ColumnItem.Width = 120;

                ColumnItem.DataSource = bindingSourceItem;
                ColumnItem.ValueMember = "FhaseOfFlightId";
                ColumnItem.DisplayMember = "FhaseOfFlightName";

                dgvTopic.Columns.Add(ColumnItem);


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
                dgvTopic.Columns[3].HeaderText = "PF";
                dgvTopic.Columns[4].HeaderText = "PM";
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
            dgvTopic.Columns[2].Width = 600;
            dgvTopic.Columns[3].Width = 100;
            dgvTopic.Columns[4].Width = 100;
        }

        private void dgvTopic_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int iRow = e.RowIndex;
            DataGridViewRow r = dgvTopic.Rows[iRow];
            string cellValue1 = r.Cells[1].Value.ToString();
            string cellValue2 = r.Cells[2].Value.ToString();
           


            if (cellValue1 == cellValue2)
            {

                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                r.DefaultCellStyle.Font = new Font(dgvTopic.Font, FontStyle.Bold);
                r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            }
            else
                r.DefaultCellStyle.Font = new Font(dgvTopic.Font, FontStyle.Regular);

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

                strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();
                dgvUT.DataSource = dt;
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

        private void txtPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in dt.Rows)
                {
                    if (drw["PilotName"].ToString() != "" && drw["PilotName"].ToString() == txtSearchPF.Text.Trim())
                    {
                        txtPFId.Text = drw["Employee_ID"].ToString();
                        return;
                    }
                    txtPFId.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtPM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in dt.Rows)
                {
                    if (drw["PilotName"].ToString() != "" && drw["PilotName"].ToString() == txtSearchPM.Text.Trim())
                    {
                        txtPMId.Text = drw["Employee_ID"].ToString();
                        return;
                    }
                    
                    txtPMId.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void cmb_Form()
        {
            Sbd = new StringBuilder();
            Sbd.Remove(0, Sbd.Length);

            Sbd.Append("SELECT SubSubjectId, SubSubjectName FROM SubSubject");

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

                cboTrainingFormName.BeginUpdate();
                cboTrainingFormName.ComboBox.DisplayMember = "SubSubjectName";
                cboTrainingFormName.ComboBox.ValueMember = "SubSubjectId";
                cboTrainingFormName.ComboBox.DataSource = dt;
                cboTrainingFormName.EndUpdate();
                cboTrainingFormName.SelectedIndex = 0;

            }
            Sdr.Close();
        }

        private void cboTrainingFormName_Click(object sender, EventArgs e)
        {
            LoadTopic();
        }

        // Setting edit datagridview

        private void setDgvRead(int i)
        {
            try
            {
                dgvTopic.ReadOnly = false;
                DataGridViewRow row = dgvTopic.Rows[i];
                row.Cells[0].ReadOnly = true;
                row.Cells[1].ReadOnly = true;
                row.Cells[2].ReadOnly = true;
                row.Cells[3].ReadOnly = false;
                row.Cells[4].ReadOnly = false;
                row.Cells[5].ReadOnly = true;
                row.Cells[6].ReadOnly = true;
                row.Cells[7].ReadOnly = true;
                dgvTopic.BeginEdit(true);
            }
            catch { }
        }

        private void dgvTopic_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTopic.Rows[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                setCellString(row, 4);
            }
            if (e.ColumnIndex == 5)
            {
                setCellString(row, 5);

            }

            


            //MessageBox.Show("test");
        }
        private void setCellString(DataGridViewRow row, int i)
        {
            if (row.Cells[i].Value.ToString() + "" != "")
            {
                if (row.Cells[i].Value.ToString() == Convert.ToDouble(row.Cells[i].Value + "").ToString("N2"))
                {
                    row.Cells[i].Value = row.Cells[i].Value.ToString();
                }
                else
                {
                    row.Cells[i].Value = Convert.ToDouble(row.Cells[i].Value + "").ToString("N2");
                }
            }
            else
            {
                row.Cells[i].Value = 0.00;
            }
        }
        private void SetTxtTotalScore(DataGridViewRow dgv)
        {
            /*
            Double UnitPrice = (row.Cells[7].Value + "" == "" ? 0.00 : Convert.ToDouble(row.Cells[7].Value)); // New Unit Price
            Double Qty = (row.Cells[4].Value + "" == "" ? 0.00 : Convert.ToDouble(row.Cells[4].Value)); // Qty
            Double Total = (UnitPrice * Qty); // New Total after additional debit
            row.Cells[8].Value = Total.ToString();
            lbldrow.Text = row.Cells[1].Value.ToString();

            //Calculated the sum of after additional debit
            Double sumAfter = 0;
            for (int i = 0; i < dgvTopic.Rows.Count; ++i)
            {
                sumAfter += Convert.ToDouble(dgvTopic.Rows[i].Cells[8].Value);
            }
            lblTotalAfter.Text = sumAfter.ToString("#,##0.00");

            // Calculated the additional Debit
            Double AddDebit = Convert.ToDouble(lblTotalAfter.Text) - Convert.ToDouble(lblTotalBefore.Text);
            lblAddDebit.Text = AddDebit.ToString("#,##0.00");
            */
            /*
            foreach (DataGridViewRow grdRows in dgvNonTechnicalSkill.Rows)
            { 
                if(grdRows.Cells["NonTechMainList_Id"].Value.Equals("NT000001"))
                    if(grdRows.Cells["PFSub"].Value != DBNull.Value)
 
                    sum += Convert.ToInt32(grdRows.Cells["PFSub"].Value);
                MessageBox.Show(sum.ToString());
            }
             * */
            
            int SumCount = 0;
            int AllSumCount = 0;
            string strNonTechMainList_Id;
            int i = 0;
            for (i = AllSumCount; i < dgvNonTechnicalSkill.Rows.Count - 1; i++)
            {
                strNonTechMainList_Id = dgvNonTechnicalSkill.Rows[i].Cells["NonTechMainList_Id"].Value.ToString();
                MessageBox.Show("i=  "+i.ToString());
                AllSumCount += (SumCount + i);
                MessageBox.Show("AllSumCount=  "+AllSumCount.ToString());
                

                MessageBox.Show(dgvNonTechnicalSkill.Rows[i].Cells["NonTechMainList_Id"].Value.ToString().Trim() + "    " + dgvNonTechnicalSkill.Rows[i].Cells["NonTechCateList_Id"].Value.ToString().Trim());
                SumCount = Convert.ToInt32(dgvNonTechnicalSkill.Rows[i + 1].Cells["SumCount"].Value);
                if (dgvNonTechnicalSkill.Rows[i].Cells["NonTechMainList_Id"].Value.ToString().Trim() == dgvNonTechnicalSkill.Rows[i].Cells["NonTechCateList_Id"].Value.ToString().Trim())
                {
                    
                    for (int j = 0; j < SumCount; j++)
                    {
                        MessageBox.Show("j=  "+j.ToString());
                        MessageBox.Show("Grade=  "+dgvNonTechnicalSkill.Rows[j + 1].Cells["PFSub"].Value.ToString());

                        sum += Convert.ToDecimal(dgvNonTechnicalSkill.Rows[j + 1].Cells["PFSub"].Value.ToString());
                       MessageBox.Show("SumGrade=  "+sum.ToString());
                    }
                    txtPFId.Text = sum.ToString();
                }
                else {
                    MessageBox.Show("111");
              }
                

            }
            
            
            
             
        }

        private void dgvTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDgvRead(e.RowIndex);
        }
        

        private void dgvTopic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void BtnRefreshTime_Click(object sender, EventArgs e)
        {
            txtEmergencyTime.TextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            string strPFId , strPFName;
            string strPMId , strPMName;

            // Change PM
            strPFId = txtPFId.Text.Trim();
            strPFName = txtSearchPF.Text.Trim();
            strPMId = txtPMId.Text.Trim();
            strPMName = txtSearchPM.Text.Trim();

            txtPMId.Text = strPFId;
            txtSearchPM.Text = strPFName;

            txtPFId.Text = strPMId;
            txtSearchPF.Text = strPMName;

            
        }

        private void dgvNonTechnicalSkill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNonTechnicalSkill.Rows[e.RowIndex];
            if (e.ColumnIndex == 6)
            {
                setCellString(row, 6);
            }
            if (e.ColumnIndex == 7)
            {
                setCellString(row, 7);

            }
            //SetTxtTotalScore(row);




            //MessageBox.Show("test");
        }

        private void dgvNonTechnicalSkill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDgvTechnicalSkillRead(e.RowIndex);
        }

        private void setDgvTechnicalSkillRead(int i)
        {
            try
            {
                dgvNonTechnicalSkill.ReadOnly = false;
                DataGridViewRow row = dgvNonTechnicalSkill.Rows[i];
                row.Cells[0].ReadOnly = true;
                row.Cells[1].ReadOnly = true;
                row.Cells[2].ReadOnly = false;
                row.Cells[3].ReadOnly = false;
                row.Cells[4].ReadOnly = true;
                row.Cells[5].ReadOnly = true;
                row.Cells[6].ReadOnly = false;
                row.Cells[7].ReadOnly = false;

                dgvNonTechnicalSkill.BeginEdit(true);
            }
            catch { }
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
            
        
        }

        private void dgvTopic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                MessageBox.Show("mess");
            }
        }

        
       



    }
}
