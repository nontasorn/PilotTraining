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
        private SqlConnection Conn;

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

        
    }
}
