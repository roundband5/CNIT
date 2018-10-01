namespace InLab05
{
    partial class Form1
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGradePoint = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGradePoint = new System.Windows.Forms.TextBox();
            this.btnPassFail = new System.Windows.Forms.Button();
            this.btnLetterGrade = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblGradePoint
            // 
            this.lblGradePoint.AutoSize = true;
            this.lblGradePoint.Location = new System.Drawing.Point(31, 58);
            this.lblGradePoint.Name = "lblGradePoint";
            this.lblGradePoint.Size = new System.Drawing.Size(66, 13);
            this.lblGradePoint.TabIndex = 1;
            this.lblGradePoint.Text = "Grade Point:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(157, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(144, 20);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGradePoint
            // 
            this.txtGradePoint.Location = new System.Drawing.Point(157, 58);
            this.txtGradePoint.Name = "txtGradePoint";
            this.txtGradePoint.Size = new System.Drawing.Size(143, 20);
            this.txtGradePoint.TabIndex = 3;
            // 
            // btnPassFail
            // 
            this.btnPassFail.Location = new System.Drawing.Point(62, 103);
            this.btnPassFail.Name = "btnPassFail";
            this.btnPassFail.Size = new System.Drawing.Size(93, 25);
            this.btnPassFail.TabIndex = 4;
            this.btnPassFail.Text = "Pass/Fail";
            this.btnPassFail.UseVisualStyleBackColor = true;
            this.btnPassFail.Click += new System.EventHandler(this.btnPassFail_Click);
            // 
            // btnLetterGrade
            // 
            this.btnLetterGrade.Location = new System.Drawing.Point(161, 102);
            this.btnLetterGrade.Name = "btnLetterGrade";
            this.btnLetterGrade.Size = new System.Drawing.Size(93, 25);
            this.btnLetterGrade.TabIndex = 5;
            this.btnLetterGrade.Text = "Letter Grade";
            this.btnLetterGrade.UseVisualStyleBackColor = true;
            this.btnLetterGrade.Click += new System.EventHandler(this.btnLetterGrade_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(61, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(161, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(34, 179);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(267, 84);
            this.txtOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 275);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLetterGrade);
            this.Controls.Add(this.btnPassFail);
            this.Controls.Add(this.txtGradePoint);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblGradePoint);
            this.Controls.Add(this.lblFullName);
            this.Name = "Form1";
            this.Text = "InLab05 by Edward Chang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGradePoint;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGradePoint;
        private System.Windows.Forms.Button btnPassFail;
        private System.Windows.Forms.Button btnLetterGrade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

