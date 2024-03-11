namespace W121z_P1A3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Method that gets triggered when the check button is clicked.
        private void checkButton_Click(object sender, EventArgs e)
        {
            //Getting the values of the checkboxes for each tip, if it's checked it'll return boolean of true otherwise it'll return a false.
            bool willAvoidProcastination = tip1CheckBox.Checked;
            bool willTakeBreaks = tip2CheckBox.Checked;
            bool willBeSocial = tip3CheckBox.Checked;
            bool willAskQuestions = tip4CheckBox.Checked;
            bool willUseACalandar = tip5CheckBox.Checked;

            //Creating a list of all the things the student will do to be a successful college student.
            List<bool> thingsStudentWillDo = new List<bool>();

            //Checking each checkbox to see what the student will do.
            if(willAvoidProcastination == true) // If the student will avoid procrastination then
            {
                thingsStudentWillDo.Add(willAvoidProcastination); // Will add that to the list of things they will do.
            }

            if(willTakeBreaks == true) // If student will take breaks then
            {
                thingsStudentWillDo.Add(willTakeBreaks); // Will add that to the list of things they will do.
            }

            if(willBeSocial == true)
            {
                thingsStudentWillDo.Add(willBeSocial);
            }

            if(willAskQuestions == true)
            {
                thingsStudentWillDo.Add(willAskQuestions);
            }

            if(willUseACalandar == true)
            {
                thingsStudentWillDo.Add(willUseACalandar);
            }

            //Checking how many of the five tips the student will do, and displaying the outcome that results of that.
            if(thingsStudentWillDo.Count <= 2) // If the student does less than or exactly two of the tips then
            {
                outcomeLabel.Text = "You may not be a successful college student."; // Updating our label to display the outcome.
                outcomeLabel.BackColor = Color.Tomato; // Updating the color of the label to better communicate the outcome.
            }

            if(thingsStudentWillDo.Count > 2 && thingsStudentWillDo.Count < 5) //If the student will only do three to four of the tips then
            {
                outcomeLabel.Text = "You will be mid college student.";
                outcomeLabel.BackColor = Color.Yellow;
            }

            if(thingsStudentWillDo.Count == 5) // If the student will do all five of the tips then
            {
                outcomeLabel.Text = "You will be a successful college student.";
                outcomeLabel.BackColor = Color.SpringGreen;
            }
        }

        //Method that gets triggered when the exit button is clicked.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closses the application.
        }
    }
}