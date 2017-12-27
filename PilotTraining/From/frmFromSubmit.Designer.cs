namespace PilotTraining.From
{
    partial class frmFromSubmit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFromSubmit));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbltrainingName = new System.Windows.Forms.ToolStripLabel();
            this.cboTrainingFormName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Create_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvTopic = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNonTechnicalSkill = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUT = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.eToolTip1 = new AdvancedControls.eToolTip();
            this.dropDownPanel1 = new ScrewTurn.DropDownPanel();
            this.dtTrainingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.txtPMId = new System.Windows.Forms.TextBox();
            this.txtPFId = new System.Windows.Forms.TextBox();
            this.txtSearchPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonTechnicalSkill)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUT)).BeginInit();
            this.dropDownPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltrainingName,
            this.cboTrainingFormName,
            this.toolStripSeparator1,
            this.Create_Course_Btn,
            this.Edit_Course_Btn,
            this.Refresh_btn,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1240, 39);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "                                                                ";
            // 
            // lbltrainingName
            // 
            this.lbltrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrainingName.Name = "lbltrainingName";
            this.lbltrainingName.Size = new System.Drawing.Size(108, 36);
            this.lbltrainingName.Text = "Training Form :";
            // 
            // cboTrainingFormName
            // 
            this.cboTrainingFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboTrainingFormName.Name = "cboTrainingFormName";
            this.cboTrainingFormName.Size = new System.Drawing.Size(121, 39);
            this.cboTrainingFormName.Click += new System.EventHandler(this.cboTrainingFormName_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Create_Course_Btn
            // 
            this.Create_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Course_Btn.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Course_Btn.Name = "Create_Course_Btn";
            this.Create_Course_Btn.Size = new System.Drawing.Size(77, 36);
            this.Create_Course_Btn.Text = "Save";
            // 
            // Edit_Course_Btn
            // 
            this.Edit_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Course_Btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Course_Btn.Name = "Edit_Course_Btn";
            this.Edit_Course_Btn.Size = new System.Drawing.Size(69, 36);
            this.Edit_Course_Btn.Text = "Edit";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Refresh_btn.Image = global::PilotTraining.Properties.Resources.refresh;
            this.Refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(96, 36);
            this.Refresh_btn.Text = "Refresh";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // dgvTopic
            // 
            this.dgvTopic.AllowUserToAddRows = false;
            this.dgvTopic.AllowUserToDeleteRows = false;
            this.dgvTopic.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopic.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTopic.Location = new System.Drawing.Point(3, 17);
            this.dgvTopic.MultiSelect = false;
            this.dgvTopic.Name = "dgvTopic";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTopic.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopic.Size = new System.Drawing.Size(858, 180);
            this.dgvTopic.TabIndex = 9;
            this.dgvTopic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopic_CellEndEdit);
            this.dgvTopic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopic_CellContentClick);
            this.dgvTopic.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopic_CellEndEdit);
            this.dgvTopic.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTopic_CellFormatting_1);
            this.dgvTopic.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTopic_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dropDownPanel1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 206);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvTopic);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOPIC";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvNonTechnicalSkill);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1234, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NON-TECHNICAL SKILLS";
            this.groupBox3.Resize += new System.EventHandler(this.groupBox3_Resize);
            // 
            // dgvNonTechnicalSkill
            // 
            this.dgvNonTechnicalSkill.AllowUserToAddRows = false;
            this.dgvNonTechnicalSkill.AllowUserToDeleteRows = false;
            this.dgvNonTechnicalSkill.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvNonTechnicalSkill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNonTechnicalSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonTechnicalSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNonTechnicalSkill.EnableHeadersVisualStyles = false;
            this.dgvNonTechnicalSkill.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvNonTechnicalSkill.Location = new System.Drawing.Point(3, 17);
            this.dgvNonTechnicalSkill.MultiSelect = false;
            this.dgvNonTechnicalSkill.Name = "dgvNonTechnicalSkill";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNonTechnicalSkill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNonTechnicalSkill.RowHeadersVisible = false;
            this.dgvNonTechnicalSkill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNonTechnicalSkill.Size = new System.Drawing.Size(1228, 116);
            this.dgvNonTechnicalSkill.TabIndex = 10;
            this.dgvNonTechnicalSkill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNonTechnicalSkill_CellClick);
            this.dgvNonTechnicalSkill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNonTechnicalSkill_CellEndEdit);
            this.dgvNonTechnicalSkill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNonTechnicalSkill_CellFormatting);
            this.dgvNonTechnicalSkill.Resize += new System.EventHandler(this.dgvNonTechnicalSkill_Resize);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvUT);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox4.Location = new System.Drawing.Point(3, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1234, 158);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UNIVERSITY OF TEXAS  MARKERS";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgvUT
            // 
            this.dgvUT.AllowUserToAddRows = false;
            this.dgvUT.AllowUserToDeleteRows = false;
            this.dgvUT.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUT.ColumnHeadersVisible = false;
            this.dgvUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUT.EnableHeadersVisualStyles = false;
            this.dgvUT.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUT.Location = new System.Drawing.Point(3, 17);
            this.dgvUT.MultiSelect = false;
            this.dgvUT.Name = "dgvUT";
            this.dgvUT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUT.RowHeadersVisible = false;
            this.dgvUT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUT.Size = new System.Drawing.Size(1228, 138);
            this.dgvUT.TabIndex = 11;
            this.dgvUT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUT_CellFormatting);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // eToolTip1
            // 
            this.eToolTip1.AutoPopDelay = 5000;
            this.eToolTip1.AutoSize = true;
            this.eToolTip1.BackgroundImage = null;
            this.eToolTip1.DescriptionColor = System.Drawing.Color.Black;
            this.eToolTip1.DescriptionFont = new System.Drawing.Font("Times New Roman", 10F);
            this.eToolTip1.ForeColor = System.Drawing.Color.Empty;
            this.eToolTip1.InitialDelay = 1;
            this.eToolTip1.MaxWidth = 0;
            this.eToolTip1.ReshowDelay = 500;
            this.eToolTip1.ShowAlways = true;
            this.eToolTip1.Size = new System.Drawing.Size(100, 70);
            this.eToolTip1.TitleColor = System.Drawing.Color.Black;
            this.eToolTip1.TitleFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.eToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.eToolTip1.ToolTipTitle = "";
            // 
            // dropDownPanel1
            // 
            this.dropDownPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownPanel1.AutoCollapseDelay = -1;
            this.dropDownPanel1.Controls.Add(this.dtTrainingDate);
            this.dropDownPanel1.Controls.Add(this.label2);
            this.dropDownPanel1.Controls.Add(this.BtnSwap);
            this.dropDownPanel1.Controls.Add(this.txtPMId);
            this.dropDownPanel1.Controls.Add(this.txtPFId);
            this.dropDownPanel1.Controls.Add(this.txtSearchPM);
            this.dropDownPanel1.Controls.Add(this.label1);
            this.dropDownPanel1.Controls.Add(this.txtSearchPF);
            this.dropDownPanel1.Controls.Add(this.label3);
            this.dropDownPanel1.EnableHeaderMenu = true;
            this.dropDownPanel1.ExpandAnimationSpeed = ScrewTurn.AnimationSpeed.Medium;
            this.dropDownPanel1.Expanded = true;
            this.dropDownPanel1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dropDownPanel1.HeaderHeight = 20;
            this.dropDownPanel1.HeaderIconNormal = null;
            this.dropDownPanel1.HeaderIconOver = null;
            this.dropDownPanel1.HeaderText = "Pilot Information";
            this.dropDownPanel1.HomeLocation = new System.Drawing.Point(870, 15);
            this.dropDownPanel1.HotTrackStyle = ScrewTurn.HotTrackStyle.Both;
            this.dropDownPanel1.Location = new System.Drawing.Point(870, 15);
            this.dropDownPanel1.ManageControls = false;
            this.dropDownPanel1.Moveable = false;
            this.dropDownPanel1.Name = "dropDownPanel1";
            this.dropDownPanel1.RoundedCorners = true;
            this.dropDownPanel1.Size = new System.Drawing.Size(358, 182);
            this.dropDownPanel1.TabIndex = 12;
            // 
            // dtTrainingDate
            // 
            this.dtTrainingDate.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dtTrainingDate.Location = new System.Drawing.Point(149, 30);
            this.dtTrainingDate.Name = "dtTrainingDate";
            this.dtTrainingDate.Size = new System.Drawing.Size(200, 26);
            this.dtTrainingDate.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 137;
            this.label2.Text = "Training Date  :";
            // 
            // BtnSwap
            // 
            this.BtnSwap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSwap.BackgroundImage")));
            this.BtnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSwap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwap.Location = new System.Drawing.Point(279, 130);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(70, 42);
            this.BtnSwap.TabIndex = 136;
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // txtPMId
            // 
            this.txtPMId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPMId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPMId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPMId.ForeColor = System.Drawing.Color.Red;
            this.txtPMId.Location = new System.Drawing.Point(61, 98);
            this.txtPMId.Name = "txtPMId";
            this.txtPMId.ReadOnly = true;
            this.txtPMId.Size = new System.Drawing.Size(82, 27);
            this.txtPMId.TabIndex = 135;
            this.txtPMId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPFId
            // 
            this.txtPFId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPFId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPFId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFId.ForeColor = System.Drawing.Color.Red;
            this.txtPFId.Location = new System.Drawing.Point(61, 64);
            this.txtPFId.Name = "txtPFId";
            this.txtPFId.ReadOnly = true;
            this.txtPFId.Size = new System.Drawing.Size(82, 27);
            this.txtPFId.TabIndex = 134;
            this.txtPFId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchPM
            // 
            this.txtSearchPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPM.Location = new System.Drawing.Point(149, 98);
            this.txtSearchPM.Name = "txtSearchPM";
            this.txtSearchPM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchPM.Size = new System.Drawing.Size(200, 26);
            this.txtSearchPM.TabIndex = 133;
            this.txtSearchPM.TextChanged += new System.EventHandler(this.txtPM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 132;
            this.label1.Text = "PM  :";
            // 
            // txtSearchPF
            // 
            this.txtSearchPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPF.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPF.Location = new System.Drawing.Point(149, 64);
            this.txtSearchPF.Name = "txtSearchPF";
            this.txtSearchPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchPF.Size = new System.Drawing.Size(200, 26);
            this.txtSearchPF.TabIndex = 131;
            this.txtSearchPF.TextChanged += new System.EventHandler(this.txtPF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 130;
            this.label3.Text = "PF  :";
            // 
            // frmFromSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1240, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmFromSubmit";
            this.Text = "frmFromSubmit";
            this.Load += new System.EventHandler(this.frmFromSubmit_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonTechnicalSkill)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUT)).EndInit();
            this.dropDownPanel1.ResumeLayout(false);
            this.dropDownPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Course_Btn;
        private System.Windows.Forms.ToolStripButton Edit_Course_Btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.DataGridView dgvTopic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private AdvancedControls.eToolTip eToolTip1;
        private ScrewTurn.DropDownPanel dropDownPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNonTechnicalSkill;
        private System.Windows.Forms.DataGridView dgvUT;
        private System.Windows.Forms.TextBox txtSearchPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPMId;
        private System.Windows.Forms.TextBox txtPFId;
        private System.Windows.Forms.ToolStripLabel lbltrainingName;
        private System.Windows.Forms.ToolStripComboBox cboTrainingFormName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTrainingDate;
    }
}