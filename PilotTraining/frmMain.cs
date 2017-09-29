using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PilotTraining.Class;

namespace PilotTraining
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Menu_Grade_Management2_Click(object sender, EventArgs e)
        {
            Fundamental.GradManagement frm = new Fundamental.GradManagement();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Menu_Employee_Management2_Click(object sender, EventArgs e)
        {
            Administration.Employee_Management frm = new Administration.Employee_Management();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            lblUser.Text= DBConnString.sUserlogin;
            this.Activate();
            
        }

        private void Menu_Training_Type_Management2_Click(object sender, EventArgs e)
        {
            Fundamental.Training_Type frm = new Fundamental.Training_Type();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Menu_Course_Management2_Click(object sender, EventArgs e)
        {
            Fundamental.Course_Management frm = new Fundamental.Course_Management();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Assign_Course_Menu_Click(object sender, EventArgs e)
        {
            TrainingManagement.TrainingManagement frm = new TrainingManagement.TrainingManagement();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Menu_Form_Management2_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuCreateTrainingDetails2_Click(object sender, EventArgs e)
        {
            Fundamental.MainTopic frm = new Fundamental.MainTopic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SubjectManagementMenu_Click(object sender, EventArgs e)
        {
            Fundamental.Subject frm = new Fundamental.Subject();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Subtopic_Click(object sender, EventArgs e)
        {
            Fundamental.SubTopic frm = new Fundamental.SubTopic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SubSubjectManagementMenu_Click(object sender, EventArgs e)
        {
            Fundamental.Sub_Subject frm = new Fundamental.Sub_Subject();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ViewSchedulebtn_Click(object sender, EventArgs e)
        {
            TrainingManagement.ViewSchedule frm = new TrainingManagement.ViewSchedule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NonTechnicalSkill_Btn_Click(object sender, EventArgs e)
        {
            Fundamental.NonTechnicalList frm = new Fundamental.NonTechnicalList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Category_Btn_Click(object sender, EventArgs e)
        {
            Fundamental.NonTechnicalCategoryList frm = new Fundamental.NonTechnicalCategoryList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void subcate_btn_Click(object sender, EventArgs e)
        {
            Fundamental.NonTechnicalSubList frm = new Fundamental.NonTechnicalSubList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void University_Main_List_Click(object sender, EventArgs e)
        {
            Fundamental.UniversityList frm = new Fundamental.UniversityList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void University_Category_List_Click(object sender, EventArgs e)
        {
            Fundamental.List.UniversityCategoryList frm = new Fundamental.List.UniversityCategoryList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From.frmFromSubmit frm = new From.frmFromSubmit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ViewTopic_Click(object sender, EventArgs e)
        {
            Fundamental.Topic.ViewTopic frm = new Fundamental.Topic.ViewTopic();
            frm.MdiParent = this;
            frm.Show();
        }


        
    }
}
