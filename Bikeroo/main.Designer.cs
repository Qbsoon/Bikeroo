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
            haslo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(253, 207);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 0;
            // 
            // haslo
            // 
            haslo.Location = new Point(411, 207);
            haslo.Name = "haslo";
            haslo.Size = new Size(100, 23);
            haslo.TabIndex = 1;
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
            label1.Click += label1_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(haslo);
            Controls.Add(login);
            Name = "main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login;
        private TextBox haslo;
        private Label label1;
    }
}
