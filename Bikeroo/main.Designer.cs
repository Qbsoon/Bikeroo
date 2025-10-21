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
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(361, 345);
            login.Margin = new Padding(4, 5, 4, 5);
            login.Name = "login";
            login.Size = new Size(141, 31);
            login.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(587, 345);
            password.Margin = new Padding(4, 5, 4, 5);
            password.Name = "password";
            password.Size = new Size(141, 31);
            password.TabIndex = 1;
            password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 48);
            label1.TabIndex = 2;
            label1.Text = "BikeROOOOOOO";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(378, 439);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(124, 38);
            loginButton.TabIndex = 3;
            loginButton.Text = "Zaloguj";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 313);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(629, 313);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // singInButton
            // 
            singInButton.Location = new Point(597, 439);
            singInButton.Margin = new Padding(4, 5, 4, 5);
            singInButton.Name = "singInButton";
            singInButton.Size = new Size(124, 38);
            singInButton.TabIndex = 6;
            singInButton.Text = "zarejestruj się";
            singInButton.UseVisualStyleBackColor = true;
            singInButton.Click += singInButton_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 750);
            Controls.Add(singInButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(login);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}
