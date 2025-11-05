namespace Bikeroo
{
    partial class zgloszeniaWidok
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
            confirm = new Button();
            listView1 = new ListView();
            options = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            takeButton = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            options.SuspendLayout();
            SuspendLayout();
            // 
            // confirm
            // 
            confirm.Location = new Point(535, 383);
            confirm.Name = "confirm";
            confirm.Size = new Size(253, 49);
            confirm.TabIndex = 0;
            confirm.Text = "potwierdz";
            confirm.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 34);
            listView1.Name = "listView1";
            listView1.Size = new Size(517, 398);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // options
            // 
            options.Controls.Add(radioButton2);
            options.Controls.Add(radioButton1);
            options.Location = new Point(594, 302);
            options.Name = "options";
            options.Size = new Size(131, 75);
            options.TabIndex = 4;
            options.TabStop = false;
            options.Text = "Opcje";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Wykonane";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(109, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Usuń zgłoszenie";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Lista zgłoszeń";
            // 
            // takeButton
            // 
            takeButton.Location = new Point(535, 255);
            takeButton.Name = "takeButton";
            takeButton.Size = new Size(253, 41);
            takeButton.TabIndex = 6;
            takeButton.Text = "przejmij";
            takeButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(535, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 174);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 34);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Treść zgłoszenia";
            // 
            // zgloszeniaWidok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(takeButton);
            Controls.Add(label1);
            Controls.Add(options);
            Controls.Add(listView1);
            Controls.Add(confirm);
            Name = "zgloszeniaWidok";
            Text = "zgloszeniaWidok";
            options.ResumeLayout(false);
            options.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirm;
        private ListView listView1;
        private GroupBox options;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button takeButton;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}