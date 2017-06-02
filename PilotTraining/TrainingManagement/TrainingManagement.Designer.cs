namespace PilotTraining.TrainingManagement
{
    partial class TrainingManagement
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Delete_Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrainingById = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrainingBy = new System.Windows.Forms.TextBox();
            this.txtAssignID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txt_Pilot_Id = new System.Windows.Forms.TextBox();
            this.DT_End = new System.Windows.Forms.DateTimePicker();
            this.comb_Training = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_Start = new System.Windows.Forms.DateTimePicker();
            this.txt_Pilot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ViewAssignCourse = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.schedule_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAssignCourse)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Assign_Course_btn,
            this.Edit_Assign_Course_btn,
            this.schedule_btn,
            this.Delete_Assign_Course_btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1148, 39);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Assign_Course_btn
            // 
            this.Assign_Course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assign_Course_btn.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Assign_Course_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Assign_Course_btn.Name = "Assign_Course_btn";
            this.Assign_Course_btn.Size = new System.Drawing.Size(141, 36);
            this.Assign_Course_btn.Text = "Assign Course";
            this.Assign_Course_btn.Click += new System.EventHandler(this.Assign_Course_btn_Click);
            // 
            // Edit_Assign_Course_btn
            // 
            this.Edit_Assign_Course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Assign_Course_btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Assign_Course_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Assign_Course_btn.Name = "Edit_Assign_Course_btn";
            this.Edit_Assign_Course_btn.Size = new System.Drawing.Size(117, 36);
            this.Edit_Assign_Course_btn.Text = "Edit Assign";
            this.Edit_Assign_Course_btn.Click += new System.EventHandler(this.Edit_Assign_Course_btn_Click);
            // 
            // Delete_Assign_Course_btn
            // 
            this.Delete_Assign_Course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Delete_Assign_Course_btn.Image = global::PilotTraining.Properties.Resources.delete_file_icon;
            this.Delete_Assign_Course_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Assign_Course_btn.Name = "Delete_Assign_Course_btn";
            this.Delete_Assign_Course_btn.Size = new System.Drawing.Size(134, 36);
            this.Delete_Assign_Course_btn.Text = "Delete Assign";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTrainingById);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTrainingBy);
            this.groupBox1.Controls.Add(this.txtAssignID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.txt_Pilot_Id);
            this.groupBox1.Controls.Add(this.DT_End);
            this.groupBox1.Controls.Add(this.comb_Training);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_Start);
            this.groupBox1.Controls.Add(this.txt_Pilot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // txtTrainingById
            // 
            this.txtTrainingById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTrainingById.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTrainingById.ForeColor = System.Drawing.Color.Red;
            this.txtTrainingById.Location = new System.Drawing.Point(798, 31);
            this.txtTrainingById.Name = "txtTrainingById";
            this.txtTrainingById.ReadOnly = true;
            this.txtTrainingById.Size = new System.Drawing.Size(72, 22);
            this.txtTrainingById.TabIndex = 140;
            this.txtTrainingById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "Train By :";
            // 
            // txtTrainingBy
            // 
            this.txtTrainingBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTrainingBy.Location = new System.Drawing.Point(878, 31);
            this.txtTrainingBy.Name = "txtTrainingBy";
            this.txtTrainingBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTrainingBy.Size = new System.Drawing.Size(218, 22);
            this.txtTrainingBy.TabIndex = 138;
            this.txtTrainingBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTrainingBy.TextChanged += new System.EventHandler(this.txtTrainingBy_TextChanged);
            // 
            // txtAssignID
            // 
            this.txtAssignID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAssignID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAssignID.ForeColor = System.Drawing.Color.Red;
            this.txtAssignID.Location = new System.Drawing.Point(525, 31);
            this.txtAssignID.Name = "txtAssignID";
            this.txtAssignID.ReadOnly = true;
            this.txtAssignID.Size = new System.Drawing.Size(157, 22);
            this.txtAssignID.TabIndex = 137;
            this.txtAssignID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 136;
            this.label8.Text = "Assign ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(58, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRemarks.Location = new System.Drawing.Point(135, 144);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemarks.Size = new System.Drawing.Size(547, 22);
            this.txtRemarks.TabIndex = 134;
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Pilot_Id
            // 
            this.txt_Pilot_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_Pilot_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Pilot_Id.ForeColor = System.Drawing.Color.Red;
            this.txt_Pilot_Id.Location = new System.Drawing.Point(138, 29);
            this.txt_Pilot_Id.Name = "txt_Pilot_Id";
            this.txt_Pilot_Id.ReadOnly = true;
            this.txt_Pilot_Id.Size = new System.Drawing.Size(72, 22);
            this.txt_Pilot_Id.TabIndex = 133;
            this.txt_Pilot_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DT_End
            // 
            this.DT_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DT_End.Location = new System.Drawing.Point(525, 69);
            this.DT_End.Name = "DT_End";
            this.DT_End.Size = new System.Drawing.Size(231, 22);
            this.DT_End.TabIndex = 132;
            // 
            // comb_Training
            // 
            this.comb_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comb_Training.FormattingEnabled = true;
            this.comb_Training.Location = new System.Drawing.Point(135, 109);
            this.comb_Training.Name = "comb_Training";
            this.comb_Training.Size = new System.Drawing.Size(299, 24);
            this.comb_Training.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(70, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "Course :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(448, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "End Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Start Date :";
            // 
            // DT_Start
            // 
            this.DT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Start.Location = new System.Drawing.Point(135, 72);
            this.DT_Start.Name = "DT_Start";
            this.DT_Start.Size = new System.Drawing.Size(237, 22);
            this.DT_Start.TabIndex = 127;
            // 
            // txt_Pilot
            // 
            this.txt_Pilot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Pilot.Location = new System.Drawing.Point(216, 30);
            this.txt_Pilot.Name = "txt_Pilot";
            this.txt_Pilot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pilot.Size = new System.Drawing.Size(218, 22);
            this.txt_Pilot.TabIndex = 126;
            this.txt_Pilot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Pilot.TextChanged += new System.EventHandler(this.txt_Pilot_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "Pilot Name :";
            // 
            // dgv_ViewAssignCourse
            // 
            this.dgv_ViewAssignCourse.AllowUserToAddRows = false;
            this.dgv_ViewAssignCourse.AllowUserToDeleteRows = false;
            this.dgv_ViewAssignCourse.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewAssignCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewAssignCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewAssignCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewAssignCourse.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewAssignCourse.Location = new System.Drawing.Point(3, 191);
            this.dgv_ViewAssignCourse.MultiSelect = false;
            this.dgv_ViewAssignCourse.Name = "dgv_ViewAssignCourse";
            this.dgv_ViewAssignCourse.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAssignCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewAssignCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAssignCourse.Size = new System.Drawing.Size(1142, 361);
            this.dgv_ViewAssignCourse.TabIndex = 8;
            this.dgv_ViewAssignCourse.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewAssignCourse_CellMouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAssignCourse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.12613F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 555);
            this.tableLayoutPanel1.TabIndex = 135;
            // 
            // schedule_btn
            // 
            this.schedule_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.schedule_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.schedule_btn.Name = "schedule_btn";
            this.schedule_btn.Size = new System.Drawing.Size(105, 36);
            this.schedule_btn.Text = "Schedule";
            this.schedule_btn.Click += new System.EventHandler(this.schedule_btn_Click);
            // 
            // TrainingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "TrainingManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingManagement";
            this.Load += new System.EventHandler(this.TrainingManagement_Load);
            this.Resize += new System.EventHandler(this.TrainingManagement_Resize);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAssignCourse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Assign_Course_btn;
        private System.Windows.Forms.ToolStripButton Edit_Assign_Course_btn;
        private System.Windows.Forms.ToolStripButton Delete_Assign_Course_btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Pilot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_Start;
        private System.Windows.Forms.DataGridView dgv_ViewAssignCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_End;
        private System.Windows.Forms.ComboBox comb_Training;
        private System.Windows.Forms.TextBox txt_Pilot_Id;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAssignID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrainingBy;
        private System.Windows.Forms.TextBox txtTrainingById;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton schedule_btn;
    }
}