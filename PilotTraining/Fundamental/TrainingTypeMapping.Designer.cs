namespace PilotTraining.Fundamental
{
    partial class TrainingTypeMapping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.Create_Mapping = new System.Windows.Forms.ToolStripButton();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.txtTrainingTypeId = new System.Windows.Forms.TextBox();
            this.btn_SelectSubject = new System.Windows.Forms.Button();
            this.pn_Subject = new System.Windows.Forms.Panel();
            this.lbSumList = new System.Windows.Forms.Label();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnOKSelect = new System.Windows.Forms.Button();
            this.dgv_Subject = new System.Windows.Forms.DataGridView();
            this.txt_TrainingType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SelectSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.pn_Subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subject)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectSubject)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
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
            // txtTrainingTypeId
            // 
            this.txtTrainingTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingTypeId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingTypeId.Location = new System.Drawing.Point(497, 14);
            this.txtTrainingTypeId.Name = "txtTrainingTypeId";
            this.txtTrainingTypeId.ReadOnly = true;
            this.txtTrainingTypeId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTrainingTypeId.Size = new System.Drawing.Size(154, 26);
            this.txtTrainingTypeId.TabIndex = 130;
            this.txtTrainingTypeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SelectSubject
            // 
            this.btn_SelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_SelectSubject.Location = new System.Drawing.Point(657, 14);
            this.btn_SelectSubject.Name = "btn_SelectSubject";
            this.btn_SelectSubject.Size = new System.Drawing.Size(127, 26);
            this.btn_SelectSubject.TabIndex = 129;
            this.btn_SelectSubject.Text = "Select Subject";
            this.btn_SelectSubject.UseVisualStyleBackColor = true;
            this.btn_SelectSubject.Click += new System.EventHandler(this.btn_SelectSubject_Click);
            // 
            // pn_Subject
            // 
            this.pn_Subject.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_Subject.Controls.Add(this.lbSumList);
            this.pn_Subject.Controls.Add(this.btnCancelSelect);
            this.pn_Subject.Controls.Add(this.btnOKSelect);
            this.pn_Subject.Controls.Add(this.btnExitMain);
            this.pn_Subject.Controls.Add(this.dgv_Subject);
            this.pn_Subject.Location = new System.Drawing.Point(222, 46);
            this.pn_Subject.Name = "pn_Subject";
            this.pn_Subject.Size = new System.Drawing.Size(565, 344);
            this.pn_Subject.TabIndex = 129;
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
            // dgv_Subject
            // 
            this.dgv_Subject.AllowUserToAddRows = false;
            this.dgv_Subject.AllowUserToDeleteRows = false;
            this.dgv_Subject.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Subject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Subject.ColumnHeadersHeight = 25;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Subject.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Subject.Location = new System.Drawing.Point(18, 50);
            this.dgv_Subject.Name = "dgv_Subject";
            this.dgv_Subject.RowHeadersVisible = false;
            this.dgv_Subject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Subject.Size = new System.Drawing.Size(530, 279);
            this.dgv_Subject.TabIndex = 134;
            // 
            // txt_TrainingType
            // 
            this.txt_TrainingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TrainingType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrainingType.Location = new System.Drawing.Point(222, 14);
            this.txt_TrainingType.Name = "txt_TrainingType";
            this.txt_TrainingType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TrainingType.Size = new System.Drawing.Size(269, 26);
            this.txt_TrainingType.TabIndex = 126;
            this.txt_TrainingType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Training Type :";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTrainingTypeId);
            this.groupBox1.Controls.Add(this.btn_SelectSubject);
            this.groupBox1.Controls.Add(this.pn_Subject);
            this.groupBox1.Controls.Add(this.txt_TrainingType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_SelectSubject);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 390);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            // 
            // dgv_SelectSubject
            // 
            this.dgv_SelectSubject.AllowUserToAddRows = false;
            this.dgv_SelectSubject.AllowUserToDeleteRows = false;
            this.dgv_SelectSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_SelectSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_SelectSubject.Location = new System.Drawing.Point(0, 55);
            this.dgv_SelectSubject.MultiSelect = false;
            this.dgv_SelectSubject.Name = "dgv_SelectSubject";
            this.dgv_SelectSubject.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_SelectSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SelectSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectSubject.Size = new System.Drawing.Size(995, 335);
            this.dgv_SelectSubject.TabIndex = 7;
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
            this.toolStrip2.Size = new System.Drawing.Size(995, 39);
            this.toolStrip2.TabIndex = 134;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TrainingTypeMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "TrainingTypeMapping";
            this.Text = "TrainingTypeMapping";
            this.Load += new System.EventHandler(this.TrainingTypeMapping_Load);
            this.pn_Subject.ResumeLayout(false);
            this.pn_Subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectSubject)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.ToolStripButton Create_Mapping;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.TextBox txtTrainingTypeId;
        private System.Windows.Forms.Button btn_SelectSubject;
        private System.Windows.Forms.Panel pn_Subject;
        private System.Windows.Forms.Label lbSumList;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnOKSelect;
        private System.Windows.Forms.DataGridView dgv_Subject;
        private System.Windows.Forms.TextBox txt_TrainingType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Edit_Course_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SelectSubject;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}