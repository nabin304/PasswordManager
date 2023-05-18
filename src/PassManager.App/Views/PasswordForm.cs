using PassManager.App.Services;

namespace PassManager.App.Views
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            //checkBox1.Checked = true;
            //checkBox2.Checked = true;
            //numericUpDown1.Value = 10;
        }

        private void OnButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            var passwordGenerator = new PasswordGenerator();
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
    }
}
