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
            bikeList = new ListView();
            deleteBike = new Button();
            addBike = new Button();
            tabPage2 = new TabPage();
            stationList = new ListView();
            deleteStation = new Button();
            addStation = new Button();
            tabPage3 = new TabPage();
            userList = new ListView();
            deleteAccounts = new Button();
            addAccounts = new Button();
            reports = new Button();
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
            tabPage1.Controls.Add(bikeList);
            tabPage1.Controls.Add(deleteBike);
            tabPage1.Controls.Add(addBike);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "rowery";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bikeList
            // 
            bikeList.Location = new Point(6, 6);
            bikeList.Name = "bikeList";
            bikeList.Size = new Size(756, 303);
            bikeList.TabIndex = 4;
            bikeList.UseCompatibleStateImageBehavior = false;
            // 
            // deleteBike
            // 
            deleteBike.Location = new Point(225, 315);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(164, 77);
            deleteBike.TabIndex = 3;
            deleteBike.Text = "usuń";
            deleteBike.UseVisualStyleBackColor = true;
            deleteBike.Click += deleteBike_Click;
            // 
            // addBike
            // 
            addBike.Location = new Point(395, 315);
            addBike.Name = "addBike";
            addBike.Size = new Size(164, 77);
            addBike.TabIndex = 2;
            addBike.Text = "dodaj";
            addBike.UseVisualStyleBackColor = true;
            addBike.Click += addBike_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(stationList);
            tabPage2.Controls.Add(deleteStation);
            tabPage2.Controls.Add(addStation);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "stacje";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // stationList
            // 
            stationList.Location = new Point(6, 6);
            stationList.Name = "stationList";
            stationList.Size = new Size(756, 303);
            stationList.TabIndex = 6;
            stationList.UseCompatibleStateImageBehavior = false;
            // 
            // deleteStation
            // 
            deleteStation.Location = new Point(216, 315);
            deleteStation.Name = "deleteStation";
            deleteStation.Size = new Size(164, 77);
            deleteStation.TabIndex = 5;
            deleteStation.Text = "usuń";
            deleteStation.UseVisualStyleBackColor = true;
            deleteStation.Click += deleteStation_Click;
            // 
            // addStation
            // 
            addStation.Location = new Point(386, 315);
            addStation.Name = "addStation";
            addStation.Size = new Size(164, 77);
            addStation.TabIndex = 4;
            addStation.Text = "dodaj";
            addStation.UseVisualStyleBackColor = true;
            addStation.Click += addStation_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(userList);
            tabPage3.Controls.Add(deleteAccounts);
            tabPage3.Controls.Add(addAccounts);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "konta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // userList
            // 
            userList.Location = new Point(3, 3);
            userList.Name = "userList";
            userList.Size = new Size(756, 303);
            userList.TabIndex = 6;
            userList.UseCompatibleStateImageBehavior = false;
            // 
            // deleteAccounts
            // 
            deleteAccounts.Location = new Point(219, 312);
            deleteAccounts.Name = "deleteAccounts";
            deleteAccounts.Size = new Size(164, 77);
            deleteAccounts.TabIndex = 5;
            deleteAccounts.Text = "usuń";
            deleteAccounts.UseVisualStyleBackColor = true;
            deleteAccounts.Click += deleteAccounts_Click;
            // 
            // addAccounts
            // 
            addAccounts.Location = new Point(389, 312);
            addAccounts.Name = "addAccounts";
            addAccounts.Size = new Size(164, 77);
            addAccounts.TabIndex = 4;
            addAccounts.Text = "dodaj";
            addAccounts.UseVisualStyleBackColor = true;
            addAccounts.Click += addAccounts_Click;
            // 
            // reports
            // 
            reports.Location = new Point(706, 7);
            reports.Name = "reports";
            reports.Size = new Size(75, 23);
            reports.TabIndex = 1;
            reports.Text = "zgłoszenia";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reports);
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
        private Button addBike;
        private TabPage tabPage3;
        private Button addStation;
        private Button addAccounts;
        private Button reports;
        private ListView bikeList;
        private Button deleteBike;
        private Button deleteStation;
        private Button deleteAccounts;
        private ListView stationList;
        private ListView userList;
    }
}