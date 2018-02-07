namespace PilotTraining.Fundamental.Aircraft
{
    partial class AircraftType
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
            this.Create_AircraftType = new System.Windows.Forms.ToolStripButton();
            this.Edit_AircraftType = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAircraftTypeId = new System.Windows.Forms.Label();
            this.txtAircraftTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ViewAircraftType = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAircraftType)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_AircraftType,
            this.Edit_AircraftType,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(884, 39);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_AircraftType
            // 
            this.Create_AircraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_AircraftType.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_AircraftType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_AircraftType.Name = "Create_AircraftType";
            this.Create_AircraftType.Size = new System.Drawing.Size(174, 36);
            this.Create_AircraftType.Text = "Create Aircraft Type";
            this.Create_AircraftType.Click += new System.EventHandler(this.Create_AircraftType_Click);
            // 
            // Edit_AircraftType
            // 
            this.Edit_AircraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_AircraftType.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_AircraftType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_AircraftType.Name = "Edit_AircraftType";
            this.Edit_AircraftType.Size = new System.Drawing.Size(155, 36);
            this.Edit_AircraftType.Text = "Edit Aircraft Type";
            this.Edit_AircraftType.Click += new System.EventHandler(this.Edit_AircraftType_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewAircraftType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 523);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comb_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAircraftTypeId);
            this.groupBox1.Controls.Add(this.txtAircraftTypeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aircraft Type";
            // 
            // comb_status
            // 
            this.comb_status.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_status.FormattingEnabled = true;
            this.comb_status.Location = new System.Drawing.Point(269, 143);
            this.comb_status.Name = "comb_status";
            this.comb_status.Size = new System.Drawing.Size(96, 26);
            this.comb_status.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Status :";
            // 
            // lblAircraftTypeId
            // 
            this.lblAircraftTypeId.AutoSize = true;
            this.lblAircraftTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftTypeId.Location = new System.Drawing.Point(266, 65);
            this.lblAircraftTypeId.Name = "lblAircraftTypeId";
            this.lblAircraftTypeId.Size = new System.Drawing.Size(16, 18);
            this.lblAircraftTypeId.TabIndex = 127;
            this.lblAircraftTypeId.Text = "#";
            // 
            // txtAircraftTypeName
            // 
            this.txtAircraftTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAircraftTypeName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAircraftTypeName.Location = new System.Drawing.Point(269, 98);
            this.txtAircraftTypeName.Name = "txtAircraftTypeName";
            this.txtAircraftTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAircraftTypeName.Size = new System.Drawing.Size(383, 26);
            this.txtAircraftTypeName.TabIndex = 126;
            this.txtAircraftTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Type Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 123;
            this.label1.Text = "Aircraft type :";
            // 
            // dgv_ViewAircraftType
            // 
            this.dgv_ViewAircraftType.AllowUserToAddRows = false;
            this.dgv_ViewAircraftType.AllowUserToDeleteRows = false;
            this.dgv_ViewAircraftType.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewAircraftType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewAircraftType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewAircraftType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewAircraftType.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewAircraftType.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewAircraftType.MultiSelect = false;
            this.dgv_ViewAircraftType.Name = "dgv_ViewAircraftType";
            this.dgv_ViewAircraftType.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewAircraftType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewAircraftType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewAircraftType.Size = new System.Drawing.Size(878, 246);
            this.dgv_ViewAircraftType.TabIndex = 0;
            this.dgv_ViewAircraftType.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ViewAircraftType_CellMouseUp);
            // 
            // AircraftType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "AircraftType";
            this.Text = "AircraftType";
            this.Load += new System.EventHandler(this.AircraftType_Load);
            this.Resize += new System.EventHandler(this.AircraftType_Resize);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewAircraftType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_AircraftType;
        private System.Windows.Forms.ToolStripButton Edit_AircraftType;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAircraftTypeId;
        private System.Windows.Forms.TextBox txtAircraftTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ViewAircraftType;
    }
}