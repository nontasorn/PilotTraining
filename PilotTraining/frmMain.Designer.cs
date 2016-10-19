namespace PilotTraining
{
    partial class frmMain
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
            this.Menu_Home = new System.Windows.Forms.MenuStrip();
            this.Menu_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.memuDataMain = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Grade1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Grade_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_From1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Form_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Home.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Home
            // 
            this.Menu_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuDataMain,
            this.Menu_Administration,
            this.assignCourseToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.Menu_Home.Location = new System.Drawing.Point(0, 0);
            this.Menu_Home.Name = "Menu_Home";
            this.Menu_Home.Size = new System.Drawing.Size(984, 28);
            this.Menu_Home.TabIndex = 12;
            this.Menu_Home.Text = "menuStrip1";
            // 
            // Menu_Administration
            // 
            this.Menu_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Employee1});
            this.Menu_Administration.Image = global::PilotTraining.Properties.Resources.helpdesk;
            this.Menu_Administration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Administration.Name = "Menu_Administration";
            this.Menu_Administration.Size = new System.Drawing.Size(129, 24);
            this.Menu_Administration.Text = "Administration";
            // 
            // Menu_Employee1
            // 
            this.Menu_Employee1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Employee_Management2});
            this.Menu_Employee1.Name = "Menu_Employee1";
            this.Menu_Employee1.Size = new System.Drawing.Size(152, 22);
            this.Menu_Employee1.Text = "Employee";
            // 
            // Menu_Employee_Management2
            // 
            this.Menu_Employee_Management2.Name = "Menu_Employee_Management2";
            this.Menu_Employee_Management2.Size = new System.Drawing.Size(232, 22);
            this.Menu_Employee_Management2.Text = "Employee Management";
            this.Menu_Employee_Management2.Click += new System.EventHandler(this.Menu_Employee_Management2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 536);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Image = global::PilotTraining.Properties.Resources.Emp;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Login :";
            // 
            // memuDataMain
            // 
            this.memuDataMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Grade1,
            this.Menu_From1});
            this.memuDataMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memuDataMain.Image = global::PilotTraining.Properties.Resources._21;
            this.memuDataMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memuDataMain.Name = "memuDataMain";
            this.memuDataMain.Size = new System.Drawing.Size(131, 24);
            this.memuDataMain.Text = "Fundamental";
            // 
            // Menu_Grade1
            // 
            this.Menu_Grade1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Grade_Management2});
            this.Menu_Grade1.Name = "Menu_Grade1";
            this.Menu_Grade1.Size = new System.Drawing.Size(152, 24);
            this.Menu_Grade1.Text = "Grade";
            // 
            // Menu_Grade_Management2
            // 
            this.Menu_Grade_Management2.Name = "Menu_Grade_Management2";
            this.Menu_Grade_Management2.Size = new System.Drawing.Size(221, 24);
            this.Menu_Grade_Management2.Text = "Grade Management";
            this.Menu_Grade_Management2.Click += new System.EventHandler(this.Menu_Grade_Management2_Click);
            // 
            // Menu_From1
            // 
            this.Menu_From1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Form_Management2});
            this.Menu_From1.Name = "Menu_From1";
            this.Menu_From1.Size = new System.Drawing.Size(152, 24);
            this.Menu_From1.Text = "Form";
            // 
            // Menu_Form_Management2
            // 
            this.Menu_Form_Management2.Name = "Menu_Form_Management2";
            this.Menu_Form_Management2.Size = new System.Drawing.Size(213, 24);
            this.Menu_Form_Management2.Text = "Form Management";
            // 
            // assignCourseToolStripMenuItem
            // 
            this.assignCourseToolStripMenuItem.Name = "assignCourseToolStripMenuItem";
            this.assignCourseToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.assignCourseToolStripMenuItem.Text = "Assign Course";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Menu_Home);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_Home;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Menu_Home.ResumeLayout(false);
            this.Menu_Home.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Home;
        private System.Windows.Forms.ToolStripMenuItem memuDataMain;
        private System.Windows.Forms.ToolStripMenuItem Menu_Grade1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Grade_Management2;
        private System.Windows.Forms.ToolStripMenuItem Menu_From1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Form_Management2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Administration;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employee_Management2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem assignCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}