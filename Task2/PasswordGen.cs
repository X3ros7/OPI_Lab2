namespace Task2
{
    public partial class PasswordGen : Form
    {

        public PasswordGen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, який виконується при натискані на кнопку "Generate"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            string passwordLengthString = lengthBox.Text;
            string uppercasePercentageString = uppercaseBox.Text;
            string lowercasePercentageString = lowercaseBox.Text;
            string numberPercentageString = numbersBox.Text;
            string specialPercentageString = specialBox.Text;

            if (!int.TryParse(passwordLengthString, out int passwordLength))
            {
                MessageBox.Show("Enter a password length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(uppercasePercentageString, out int uppercasePercentage))
            {
                MessageBox.Show("Enter a % of uppercase letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(lowercasePercentageString, out int lowercasePercentage))
            {
                MessageBox.Show("Enter a % of lowercase letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(numberPercentageString, out int numberPercentage))
            {
                MessageBox.Show("Enter a % of numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(specialPercentageString, out int specialPercentage))
            {
                MessageBox.Show("Enter a % of special digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string password = PasswordGenerator.GeneratePassword(
                passwordLength, // довжина пароля
                uppercasePercentage, // % великих літер
                lowercasePercentage, // % маленьких літер
                numberPercentage, // % цифр
                specialPercentage // % спеціальних символів
                );
                
                passwordBox.Text = password;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show($"Error: {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
