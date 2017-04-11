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
            Fundamental.Form_Details_Management frm = new Fundamental.Form_Details_Management();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuCreateTrainingDetails2_Click(object sender, EventArgs e)
        {
            Fundamental.DetailsGroup frm = new Fundamental.DetailsGroup();
            frm.MdiParent = this;
            frm.Show();
        }

        
    }
}
