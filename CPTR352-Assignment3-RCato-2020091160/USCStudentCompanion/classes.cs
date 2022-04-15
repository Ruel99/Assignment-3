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
    public partial class classes : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public classes()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_assignmentNum.Text == " " && txt_lecturer.Text ==" " && txt_classDays.Text == " " && txt_classTime.Text == " ")
            {
                MessageBox.Show("All fields should be filled", "Update Class Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update myCourses set CourseName='" + txt_courseName.Text + "', AssignmentNumber= '" + txt_assignmentNum.Text + "', Lecturer= '" + txt_lecturer.Text + "', ClassDays= '" + txt_classDays.Text + "', ClassTime= '" + txt_classTime.Text + "'where CourseCode='" + txt_courseCode.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();


                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_assignmentNum.Text = " ";
                txt_lecturer.Text = " ";
                txt_classDays.Text = " ";
                txt_classTime.Text = " ";

                MessageBox.Show("Your Class has been Successfully Updated", "Update Class Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }//end of update function

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_assignmentNum.Text == " " && txt_lecturer.Text == " " && txt_classDays.Text == " " && txt_classTime.Text == " ")
            {
                MessageBox.Show("All fields should be filled", "Add Class Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string add_class = "INSERT INTO myCourses VALUES ('" + txt_courseCode.Text + "','" + txt_courseName.Text + "','" + txt_assignmentNum.Text + "','" + txt_lecturer.Text + "','" + txt_classDays.Text + "','" + txt_classTime.Text + "')";

                cmd = new OleDbCommand(add_class, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_assignmentNum.Text = " ";
                txt_lecturer.Text = " ";
                txt_classDays.Text = " ";
                txt_classTime.Text = " ";

                MessageBox.Show("Your Class has been Successfully Added", "Add Class Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }//end of add class function

        private void btn_view_Click(object sender, EventArgs e)
        {
            new viewClasses().Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            new deleteClass().Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btn_myclasses_Click(object sender, EventArgs e)
        {
            new classes().Show();
            this.Hide();
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            new courses().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new assignments().Show();
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }

        private void txt_assignmentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows the user to enter a number value
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }//end of if
        }
    }
}
