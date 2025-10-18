namespace Bikeroo
{
    partial class klient
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
            button1 = new Button();
            rentBtn = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rentList = new ListBox();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            listView2 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(716, 3);
            button1.Name = "button1";
            button1.Size = new Size(82, 33);
            button1.TabIndex = 0;
            button1.Text = "Zgłoś";
            button1.UseVisualStyleBackColor = true;
            // 
            // rentBtn
            // 
            rentBtn.Location = new Point(595, 337);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(177, 55);
            rentBtn.TabIndex = 4;
            rentBtn.Text = "WYPOŻYCZ";
            rentBtn.UseVisualStyleBackColor = true;
            rentBtn.Click += rentBtn_click;
            // 
            // button3
            // 
            button3.Location = new Point(595, 338);
            button3.Name = "button3";
            button3.Size = new Size(177, 54);
            button3.TabIndex = 5;
            button3.Text = "ZWRÓĆ";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 426);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rentBtn);
            tabPage1.Controls.Add(rentList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Wypożycz";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rentList
            // 
            rentList.FormattingEnabled = true;
            rentList.ItemHeight = 15;
            rentList.Location = new Point(0, 0);
            rentList.Name = "rentList";
            rentList.Size = new Size(775, 394);
            rentList.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zwróć";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(405, 348);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(6, 346);
            label1.Name = "label1";
            label1.Size = new Size(381, 25);
            label1.TabIndex = 7;
            label1.Text = "Podaj nazwa stacji do której zwracasz rower";
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(769, 326);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // klient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "klient";
            Text = "klient";
            Load += klient_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button rentBtn;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView2;
        private Label label1;
        private TextBox textBox1;
        private ListBox rentList;
    }
}