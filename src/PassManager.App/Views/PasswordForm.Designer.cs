namespace PassManager.App.Views
{
    partial class PasswordForm
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
            btnGeneratePassword = new Button();
            SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(173, 188);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(255, 66);
            btnGeneratePassword.TabIndex = 0;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += OnButtonGeneratePassword_Click;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeneratePassword);
            Name = "PasswordForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeneratePassword;
    }
}