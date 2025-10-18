namespace Bikeroo
{
    partial class daneRowery
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
            addBikes = new Button();
            addBikeModel = new TextBox();
            bikeStation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // addBikes
            // 
            addBikes.Location = new Point(90, 132);
            addBikes.Name = "addBikes";
            addBikes.Size = new Size(75, 23);
            addBikes.TabIndex = 0;
            addBikes.Text = "potwierdz";
            addBikes.UseVisualStyleBackColor = true;
            // 
            // addBikeModel
            // 
            addBikeModel.Location = new Point(76, 74);
            addBikeModel.Name = "addBikeModel";
            addBikeModel.Size = new Size(100, 23);
            addBikeModel.TabIndex = 1;
            // 
            // bikeStation
            // 
            bikeStation.Location = new Point(76, 103);
            bikeStation.Name = "bikeStation";
            bikeStation.Size = new Size(100, 23);
            bikeStation.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 74);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Stacja";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(49, 22);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 5;
            label3.Text = "Uzupełnij dane";
            label3.Click += label3_Click;
            // 
            // daneRowery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 177);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bikeStation);
            Controls.Add(addBikeModel);
            Controls.Add(addBikes);
            Name = "daneRowery";
            Text = "daneRowery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBikes;
        private TextBox addBikeModel;
        private TextBox bikeStation;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}