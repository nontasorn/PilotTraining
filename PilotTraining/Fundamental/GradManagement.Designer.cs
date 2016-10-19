namespace PilotTraining.Fundamental
{
    partial class GradManagement
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
            this.Create_Grade_Buton = new System.Windows.Forms.ToolStripButton();
            this.Edit_Grade_Button = new System.Windows.Forms.ToolStripButton();
            this.Delete_Grade_Button = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_Grade_Type = new System.Windows.Forms.ComboBox();
            this.txt_Grade_Rate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Grade_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ViewGrade = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewGrade)).BeginInit();
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
            this.toolStrip2.Size = new System.Drawing.Size(1073, 39);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Grade_Buton
            // 
            this.Create_Grade_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Grade_Buton.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Grade_Buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Grade_Buton.Name = "Create_Grade_Buton";
            this.Create_Grade_Buton.Size = new System.Drawing.Size(133, 36);
            this.Create_Grade_Buton.Text = "Create Grade";
            this.Create_Grade_Buton.Click += new System.EventHandler(this.Create_Grade_Buton_Click);
            // 
            // Edit_Grade_Button
            // 
            this.Edit_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Grade_Button.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Grade_Button.Name = "Edit_Grade_Button";
            this.Edit_Grade_Button.Size = new System.Drawing.Size(114, 36);
            this.Edit_Grade_Button.Text = "Edit Grade";
            this.Edit_Grade_Button.Click += new System.EventHandler(this.Edit_Grade_Button_Click);
            // 
            // Delete_Grade_Button
            // 
            this.Delete_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Delete_Grade_Button.Image = global::PilotTraining.Properties.Resources.delete_file_icon;
            this.Delete_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Grade_Button.Name = "Delete_Grade_Button";
            this.Delete_Grade_Button.Size = new System.Drawing.Size(131, 36);
            this.Delete_Grade_Button.Text = "Delete Grade";
            this.Delete_Grade_Button.Click += new System.EventHandler(this.Delete_Grade_Button_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewGrade, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.56088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 490);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comb_Grade_Type);
            this.groupBox1.Controls.Add(this.txt_Grade_Rate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Grade_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Management";
            // 
            // comb_Grade_Type
            // 
            this.comb_Grade_Type.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_Grade_Type.FormattingEnabled = true;
            this.comb_Grade_Type.Location = new System.Drawing.Point(196, 76);
            this.comb_Grade_Type.Name = "comb_Grade_Type";
            this.comb_Grade_Type.Size = new System.Drawing.Size(286, 26);
            this.comb_Grade_Type.TabIndex = 127;
            // 
            // txt_Grade_Rate
            // 
            this.txt_Grade_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Grade_Rate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grade_Rate.Location = new System.Drawing.Point(196, 148);
            this.txt_Grade_Rate.Name = "txt_Grade_Rate";
            this.txt_Grade_Rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Grade_Rate.Size = new System.Drawing.Size(286, 26);
            this.txt_Grade_Rate.TabIndex = 126;
            this.txt_Grade_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Grade_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Grade_Rate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Rate :";
            // 
            // txt_Grade_Name
            // 
            this.txt_Grade_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Grade_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grade_Name.Location = new System.Drawing.Point(196, 113);
            this.txt_Grade_Name.Name = "txt_Grade_Name";
            this.txt_Grade_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Grade_Name.Size = new System.Drawing.Size(451, 26);
            this.txt_Grade_Name.TabIndex = 124;
            this.txt_Grade_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 123;
            this.label1.Text = "Grade Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Grade Type :";
            // 
            // dgv_ViewGrade
            // 
            this.dgv_ViewGrade.AllowUserToAddRows = false;
            this.dgv_ViewGrade.AllowUserToDeleteRows = false;
            this.dgv_ViewGrade.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewGrade.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewGrade.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewGrade.MultiSelect = false;
            this.dgv_ViewGrade.Name = "dgv_ViewGrade";
            this.dgv_ViewGrade.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewGrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ViewGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewGrade.Size = new System.Drawing.Size(1067, 203);
            this.dgv_ViewGrade.TabIndex = 0;
            this.dgv_ViewGrade.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewGrade_CellMouseUp);
            // 
            // GradManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "GradManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GradManagement";
            this.Load += new System.EventHandler(this.GradManagement_Load);
            this.Resize += new System.EventHandler(this.GradManagement_Resize);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Grade_Buton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_ViewGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Grade_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Grade_Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton Edit_Grade_Button;
        private System.Windows.Forms.ToolStripButton Delete_Grade_Button;
        private System.Windows.Forms.ComboBox comb_Grade_Type;
        private System.Windows.Forms.ToolStripButton Refresh_btn;

    }
}