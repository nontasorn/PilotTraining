namespace PilotTraining.Fundamental
{
    partial class Training_Type
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCountSubject = new System.Windows.Forms.Label();
            this.dgv_ViewTrainingType = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_Location = new System.Windows.Forms.ComboBox();
            this.txt_Training_Type_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Training_Type_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ViewSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_TrainingType_Btn = new System.Windows.Forms.ToolStripButton();
            this.EditTrainingTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.MappingTheSubject = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewTrainingType)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubject)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCountSubject, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewTrainingType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewSubject, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.26291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.73709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 602);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblCountSubject
            // 
            this.lblCountSubject.AutoSize = true;
            this.lblCountSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSubject.Location = new System.Drawing.Point(3, 391);
            this.lblCountSubject.Name = "lblCountSubject";
            this.lblCountSubject.Size = new System.Drawing.Size(65, 18);
            this.lblCountSubject.TabIndex = 128;
            this.lblCountSubject.Text = "Subject :";
            // 
            // dgv_ViewTrainingType
            // 
            this.dgv_ViewTrainingType.AllowUserToAddRows = false;
            this.dgv_ViewTrainingType.AllowUserToDeleteRows = false;
            this.dgv_ViewTrainingType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ViewTrainingType.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewTrainingType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewTrainingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewTrainingType.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewTrainingType.Location = new System.Drawing.Point(3, 152);
            this.dgv_ViewTrainingType.MultiSelect = false;
            this.dgv_ViewTrainingType.Name = "dgv_ViewTrainingType";
            this.dgv_ViewTrainingType.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewTrainingType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewTrainingType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewTrainingType.Size = new System.Drawing.Size(1067, 236);
            this.dgv_ViewTrainingType.TabIndex = 0;
            this.dgv_ViewTrainingType.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewTrainingType_CellMouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comb_Location);
            this.groupBox1.Controls.Add(this.txt_Training_Type_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Training_Type_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Type Manament";
            // 
            // comb_Location
            // 
            this.comb_Location.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_Location.FormattingEnabled = true;
            this.comb_Location.Location = new System.Drawing.Point(313, 74);
            this.comb_Location.Name = "comb_Location";
            this.comb_Location.Size = new System.Drawing.Size(286, 26);
            this.comb_Location.TabIndex = 127;
            // 
            // txt_Training_Type_Name
            // 
            this.txt_Training_Type_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Training_Type_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Training_Type_Name.Location = new System.Drawing.Point(313, 112);
            this.txt_Training_Type_Name.Name = "txt_Training_Type_Name";
            this.txt_Training_Type_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Training_Type_Name.Size = new System.Drawing.Size(286, 26);
            this.txt_Training_Type_Name.TabIndex = 126;
            this.txt_Training_Type_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Training Type Name :";
            // 
            // txt_Training_Type_ID
            // 
            this.txt_Training_Type_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Training_Type_ID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Training_Type_ID.Location = new System.Drawing.Point(313, 35);
            this.txt_Training_Type_ID.Name = "txt_Training_Type_ID";
            this.txt_Training_Type_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Training_Type_ID.Size = new System.Drawing.Size(286, 26);
            this.txt_Training_Type_ID.TabIndex = 124;
            this.txt_Training_Type_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 123;
            this.label1.Text = "Training Type ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Location :";
            // 
            // dgv_ViewSubject
            // 
            this.dgv_ViewSubject.AllowUserToAddRows = false;
            this.dgv_ViewSubject.AllowUserToDeleteRows = false;
            this.dgv_ViewSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ViewSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewSubject.Location = new System.Drawing.Point(3, 414);
            this.dgv_ViewSubject.MultiSelect = false;
            this.dgv_ViewSubject.Name = "dgv_ViewSubject";
            this.dgv_ViewSubject.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewSubject.Size = new System.Drawing.Size(1067, 185);
            this.dgv_ViewSubject.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_TrainingType_Btn,
            this.EditTrainingTypeBtn,
            this.MappingTheSubject,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1073, 39);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_TrainingType_Btn
            // 
            this.Create_TrainingType_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_TrainingType_Btn.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_TrainingType_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_TrainingType_Btn.Name = "Create_TrainingType_Btn";
            this.Create_TrainingType_Btn.Size = new System.Drawing.Size(180, 36);
            this.Create_TrainingType_Btn.Text = "Create Training Type";
            this.Create_TrainingType_Btn.Click += new System.EventHandler(this.Create_TrainingType_Btn_Click);
            // 
            // EditTrainingTypeBtn
            // 
            this.EditTrainingTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTrainingTypeBtn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.EditTrainingTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTrainingTypeBtn.Name = "EditTrainingTypeBtn";
            this.EditTrainingTypeBtn.Size = new System.Drawing.Size(150, 36);
            this.EditTrainingTypeBtn.Text = "Edit Traing Type";
            this.EditTrainingTypeBtn.Click += new System.EventHandler(this.EditTrainingTypeBtn_Click);
            // 
            // MappingTheSubject
            // 
            this.MappingTheSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MappingTheSubject.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.MappingTheSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MappingTheSubject.Name = "MappingTheSubject";
            this.MappingTheSubject.Size = new System.Drawing.Size(148, 36);
            this.MappingTheSubject.Text = "Map the subject";
            this.MappingTheSubject.Click += new System.EventHandler(this.MappingTheSubject_Click);
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
            // Training_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Training_Type";
            this.Text = "Training_Type";
            this.Load += new System.EventHandler(this.Training_Type_Load);
            this.Resize += new System.EventHandler(this.Training_Type_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewTrainingType)).EndInit();
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
        private System.Windows.Forms.ComboBox comb_Location;
        private System.Windows.Forms.TextBox txt_Training_Type_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Training_Type_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_ViewTrainingType;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_TrainingType_Btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.ToolStripButton MappingTheSubject;
        private System.Windows.Forms.ToolStripButton EditTrainingTypeBtn;
        private System.Windows.Forms.DataGridView dgv_ViewSubject;
        private System.Windows.Forms.Label lblCountSubject;
    }
}