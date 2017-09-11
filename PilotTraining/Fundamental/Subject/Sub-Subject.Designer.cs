namespace PilotTraining.Fundamental
{
    partial class Sub_Subject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubSubjectId = new System.Windows.Forms.Label();
            this.txt_SubSubject_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ViewSubSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_SubSubject = new System.Windows.Forms.ToolStripButton();
            this.Edit_SubSubject = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubSubject)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewSubSubject, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.56088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 467);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comb_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSubSubjectId);
            this.groupBox1.Controls.Add(this.txt_SubSubject_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub-Subject Management";
            // 
            // comb_status
            // 
            this.comb_status.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_status.FormattingEnabled = true;
            this.comb_status.Location = new System.Drawing.Point(269, 147);
            this.comb_status.Name = "comb_status";
            this.comb_status.Size = new System.Drawing.Size(96, 26);
            this.comb_status.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Status :";
            // 
            // lblSubSubjectId
            // 
            this.lblSubSubjectId.AutoSize = true;
            this.lblSubSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSubjectId.Location = new System.Drawing.Point(266, 65);
            this.lblSubSubjectId.Name = "lblSubSubjectId";
            this.lblSubSubjectId.Size = new System.Drawing.Size(16, 18);
            this.lblSubSubjectId.TabIndex = 127;
            this.lblSubSubjectId.Text = "#";
            // 
            // txt_SubSubject_Name
            // 
            this.txt_SubSubject_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SubSubject_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubSubject_Name.Location = new System.Drawing.Point(269, 98);
            this.txt_SubSubject_Name.Name = "txt_SubSubject_Name";
            this.txt_SubSubject_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_SubSubject_Name.Size = new System.Drawing.Size(383, 26);
            this.txt_SubSubject_Name.TabIndex = 126;
            this.txt_SubSubject_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // dgv_ViewSubSubject
            // 
            this.dgv_ViewSubSubject.AllowUserToAddRows = false;
            this.dgv_ViewSubSubject.AllowUserToDeleteRows = false;
            this.dgv_ViewSubSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ViewSubSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewSubSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewSubSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewSubSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewSubSubject.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewSubSubject.MultiSelect = false;
            this.dgv_ViewSubSubject.Name = "dgv_ViewSubSubject";
            this.dgv_ViewSubSubject.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewSubSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ViewSubSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewSubSubject.Size = new System.Drawing.Size(958, 182);
            this.dgv_ViewSubSubject.TabIndex = 0;
            this.dgv_ViewSubSubject.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewSubSubject_CellMouseUp);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_SubSubject,
            this.Edit_SubSubject,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(964, 39);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_SubSubject
            // 
            this.Create_SubSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_SubSubject.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_SubSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_SubSubject.Name = "Create_SubSubject";
            this.Create_SubSubject.Size = new System.Drawing.Size(141, 36);
            this.Create_SubSubject.Text = "Create Subject";
            this.Create_SubSubject.Click += new System.EventHandler(this.Create_SubSubject_Click);
            // 
            // Edit_SubSubject
            // 
            this.Edit_SubSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_SubSubject.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_SubSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_SubSubject.Name = "Edit_SubSubject";
            this.Edit_SubSubject.Size = new System.Drawing.Size(126, 36);
            this.Edit_SubSubject.Text = "Edit  Subject";
            this.Edit_SubSubject.Click += new System.EventHandler(this.Edit_SubSubject_Click);
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
            // Sub_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Sub_Subject";
            this.Text = "Sub_Subject";
            this.Load += new System.EventHandler(this.Sub_Subject_Load);
            this.Resize += new System.EventHandler(this.Sub_Subject_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubSubject)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubSubjectId;
        private System.Windows.Forms.TextBox txt_SubSubject_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ViewSubSubject;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_SubSubject;
        private System.Windows.Forms.ToolStripButton Edit_SubSubject;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
    }
}