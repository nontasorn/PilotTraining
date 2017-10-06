namespace PilotTraining.Fundamental.Topic
{
    partial class ViewTopic
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolcmbFormName = new System.Windows.Forms.ToolStripComboBox();
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_ViewSubTopic = new System.Windows.Forms.DataGridView();
            this.dgv_ViewMainTopic = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewMainTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolcmbFormName,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(984, 39);
            this.toolStrip2.TabIndex = 129;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 36);
            this.toolStripLabel1.Text = "Form : ";
            // 
            // toolcmbFormName
            // 
            this.toolcmbFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolcmbFormName.Name = "toolcmbFormName";
            this.toolcmbFormName.Size = new System.Drawing.Size(150, 39);
            this.toolcmbFormName.SelectedIndexChanged += new System.EventHandler(this.toolcmbFormName_SelectedIndexChanged);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.Image = global::PilotTraining.Properties.Resources.refresh;
            this.Refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(97, 36);
            this.Refresh_btn.Text = "Search";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewSubTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewMainTopic, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 499);
            this.tableLayoutPanel1.TabIndex = 130;
            // 
            // dgv_ViewSubTopic
            // 
            this.dgv_ViewSubTopic.AllowUserToAddRows = false;
            this.dgv_ViewSubTopic.AllowUserToDeleteRows = false;
            this.dgv_ViewSubTopic.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewSubTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewSubTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewSubTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewSubTopic.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewSubTopic.Location = new System.Drawing.Point(3, 252);
            this.dgv_ViewSubTopic.MultiSelect = false;
            this.dgv_ViewSubTopic.Name = "dgv_ViewSubTopic";
            this.dgv_ViewSubTopic.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewSubTopic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewSubTopic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewSubTopic.Size = new System.Drawing.Size(978, 244);
            this.dgv_ViewSubTopic.TabIndex = 2;
            // 
            // dgv_ViewMainTopic
            // 
            this.dgv_ViewMainTopic.AllowUserToAddRows = false;
            this.dgv_ViewMainTopic.AllowUserToDeleteRows = false;
            this.dgv_ViewMainTopic.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewMainTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewMainTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewMainTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewMainTopic.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewMainTopic.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewMainTopic.MultiSelect = false;
            this.dgv_ViewMainTopic.Name = "dgv_ViewMainTopic";
            this.dgv_ViewMainTopic.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewMainTopic.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ViewMainTopic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewMainTopic.Size = new System.Drawing.Size(978, 243);
            this.dgv_ViewMainTopic.TabIndex = 1;
            // 
            // ViewTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "ViewTopic";
            this.Text = "ViewTopic";
            this.Load += new System.EventHandler(this.ViewTopic_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSubTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewMainTopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.ToolStripComboBox toolcmbFormName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_ViewSubTopic;
        private System.Windows.Forms.DataGridView dgv_ViewMainTopic;
    }
}