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
            reportButton = new Button();
            rentBtn = new Button();
            returnBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rentList = new ListBox();
            tabPage2 = new TabPage();
            stationToReturn = new ComboBox();
            returnList = new ListBox();
            label1 = new Label();
            balanceLabel = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // reportButton
            // 
            reportButton.Location = new Point(716, 3);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(82, 33);
            reportButton.TabIndex = 0;
            reportButton.Text = "Zgłoś";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += reportButton_Click;
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
            // returnBtn
            // 
            returnBtn.Location = new Point(595, 338);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(177, 54);
            returnBtn.TabIndex = 5;
            returnBtn.Text = "ZWRÓĆ";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
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
            rentList.Location = new Point(6, 6);
            rentList.Name = "rentList";
            rentList.Size = new Size(769, 319);
            rentList.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(stationToReturn);
            tabPage2.Controls.Add(returnList);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(returnBtn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zwróć";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // stationToReturn
            // 
            stationToReturn.AllowDrop = true;
            stationToReturn.FormattingEnabled = true;
            stationToReturn.Location = new Point(393, 351);
            stationToReturn.Name = "stationToReturn";
            stationToReturn.Size = new Size(196, 23);
            stationToReturn.TabIndex = 10;
            // 
            // returnList
            // 
            returnList.FormattingEnabled = true;
            returnList.ItemHeight = 15;
            returnList.Location = new Point(6, 6);
            returnList.Name = "returnList";
            returnList.Size = new Size(769, 319);
            returnList.TabIndex = 9;
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
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(529, 12);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(39, 15);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "Saldo:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(723, 434);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "WYLOGUJ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // klient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(button1);
            Controls.Add(balanceLabel);
            Controls.Add(reportButton);
            Controls.Add(tabControl1);
            Name = "klient";
            Text = "klient";
            Load += klient_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reportButton;
        private Button rentBtn;
        private Button returnBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ListBox rentList;
        private ListBox returnList;
        private Label balanceLabel;
        private Button button1;
        private ComboBox stationToReturn;
    }
}