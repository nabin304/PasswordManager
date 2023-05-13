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
            var password = passwordGenerator.Generate(new PasswordConfiguration());
            MessageBox.Show($"The generated password is: {password}");
        }
    }
}
