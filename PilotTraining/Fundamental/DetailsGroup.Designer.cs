namespace PilotTraining.Fundamental
{
    partial class DetailsGroup
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
            this.lblDetailId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Grade_Rate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ViewTrainingDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewTrainingDetails)).BeginInit();
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
            this.toolStrip2.Size = new System.Drawing.Size(786, 39);
            this.toolStrip2.TabIndex = 128;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Grade_Buton
            // 
            this.Create_Grade_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Grade_Buton.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Grade_Buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Grade_Buton.Name = "Create_Grade_Buton";
            this.Create_Grade_Buton.Size = new System.Drawing.Size(88, 36);
            this.Create_Grade_Buton.Text = "Create";
            // 
            // Edit_Grade_Button
            // 
            this.Edit_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Grade_Button.Image = global::PilotTraining.Properties.Resources.edit_file_icon;
            this.Edit_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Grade_Button.Name = "Edit_Grade_Button";
            this.Edit_Grade_Button.Size = new System.Drawing.Size(69, 36);
            this.Edit_Grade_Button.Text = "Edit";
            // 
            // Delete_Grade_Button
            // 
            this.Delete_Grade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Delete_Grade_Button.Image = global::PilotTraining.Properties.Resources.delete_file_icon;
            this.Delete_Grade_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Grade_Button.Name = "Delete_Grade_Button";
            this.Delete_Grade_Button.Size = new System.Drawing.Size(86, 36);
            this.Delete_Grade_Button.Text = "Delete";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ViewTrainingDetails, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.56088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 420);
            this.tableLayoutPanel1.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lblDetailId);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comb_Status);
            this.groupBox1.Controls.Add(this.txt_Grade_Rate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Details";
            // 
            // lblDetailId
            // 
            this.lblDetailId.AutoSize = true;
            this.lblDetailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailId.Location = new System.Drawing.Point(193, 32);
            this.lblDetailId.Name = "lblDetailId";
            this.lblDetailId.Size = new System.Drawing.Size(0, 18);
            this.lblDetailId.TabIndex = 130;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(286, 26);
            this.textBox1.TabIndex = 129;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Description :";
            // 
            // comb_Status
            // 
            this.comb_Status.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comb_Status.FormattingEnabled = true;
            this.comb_Status.Location = new System.Drawing.Point(196, 142);
            this.comb_Status.Name = "comb_Status";
            this.comb_Status.Size = new System.Drawing.Size(286, 26);
            this.comb_Status.TabIndex = 127;
            // 
            // txt_Grade_Rate
            // 
            this.txt_Grade_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Grade_Rate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grade_Rate.Location = new System.Drawing.Point(196, 104);
            this.txt_Grade_Rate.Name = "txt_Grade_Rate";
            this.txt_Grade_Rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Grade_Rate.Size = new System.Drawing.Size(286, 26);
            this.txt_Grade_Rate.TabIndex = 126;
            this.txt_Grade_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Order :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 123;
            this.label1.Text = "Detail # :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Status :";
            // 
            // dgv_ViewTrainingDetails
            // 
            this.dgv_ViewTrainingDetails.AllowUserToAddRows = false;
            this.dgv_ViewTrainingDetails.AllowUserToDeleteRows = false;
            this.dgv_ViewTrainingDetails.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ViewTrainingDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ViewTrainingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewTrainingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewTrainingDetails.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ViewTrainingDetails.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViewTrainingDetails.MultiSelect = false;
            this.dgv_ViewTrainingDetails.Name = "dgv_ViewTrainingDetails";
            this.dgv_ViewTrainingDetails.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ViewTrainingDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ViewTrainingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewTrainingDetails.Size = new System.Drawing.Size(780, 179);
            this.dgv_ViewTrainingDetails.TabIndex = 0;
            // 
            // DetailsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "DetailsGroup";
            this.Text = "DetailsGroup";
            this.Load += new System.EventHandler(this.DetailsGroup_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewTrainingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Grade_Buton;
        private System.Windows.Forms.ToolStripButton Edit_Grade_Button;
        private System.Windows.Forms.ToolStripButton Delete_Grade_Button;
        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_Status;
        private System.Windows.Forms.TextBox txt_Grade_Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_ViewTrainingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDetailId;
    }
}