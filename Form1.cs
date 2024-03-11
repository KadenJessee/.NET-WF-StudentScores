namespace WinFormsApp1
{
    /// <summary>
    /// This is the Main window where user can enter student
    /// assignments and scores
    /// </summary>
    public partial class Form1 : Form
    {
        
        /// <summary>
        /// single dimension array for num of students
        /// and multi dimension for assignments
        /// </summary>
        string[] students;
        int[,] scores;

        /// <summary>
        /// use for number of students input
        /// </summary>
        int studentNum;
        
        /// <summary>
        /// use for number of assignments input
        /// </summary>
        int assignmentNum;

        /// <summary>
        /// keeps track of indexed student
        /// </summary>
        int iSelectedStudentIndex;

        /// <summary>
        /// keeps track of the text entered
        /// for the enter assignment number
        /// in the student info
        /// </summary>
        int studentAssignmentNum;

        /// <summary>
        /// keeps track of the assignment
        /// score entered in the student info
        /// </summary>
        int assignmentScore;

        /// <summary>
        /// Initializes componenent and sets
        /// everything except counts box to disabled
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when submit counts button is clicked, tryparse the input
        /// and if valid, enable all other functionality
        /// stores number of students and number of assignments into arrays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitCount_Click(object sender, EventArgs e)
        {
            //validate user input
            //if not between 1-10 for students and 1-99 for assignments
            if (!Int32.TryParse(txtNumStudents.Text, out studentNum) || (studentNum > 10 || studentNum < 1) ||
                !Int32.TryParse(txtNumAssignments.Text, out assignmentNum) || (assignmentNum > 99 || assignmentNum < 1))
            {
                //use label and not messageBox
                lblWrongInput.Visible = true; //display error label
                tmrEmptyInput.Enabled = true; //start timer
                //btnSubmitCount.Visible = false; //remove submit counts button
                return;
            }
            //if string is empty or null
            else if(string.IsNullOrEmpty(txtNumStudents.Text) || string.IsNullOrEmpty(txtNumAssignments.Text))
            {
                //use label and not messageBox
                lblWrongInput.Visible = true; //display error label
                tmrEmptyInput.Enabled = true; //start timer
                //btnSubmitCount.Visible = false; //remove submit counts button
                return;
            }
            //else run the code
            else
            {
                //set students array to studentNum
                students = new string[studentNum];
                scores = new int[studentNum, assignmentNum];

                //set assignments array to assignmentNum

                //set rest of form to enabled
                boxNavigation.Enabled = true;
                boxStudentSaveName.Enabled = true;
                boxStudentAssignment.Enabled = true;
                btnReset.Enabled = true;
                btnDisplayScores.Enabled = true;
                txtDisplayScores.Enabled = true;

                //set index to 1
                iSelectedStudentIndex = 1;
                //set student #X to student #1
                lblStudentNumber.Text = "Student #" + iSelectedStudentIndex;

                //set assignment num (1-x) to 1-assignmentNum
                lblAssignmentNum.Text = "Enter Assignment Number (1-" + assignmentNum.ToString() + ")";
            }
        }

        /// <summary>
        /// reset the program to its origina lstate of entering the counts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the window
            //set rest of form to disabled
            boxNavigation.Enabled = false;
            boxStudentSaveName.Enabled = false;
            boxStudentAssignment.Enabled = false;
            btnReset.Enabled = false;
            btnDisplayScores.Enabled = false;
            txtDisplayScores.Enabled = false;

            //clear counts box
            txtNumStudents.Text = string.Empty;
            txtNumAssignments.Text = string.Empty;

            //clear student name
            txtSaveStudentName.Text = string.Empty;

            //clear student info txt boxes
            txtAssignmentNum.Text = string.Empty;
            txtAssignmentScore.Text = string.Empty;

            //clear rich text box
            txtDisplayScores.Text = string.Empty;
        }

        /// <summary>
        /// when clicked, sets student #x to first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstStudent_Click(object sender, EventArgs e)
        {
            //set to first index
            iSelectedStudentIndex = 1;
            //display students data
            lblStudentNumber.Text = "Student #" + iSelectedStudentIndex;
        }

        /// <summary>
        /// when clicked, sets student #x to previous
        /// doesn't work if less than 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevStudent_Click(object sender, EventArgs e)
        {
            //move students index down by one
            if(iSelectedStudentIndex - 1 < 1)
            {
                return;
            }
            //decrement by 1
            iSelectedStudentIndex = iSelectedStudentIndex - 1;
            //update display
            lblStudentNumber.Text = "Student #" + iSelectedStudentIndex.ToString();
        }
        /// <summary>
        /// when clicked, sets student #x to next
        /// doesn't work if greater than studentNum + 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            //move index up by one
            if(iSelectedStudentIndex + 1 > studentNum)
            {
                return;
            }
            //increment by 1
            iSelectedStudentIndex = iSelectedStudentIndex + 1;
            //update display
            lblStudentNumber.Text = "Student #" + iSelectedStudentIndex.ToString();
        }

        /// <summary>
        /// when clicked, sets student #x to last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastStudent_Click(object sender, EventArgs e)
        {
            //set to last index
            iSelectedStudentIndex = studentNum;
            //update display
            lblStudentNumber.Text = "Student #" + iSelectedStudentIndex.ToString();
        }

        /// <summary>
        /// checks for valid name
        /// saves name into students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            //validate the users name
            if (string.IsNullOrEmpty(txtSaveStudentName.Text))
            {
                lblWrongInput.Visible = true;
                tmrEmptyInput.Enabled = true;
                return;
            }
            //save name based on index
            students[iSelectedStudentIndex - 1] = txtSaveStudentName.Text;
            
        }

        /// <summary>
        /// checks for valid assignment number
        /// and score and stores into scores array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            //validate assignment number
            //validate assignment score
            if(!Int32.TryParse(txtAssignmentNum.Text, out studentAssignmentNum) || (studentAssignmentNum > assignmentNum) ||
                (studentAssignmentNum < 1) || 
                !Int32.TryParse(txtAssignmentScore.Text, out assignmentScore) || (assignmentScore > 100) || (assignmentScore < 0))
            {
                //display invalid message
                lblWrongInput.Visible = true;
                tmrEmptyInput.Enabled = true;
                return;
            }
            
            //save the students score to an array, iSelectedStudentIndex is the row/selected student
            //studentAssignmentNum is the column
            scores[iSelectedStudentIndex-1, studentAssignmentNum-1] = assignmentScore;
        }

        /// <summary>
        /// Dynamically displays the students and their scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            txtDisplayScores.Text = string.Empty;
            //generate the header, number of assignments
            txtDisplayScores.AppendText("STUDENT\t\t");
            //displays assignment numbers dynamically
            for(int i = 1; i <= assignmentNum; i++)
            {
                txtDisplayScores.AppendText("#" + i + "\t");
            }
            //display for average and grade
            txtDisplayScores.AppendText("AVG\t" + "GRADE\n");

            //for calc sum and average
            int sum = 0;
            double average = 0;
            //outer for loop through students
            for(int i = 0; i < students.Length; i++)
            {
                //reset sum to 0
                sum = 0;
                //add name
                txtDisplayScores.AppendText(students[i] + "\t\t\t");
                //inner for loop through scores
                for(int j = 0; j < assignmentNum; j++)
                {
                    //add up then calculate average
                    txtDisplayScores.AppendText(scores[i, j].ToString() + "\t");
                    sum += scores[i, j];
                }
                //calculate average
                average = sum / assignmentNum;
                //display average
                txtDisplayScores.AppendText(average.ToString() + "\t");
                //GradeLetter
                txtDisplayScores.AppendText(GradeLetter(average) + "\n");
            }

        }

        /// <summary>
        /// Timer for error label displaying, then
        /// hiding label and showing the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrEmptyInput_Tick(object sender, EventArgs e)
        {
            lblWrongInput.Visible = false;  //hide label
        }

        /// <summary>
        /// takes in average grade
        /// and determines the corresponding letter grade
        /// </summary>
        /// <param name="average"></param>
        /// <returns></returns>
        private string GradeLetter(double average)
        {

            string grade = "";
            if(average < 60) // E
            {
                grade = "E";
            }
            else if(average >= 60 && average <= 62.9) // D-
            {
                grade = "D-";
            }
            else if (average >= 63 && average <= 66.9) // D
            {
                grade = "D";
            }
            else if (average >= 67 && average <= 69.9) // D+
            {
                grade = "D+";
            }
            else if (average >= 70 && average <= 72.9) // C-
            {
                grade = "C-";
            }
            else if (average >= 73 && average <= 76.9) // C
            {
                grade = "C";
            }
            else if (average >= 77 && average <= 79.9) // C+
            {
                grade = "C+";
            }
            else if (average >= 80 && average <= 82.9) // B-
            {
                grade = "B-";
            }
            else if (average >= 83 && average <= 86.9) // B
            {
                grade = "B";
            }
            else if (average >= 87 && average <= 89.9) // B+
            {
                grade = "B+";
            }
            else if (average >= 90 && average <= 92.9) // A-
            {
                grade = "A-";
            }
            else if (average >= 93 && average <= 100.0) // A
            {
                grade = "A";
            }
            return grade;
        }
    }
}