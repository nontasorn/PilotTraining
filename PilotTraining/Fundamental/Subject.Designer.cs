namespace PilotTraining.Fundamental
{
    partial class Subject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTrainingPart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.txt_Subject_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ViewSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Subject = new System.Windows.Forms.ToolStripButton();
            this.Edit_Subject = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.SubSubjectMappingbtn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubject)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewSubject, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 467);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cboTrainingPart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comb_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSubjectId);
            this.groupBox1.Controls.Add(this.txt_Subject_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Management";
            // 
            // cboTrainingPart
            // 
            this.cboTrainingPart.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cboTrainingPart.FormattingEnabled = true;
            this.cboTrainingPart.Location = new System.Drawing.Point(269, 142);
            this.cboTrainingPart.Name = "cboTrainingPart";
            this.cboTrainingPart.Size = new System.Drawing.Size(254, 26);
            this.cboTrainingPart.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 130;
            this.label4.Text = "Training Part  :";
            // 
            // comb_status
            // 
            this.comb_status.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_status.FormattingEnabled = true;
            this.comb_status.Location = new System.Drawing.Point(269, 183);
            this.comb_status.Name = "comb_status";
            this.comb_status.Size = new System.Drawing.Size(96, 26);
            this.comb_status.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Status :";
            // 
            // lblSubjectId
            // 
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectId.Location = new System.Drawing.Point(266, 65);
            this.lblSubjectId.Name = "lblSubjectId";
            this.lblSubjectId.Size = new System.Drawing.Size(16, 18);
            this.lblSubjectId.TabIndex = 127;
            this.lblSubjectId.Text = "#";
            // 
            // txt_Subject_Name
            // 
            this.txt_Subject_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Subject_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject_Name.Location = new System.Drawing.Point(269, 98);
            this.txt_Subject_Name.Name = "txt_Subject_Name";
            this.txt_Subject_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Subject_Name.Size = new System.Drawing.Size(383, 26);
            this.txt_Subject_Name.TabIndex = 126;
            this.txt_Subject_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Subject Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 123;
            this.label1.Text = "Subject # :";
            // 
            // dgv_ViewSubject
            // 
            this.dgv_ViewSubject.AllowUserToAddRows = false;
            this.dgv_ViewSubject.AllowUserToDeleteRows = false;
            this.dgv_ViewSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewSubject.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewSubject.MultiSelect = false;
            this.dgv_ViewSubject.Name = "dgv_ViewSubject";
            this.dgv_ViewSubject.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewSubject.Size = new System.Drawing.Size(958, 193);
            this.dgv_ViewSubject.TabIndex = 0;
            this.dgv_ViewSubject.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewSubject_CellMouseUp);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Subject,
            this.Edit_Subject,
            this.Refresh_btn,
            this.SubSubjectMappingbtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(964, 39);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Subject
            // 
            this.Create_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Subject.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Subject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Subject.Name = "Create_Subject";
            this.Create_Subject.Size = new System.Drawing.Size(141, 36);
            this.Create_Subject.Text = "Create Subject";
            this.Create_Subject.Click += new System.EventHandler(this.Create_Subject_Click);
            // 
            // Edit_Subject
            // 
            this.Edit_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Subject.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Subject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Subject.Name = "Edit_Subject";
            this.Edit_Subject.Size = new System.Drawing.Size(126, 36);
            this.Edit_Subject.Text = "Edit  Subject";
            this.Edit_Subject.Click += new System.EventHandler(this.Edit_Subject_Click);
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
            // SubSubjectMappingbtn
            // 
            this.SubSubjectMappingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SubSubjectMappingbtn.Image = global::PilotTraining.Properties.Resources.Add;
            this.SubSubjectMappingbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubSubjectMappingbtn.Name = "SubSubjectMappingbtn";
            this.SubSubjectMappingbtn.Size = new System.Drawing.Size(184, 36);
            this.SubSubjectMappingbtn.Text = "Mapping Sub-Subject";
            this.SubSubjectMappingbtn.Click += new System.EventHandler(this.SubSubjectMappingbtn_Click);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.Resize += new System.EventHandler(this.Subject_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubject)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.TextBox txt_Subject_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ViewSubject;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Subject;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comb_status;
        private System.Windows.Forms.ToolStripButton Edit_Subject;
        private System.Windows.Forms.ComboBox cboTrainingPart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton SubSubjectMappingbtn;

    }
}