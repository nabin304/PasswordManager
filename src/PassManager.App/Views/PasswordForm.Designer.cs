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
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.BackColor = Color.FromArgb(64, 0, 64);
            btnGeneratePassword.ForeColor = SystemColors.ButtonFace;
            btnGeneratePassword.Location = new Point(220, 271);
            btnGeneratePassword.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(168, 43);
            btnGeneratePassword.TabIndex = 0;
            btnGeneratePassword.Text = "Generate Password ";
            btnGeneratePassword.UseVisualStyleBackColor = false;
            btnGeneratePassword.Click += OnButtonGeneratePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(19, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 27);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Upper Case";
            checkBox1.UseVisualStyleBackColor = true;            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(103, 65);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 4;
            label2.Text = "Length";           
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(19, 160);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(123, 27);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Lower Case";
            checkBox2.UseVisualStyleBackColor = true;            
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox3.Location = new Point(19, 193);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 27);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Digit";
            checkBox3.UseVisualStyleBackColor = true;
            
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox4.Location = new Point(19, 226);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 27);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Minus(-)";
            checkBox4.UseVisualStyleBackColor = true;           
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox5.Location = new Point(183, 127);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(140, 27);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Underscore(_)";
            checkBox5.UseVisualStyleBackColor = true;            
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox6.Location = new Point(183, 160);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(78, 27);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Space";
            checkBox6.UseVisualStyleBackColor = true;           
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox7.Location = new Point(183, 193);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(171, 27);
            checkBox7.TabIndex = 10;
            checkBox7.Text = "Special Character";
            checkBox7.UseVisualStyleBackColor = true;           
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox8.Location = new Point(183, 226);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(100, 27);
            checkBox8.TabIndex = 11;
            checkBox8.Text = "Brackets";
            checkBox8.UseVisualStyleBackColor = true;          
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(173, 65);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 12;           
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(400, 332);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(btnGeneratePassword);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasswordForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneratePassword;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private NumericUpDown numericUpDown1;
    }
}