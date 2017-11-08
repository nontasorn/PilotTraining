using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotTraining.From
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        private DataTable tblCustomer;
        private DataTable tblOrder;
        private DataSet tblDataSet; 


        private void test_Load(object sender, EventArgs e)
        {
           
            //Parent table

            DataTable dtstudent = new DataTable();

            // add column to datatable  

            dtstudent.Columns.Add("Student_ID", typeof(int));

            dtstudent.Columns.Add("Student_Name", typeof(string));

            dtstudent.Columns.Add("Student_RollNo", typeof(string));





            //Child table

            DataTable dtstudentMarks = new DataTable();

            dtstudentMarks.Columns.Add("Student_ID", typeof(int));

            dtstudentMarks.Columns.Add("Subject_ID", typeof(int));

            dtstudentMarks.Columns.Add("Subject_Name", typeof(string));

            dtstudentMarks.Columns.Add("Marks", typeof(int));







            //Adding Rows



            dtstudent.Rows.Add(111, "Devesh", "03021013014");

            dtstudent.Rows.Add(222, "ROLI", "0302101444");

            dtstudent.Rows.Add(333, "ROLI Ji", "030212222");

            dtstudent.Rows.Add(444, "NIKHIL", "KANPUR");



            // data for devesh ID=111

            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);

            dtstudentMarks.Rows.Add(111, "02", "Maths", 77);

            dtstudentMarks.Rows.Add(111, "03", "C#", 100);

            dtstudentMarks.Rows.Add(111, "01", "Physics", 99);





            //data for ROLI ID=222

            dtstudentMarks.Rows.Add(222, "01", "Physics", 80);

            dtstudentMarks.Rows.Add(222, "02", "English", 95);

            dtstudentMarks.Rows.Add(222, "03", "Commerce", 95);

            dtstudentMarks.Rows.Add(222, "01", "BankPO", 99);


           


            DataSet dsDataset = new DataSet();

            //Add two DataTables  in Dataset

            dsDataset.Tables.Add(dtstudent);

            dsDataset.Tables.Add(dtstudentMarks);


            DataRelation Datatablerelation = new DataRelation("DetailsMarks", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[0], true);

            dsDataset.Relations.Add(Datatablerelation);

            dataGrid1.DataSource = dsDataset.Tables[0];
            

            
        }

    }
}
