namespace Bikeroo
{
    partial class daneStacja
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
            addStation = new Button();
            label1 = new Label();
            label2 = new Label();
            stationName = new TextBox();
            SuspendLayout();
            // 
            // addStation
            // 
            addStation.Location = new Point(135, 82);
            addStation.Name = "addStation";
            addStation.Size = new Size(100, 46);
            addStation.TabIndex = 0;
            addStation.Text = "potwierdz";
            addStation.UseVisualStyleBackColor = true;
            addStation.Click += addStation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(114, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 1;
            label1.Text = "Usupełnij dane";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 56);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwa stacji";
            // 
            // stationName
            // 
            stationName.Location = new Point(135, 53);
            stationName.Name = "stationName";
            stationName.Size = new Size(100, 23);
            stationName.TabIndex = 3;
            // 
            // daneStacja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 140);
            Controls.Add(stationName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addStation);
            Name = "daneStacja";
            Text = "daneStacja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStation;
        private Label label1;
        private Label label2;
        private TextBox stationName;
    }
}