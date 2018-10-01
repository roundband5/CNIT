using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InLab05
   
{
    public partial class Form1 : Form
    {
        private double cPassOrFail=60.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtGradePoint.Text = "";
            txtFullName.Focus();
            txtOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPassFail_Click(object sender, EventArgs e)
        {
            double score = 0;
            if(txtFullName.Text=="")
            {
                MessageBox.Show("Enter a name. ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Focus();
                return;
            }
            else
            {
                if(double.TryParse(txtGradePoint.Text, out score)== false)
                {
                    MessageBox.Show("Enter a Numeric Value.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGradePoint.Focus();
                    return;
                }
                else
                {
                   double grade = double.Parse(txtGradePoint.Text);
                   if (grade<0 || grade > 100)
                    {
                        MessageBox.Show("Enter a number between 0 and 100.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGradePoint.Focus();
                        return;
                    }
                    else if(grade >= cPassOrFail)
                    {
                        txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nGrade Status: Passed";
                    }
                    else
                    {
                        txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nGrade Status: Failed";
                    }
                }
            }
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Enter a name. ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Focus();
                return;
            }
            double score = 0;
            if (txtGradePoint.Text == "")
            {
                MessageBox.Show("Enter a grade. ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGradePoint.Focus();
                return;
            }
            if (double.TryParse(txtGradePoint.Text, out score) == false)
            {
                MessageBox.Show("Enter a Numeric Value.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGradePoint.Focus();
                return;
            }
            
            string letter = "";
            
            double grade = double.Parse(txtGradePoint.Text);
            if (grade < 0 || grade > 100)
            {
                MessageBox.Show("Enter a number between 0 and 100.");
                txtGradePoint.Focus();
                return;
            }
            if (grade >= 90)
            {
                txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nYour letter grade is A";
            }
            else if (grade >= 80)
            {
                txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nYour letter grade is B";
            }
            else if (grade >= 70)
            {
                txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nYour letter grade is C";
            }
            else if (grade >=60)
            {
                txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nYour letter grade is D";
            }
            else
            {
                txtOutput.Text = "Full Name: " + txtFullName.Text + "\r\nYour letter grade is F";
            }
        }
    }
}
