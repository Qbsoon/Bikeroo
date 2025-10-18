namespace Bikeroo
{
    partial class admin
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            deleteBike = new Button();
            addBike = new Button();
            panelBikes = new TableLayoutPanel();
            tabPage2 = new TabPage();
            deleteStation = new Button();
            addStation = new Button();
            panelStation = new TableLayoutPanel();
            tabPage3 = new TabPage();
            deleteAccounts = new Button();
            addAccounts = new Button();
            panelAccounts = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteBike);
            tabPage1.Controls.Add(addBike);
            tabPage1.Controls.Add(panelBikes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "rowery";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteBike
            // 
            deleteBike.Location = new Point(225, 315);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(164, 77);
            deleteBike.TabIndex = 3;
            deleteBike.Text = "usuń";
            deleteBike.UseVisualStyleBackColor = true;
            // 
            // addBike
            // 
            addBike.Location = new Point(395, 315);
            addBike.Name = "addBike";
            addBike.Size = new Size(164, 77);
            addBike.TabIndex = 2;
            addBike.Text = "dodaj";
            addBike.UseVisualStyleBackColor = true;
            addBike.Click += button2_Click;
            // 
            // panelBikes
            // 
            panelBikes.ColumnCount = 2;
            panelBikes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelBikes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelBikes.Location = new Point(3, 6);
            panelBikes.Name = "panelBikes";
            panelBikes.RowCount = 2;
            panelBikes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelBikes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelBikes.Size = new Size(759, 303);
            panelBikes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(deleteStation);
            tabPage2.Controls.Add(addStation);
            tabPage2.Controls.Add(panelStation);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "stacje";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteStation
            // 
            deleteStation.Location = new Point(216, 315);
            deleteStation.Name = "deleteStation";
            deleteStation.Size = new Size(164, 77);
            deleteStation.TabIndex = 5;
            deleteStation.Text = "usuń";
            deleteStation.UseVisualStyleBackColor = true;
            // 
            // addStation
            // 
            addStation.Location = new Point(386, 315);
            addStation.Name = "addStation";
            addStation.Size = new Size(164, 77);
            addStation.TabIndex = 4;
            addStation.Text = "dodaj";
            addStation.UseVisualStyleBackColor = true;
            // 
            // panelStation
            // 
            panelStation.ColumnCount = 2;
            panelStation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelStation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelStation.Location = new Point(3, 6);
            panelStation.Name = "panelStation";
            panelStation.RowCount = 2;
            panelStation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelStation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelStation.Size = new Size(759, 303);
            panelStation.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(deleteAccounts);
            tabPage3.Controls.Add(addAccounts);
            tabPage3.Controls.Add(panelAccounts);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "konta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteAccounts
            // 
            deleteAccounts.Location = new Point(219, 312);
            deleteAccounts.Name = "deleteAccounts";
            deleteAccounts.Size = new Size(164, 77);
            deleteAccounts.TabIndex = 5;
            deleteAccounts.Text = "usuń";
            deleteAccounts.UseVisualStyleBackColor = true;
            // 
            // addAccounts
            // 
            addAccounts.Location = new Point(389, 312);
            addAccounts.Name = "addAccounts";
            addAccounts.Size = new Size(164, 77);
            addAccounts.TabIndex = 4;
            addAccounts.Text = "dodaj";
            addAccounts.UseVisualStyleBackColor = true;
            // 
            // panelAccounts
            // 
            panelAccounts.ColumnCount = 2;
            panelAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelAccounts.Location = new Point(6, 3);
            panelAccounts.Name = "panelAccounts";
            panelAccounts.RowCount = 2;
            panelAccounts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelAccounts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelAccounts.Size = new Size(759, 303);
            panelAccounts.TabIndex = 2;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "admin";
            Text = "admin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel panelBikes;
        private TableLayoutPanel panelStation;
        private Button addBike;
        private TabPage tabPage3;
        private TableLayoutPanel panelAccounts;
        private Button deleteBike;
        private Button deleteStation;
        private Button addStation;
        private Button deleteAccounts;
        private Button addAccounts;
    }
}