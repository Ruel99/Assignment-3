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
    public partial class courses : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public courses()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_credits.Text == " " && txt_semester.Text == " " && txt_year.Text == " ")
            {
                MessageBox.Show("All fields should be filled except grade", "Add Course Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string add_course = "INSERT INTO courses VALUES ('" + txt_courseCode.Text + "','" + txt_courseName.Text + "','" + txt_grade.Text + "','" + txt_credits.Text + "','" + txt_semester.Text + "','" + txt_year.Text + "')";

                cmd = new OleDbCommand(add_course, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_grade.Text = " ";
                txt_credits.Text = " ";
                txt_semester.Text = " ";
                txt_year.Text = " ";

                MessageBox.Show("Your Course has been Successfully Added", "Add Course Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }// end of add courses

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_courseCode.Text == " " && txt_courseName.Text == " " && txt_credits.Text == " " && txt_semester.Text == " " && txt_year.Text == " ")
            {
                MessageBox.Show("All fields should be filled", "Update Course Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set CourseName='" + txt_courseName.Text + "', Grade= '" + txt_grade.Text + "', Credits= '" + txt_credits.Text + "', Semester= '" + txt_semester.Text + "', YearPeriod= '" + txt_year.Text + "'where CourseCode='" + txt_courseCode.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();


                txt_courseCode.Text = " ";
                txt_courseName.Text = " ";
                txt_grade.Text = " ";
                txt_credits.Text = " ";
                txt_semester.Text = " ";
                txt_year.Text = " ";

                MessageBox.Show("Your Course has been Successfully Updated", "Update Course Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }//end of update

        private void btn_view_Click(object sender, EventArgs e)
        {
            new viewCourses().Show();
            this.Hide();
        }

        private void btn_addGrade_Click(object sender, EventArgs e)
        {
            new addGrade().Show();
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            new deleteCourse().Show();

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

        private void bnt_assignments_Click_1(object sender, EventArgs e)
        {
            new assignments().Show();
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }

        private void txt_credits_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows the user to enter a number value
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }//end of if
        }

        private void txt_semester_KeyPress(object sender, KeyPressEventArgs e)
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
