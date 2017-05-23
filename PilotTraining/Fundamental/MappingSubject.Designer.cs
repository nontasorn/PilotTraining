namespace PilotTraining.Fundamental
{
    partial class MappingSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Mapping = new System.Windows.Forms.ToolStripButton();
            this.Edit_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pn_SubSubject = new System.Windows.Forms.Panel();
            this.lbSumList = new System.Windows.Forms.Label();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnOKSelect = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.dgv_SubSubject = new System.Windows.Forms.DataGridView();
            this.dgv_SelectSubSubject = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMappingId = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.btn_SelectSubject = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pn_SubSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectSubSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Mapping,
            this.Edit_Course_Btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(964, 39);
            this.toolStrip2.TabIndex = 136;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Mapping
            // 
            this.Create_Mapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Mapping.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Mapping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Mapping.Name = "Create_Mapping";
            this.Create_Mapping.Size = new System.Drawing.Size(100, 36);
            this.Create_Mapping.Text = "Mapping";
            this.Create_Mapping.Click += new System.EventHandler(this.Create_Mapping_Click);
            // 
            // Edit_Course_Btn
            // 
            this.Edit_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Course_Btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Course_Btn.Name = "Edit_Course_Btn";
            this.Edit_Course_Btn.Size = new System.Drawing.Size(129, 36);
            this.Edit_Course_Btn.Text = "Edit Mapping";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.39655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.60345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 464);
            this.tableLayoutPanel1.TabIndex = 137;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pn_SubSubject);
            this.groupBox2.Controls.Add(this.dgv_SelectSubSubject);
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 369);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            // 
            // pn_SubSubject
            // 
            this.pn_SubSubject.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_SubSubject.Controls.Add(this.lbSumList);
            this.pn_SubSubject.Controls.Add(this.btnCancelSelect);
            this.pn_SubSubject.Controls.Add(this.btnOKSelect);
            this.pn_SubSubject.Controls.Add(this.btnExitMain);
            this.pn_SubSubject.Controls.Add(this.dgv_SubSubject);
            this.pn_SubSubject.Location = new System.Drawing.Point(174, 12);
            this.pn_SubSubject.Name = "pn_SubSubject";
            this.pn_SubSubject.Size = new System.Drawing.Size(565, 344);
            this.pn_SubSubject.TabIndex = 129;
            // 
            // lbSumList
            // 
            this.lbSumList.AutoSize = true;
            this.lbSumList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumList.Location = new System.Drawing.Point(110, 21);
            this.lbSumList.Name = "lbSumList";
            this.lbSumList.Size = new System.Drawing.Size(142, 16);
            this.lbSumList.TabIndex = 139;
            this.lbSumList.Text = "Count Sub-Subject : ";
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
            // dgv_SubSubject
            // 
            this.dgv_SubSubject.AllowUserToAddRows = false;
            this.dgv_SubSubject.AllowUserToDeleteRows = false;
            this.dgv_SubSubject.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SubSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_SubSubject.ColumnHeadersHeight = 25;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SubSubject.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_SubSubject.Location = new System.Drawing.Point(18, 50);
            this.dgv_SubSubject.Name = "dgv_SubSubject";
            this.dgv_SubSubject.RowHeadersVisible = false;
            this.dgv_SubSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SubSubject.Size = new System.Drawing.Size(530, 279);
            this.dgv_SubSubject.TabIndex = 134;
            // 
            // dgv_SelectSubSubject
            // 
            this.dgv_SelectSubSubject.AllowUserToAddRows = false;
            this.dgv_SelectSubSubject.AllowUserToDeleteRows = false;
            this.dgv_SelectSubSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_SelectSubSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectSubSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectSubSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SelectSubSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_SelectSubSubject.Location = new System.Drawing.Point(3, 16);
            this.dgv_SelectSubSubject.MultiSelect = false;
            this.dgv_SelectSubSubject.Name = "dgv_SelectSubSubject";
            this.dgv_SelectSubSubject.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_SelectSubSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_SelectSubSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectSubSubject.Size = new System.Drawing.Size(952, 350);
            this.dgv_SelectSubSubject.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMappingId);
            this.groupBox1.Controls.Add(this.txtSubjectId);
            this.groupBox1.Controls.Add(this.btn_SelectSubject);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMappingId
            // 
            this.txtMappingId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMappingId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMappingId.Location = new System.Drawing.Point(789, 32);
            this.txtMappingId.Name = "txtMappingId";
            this.txtMappingId.ReadOnly = true;
            this.txtMappingId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMappingId.Size = new System.Drawing.Size(154, 26);
            this.txtMappingId.TabIndex = 136;
            this.txtMappingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectId.Location = new System.Drawing.Point(452, 32);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.ReadOnly = true;
            this.txtSubjectId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSubjectId.Size = new System.Drawing.Size(154, 26);
            this.txtSubjectId.TabIndex = 135;
            this.txtSubjectId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SelectSubject
            // 
            this.btn_SelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_SelectSubject.Location = new System.Drawing.Point(612, 32);
            this.btn_SelectSubject.Name = "btn_SelectSubject";
            this.btn_SelectSubject.Size = new System.Drawing.Size(157, 26);
            this.btn_SelectSubject.TabIndex = 134;
            this.btn_SelectSubject.Text = "Select Sub-Subject";
            this.btn_SelectSubject.UseVisualStyleBackColor = true;
            this.btn_SelectSubject.Click += new System.EventHandler(this.btn_SelectSubject_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(177, 32);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSubject.Size = new System.Drawing.Size(269, 26);
            this.txtSubject.TabIndex = 133;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 132;
            this.label1.Text = "Subject  :";
            // 
            // MappingSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "MappingSubject";
            this.Text = "MappingSubject";
            this.Load += new System.EventHandler(this.MappingSubject_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pn_SubSubject.ResumeLayout(false);
            this.pn_SubSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectSubSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Mapping;
        private System.Windows.Forms.ToolStripButton Edit_Course_Btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMappingId;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.Button btn_SelectSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pn_SubSubject;
        private System.Windows.Forms.Label lbSumList;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnOKSelect;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.DataGridView dgv_SubSubject;
        private System.Windows.Forms.DataGridView dgv_SelectSubSubject;
    }
}