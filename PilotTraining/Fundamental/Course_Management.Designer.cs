namespace PilotTraining.Fundamental
{
    partial class Course_Management
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
            this.dgv_SelectModules = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CourseDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_Modules = new System.Windows.Forms.Panel();
            this.btn_SelectModules = new System.Windows.Forms.Button();
            this.dgv_Modules = new System.Windows.Forms.DataGridView();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnOKSelect = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.Create_Grade_Buton = new System.Windows.Forms.ToolStripButton();
            this.Edit_Grade_Button = new System.Windows.Forms.ToolStripButton();
            this.Delete_Grade_Button = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.lbSumList = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectModules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pn_Modules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modules)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Grade_Buton,
            this.Edit_Grade_Button,
            this.Delete_Grade_Button,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1084, 39);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dgv_SelectModules
            // 
            this.dgv_SelectModules.AllowUserToAddRows = false;
            this.dgv_SelectModules.AllowUserToDeleteRows = false;
            this.dgv_SelectModules.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_SelectModules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SelectModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectModules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SelectModules.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_SelectModules.Location = new System.Drawing.Point(0, 241);
            this.dgv_SelectModules.MultiSelect = false;
            this.dgv_SelectModules.Name = "dgv_SelectModules";
            this.dgv_SelectModules.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_SelectModules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SelectModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectModules.Size = new System.Drawing.Size(1084, 320);
            this.dgv_SelectModules.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_SelectModules);
            this.groupBox1.Controls.Add(this.txt_CourseDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CourseName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseName.Location = new System.Drawing.Point(222, 21);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseName.Size = new System.Drawing.Size(451, 26);
            this.txt_CourseName.TabIndex = 126;
            this.txt_CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Course Name :";
            // 
            // txt_CourseDescription
            // 
            this.txt_CourseDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseDescription.Location = new System.Drawing.Point(222, 62);
            this.txt_CourseDescription.Name = "txt_CourseDescription";
            this.txt_CourseDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CourseDescription.Size = new System.Drawing.Size(451, 26);
            this.txt_CourseDescription.TabIndex = 128;
            this.txt_CourseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 127;
            this.label2.Text = "Course Description :";
            // 
            // pn_Modules
            // 
            this.pn_Modules.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_Modules.Controls.Add(this.lbSumList);
            this.pn_Modules.Controls.Add(this.btnCancelSelect);
            this.pn_Modules.Controls.Add(this.btnOKSelect);
            this.pn_Modules.Controls.Add(this.btnExitMain);
            this.pn_Modules.Controls.Add(this.dgv_Modules);
            this.pn_Modules.Location = new System.Drawing.Point(120, 184);
            this.pn_Modules.Name = "pn_Modules";
            this.pn_Modules.Size = new System.Drawing.Size(846, 365);
            this.pn_Modules.TabIndex = 129;
            // 
            // btn_SelectModules
            // 
            this.btn_SelectModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_SelectModules.Location = new System.Drawing.Point(222, 100);
            this.btn_SelectModules.Name = "btn_SelectModules";
            this.btn_SelectModules.Size = new System.Drawing.Size(157, 34);
            this.btn_SelectModules.TabIndex = 129;
            this.btn_SelectModules.Text = "Select Modules";
            this.btn_SelectModules.UseVisualStyleBackColor = true;
            this.btn_SelectModules.Click += new System.EventHandler(this.btn_SelectModules_Click);
            // 
            // dgv_Modules
            // 
            this.dgv_Modules.AllowUserToAddRows = false;
            this.dgv_Modules.AllowUserToDeleteRows = false;
            this.dgv_Modules.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_Modules.ColumnHeadersHeight = 25;
            this.dgv_Modules.Location = new System.Drawing.Point(18, 50);
            this.dgv_Modules.Name = "dgv_Modules";
            this.dgv_Modules.RowHeadersVisible = false;
            this.dgv_Modules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Modules.Size = new System.Drawing.Size(810, 302);
            this.dgv_Modules.TabIndex = 134;
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
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitMain.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnExitMain.Image = global::PilotTraining.Properties.Resources.delete;
            this.btnExitMain.Location = new System.Drawing.Point(807, 0);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(39, 30);
            this.btnExitMain.TabIndex = 136;
            this.btnExitMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // Create_Grade_Buton
            // 
            this.Create_Grade_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Grade_Buton.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Grade_Buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Grade_Buton.Name = "Create_Grade_Buton";
            this.Create_Grade_Buton.Size = new System.Drawing.Size(141, 36);
            this.Create_Grade_Buton.Text = "Create Course";
            // 
            // Edit_Grade_Button
            // 
            this.Edit_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Grade_Button.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Grade_Button.Name = "Edit_Grade_Button";
            this.Edit_Grade_Button.Size = new System.Drawing.Size(122, 36);
            this.Edit_Grade_Button.Text = "Edit Course";
            // 
            // Delete_Grade_Button
            // 
            this.Delete_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Delete_Grade_Button.Image = global::PilotTraining.Properties.Resources.delete_file_icon;
            this.Delete_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Grade_Button.Name = "Delete_Grade_Button";
            this.Delete_Grade_Button.Size = new System.Drawing.Size(139, 36);
            this.Delete_Grade_Button.Text = "Delete Course";
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
            // Course_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.pn_Modules);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_SelectModules);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Course_Management";
            this.Text = "Course_Management";
            this.Load += new System.EventHandler(this.Course_Management_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectModules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_Modules.ResumeLayout(false);
            this.pn_Modules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Grade_Buton;
        private System.Windows.Forms.ToolStripButton Edit_Grade_Button;
        private System.Windows.Forms.ToolStripButton Delete_Grade_Button;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.DataGridView dgv_SelectModules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CourseDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_Modules;
        private System.Windows.Forms.Button btn_SelectModules;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.DataGridView dgv_Modules;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnOKSelect;
        private System.Windows.Forms.Label lbSumList;
    }
}