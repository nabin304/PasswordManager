using PassManager.App.Services;

namespace PassManager.App.Views
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void OnButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            IPasswordGenerator passwordGenerator = new PasswordGenerator();
            var passwordCon = new PasswordConfiguration
            {
                IncludeUpperCaseLetter = checkBox1.Checked,
                IncludeLowerCaseLetter = checkBox2.Checked,
                IncludeDigits = checkBox3.Checked,
                IncludeMinus = checkBox4.Checked,
                IncludeUnderscore = checkBox5.Checked,
                IncludeSpace = checkBox6.Checked,
                IncludeSpecialCharacter = checkBox7.Checked,
                IncludeBrackets = checkBox8.Checked,
                Length = (int)numericUpDown1.Value
            };
            var password = passwordGenerator.Generate(passwordCon);
            MessageBox.Show($"The generated password is: {password}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
