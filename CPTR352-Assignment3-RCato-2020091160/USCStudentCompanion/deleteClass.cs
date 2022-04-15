using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace USCStudentCompanion
{
    public partial class deleteClass : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");

        public deleteClass()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " ")
            {
                MessageBox.Show("Please Enter The Course Code", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string deleteQuery = "delete from myCourses where CourseCode ='" + txt_courseCode.Text + "'";
                cmd.CommandText = deleteQuery;

                cmd.ExecuteNonQuery();
                con.Close();
                txt_courseCode.Text = " ";

                MessageBox.Show("Class successfully removed", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
