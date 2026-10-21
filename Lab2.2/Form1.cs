namespace Lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsPassing(int score)
        {
            return score >= 50;
        }

        string GetLetterGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
        double AverageTo100(int score)
        {
            return 100 - score;
        }
        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score)
    && score >= 0 && score <= 100)
            {
                if (IsPassing(score))
                    lblResult.Text = "Pass";
                else
                    lblResult.Text = "Fail";
            }
            else
            {
                lblResult.Text = "Enter a score between 0 and 100.";
            }
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtScore.Text, out int score)
    && score >= 0 && score <= 100)
            {
                lblResult.Text = GetLetterGrade(score);
            }
            else
            {
                lblResult.Text = "Enter a score between 0 and 100.";
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score)
    && score >= 0 && score <= 100)
            {
                lblResult.Text = AverageTo100(score).ToString();
            }
            else
            {
                lblResult.Text = "Enter a score between 0 and 100.";
            }
        }
    }
}
