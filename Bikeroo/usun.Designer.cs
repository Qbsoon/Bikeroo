namespace Bikeroo
{
    partial class usun
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
            deleteYes = new Button();
            deleteNO = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // deleteYes
            // 
            deleteYes.Location = new Point(12, 83);
            deleteYes.Name = "deleteYes";
            deleteYes.Size = new Size(75, 23);
            deleteYes.TabIndex = 0;
            deleteYes.Text = "Tak";
            deleteYes.UseVisualStyleBackColor = true;
            deleteYes.Click += deleteYes_Click;
            // 
            // deleteNO
            // 
            deleteNO.Location = new Point(217, 83);
            deleteNO.Name = "deleteNO";
            deleteNO.Size = new Size(75, 23);
            deleteNO.TabIndex = 1;
            deleteNO.Text = "Nie";
            deleteNO.UseVisualStyleBackColor = true;
            deleteNO.Click += deleteNO_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(67, 26);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 2;
            label1.Text = "Czy jesteś pewien?";
            // 
            // usun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 118);
            Controls.Add(label1);
            Controls.Add(deleteNO);
            Controls.Add(deleteYes);
            Name = "usun";
            Text = "usun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteYes;
        private Button deleteNO;
        private Label label1;
    }
}