using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USCStudentCompanion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //then the home button is clicked
            new Form1().Show();
            this.Hide();
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            new courses().Show();
            this.Hide();
        }

        private void btn_myclasses_Click(object sender, EventArgs e)
        {
            new classes().Show();
            this.Hide();
        }

        private void bnt_assignments_Click(object sender, EventArgs e)
        {
            new assignments().Show();
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
