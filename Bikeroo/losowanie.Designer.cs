namespace Bikeroo
{
    partial class losowanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            randomButton = new Button();
            SuspendLayout();
            // 
            // randomButton
            // 
            randomButton.Font = new Font("Segoe UI", 15F);
            randomButton.Location = new Point(12, 12);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(243, 96);
            randomButton.TabIndex = 0;
            randomButton.Text = "LOSUJ!!!!";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // losowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 120);
            Controls.Add(randomButton);
            Name = "losowanie";
            Text = "losowanie";
            ResumeLayout(false);
        }

        #endregion

        private Button randomButton;
    }
}