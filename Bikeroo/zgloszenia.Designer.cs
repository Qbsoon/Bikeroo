﻿namespace Bikeroo
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
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
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(464, 21);
            label1.TabIndex = 2;
            label1.Text = "Twoje zgłoszenie jest dla nas bardzo ważne, dziekujemy za pomoc";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Systemu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Rower / Stacja";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(354, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 77);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zgłoszenie dotyczy";
            // 
            // zgloszenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 372);
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
    }
}