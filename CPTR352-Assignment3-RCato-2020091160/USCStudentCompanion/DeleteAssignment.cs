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
    public partial class DeleteAssignment : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t\Desktop\CPTR352-Assignment3-RCato-2020091160\Data\studentdb.accdb;Persist Security Info=False;");

        public DeleteAssignment()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_assignmentID.Text == " ")
            {
                MessageBox.Show("Please Enter The Course Code", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string deleteQuery = "delete from assignments where AssignmentID ='" + txt_assignmentID.Text + "'";
                cmd.CommandText = deleteQuery;

                cmd.ExecuteNonQuery();
                con.Close();
                txt_assignmentID.Text = " ";

                MessageBox.Show("Assignment successfully removed", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
