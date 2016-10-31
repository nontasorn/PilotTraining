namespace PilotTraining.Fundamental
{
    partial class Course_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.dgv_SelectModules = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SelectModules = new System.Windows.Forms.Button();
            this.txt_CourseDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_Modules = new System.Windows.Forms.Panel();
            this.lbSumList = new System.Windows.Forms.Label();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnOKSelect = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.dgv_Modules = new System.Windows.Forms.DataGridView();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Course_View = new System.Windows.Forms.DataGridView();
            this.dgv_Course_Modules_View = new System.Windows.Forms.DataGridView();
            this.lbl_Course_Count = new System.Windows.Forms.Label();
            this.lbl_Course_Modules = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectModules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pn_Modules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_Modules_View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Course_Btn,
            this.Edit_Course_Btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1084, 39);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Course_Btn
            // 
            this.Create_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Course_Btn.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Course_Btn.Name = "Create_Course_Btn";
            this.Create_Course_Btn.Size = new System.Drawing.Size(141, 36);
            this.Create_Course_Btn.Text = "Create Course";
            this.Create_Course_Btn.Click += new System.EventHandler(this.Create_Course_Btn_Click);
            // 
            // Edit_Course_Btn
            // 
            this.Edit_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Course_Btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Course_Btn.Name = "Edit_Course_Btn";
            this.Edit_Course_Btn.Size = new System.Drawing.Size(122, 36);
            this.Edit_Course_Btn.Text = "Edit Course";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Refresh_btn.Image = global::PilotTraining.Properties.Resources.refresh;
            this.Refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(96, 36);
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // dgv_SelectModules
            // 
            this.dgv_SelectModules.AllowUserToAddRows = false;
            this.dgv_SelectModules.AllowUserToDeleteRows = false;
            this.dgv_SelectModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SelectModules.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_SelectModules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectModules.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_SelectModules.Location = new System.Drawing.Point(0, 87);
            this.dgv_SelectModules.MultiSelect = false;
            this.dgv_SelectModules.Name = "dgv_SelectModules";
            this.dgv_SelectModules.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_SelectModules.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SelectModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectModules.Size = new System.Drawing.Size(1084, 220);
            this.dgv_SelectModules.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_SelectModules);
            this.groupBox1.Controls.Add(this.txt_CourseDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pn_Modules);
            this.groupBox1.Controls.Add(this.txt_CourseName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_SelectModules);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 315);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(497, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(60, 26);
            this.textBox1.TabIndex = 130;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SelectModules
            // 
            this.btn_SelectModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_SelectModules.Location = new System.Drawing.Point(679, 49);
            this.btn_SelectModules.Name = "btn_SelectModules";
            this.btn_SelectModules.Size = new System.Drawing.Size(127, 26);
            this.btn_SelectModules.TabIndex = 129;
            this.btn_SelectModules.Text = "Select Modules";
            this.btn_SelectModules.UseVisualStyleBackColor = true;
            this.btn_SelectModules.Click += new System.EventHandler(this.btn_SelectModules_Click);
            // 
            // txt_CourseDescription
            // 
            this.txt_CourseDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseDescription.Location = new System.Drawing.Point(222, 49);
            this.txt_CourseDescription.Name = "txt_CourseDescription";
            this.txt_CourseDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseDescription.Size = new System.Drawing.Size(451, 26);
            this.txt_CourseDescription.TabIndex = 128;
            this.txt_CourseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 127;
            this.label2.Text = "Course Description :";
            // 
            // pn_Modules
            // 
            this.pn_Modules.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_Modules.Controls.Add(this.lbSumList);
            this.pn_Modules.Controls.Add(this.btnCancelSelect);
            this.pn_Modules.Controls.Add(this.btnOKSelect);
            this.pn_Modules.Controls.Add(this.btnExitMain);
            this.pn_Modules.Controls.Add(this.dgv_Modules);
            this.pn_Modules.Location = new System.Drawing.Point(222, 88);
            this.pn_Modules.Name = "pn_Modules";
            this.pn_Modules.Size = new System.Drawing.Size(565, 214);
            this.pn_Modules.TabIndex = 129;
            // 
            // lbSumList
            // 
            this.lbSumList.AutoSize = true;
            this.lbSumList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumList.Location = new System.Drawing.Point(110, 21);
            this.lbSumList.Name = "lbSumList";
            this.lbSumList.Size = new System.Drawing.Size(116, 16);
            this.lbSumList.TabIndex = 139;
            this.lbSumList.Text = "Count Modules : ";
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelSelect.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelSelect.Image = global::PilotTraining.Properties.Resources.wrong;
            this.btnCancelSelect.Location = new System.Drawing.Point(59, 9);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(35, 35);
            this.btnCancelSelect.TabIndex = 138;
            this.btnCancelSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelSelect.UseVisualStyleBackColor = false;
            this.btnCancelSelect.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // btnOKSelect
            // 
            this.btnOKSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.btnOKSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOKSelect.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOKSelect.Image = global::PilotTraining.Properties.Resources.select1;
            this.btnOKSelect.Location = new System.Drawing.Point(18, 9);
            this.btnOKSelect.Name = "btnOKSelect";
            this.btnOKSelect.Size = new System.Drawing.Size(35, 35);
            this.btnOKSelect.TabIndex = 137;
            this.btnOKSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOKSelect.UseVisualStyleBackColor = false;
            this.btnOKSelect.Click += new System.EventHandler(this.btnOKSelect_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitMain.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnExitMain.Image = global::PilotTraining.Properties.Resources.delete;
            this.btnExitMain.Location = new System.Drawing.Point(541, 3);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(24, 24);
            this.btnExitMain.TabIndex = 136;
            this.btnExitMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // dgv_Modules
            // 
            this.dgv_Modules.AllowUserToAddRows = false;
            this.dgv_Modules.AllowUserToDeleteRows = false;
            this.dgv_Modules.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Modules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Modules.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Modules.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Modules.Location = new System.Drawing.Point(18, 50);
            this.dgv_Modules.Name = "dgv_Modules";
            this.dgv_Modules.RowHeadersVisible = false;
            this.dgv_Modules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Modules.Size = new System.Drawing.Size(530, 149);
            this.dgv_Modules.TabIndex = 134;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseName.Location = new System.Drawing.Point(222, 14);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseName.Size = new System.Drawing.Size(269, 26);
            this.txt_CourseName.TabIndex = 126;
            this.txt_CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Course Name :";
            // 
            // dgv_Course_View
            // 
            this.dgv_Course_View.AllowUserToAddRows = false;
            this.dgv_Course_View.AllowUserToDeleteRows = false;
            this.dgv_Course_View.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_Course_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Course_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_View.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_Course_View.Location = new System.Drawing.Point(2, 382);
            this.dgv_Course_View.MultiSelect = false;
            this.dgv_Course_View.Name = "dgv_Course_View";
            this.dgv_Course_View.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Course_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Course_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Course_View.Size = new System.Drawing.Size(896, 230);
            this.dgv_Course_View.TabIndex = 130;
            this.dgv_Course_View.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Course_View_CellMouseUp);
            // 
            // dgv_Course_Modules_View
            // 
            this.dgv_Course_Modules_View.AllowUserToAddRows = false;
            this.dgv_Course_Modules_View.AllowUserToDeleteRows = false;
            this.dgv_Course_Modules_View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Course_Modules_View.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_Course_Modules_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Course_Modules_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_Modules_View.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_Course_Modules_View.Location = new System.Drawing.Point(904, 382);
            this.dgv_Course_Modules_View.MultiSelect = false;
            this.dgv_Course_Modules_View.Name = "dgv_Course_Modules_View";
            this.dgv_Course_Modules_View.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Course_Modules_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Course_Modules_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Course_Modules_View.Size = new System.Drawing.Size(174, 230);
            this.dgv_Course_Modules_View.TabIndex = 131;
            // 
            // lbl_Course_Count
            // 
            this.lbl_Course_Count.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Course_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Course_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Course_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Course_Count.Location = new System.Drawing.Point(2, 360);
            this.lbl_Course_Count.Name = "lbl_Course_Count";
            this.lbl_Course_Count.Size = new System.Drawing.Size(126, 19);
            this.lbl_Course_Count.TabIndex = 132;
            this.lbl_Course_Count.Text = "Courses : ";
            this.lbl_Course_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Course_Modules
            // 
            this.lbl_Course_Modules.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Course_Modules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Course_Modules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Course_Modules.ForeColor = System.Drawing.Color.White;
            this.lbl_Course_Modules.Location = new System.Drawing.Point(904, 360);
            this.lbl_Course_Modules.Name = "lbl_Course_Modules";
            this.lbl_Course_Modules.Size = new System.Drawing.Size(108, 19);
            this.lbl_Course_Modules.TabIndex = 133;
            this.lbl_Course_Modules.Text = "Modules :";
            this.lbl_Course_Modules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Course_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.lbl_Course_Modules);
            this.Controls.Add(this.lbl_Course_Count);
            this.Controls.Add(this.dgv_Course_Modules_View);
            this.Controls.Add(this.dgv_Course_View);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Course_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course_Management";
            this.Load += new System.EventHandler(this.Course_Management_Load);
            this.Resize += new System.EventHandler(this.Course_Management_Resize);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectModules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_Modules.ResumeLayout(false);
            this.pn_Modules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_Modules_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Course_Btn;
        private System.Windows.Forms.ToolStripButton Edit_Course_Btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.DataGridView dgv_SelectModules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CourseDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_Modules;
        private System.Windows.Forms.Button btn_SelectModules;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.DataGridView dgv_Modules;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnOKSelect;
        private System.Windows.Forms.Label lbSumList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_Course_View;
        private System.Windows.Forms.DataGridView dgv_Course_Modules_View;
        internal System.Windows.Forms.Label lbl_Course_Count;
        internal System.Windows.Forms.Label lbl_Course_Modules;
    }
}