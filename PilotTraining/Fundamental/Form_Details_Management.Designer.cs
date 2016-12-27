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
            this.Refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Create_Element_Buton = new System.Windows.Forms.ToolStripButton();
            this.dgv_MainElement = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MainElement)).BeginInit();
            this.SuspendLayout();
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
            this.Create_Element_Buton,
            this.Refresh_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1191, 39);
            this.toolStrip2.TabIndex = 145;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Create_Element_Buton
            // 
            this.Create_Element_Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Element_Buton.Image = global::PilotTraining.Properties.Resources.Add_icon;
            this.Create_Element_Buton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_Element_Buton.Name = "Create_Element_Buton";
            this.Create_Element_Buton.Size = new System.Drawing.Size(146, 36);
            this.Create_Element_Buton.Text = "Create Element";
            this.Create_Element_Buton.Click += new System.EventHandler(this.Create_Element_Buton_Click);
            // 
            // dgv_MainElement
            // 
            this.dgv_MainElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MainElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MainElement.Location = new System.Drawing.Point(12, 56);
            this.dgv_MainElement.Name = "dgv_MainElement";
            this.dgv_MainElement.Size = new System.Drawing.Size(1167, 150);
            this.dgv_MainElement.TabIndex = 146;
            this.dgv_MainElement.Resize += new System.EventHandler(this.dgv_MainElement_Resize);
            // 
            // Form_Details_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 561);
            this.Controls.Add(this.dgv_MainElement);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form_Details_Management";
            this.Text = "Form_Details_Management";
            this.Load += new System.EventHandler(this.Form_Details_Management_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MainElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Refresh_btn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Create_Element_Buton;
        private System.Windows.Forms.DataGridView dgv_MainElement;

    }
}