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
    public partial class assignments : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public assignments()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_assignmentID.Text == " " && txt_assignmentName.Text == " " && tp_date.Value.ToString() == " ")
            {
                MessageBox.Show("All fields should be filled", "Add Assignment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string add_assignment = "INSERT INTO assignments VALUES ('" + txt_assignmentID.Text + "','" + txt_assignmentName.Text + "','" + txt_courseCode.Text + "','" + txt_courseName.Text + "','" + tp_date.Value.ToString() + "')";

                cmd = new OleDbCommand(add_assignment, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_assignmentID.Text = " ";
                txt_assignmentName.Text = " ";
                //txt_dueDate.Text = " ";

                MessageBox.Show("Your assignment has been Successfully Added", "Add Class Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }//end of add assignment

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_assignmentID.Text == " " && txt_assignmentName.Text == " " && tp_date.Value.ToString() == " ")
            {
                MessageBox.Show("All fields should be filled", "Update Assignment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update assignments set AssignmentID='" + txt_assignmentID.Text + "', AssignmentName= '" + txt_assignmentName.Text + "', CourseName= '" + txt_courseName.Text + "', DueDate= '" + tp_date.Text + "'where CourseCode='" + txt_courseCode.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();


                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_assignmentID.Text = " ";
                txt_assignmentName.Text = " ";
                //txt_dueDate.Text = " ";

                MessageBox.Show("Your Assignment has been Successfully Updated", "Update Assignment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            new ViewAssignments().Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            new DeleteAssignment().Show();
            
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btn_myclasses_Click_1(object sender, EventArgs e)
        {
            new classes().Show();
            this.Hide();
        }

        private void btn_courses_Click_1(object sender, EventArgs e)
        {
            new courses().Show();
            this.Hide();
        }

        private void btn_assignments_Click(object sender, EventArgs e)
        {
            new assignments().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
