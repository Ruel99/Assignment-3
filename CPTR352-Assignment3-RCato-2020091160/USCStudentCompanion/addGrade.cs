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
    public partial class addGrade : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");

        public addGrade()
        {
            InitializeComponent();
        }

        private void btn_enterGrade_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_grade.Text == " ")
            {
                MessageBox.Show("Course code and grade fields are empty", "Add Grade Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set  Grade= '" + txt_grade.Text + "'where CourseCode='" + txt_courseCode.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                txt_courseCode.Text = " ";
                txt_grade.Text = " ";

                MessageBox.Show("Your grade has been Successfully entered", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
