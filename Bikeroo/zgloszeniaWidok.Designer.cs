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
            Konemtarz = new Label();
            richTextBox1 = new RichTextBox();
            options = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
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
            // Konemtarz
            // 
            Konemtarz.AutoSize = true;
            Konemtarz.Location = new Point(579, 34);
            Konemtarz.Name = "Konemtarz";
            Konemtarz.Size = new Size(64, 15);
            Konemtarz.TabIndex = 2;
            Konemtarz.Text = "Komentarz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(535, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 244);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // options
            // 
            options.Controls.Add(radioButton2);
            options.Controls.Add(radioButton1);
            options.Location = new Point(593, 302);
            options.Name = "options";
            options.Size = new Size(131, 75);
            options.TabIndex = 4;
            options.TabStop = false;
            options.Text = "Opcje";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Lista zgłoszeń";
            // 
            // zgloszeniaWidok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(options);
            Controls.Add(richTextBox1);
            Controls.Add(Konemtarz);
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
        private Label Konemtarz;
        private RichTextBox richTextBox1;
        private GroupBox options;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
    }
}