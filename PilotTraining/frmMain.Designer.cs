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
            this.memuDataMain = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Grade1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Grade_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Training_Type1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Training_Type_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_From1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Form_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Course1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Course_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employee_Management2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Training_Management_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Assign_Course_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblUser = new System.Windows.Forms.ToolStripLabel();
            this.Menu_TrainingDetails1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreateTrainingDetails2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Menu_Training_Management_Menu,
            this.viewToolStripMenuItem});
            this.Menu_Home.Location = new System.Drawing.Point(0, 0);
            this.Menu_Home.Name = "Menu_Home";
            this.Menu_Home.Size = new System.Drawing.Size(984, 28);
            this.Menu_Home.TabIndex = 12;
            this.Menu_Home.Text = "menuStrip1";
            // 
            // memuDataMain
            // 
            this.memuDataMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Grade1,
            this.Menu_Training_Type1,
            this.Menu_From1,
            this.Menu_Course1,
            this.Menu_TrainingDetails1});
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
            this.Menu_Grade1.Size = new System.Drawing.Size(187, 24);
            this.Menu_Grade1.Text = "Grade";
            // 
            // Menu_Grade_Management2
            // 
            this.Menu_Grade_Management2.Name = "Menu_Grade_Management2";
            this.Menu_Grade_Management2.Size = new System.Drawing.Size(221, 24);
            this.Menu_Grade_Management2.Text = "Grade Management";
            this.Menu_Grade_Management2.Click += new System.EventHandler(this.Menu_Grade_Management2_Click);
            // 
            // Menu_Training_Type1
            // 
            this.Menu_Training_Type1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Training_Type_Management2});
            this.Menu_Training_Type1.Name = "Menu_Training_Type1";
            this.Menu_Training_Type1.Size = new System.Drawing.Size(187, 24);
            this.Menu_Training_Type1.Text = "Training Type";
            // 
            // Menu_Training_Type_Management2
            // 
            this.Menu_Training_Type_Management2.Name = "Menu_Training_Type_Management2";
            this.Menu_Training_Type_Management2.Size = new System.Drawing.Size(258, 24);
            this.Menu_Training_Type_Management2.Text = "Traing Type Management";
            this.Menu_Training_Type_Management2.Click += new System.EventHandler(this.Menu_Training_Type_Management2_Click);
            // 
            // Menu_From1
            // 
            this.Menu_From1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Form_Management2});
            this.Menu_From1.Name = "Menu_From1";
            this.Menu_From1.Size = new System.Drawing.Size(187, 24);
            this.Menu_From1.Text = "Form";
            // 
            // Menu_Form_Management2
            // 
            this.Menu_Form_Management2.Name = "Menu_Form_Management2";
            this.Menu_Form_Management2.Size = new System.Drawing.Size(213, 24);
            this.Menu_Form_Management2.Text = "Form Management";
            this.Menu_Form_Management2.Click += new System.EventHandler(this.Menu_Form_Management2_Click);
            // 
            // Menu_Course1
            // 
            this.Menu_Course1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Course_Management2});
            this.Menu_Course1.Name = "Menu_Course1";
            this.Menu_Course1.Size = new System.Drawing.Size(187, 24);
            this.Menu_Course1.Text = "Course";
            // 
            // Menu_Course_Management2
            // 
            this.Menu_Course_Management2.Name = "Menu_Course_Management2";
            this.Menu_Course_Management2.Size = new System.Drawing.Size(227, 24);
            this.Menu_Course_Management2.Text = "Course Management";
            this.Menu_Course_Management2.Click += new System.EventHandler(this.Menu_Course_Management2_Click);
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
            this.Menu_Employee1.Size = new System.Drawing.Size(142, 22);
            this.Menu_Employee1.Text = "Employee";
            // 
            // Menu_Employee_Management2
            // 
            this.Menu_Employee_Management2.Name = "Menu_Employee_Management2";
            this.Menu_Employee_Management2.Size = new System.Drawing.Size(232, 22);
            this.Menu_Employee_Management2.Text = "Employee Management";
            this.Menu_Employee_Management2.Click += new System.EventHandler(this.Menu_Employee_Management2_Click);
            // 
            // Menu_Training_Management_Menu
            // 
            this.Menu_Training_Management_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingManagementToolStripMenuItem});
            this.Menu_Training_Management_Menu.Name = "Menu_Training_Management_Menu";
            this.Menu_Training_Management_Menu.Size = new System.Drawing.Size(162, 24);
            this.Menu_Training_Management_Menu.Text = "Training Management";
            // 
            // trainingManagementToolStripMenuItem
            // 
            this.trainingManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Assign_Course_Menu});
            this.trainingManagementToolStripMenuItem.Name = "trainingManagementToolStripMenuItem";
            this.trainingManagementToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.trainingManagementToolStripMenuItem.Text = "Training Management";
            // 
            // Assign_Course_Menu
            // 
            this.Assign_Course_Menu.Name = "Assign_Course_Menu";
            this.Assign_Course_Menu.Size = new System.Drawing.Size(173, 22);
            this.Assign_Course_Menu.Text = "Assign Course";
            this.Assign_Course_Menu.Click += new System.EventHandler(this.Assign_Course_Menu_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.viewToolStripMenuItem.Text = "View";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Image = global::PilotTraining.Properties.Resources.Emp;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Login :";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 22);
            // 
            // Menu_TrainingDetails1
            // 
            this.Menu_TrainingDetails1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreateTrainingDetails2});
            this.Menu_TrainingDetails1.Name = "Menu_TrainingDetails1";
            this.Menu_TrainingDetails1.Size = new System.Drawing.Size(187, 24);
            this.Menu_TrainingDetails1.Text = "Training Details";
            // 
            // MenuCreateTrainingDetails2
            // 
            this.MenuCreateTrainingDetails2.Name = "MenuCreateTrainingDetails2";
            this.MenuCreateTrainingDetails2.Size = new System.Drawing.Size(239, 24);
            this.MenuCreateTrainingDetails2.Text = "Create Training Details";
            this.MenuCreateTrainingDetails2.Click += new System.EventHandler(this.MenuCreateTrainingDetails2_Click);
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
        private System.Windows.Forms.ToolStripMenuItem Menu_Training_Management_Menu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Training_Type1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Training_Type_Management2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Course1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Course_Management2;
        private System.Windows.Forms.ToolStripMenuItem trainingManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Assign_Course_Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_TrainingDetails1;
        private System.Windows.Forms.ToolStripMenuItem MenuCreateTrainingDetails2;
    }
}