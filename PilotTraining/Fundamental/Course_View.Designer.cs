namespace PilotTraining.Fundamental
{
    partial class Course_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCheckResult = new System.Windows.Forms.Label();
            this.dgv_Course_Modules_View = new System.Windows.Forms.DataGridView();
            this.dgv_Course_View = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Edit_Course_Btn = new System.Windows.Forms.ToolStripButton();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_Modules_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_View)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCheckResult, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Course_Modules_View, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Course_View, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCheckResult
            // 
            this.lblCheckResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCheckResult.BackColor = System.Drawing.Color.ForestGreen;
            this.lblCheckResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCheckResult.ForeColor = System.Drawing.Color.White;
            this.lblCheckResult.Location = new System.Drawing.Point(3, 498);
            this.lblCheckResult.Name = "lblCheckResult";
            this.lblCheckResult.Size = new System.Drawing.Size(186, 20);
            this.lblCheckResult.TabIndex = 54;
            this.lblCheckResult.Text = "Total Courses :";
            this.lblCheckResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_Course_Modules_View
            // 
            this.dgv_Course_Modules_View.AllowUserToAddRows = false;
            this.dgv_Course_Modules_View.AllowUserToDeleteRows = false;
            this.dgv_Course_Modules_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Course_Modules_View.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_Course_Modules_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Course_Modules_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_Modules_View.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_Course_Modules_View.Location = new System.Drawing.Point(3, 252);
            this.dgv_Course_Modules_View.MultiSelect = false;
            this.dgv_Course_Modules_View.Name = "dgv_Course_Modules_View";
            this.dgv_Course_Modules_View.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Course_Modules_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Course_Modules_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Course_Modules_View.Size = new System.Drawing.Size(891, 243);
            this.dgv_Course_Modules_View.TabIndex = 132;
            // 
            // dgv_Course_View
            // 
            this.dgv_Course_View.AllowUserToAddRows = false;
            this.dgv_Course_View.AllowUserToDeleteRows = false;
            this.dgv_Course_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Course_View.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_Course_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Course_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_View.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_Course_View.Location = new System.Drawing.Point(3, 3);
            this.dgv_Course_View.MultiSelect = false;
            this.dgv_Course_View.Name = "dgv_Course_View";
            this.dgv_Course_View.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Course_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Course_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Course_View.Size = new System.Drawing.Size(891, 243);
            this.dgv_Course_View.TabIndex = 131;
            this.dgv_Course_View.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Course_View_CellMouseUp);
            this.dgv_Course_View.Resize += new System.EventHandler(this.dgv_Course_View_Resize);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_Course_Btn,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(898, 39);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Edit_Course_Btn
            // 
            this.Edit_Course_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Course_Btn.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Course_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Course_Btn.Name = "Edit_Course_Btn";
            this.Edit_Course_Btn.Size = new System.Drawing.Size(122, 36);
            this.Edit_Course_Btn.Text = "Edit Course";
            this.Edit_Course_Btn.Click += new System.EventHandler(this.Edit_Course_Btn_Click);
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
            // Course_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 560);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Course_View";
            this.Text = "Course_View";
            this.Load += new System.EventHandler(this.Course_View_Load);
            this.Resize += new System.EventHandler(this.Course_View_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_Modules_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_View)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Edit_Course_Btn;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.DataGridView dgv_Course_View;
        private System.Windows.Forms.DataGridView dgv_Course_Modules_View;
        internal System.Windows.Forms.Label lblCheckResult;
    }
}