namespace Bikeroo
{
    partial class zgloszenia
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
            submitButton = new Button();
            reportText = new RichTextBox();
            label1 = new Label();
            system = new CheckBox();
            bikesAndStations = new CheckBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            reportTitle = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(354, 315);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(126, 45);
            submitButton.TabIndex = 0;
            submitButton.Text = "zgłaszam";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // reportText
            // 
            reportText.Location = new Point(12, 58);
            reportText.Name = "reportText";
            reportText.Size = new Size(324, 302);
            reportText.TabIndex = 1;
            reportText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(464, 21);
            label1.TabIndex = 2;
            label1.Text = "Twoje zgłoszenie jest dla nas bardzo ważne, dziekujemy za pomoc";
            // 
            // system
            // 
            system.AutoSize = true;
            system.Location = new Point(6, 47);
            system.Name = "system";
            system.Size = new Size(71, 19);
            system.TabIndex = 3;
            system.Text = "Systemu";
            system.UseVisualStyleBackColor = true;
            // 
            // bikesAndStations
            // 
            bikesAndStations.AutoSize = true;
            bikesAndStations.Location = new Point(6, 22);
            bikesAndStations.Name = "bikesAndStations";
            bikesAndStations.Size = new Size(101, 19);
            bikesAndStations.TabIndex = 4;
            bikesAndStations.Text = "Rower / Stacja";
            bikesAndStations.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bikesAndStations);
            groupBox1.Controls.Add(system);
            groupBox1.Location = new Point(354, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 77);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zgłoszenie dotyczy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 76);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Tytuł zgłoszenia";
            // 
            // reportTitle
            // 
            reportTitle.Location = new Point(342, 94);
            reportTitle.Name = "reportTitle";
            reportTitle.Size = new Size(160, 23);
            reportTitle.TabIndex = 7;
            // 
            // zgloszenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 372);
            Controls.Add(reportTitle);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(reportText);
            Controls.Add(submitButton);
            Name = "zgloszenia";
            Text = "zgloszenia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private RichTextBox reportText;
        private Label label1;
        private CheckBox system;
        private CheckBox bikesAndStations;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox reportTitle;
    }
}