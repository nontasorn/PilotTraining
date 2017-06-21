namespace PilotTraining.TrainingManagement
{
    partial class ViewSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchEmployeeCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ShowScheduleHead = new System.Windows.Forms.DataGridView();
            this.dgv_ShowScheduleDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPilotName = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowScheduleHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowScheduleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.txtSearchPilotName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchEmployeeCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 84);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtSearchEmployeeCode
            // 
            this.txtSearchEmployeeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearchEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmployeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearchEmployeeCode.ForeColor = System.Drawing.Color.Red;
            this.txtSearchEmployeeCode.Location = new System.Drawing.Point(249, 30);
            this.txtSearchEmployeeCode.Name = "txtSearchEmployeeCode";
            this.txtSearchEmployeeCode.Size = new System.Drawing.Size(113, 22);
            this.txtSearchEmployeeCode.TabIndex = 133;
            this.txtSearchEmployeeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "Employee Code :";
            // 
            // dgv_ShowScheduleHead
            // 
            this.dgv_ShowScheduleHead.AllowUserToAddRows = false;
            this.dgv_ShowScheduleHead.AllowUserToDeleteRows = false;
            this.dgv_ShowScheduleHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ShowScheduleHead.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ShowScheduleHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ShowScheduleHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowScheduleHead.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ShowScheduleHead.Location = new System.Drawing.Point(12, 102);
            this.dgv_ShowScheduleHead.MultiSelect = false;
            this.dgv_ShowScheduleHead.Name = "dgv_ShowScheduleHead";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ShowScheduleHead.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ShowScheduleHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ShowScheduleHead.Size = new System.Drawing.Size(962, 277);
            this.dgv_ShowScheduleHead.TabIndex = 145;
            this.dgv_ShowScheduleHead.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ShowSubject_CellMouseUp);
            // 
            // dgv_ShowScheduleDetails
            // 
            this.dgv_ShowScheduleDetails.AllowUserToAddRows = false;
            this.dgv_ShowScheduleDetails.AllowUserToDeleteRows = false;
            this.dgv_ShowScheduleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ShowScheduleDetails.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ShowScheduleDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ShowScheduleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowScheduleDetails.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ShowScheduleDetails.Location = new System.Drawing.Point(12, 389);
            this.dgv_ShowScheduleDetails.MultiSelect = false;
            this.dgv_ShowScheduleDetails.Name = "dgv_ShowScheduleDetails";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ShowScheduleDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ShowScheduleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ShowScheduleDetails.Size = new System.Drawing.Size(962, 255);
            this.dgv_ShowScheduleDetails.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "Pilot Name :";
            // 
            // txtSearchPilotName
            // 
            this.txtSearchPilotName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearchPilotName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPilotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearchPilotName.ForeColor = System.Drawing.Color.Red;
            this.txtSearchPilotName.Location = new System.Drawing.Point(476, 31);
            this.txtSearchPilotName.Name = "txtSearchPilotName";
            this.txtSearchPilotName.Size = new System.Drawing.Size(243, 22);
            this.txtSearchPilotName.TabIndex = 135;
            this.txtSearchPilotName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(739, 31);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 136;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 656);
            this.Controls.Add(this.dgv_ShowScheduleDetails);
            this.Controls.Add(this.dgv_ShowScheduleHead);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewSchedule";
            this.Text = "ViewSchedule";
            this.Load += new System.EventHandler(this.ViewSchedule_Load);
            this.Resize += new System.EventHandler(this.ViewSchedule_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowScheduleHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowScheduleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchEmployeeCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_ShowScheduleHead;
        private System.Windows.Forms.DataGridView dgv_ShowScheduleDetails;
        private System.Windows.Forms.TextBox txtSearchPilotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
    }
}