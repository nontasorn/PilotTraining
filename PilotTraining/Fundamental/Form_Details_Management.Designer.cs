namespace PilotTraining.Fundamental
{
    partial class Form_Details_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_GradeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Status = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd_Default = new System.Windows.Forms.RadioButton();
            this.txt_Grade_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_Modules = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Grade_Buton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ViewElement = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewElement)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_GradeType
            // 
            this.cbo_GradeType.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbo_GradeType.FormattingEnabled = true;
            this.cbo_GradeType.Location = new System.Drawing.Point(111, 259);
            this.cbo_GradeType.Name = "cbo_GradeType";
            this.cbo_GradeType.Size = new System.Drawing.Size(286, 26);
            this.cbo_GradeType.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 148;
            this.label5.Text = "Grade Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 147;
            this.label4.Text = "Status :";
            // 
            // cbo_Status
            // 
            this.cbo_Status.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(111, 304);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(286, 26);
            this.cbo_Status.TabIndex = 146;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton1.Location = new System.Drawing.Point(111, 225);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 22);
            this.radioButton1.TabIndex = 144;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Additional";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rd_Default
            // 
            this.rd_Default.AutoSize = true;
            this.rd_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rd_Default.Location = new System.Drawing.Point(111, 194);
            this.rd_Default.Name = "rd_Default";
            this.rd_Default.Size = new System.Drawing.Size(72, 22);
            this.rd_Default.TabIndex = 143;
            this.rd_Default.TabStop = true;
            this.rd_Default.Text = "Default";
            this.rd_Default.UseVisualStyleBackColor = true;
            // 
            // txt_Grade_Name
            // 
            this.txt_Grade_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Grade_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grade_Name.Location = new System.Drawing.Point(111, 156);
            this.txt_Grade_Name.Name = "txt_Grade_Name";
            this.txt_Grade_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Grade_Name.Size = new System.Drawing.Size(286, 26);
            this.txt_Grade_Name.TabIndex = 142;
            this.txt_Grade_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 141;
            this.label3.Text = "Element :";
            // 
            // comb_Modules
            // 
            this.comb_Modules.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_Modules.FormattingEnabled = true;
            this.comb_Modules.Location = new System.Drawing.Point(111, 112);
            this.comb_Modules.Name = "comb_Modules";
            this.comb_Modules.Size = new System.Drawing.Size(286, 26);
            this.comb_Modules.TabIndex = 140;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 139;
            this.label7.Text = "Module :";
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
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_Grade_Buton,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1191, 39);
            this.toolStrip2.TabIndex = 145;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Grade_Buton
            // 
            this.Create_Grade_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Grade_Buton.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Grade_Buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Grade_Buton.Name = "Create_Grade_Buton";
            this.Create_Grade_Buton.Size = new System.Drawing.Size(146, 36);
            this.Create_Grade_Buton.Text = "Create Element";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ViewElement);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(423, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 507);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // dgv_ViewElement
            // 
            this.dgv_ViewElement.AllowUserToAddRows = false;
            this.dgv_ViewElement.AllowUserToDeleteRows = false;
            this.dgv_ViewElement.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewElement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewElement.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewElement.Location = new System.Drawing.Point(3, 18);
            this.dgv_ViewElement.MultiSelect = false;
            this.dgv_ViewElement.Name = "dgv_ViewElement";
            this.dgv_ViewElement.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewElement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ViewElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewElement.Size = new System.Drawing.Size(750, 486);
            this.dgv_ViewElement.TabIndex = 1;
            // 
            // Form_Details_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_GradeType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Status);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rd_Default);
            this.Controls.Add(this.txt_Grade_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comb_Modules);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form_Details_Management";
            this.Text = "Form_Details_Management";
            this.Load += new System.EventHandler(this.Form_Details_Management_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_GradeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Status;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rd_Default;
        private System.Windows.Forms.TextBox txt_Grade_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comb_Modules;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Grade_Buton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ViewElement;

    }
}