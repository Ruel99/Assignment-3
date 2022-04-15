namespace USCStudentCompanion
{
    partial class addGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_courseCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.btn_enterGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Your Grades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Enter the Course Code";
            // 
            // txt_courseCode
            // 
            this.txt_courseCode.Location = new System.Drawing.Point(299, 171);
            this.txt_courseCode.Name = "txt_courseCode";
            this.txt_courseCode.Size = new System.Drawing.Size(91, 20);
            this.txt_courseCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Grade";
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(197, 210);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(70, 20);
            this.txt_grade.TabIndex = 8;
            // 
            // btn_enterGrade
            // 
            this.btn_enterGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(174)))));
            this.btn_enterGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enterGrade.ForeColor = System.Drawing.Color.White;
            this.btn_enterGrade.Location = new System.Drawing.Point(291, 275);
            this.btn_enterGrade.Name = "btn_enterGrade";
            this.btn_enterGrade.Size = new System.Drawing.Size(83, 33);
            this.btn_enterGrade.TabIndex = 9;
            this.btn_enterGrade.Text = "Enter Grade";
            this.btn_enterGrade.UseVisualStyleBackColor = false;
            this.btn_enterGrade.Click += new System.EventHandler(this.btn_enterGrade_Click);
            // 
            // addGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 332);
            this.Controls.Add(this.btn_enterGrade);
            this.Controls.Add(this.txt_grade);
            this.Controls.Add(this.txt_courseCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_courseCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Button btn_enterGrade;
    }
}