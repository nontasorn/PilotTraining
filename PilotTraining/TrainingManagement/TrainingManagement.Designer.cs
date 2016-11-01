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
            this.dgv_ViewGrade = new System.Windows.Forms.DataGridView();
            this.lbl_Training_Count = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAssignID = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewGrade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
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
            this.DT_End.Location = new System.Drawing.Point(451, 72);
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
            this.label2.Location = new System.Drawing.Point(378, 74);
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
            // dgv_ViewGrade
            // 
            this.dgv_ViewGrade.AllowUserToAddRows = false;
            this.dgv_ViewGrade.AllowUserToDeleteRows = false;
            this.dgv_ViewGrade.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewGrade.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewGrade.Location = new System.Drawing.Point(0, 286);
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
            this.dgv_ViewGrade.Size = new System.Drawing.Size(1148, 310);
            this.dgv_ViewGrade.TabIndex = 8;
            // 
            // lbl_Training_Count
            // 
            this.lbl_Training_Count.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_Training_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Training_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Training_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Training_Count.Location = new System.Drawing.Point(3, 264);
            this.lbl_Training_Count.Name = "lbl_Training_Count";
            this.lbl_Training_Count.Size = new System.Drawing.Size(126, 19);
            this.lbl_Training_Count.TabIndex = 133;
            this.lbl_Training_Count.Text = "Training : ";
            this.lbl_Training_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(760, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 90);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Calculator";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox5.ForeColor = System.Drawing.Color.Red;
            this.textBox5.Location = new System.Drawing.Point(228, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(36, 22);
            this.textBox5.TabIndex = 138;
            this.textBox5.Text = "=";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(270, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(59, 22);
            this.textBox4.TabIndex = 137;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(228, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(36, 22);
            this.textBox3.TabIndex = 136;
            this.textBox3.Text = "+";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(270, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 134;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(23, 32);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker3.TabIndex = 134;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(760, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 93);
            this.groupBox3.TabIndex = 135;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PPC Date Calculator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 142;
            this.label6.Text = "PPC1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "PPC2 :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(271, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(36, 22);
            this.textBox6.TabIndex = 140;
            this.textBox6.Text = "=";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Location = new System.Drawing.Point(66, 30);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker4.TabIndex = 139;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(66, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(198, 22);
            this.textBox7.TabIndex = 139;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TrainingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_ViewGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_End;
        private System.Windows.Forms.ComboBox comb_Training;
        internal System.Windows.Forms.Label lbl_Training_Count;
        private System.Windows.Forms.TextBox txt_Pilot_Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAssignID;
    }
}