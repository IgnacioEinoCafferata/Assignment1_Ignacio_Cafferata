namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void summarizebutton_Click(object sender, EventArgs e)
        {
            try
            {
                summarizeLabel.ForeColor = Color.Black;
                var firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                double hoursWorked;
                hoursWorked = double.Parse(hoursWorkedTextBox.Text);
                double TOTAL_SALARY;
                double PAY_PER_HOUR = 10.5;
                TOTAL_SALARY = hoursWorked * PAY_PER_HOUR;
                string summarize = firstName + " " + lastName + $" worked {hoursWorked} hours at $10.50 an hour for a total of $ {TOTAL_SALARY}";
                summarizeLabel.Text = summarize;
            }
            catch
            {
                summarizeLabel.ForeColor = Color.Red;
                summarizeLabel.Text = "There was an error!";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultlabel_Click(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            summarizeLabel.Text = "";

        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }
    }
}
