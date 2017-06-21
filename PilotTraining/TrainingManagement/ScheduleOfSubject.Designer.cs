namespace PilotTraining.TrainingManagement
{
    partial class ScheduleOfSubject
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Schedule_btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAssignID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Pilot_Id = new System.Windows.Forms.TextBox();
            this.DT_End = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_Start = new System.Windows.Forms.DateTimePicker();
            this.txt_Pilot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ShowSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Schedule_btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(962, 39);
            this.toolStrip2.TabIndex = 142;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Schedule_btn
            // 
            this.Create_Schedule_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Schedule_btn.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Schedule_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Schedule_btn.Name = "Create_Schedule_btn";
            this.Create_Schedule_btn.Size = new System.Drawing.Size(153, 36);
            this.Create_Schedule_btn.Text = "Create Schedule";
            this.Create_Schedule_btn.Click += new System.EventHandler(this.Create_Schedule_btn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCourse);
            this.groupBox1.Controls.Add(this.txtAssignID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Pilot_Id);
            this.groupBox1.Controls.Add(this.DT_End);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_Start);
            this.groupBox1.Controls.Add(this.txt_Pilot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 157);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // txtCourse
            // 
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCourse.Location = new System.Drawing.Point(208, 110);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCourse.Size = new System.Drawing.Size(547, 22);
            this.txtCourse.TabIndex = 138;
            // 
            // txtAssignID
            // 
            this.txtAssignID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAssignID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAssignID.ForeColor = System.Drawing.Color.Red;
            this.txtAssignID.Location = new System.Drawing.Point(595, 31);
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
            this.label8.Location = new System.Drawing.Point(518, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 136;
            this.label8.Text = "Assign ID :";
            // 
            // txt_Pilot_Id
            // 
            this.txt_Pilot_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_Pilot_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Pilot_Id.ForeColor = System.Drawing.Color.Red;
            this.txt_Pilot_Id.Location = new System.Drawing.Point(208, 29);
            this.txt_Pilot_Id.Name = "txt_Pilot_Id";
            this.txt_Pilot_Id.ReadOnly = true;
            this.txt_Pilot_Id.Size = new System.Drawing.Size(72, 22);
            this.txt_Pilot_Id.TabIndex = 133;
            this.txt_Pilot_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DT_End
            // 
            this.DT_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DT_End.Location = new System.Drawing.Point(521, 72);
            this.DT_End.Name = "DT_End";
            this.DT_End.Size = new System.Drawing.Size(231, 22);
            this.DT_End.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(140, 112);
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
            this.label1.Location = new System.Drawing.Point(124, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Start Date :";
            // 
            // DT_Start
            // 
            this.DT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Start.Location = new System.Drawing.Point(205, 72);
            this.DT_Start.Name = "DT_Start";
            this.DT_Start.Size = new System.Drawing.Size(237, 22);
            this.DT_Start.TabIndex = 127;
            // 
            // txt_Pilot
            // 
            this.txt_Pilot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Pilot.Location = new System.Drawing.Point(286, 30);
            this.txt_Pilot.Name = "txt_Pilot";
            this.txt_Pilot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pilot.Size = new System.Drawing.Size(218, 22);
            this.txt_Pilot.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "Pilot Name :";
            // 
            // dgv_ShowSubject
            // 
            this.dgv_ShowSubject.AllowUserToAddRows = false;
            this.dgv_ShowSubject.AllowUserToDeleteRows = false;
            this.dgv_ShowSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ShowSubject.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ShowSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ShowSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowSubject.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ShowSubject.Location = new System.Drawing.Point(0, 214);
            this.dgv_ShowSubject.MultiSelect = false;
            this.dgv_ShowSubject.Name = "dgv_ShowSubject";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ShowSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ShowSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_ShowSubject.Size = new System.Drawing.Size(962, 254);
            this.dgv_ShowSubject.TabIndex = 9;
            this.dgv_ShowSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShowSubject_CellClick);
            this.dgv_ShowSubject.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_ShowSubject_ColumnWidthChanged);
            this.dgv_ShowSubject.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_ShowSubject_Scroll);
            // 
            // ScheduleOfSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 472);
            this.Controls.Add(this.dgv_ShowSubject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "ScheduleOfSubject";
            this.Text = "ScheduleOfSubject";
            this.Load += new System.EventHandler(this.ScheduleOfSubject_Load);
            this.Resize += new System.EventHandler(this.ScheduleOfSubject_Resize);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Schedule_btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAssignID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Pilot_Id;
        private System.Windows.Forms.DateTimePicker DT_End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_Start;
        private System.Windows.Forms.TextBox txt_Pilot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.DataGridView dgv_ShowSubject;
    }
}