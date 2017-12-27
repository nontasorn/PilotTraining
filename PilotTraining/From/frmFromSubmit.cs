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

        DateTimePicker timepicker = new DateTimePicker();
        Rectangle _Rec;


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

            dtTrainingDate.Value = DateTime.Now;

            dgvTopic.Controls.Add(timepicker);
            timepicker.ShowUpDown = true;
            timepicker.CustomFormat = "mm:ss";
            timepicker.Format = DateTimePickerFormat.Custom;
            timepicker.TextChanged += new EventHandler(timepicker_MouseDown);
            
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
                /*
                // Grade
                string selectQueryStringItem_Grade = "SELECT Grade_Rate,Grade_Name FROM Grade WHERE Grade_Type_ID = 'T1' ORDER BY Grade_Rate";
                SqlDataAdapter sqlDataAdapterItem_Grade = new SqlDataAdapter(selectQueryStringItem_Grade, Conn);
                SqlCommandBuilder sqlCommandBuilderItem_Grade = new SqlCommandBuilder(sqlDataAdapterItem_Grade);

                DataTable dataTableItem_Grade = new DataTable();
                sqlDataAdapterItem_Grade.Fill(dataTableItem_Grade);
                BindingSource bindingSourceItem_Grade = new BindingSource();
                bindingSourceItem_Grade.DataSource = dataTableItem_Grade;
                //Adding  Item ComboBox

                DataGridViewComboBoxColumn ColumnItem_Grade = new DataGridViewComboBoxColumn();
                ColumnItem_Grade.DataPropertyName = "Grade_Rate";
                ColumnItem_Grade.HeaderText = "PF";
                ColumnItem_Grade.Width = 120;

                ColumnItem_Grade.DataSource = bindingSourceItem_Grade;
                ColumnItem_Grade.ValueMember = "Grade_Rate";
                ColumnItem_Grade.DisplayMember = "Grade_Name";

                dgvTopic.Columns.Add(ColumnItem_Grade);

                
                // Grade
                string selectQueryStringItem_GradePM = "SELECT Grade_Rate,Grade_Name FROM Grade WHERE Grade_Type_ID = 'T1' ORDER BY Grade_Rate";
                SqlDataAdapter sqlDataAdapterItem_GradePM = new SqlDataAdapter(selectQueryStringItem_GradePM, Conn);
                SqlCommandBuilder sqlCommandBuilderItem_GradePM = new SqlCommandBuilder(sqlDataAdapterItem_GradePM);

                DataTable dataTableItem_GradePM = new DataTable();
                sqlDataAdapterItem_GradePM.Fill(dataTableItem_GradePM);
                BindingSource bindingSourceItem_GradePM = new BindingSource();
                bindingSourceItem_GradePM.DataSource = dataTableItem_GradePM;
                //Adding  Item ComboBox

                DataGridViewComboBoxColumn ColumnItem_GradePM = new DataGridViewComboBoxColumn();
                ColumnItem_GradePM.DataPropertyName = "Grade_Rate";
                ColumnItem_GradePM.HeaderText = "PM";
                ColumnItem_GradePM.Width = 120;

                ColumnItem_GradePM.DataSource = bindingSourceItem_GradePM;
                ColumnItem_GradePM.ValueMember = "Grade_Rate";
                ColumnItem_GradePM.DisplayMember = "Grade_Name";

                dgvTopic.Columns.Add(ColumnItem_GradePM);
              */
                //--
                
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
                dgvTopic.Columns[5].HeaderText = "Time";
                dgvTopic.Columns[6].HeaderText = "Phase Of Flight";
                FixColumnWidth_dgv_ViewScheduleHead_Format();        
                dgvTopic.Columns[0].Visible = false;
                dgvTopic.Columns[1].Visible = false;
                dgvTopic.Columns[6].DefaultCellStyle.Format = "hh:mm";
            }
        }
       
        private void FixColumnWidth_dgv_ViewScheduleHead_Format()
        {
            int w = dgvTopic.Width;
            dgvTopic.Columns[0].Width = 100;
            dgvTopic.Columns[1].Width = 100;
            dgvTopic.Columns[2].Width = 350;
            dgvTopic.Columns[3].Width = 100;
            dgvTopic.Columns[4].Width = 100;
            dgvTopic.Columns[5].Width = 150;
            dgvTopic.Columns[6].Width = 100;
        }

        private void dgvTopic_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            int iRow = e.RowIndex;
            DataGridViewRow r = dgvTopic.Rows[iRow];
            string cellValue1 = r.Cells["MappingId"].Value.ToString();
            string cellValue2 = r.Cells["TopicId"].Value.ToString();

                if (cellValue1 == cellValue2)
                {

                    r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                    r.DefaultCellStyle.Font = new Font(dgvTopic.Font, FontStyle.Bold);
                    r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                }
                else
                    r.DefaultCellStyle.Font = new Font(dgvTopic.Font, FontStyle.Regular);
            
        }
        private void timepicker_MouseDown(object sender, EventArgs e)
        {
            dgvTopic.CurrentCell.Value = timepicker.Text.ToString();
        }

        private void timepicker_TextChange(object sender, EventArgs e)
        {
            dgvTopic.CurrentCell.Value = timepicker.Text.ToString();

        }

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

                //Adding  Item ComboBox
                string selectQueryStringItem_SubTech = "SELECT NonTechSecSubList_Id,NonTechSecSubList_Name FROM NonTech_SubCategory_List S INNER JOIN NonTech_Category_List C ON C.NonTechCateList_Id = S.NonTechCateList_Id";
                SqlDataAdapter sqlDataAdapterItem_SubTech = new SqlDataAdapter(selectQueryStringItem_SubTech, Conn);
                SqlCommandBuilder sqlCommandBuilderItem_SubTech = new SqlCommandBuilder(sqlDataAdapterItem_SubTech);
                DataTable dataTableItem_SubTech = new DataTable();
                sqlDataAdapterItem_SubTech.Fill(dataTableItem_SubTech);
                BindingSource bindingSourceItem_SubTech = new BindingSource();
                bindingSourceItem_SubTech.DataSource = dataTableItem_SubTech;
                DataGridViewComboBoxColumn ColumnItem_SubTech = new DataGridViewComboBoxColumn();
                ColumnItem_SubTech.DataPropertyName = "SubTech";
                ColumnItem_SubTech.HeaderText = "";
                ColumnItem_SubTech.Width = 120;

                ColumnItem_SubTech.DataSource = bindingSourceItem_SubTech;
                ColumnItem_SubTech.ValueMember = "NonTechSecSubList_Id";
                ColumnItem_SubTech.DisplayMember = "NonTechSecSubList_Name";

                dgvNonTechnicalSkill.Columns.Add(ColumnItem_SubTech);

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
                dgvNonTechnicalSkill.Columns[6].HeaderText = "";
                
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
            dgvNonTechnicalSkill.Columns[6].Width = 200;
        }

        private void LoadUTSkill()
        {

            dt = Class.DBConnString.clsDB.QueryDataTable("UT_Skill");


            if (dt.Rows.Count > 0)
            {

                //strTopic1 = dtTopicDefault.Rows[0]["TopicId"].ToString();
                //strTopic2 = dtTopicDefault.Rows[0]["MappingId"].ToString();
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
            string cellValue1 = r.Cells["UniversityCateList_Id"].Value.ToString();
            //MessageBox.Show(cellValue1);
            if (cellValue1 == "")
            {
                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 255);
                r.DefaultCellStyle.Font = new Font(dgvUT.Font, FontStyle.Bold);
                //r.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            if (e.ColumnIndex == 3)
            {
                setCellString(row, 3);
            }
            if (e.ColumnIndex == 4)
            {
                setCellString(row, 4);

            }
            switch (dgvTopic.Columns[e.ColumnIndex].Name)
            {

                case "Time":

                    _Rec = dgvTopic.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    timepicker.Size = new Size(_Rec.Width, _Rec.Height);
                    timepicker.Location = new Point(_Rec.X, _Rec.Y);
                    timepicker.Visible = true;
                    break;


            }
            
        }
        private void setCellString(DataGridViewRow row, int i)
        {
            
            if (row.Cells[i].Value.ToString() + "" != "")
            {
                if (row.Cells[i].Value.ToString() == Convert.ToInt32(row.Cells[i].Value + "").ToString())
                {
                    row.Cells[i].Value = row.Cells[i].Value.ToString();
                }
                else
                {
                    row.Cells[i].Value = Convert.ToInt32(row.Cells[i].Value + "").ToString();
                }
            }
            else
            {
                row.Cells[i].Value = 0;
            }
             
        }
        

        private void dgvTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDgvRead(e.RowIndex);
        }
        

        private void dgvTopic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
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
            if (e.ColumnIndex == 2)
            {
                setCellString(row, 2);
            }
            if (e.ColumnIndex == 3)
            {
                setCellString(row, 3);

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
                row.Cells[6].ReadOnly = true;

                dgvNonTechnicalSkill.BeginEdit(true);
            }
            catch { }
        }

        private void dgvNonTechnicalSkill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            int iRow = e.RowIndex;
            DataGridViewRow r = dgvNonTechnicalSkill.Rows[iRow];
            string cellValue1 = r.Cells["NonTechCateList_Name"].Value.ToString();
            //string cellValue1 = r.Cells[4].Value.ToString();
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
            }
        }


        
       



    }
}
