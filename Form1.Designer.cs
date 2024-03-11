namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boxCounts = new System.Windows.Forms.GroupBox();
            this.txtNumAssignments = new System.Windows.Forms.TextBox();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.lblNumAssignments = new System.Windows.Forms.Label();
            this.lblNumStudents = new System.Windows.Forms.Label();
            this.btnSubmitCount = new System.Windows.Forms.Button();
            this.lblWrongInput = new System.Windows.Forms.Label();
            this.boxNavigation = new System.Windows.Forms.GroupBox();
            this.btnLastStudent = new System.Windows.Forms.Button();
            this.btnNextStudent = new System.Windows.Forms.Button();
            this.btnPrevStudent = new System.Windows.Forms.Button();
            this.btnFirstStudent = new System.Windows.Forms.Button();
            this.boxStudentSaveName = new System.Windows.Forms.GroupBox();
            this.txtSaveStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.boxStudentAssignment = new System.Windows.Forms.GroupBox();
            this.txtAssignmentScore = new System.Windows.Forms.TextBox();
            this.txtAssignmentNum = new System.Windows.Forms.TextBox();
            this.lblAssignmentScore = new System.Windows.Forms.Label();
            this.lblAssignmentNum = new System.Windows.Forms.Label();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.txtDisplayScores = new System.Windows.Forms.RichTextBox();
            this.tmrEmptyInput = new System.Windows.Forms.Timer(this.components);
            this.boxCounts.SuspendLayout();
            this.boxNavigation.SuspendLayout();
            this.boxStudentSaveName.SuspendLayout();
            this.boxStudentAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxCounts
            // 
            this.boxCounts.Controls.Add(this.txtNumAssignments);
            this.boxCounts.Controls.Add(this.txtNumStudents);
            this.boxCounts.Controls.Add(this.lblNumAssignments);
            this.boxCounts.Controls.Add(this.lblNumStudents);
            this.boxCounts.Controls.Add(this.btnSubmitCount);
            this.boxCounts.Location = new System.Drawing.Point(28, 30);
            this.boxCounts.Name = "boxCounts";
            this.boxCounts.Size = new System.Drawing.Size(465, 100);
            this.boxCounts.TabIndex = 0;
            this.boxCounts.TabStop = false;
            this.boxCounts.Text = "Counts";
            // 
            // txtNumAssignments
            // 
            this.txtNumAssignments.Location = new System.Drawing.Point(203, 67);
            this.txtNumAssignments.Name = "txtNumAssignments";
            this.txtNumAssignments.Size = new System.Drawing.Size(100, 23);
            this.txtNumAssignments.TabIndex = 4;
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(203, 29);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 23);
            this.txtNumStudents.TabIndex = 3;
            // 
            // lblNumAssignments
            // 
            this.lblNumAssignments.AutoSize = true;
            this.lblNumAssignments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumAssignments.Location = new System.Drawing.Point(17, 67);
            this.lblNumAssignments.Name = "lblNumAssignments";
            this.lblNumAssignments.Size = new System.Drawing.Size(180, 21);
            this.lblNumAssignments.TabIndex = 2;
            this.lblNumAssignments.Text = "Number of assignments:";
            // 
            // lblNumStudents
            // 
            this.lblNumStudents.AutoSize = true;
            this.lblNumStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumStudents.Location = new System.Drawing.Point(45, 27);
            this.lblNumStudents.Name = "lblNumStudents";
            this.lblNumStudents.Size = new System.Drawing.Size(152, 21);
            this.lblNumStudents.TabIndex = 1;
            this.lblNumStudents.Text = "Number of students:";
            // 
            // btnSubmitCount
            // 
            this.btnSubmitCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitCount.Location = new System.Drawing.Point(341, 31);
            this.btnSubmitCount.Name = "btnSubmitCount";
            this.btnSubmitCount.Size = new System.Drawing.Size(90, 57);
            this.btnSubmitCount.TabIndex = 0;
            this.btnSubmitCount.Text = "Submit Counts";
            this.btnSubmitCount.UseVisualStyleBackColor = true;
            this.btnSubmitCount.Click += new System.EventHandler(this.btnSubmitCount_Click);
            // 
            // lblWrongInput
            // 
            this.lblWrongInput.AutoSize = true;
            this.lblWrongInput.BackColor = System.Drawing.Color.Red;
            this.lblWrongInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrongInput.Location = new System.Drawing.Point(264, 9);
            this.lblWrongInput.Name = "lblWrongInput";
            this.lblWrongInput.Size = new System.Drawing.Size(208, 28);
            this.lblWrongInput.TabIndex = 7;
            this.lblWrongInput.Text = "Invalid input. Try again";
            this.lblWrongInput.Visible = false;
            // 
            // boxNavigation
            // 
            this.boxNavigation.Controls.Add(this.btnLastStudent);
            this.boxNavigation.Controls.Add(this.btnNextStudent);
            this.boxNavigation.Controls.Add(this.btnPrevStudent);
            this.boxNavigation.Controls.Add(this.btnFirstStudent);
            this.boxNavigation.Enabled = false;
            this.boxNavigation.Location = new System.Drawing.Point(28, 136);
            this.boxNavigation.Name = "boxNavigation";
            this.boxNavigation.Size = new System.Drawing.Size(695, 100);
            this.boxNavigation.TabIndex = 1;
            this.boxNavigation.TabStop = false;
            this.boxNavigation.Text = "Navigate";
            // 
            // btnLastStudent
            // 
            this.btnLastStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLastStudent.Location = new System.Drawing.Point(510, 37);
            this.btnLastStudent.Name = "btnLastStudent";
            this.btnLastStudent.Size = new System.Drawing.Size(129, 36);
            this.btnLastStudent.TabIndex = 3;
            this.btnLastStudent.Text = ">> Last Student";
            this.btnLastStudent.UseVisualStyleBackColor = true;
            this.btnLastStudent.Click += new System.EventHandler(this.btnLastStudent_Click);
            // 
            // btnNextStudent
            // 
            this.btnNextStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextStudent.Location = new System.Drawing.Point(341, 37);
            this.btnNextStudent.Name = "btnNextStudent";
            this.btnNextStudent.Size = new System.Drawing.Size(128, 36);
            this.btnNextStudent.TabIndex = 2;
            this.btnNextStudent.Text = "> Next Student";
            this.btnNextStudent.UseVisualStyleBackColor = true;
            this.btnNextStudent.Click += new System.EventHandler(this.btnNextStudent_Click);
            // 
            // btnPrevStudent
            // 
            this.btnPrevStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevStudent.Location = new System.Drawing.Point(179, 37);
            this.btnPrevStudent.Name = "btnPrevStudent";
            this.btnPrevStudent.Size = new System.Drawing.Size(124, 36);
            this.btnPrevStudent.TabIndex = 1;
            this.btnPrevStudent.Text = "< Prev Student";
            this.btnPrevStudent.UseVisualStyleBackColor = true;
            this.btnPrevStudent.Click += new System.EventHandler(this.btnPrevStudent_Click);
            // 
            // btnFirstStudent
            // 
            this.btnFirstStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirstStudent.Location = new System.Drawing.Point(17, 37);
            this.btnFirstStudent.Name = "btnFirstStudent";
            this.btnFirstStudent.Size = new System.Drawing.Size(138, 36);
            this.btnFirstStudent.TabIndex = 0;
            this.btnFirstStudent.Text = "<< First Student";
            this.btnFirstStudent.UseVisualStyleBackColor = true;
            this.btnFirstStudent.Click += new System.EventHandler(this.btnFirstStudent_Click);
            // 
            // boxStudentSaveName
            // 
            this.boxStudentSaveName.Controls.Add(this.txtSaveStudentName);
            this.boxStudentSaveName.Controls.Add(this.lblStudentNumber);
            this.boxStudentSaveName.Controls.Add(this.btnSaveName);
            this.boxStudentSaveName.Enabled = false;
            this.boxStudentSaveName.Location = new System.Drawing.Point(28, 242);
            this.boxStudentSaveName.Name = "boxStudentSaveName";
            this.boxStudentSaveName.Size = new System.Drawing.Size(695, 75);
            this.boxStudentSaveName.TabIndex = 2;
            this.boxStudentSaveName.TabStop = false;
            this.boxStudentSaveName.Text = "Student Info";
            // 
            // txtSaveStudentName
            // 
            this.txtSaveStudentName.Location = new System.Drawing.Point(135, 30);
            this.txtSaveStudentName.Name = "txtSaveStudentName";
            this.txtSaveStudentName.Size = new System.Drawing.Size(358, 23);
            this.txtSaveStudentName.TabIndex = 2;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNumber.Location = new System.Drawing.Point(21, 32);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(85, 21);
            this.lblStudentNumber.TabIndex = 1;
            this.lblStudentNumber.Text = "Student #X";
            // 
            // btnSaveName
            // 
            this.btnSaveName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveName.Location = new System.Drawing.Point(538, 27);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(101, 31);
            this.btnSaveName.TabIndex = 0;
            this.btnSaveName.Text = "Save Name";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // boxStudentAssignment
            // 
            this.boxStudentAssignment.Controls.Add(this.txtAssignmentScore);
            this.boxStudentAssignment.Controls.Add(this.txtAssignmentNum);
            this.boxStudentAssignment.Controls.Add(this.lblAssignmentScore);
            this.boxStudentAssignment.Controls.Add(this.lblAssignmentNum);
            this.boxStudentAssignment.Controls.Add(this.btnSaveScore);
            this.boxStudentAssignment.Enabled = false;
            this.boxStudentAssignment.Location = new System.Drawing.Point(28, 323);
            this.boxStudentAssignment.Name = "boxStudentAssignment";
            this.boxStudentAssignment.Size = new System.Drawing.Size(695, 100);
            this.boxStudentAssignment.TabIndex = 3;
            this.boxStudentAssignment.TabStop = false;
            this.boxStudentAssignment.Text = "Student Info";
            // 
            // txtAssignmentScore
            // 
            this.txtAssignmentScore.Location = new System.Drawing.Point(274, 67);
            this.txtAssignmentScore.Name = "txtAssignmentScore";
            this.txtAssignmentScore.Size = new System.Drawing.Size(103, 23);
            this.txtAssignmentScore.TabIndex = 4;
            // 
            // txtAssignmentNum
            // 
            this.txtAssignmentNum.Location = new System.Drawing.Point(274, 30);
            this.txtAssignmentNum.Name = "txtAssignmentNum";
            this.txtAssignmentNum.Size = new System.Drawing.Size(103, 23);
            this.txtAssignmentNum.TabIndex = 3;
            // 
            // lblAssignmentScore
            // 
            this.lblAssignmentScore.AutoSize = true;
            this.lblAssignmentScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAssignmentScore.Location = new System.Drawing.Point(99, 65);
            this.lblAssignmentScore.Name = "lblAssignmentScore";
            this.lblAssignmentScore.Size = new System.Drawing.Size(142, 21);
            this.lblAssignmentScore.TabIndex = 2;
            this.lblAssignmentScore.Text = "Assignment Score: ";
            // 
            // lblAssignmentNum
            // 
            this.lblAssignmentNum.AutoSize = true;
            this.lblAssignmentNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAssignmentNum.Location = new System.Drawing.Point(6, 28);
            this.lblAssignmentNum.Name = "lblAssignmentNum";
            this.lblAssignmentNum.Size = new System.Drawing.Size(235, 21);
            this.lblAssignmentNum.TabIndex = 1;
            this.lblAssignmentNum.Text = "Enter Assignment Number (1-X):";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveScore.Location = new System.Drawing.Point(457, 37);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(97, 38);
            this.btnSaveScore.TabIndex = 0;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(538, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 57);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Enabled = false;
            this.btnDisplayScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayScores.Location = new System.Drawing.Point(302, 441);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(127, 39);
            this.btnDisplayScores.TabIndex = 5;
            this.btnDisplayScores.Text = "Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // txtDisplayScores
            // 
            this.txtDisplayScores.Enabled = false;
            this.txtDisplayScores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplayScores.Location = new System.Drawing.Point(28, 499);
            this.txtDisplayScores.Name = "txtDisplayScores";
            this.txtDisplayScores.Size = new System.Drawing.Size(695, 219);
            this.txtDisplayScores.TabIndex = 6;
            this.txtDisplayScores.Text = "";
            // 
            // tmrEmptyInput
            // 
            this.tmrEmptyInput.Interval = 1500;
            this.tmrEmptyInput.Tick += new System.EventHandler(this.tmrEmptyInput_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 730);
            this.Controls.Add(this.lblWrongInput);
            this.Controls.Add(this.txtDisplayScores);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.boxStudentAssignment);
            this.Controls.Add(this.boxStudentSaveName);
            this.Controls.Add(this.boxNavigation);
            this.Controls.Add(this.boxCounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxCounts.ResumeLayout(false);
            this.boxCounts.PerformLayout();
            this.boxNavigation.ResumeLayout(false);
            this.boxStudentSaveName.ResumeLayout(false);
            this.boxStudentSaveName.PerformLayout();
            this.boxStudentAssignment.ResumeLayout(false);
            this.boxStudentAssignment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox boxCounts;
        private TextBox txtNumStudents;
        private Label lblNumAssignments;
        private Label lblNumStudents;
        private Button btnSubmitCount;
        private GroupBox boxNavigation;
        private Button btnLastStudent;
        private Button btnNextStudent;
        private Button btnPrevStudent;
        private Button btnFirstStudent;
        private GroupBox boxStudentSaveName;
        private Button btnSaveName;
        private GroupBox boxStudentAssignment;
        private Button btnSaveScore;
        private Button btnReset;
        private Button btnDisplayScores;
        private RichTextBox txtDisplayScores;
        private TextBox txtNumAssignments;
        private TextBox txtSaveStudentName;
        private Label lblStudentNumber;
        private TextBox txtAssignmentScore;
        private TextBox txtAssignmentNum;
        private Label lblAssignmentScore;
        private Label lblAssignmentNum;
        private Label lblWrongInput;
        private System.Windows.Forms.Timer tmrEmptyInput;
    }
}