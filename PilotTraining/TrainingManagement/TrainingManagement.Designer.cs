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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Delete_Assign_Course_btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pilot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ViewGrade = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_Training = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Training_Count = new System.Windows.Forms.Label();
            this.txt_Pilot_Id = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Assign_Course_btn,
            this.Edit_Assign_Course_btn,
            this.Delete_Assign_Course_btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(984, 39);
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
            // 
            // Edit_Assign_Course_btn
            // 
            this.Edit_Assign_Course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Assign_Course_btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Assign_Course_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Assign_Course_btn.Name = "Edit_Assign_Course_btn";
            this.Edit_Assign_Course_btn.Size = new System.Drawing.Size(117, 36);
            this.Edit_Assign_Course_btn.Text = "Edit Assign";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Pilot_Id);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comb_Training);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_Pilot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txt_Pilot
            // 
            this.txt_Pilot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pilot.Location = new System.Drawing.Point(216, 30);
            this.txt_Pilot.Name = "txt_Pilot";
            this.txt_Pilot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pilot.Size = new System.Drawing.Size(299, 26);
            this.txt_Pilot.TabIndex = 126;
            this.txt_Pilot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Pilot.TextChanged += new System.EventHandler(this.txt_Pilot_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 125;
            this.label7.Text = "Pilot Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 24);
            this.dateTimePicker1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "Start Date:";
            // 
            // dgv_ViewGrade
            // 
            this.dgv_ViewGrade.AllowUserToAddRows = false;
            this.dgv_ViewGrade.AllowUserToDeleteRows = false;
            this.dgv_ViewGrade.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewGrade.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewGrade.Location = new System.Drawing.Point(0, 259);
            this.dgv_ViewGrade.MultiSelect = false;
            this.dgv_ViewGrade.Name = "dgv_ViewGrade";
            this.dgv_ViewGrade.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewGrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ViewGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewGrade.Size = new System.Drawing.Size(984, 303);
            this.dgv_ViewGrade.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 129;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 130;
            this.label3.Text = "Course :";
            // 
            // comb_Training
            // 
            this.comb_Training.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_Training.FormattingEnabled = true;
            this.comb_Training.Location = new System.Drawing.Point(135, 109);
            this.comb_Training.Name = "comb_Training";
            this.comb_Training.Size = new System.Drawing.Size(299, 26);
            this.comb_Training.TabIndex = 131;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePicker2.Location = new System.Drawing.Point(528, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 24);
            this.dateTimePicker2.TabIndex = 132;
            // 
            // lbl_Training_Count
            // 
            this.lbl_Training_Count.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Training_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Training_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Training_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Training_Count.Location = new System.Drawing.Point(1, 237);
            this.lbl_Training_Count.Name = "lbl_Training_Count";
            this.lbl_Training_Count.Size = new System.Drawing.Size(126, 19);
            this.lbl_Training_Count.TabIndex = 133;
            this.lbl_Training_Count.Text = "Training : ";
            this.lbl_Training_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Pilot_Id
            // 
            this.txt_Pilot_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_Pilot_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pilot_Id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pilot_Id.ForeColor = System.Drawing.Color.Red;
            this.txt_Pilot_Id.Location = new System.Drawing.Point(138, 29);
            this.txt_Pilot_Id.Name = "txt_Pilot_Id";
            this.txt_Pilot_Id.ReadOnly = true;
            this.txt_Pilot_Id.Size = new System.Drawing.Size(72, 27);
            this.txt_Pilot_Id.TabIndex = 133;
            this.txt_Pilot_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrainingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbl_Training_Count);
            this.Controls.Add(this.dgv_ViewGrade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "TrainingManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingManagement";
            this.Load += new System.EventHandler(this.TrainingManagement_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewGrade)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgv_ViewGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comb_Training;
        internal System.Windows.Forms.Label lbl_Training_Count;
        private System.Windows.Forms.TextBox txt_Pilot_Id;
    }
}