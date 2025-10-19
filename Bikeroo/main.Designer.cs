namespace Bikeroo
{
    partial class main
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
            login = new TextBox();
            password = new TextBox();
            label1 = new Label();
            loginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            singInButton = new Button();
            label4 = new Label();
            label5 = new Label();
            signUpLogin = new TextBox();
            signUpPassword = new TextBox();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(253, 207);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(411, 207);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 1;
            password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 72);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 2;
            label1.Text = "BikeROOOOOOO";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(578, 207);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(87, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Zaloguj";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 188);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 188);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // singInButton
            // 
            singInButton.Location = new Point(578, 332);
            singInButton.Name = "singInButton";
            singInButton.Size = new Size(87, 23);
            singInButton.TabIndex = 6;
            singInButton.Text = "zarejestruj się";
            singInButton.UseVisualStyleBackColor = true;
            singInButton.Click += singInButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 298);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Hasło";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 298);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Login";
            // 
            // signUpLogin
            // 
            signUpLogin.Location = new Point(253, 332);
            signUpLogin.Name = "signUpLogin";
            signUpLogin.Size = new Size(100, 23);
            signUpLogin.TabIndex = 9;
            // 
            // signUpPassword
            // 
            signUpPassword.Location = new Point(411, 332);
            signUpPassword.Name = "signUpPassword";
            signUpPassword.Size = new Size(100, 23);
            signUpPassword.TabIndex = 10;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(signUpPassword);
            Controls.Add(signUpLogin);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(singInButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(login);
            Name = "main";
            Text = "Form1";
            Load += main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login;
        private TextBox password;
        private Label label1;
        private Button loginButton;
        private Label label2;
        private Label label3;
        private Button singInButton;
        private Label label4;
        private Label label5;
        private TextBox signUpLogin;
        private TextBox signUpPassword;
    }
}
