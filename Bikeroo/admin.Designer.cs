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
            bikeTable = new DataGridView();
            bikesT_id = new DataGridViewTextBoxColumn();
            bikesT_model = new DataGridViewTextBoxColumn();
            bikesT_station = new DataGridViewTextBoxColumn();
            bikesT_borrowed = new DataGridViewTextBoxColumn();
            bikesT_maintenance = new DataGridViewTextBoxColumn();
            deleteBike = new Button();
            addBike = new Button();
            tabPage2 = new TabPage();
            stationTable = new DataGridView();
            stationT_id = new DataGridViewTextBoxColumn();
            stationT_name = new DataGridViewTextBoxColumn();
            stationT_bikeCount = new DataGridViewTextBoxColumn();
            deleteStation = new Button();
            addStation = new Button();
            tabPage3 = new TabPage();
            userTable = new DataGridView();
            accountT_Id = new DataGridViewTextBoxColumn();
            accountT_uname = new DataGridViewTextBoxColumn();
            accountT_type = new DataGridViewTextBoxColumn();
            accountT_balance = new DataGridViewTextBoxColumn();
            deleteAccounts = new Button();
            addAccounts = new Button();
            reports = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeTable).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stationTable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(17, 20);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1109, 710);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bikeTable);
            tabPage1.Controls.Add(deleteBike);
            tabPage1.Controls.Add(addBike);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1101, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "rowery";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bikeTable
            // 
            bikeTable.AllowUserToAddRows = false;
            bikeTable.AllowUserToDeleteRows = false;
            bikeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bikeTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bikeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bikeTable.Columns.AddRange(new DataGridViewColumn[] { bikesT_id, bikesT_model, bikesT_station, bikesT_borrowed, bikesT_maintenance });
            bikeTable.Location = new Point(9, 10);
            bikeTable.MultiSelect = false;
            bikeTable.Name = "bikeTable";
            bikeTable.ReadOnly = true;
            bikeTable.RowHeadersVisible = false;
            bikeTable.RowHeadersWidth = 200;
            bikeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bikeTable.Size = new Size(1078, 502);
            bikeTable.TabIndex = 5;
            // 
            // bikesT_id
            // 
            bikesT_id.HeaderText = "Id";
            bikesT_id.MinimumWidth = 8;
            bikesT_id.Name = "bikesT_id";
            bikesT_id.ReadOnly = true;
            bikesT_id.Width = 64;
            // 
            // bikesT_model
            // 
            bikesT_model.HeaderText = "Model";
            bikesT_model.MinimumWidth = 8;
            bikesT_model.Name = "bikesT_model";
            bikesT_model.ReadOnly = true;
            bikesT_model.Width = 99;
            // 
            // bikesT_station
            // 
            bikesT_station.HeaderText = "Stacja";
            bikesT_station.MinimumWidth = 8;
            bikesT_station.Name = "bikesT_station";
            bikesT_station.ReadOnly = true;
            bikesT_station.Width = 93;
            // 
            // bikesT_borrowed
            // 
            bikesT_borrowed.HeaderText = "Wypożyczenie";
            bikesT_borrowed.MinimumWidth = 8;
            bikesT_borrowed.Name = "bikesT_borrowed";
            bikesT_borrowed.ReadOnly = true;
            bikesT_borrowed.Width = 161;
            // 
            // bikesT_maintenance
            // 
            bikesT_maintenance.HeaderText = "Naprawa";
            bikesT_maintenance.MinimumWidth = 8;
            bikesT_maintenance.Name = "bikesT_maintenance";
            bikesT_maintenance.ReadOnly = true;
            bikesT_maintenance.Width = 118;
            // 
            // deleteBike
            // 
            deleteBike.Location = new Point(321, 525);
            deleteBike.Margin = new Padding(4, 5, 4, 5);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(234, 128);
            deleteBike.TabIndex = 3;
            deleteBike.Text = "usuń";
            deleteBike.UseVisualStyleBackColor = true;
            deleteBike.Click += deleteBike_Click;
            // 
            // addBike
            // 
            addBike.Location = new Point(564, 525);
            addBike.Margin = new Padding(4, 5, 4, 5);
            addBike.Name = "addBike";
            addBike.Size = new Size(234, 128);
            addBike.TabIndex = 2;
            addBike.Text = "dodaj";
            addBike.UseVisualStyleBackColor = true;
            addBike.Click += addBike_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(stationTable);
            tabPage2.Controls.Add(deleteStation);
            tabPage2.Controls.Add(addStation);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1101, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "stacje";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // stationTable
            // 
            stationTable.AllowUserToAddRows = false;
            stationTable.AllowUserToDeleteRows = false;
            stationTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            stationTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            stationTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stationTable.Columns.AddRange(new DataGridViewColumn[] { stationT_id, stationT_name, stationT_bikeCount });
            stationTable.Location = new Point(9, 10);
            stationTable.MultiSelect = false;
            stationTable.Name = "stationTable";
            stationTable.ReadOnly = true;
            stationTable.RowHeadersVisible = false;
            stationTable.RowHeadersWidth = 120;
            stationTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stationTable.Size = new Size(1078, 502);
            stationTable.TabIndex = 7;
            // 
            // stationT_id
            // 
            stationT_id.HeaderText = "Id";
            stationT_id.MinimumWidth = 8;
            stationT_id.Name = "stationT_id";
            stationT_id.ReadOnly = true;
            stationT_id.Width = 64;
            // 
            // stationT_name
            // 
            stationT_name.HeaderText = "Nazwa";
            stationT_name.MinimumWidth = 8;
            stationT_name.Name = "stationT_name";
            stationT_name.ReadOnly = true;
            // 
            // stationT_bikeCount
            // 
            stationT_bikeCount.HeaderText = "Liczba rowerów";
            stationT_bikeCount.MinimumWidth = 8;
            stationT_bikeCount.Name = "stationT_bikeCount";
            stationT_bikeCount.ReadOnly = true;
            stationT_bikeCount.Width = 170;
            // 
            // deleteStation
            // 
            deleteStation.Location = new Point(309, 525);
            deleteStation.Margin = new Padding(4, 5, 4, 5);
            deleteStation.Name = "deleteStation";
            deleteStation.Size = new Size(234, 128);
            deleteStation.TabIndex = 5;
            deleteStation.Text = "usuń";
            deleteStation.UseVisualStyleBackColor = true;
            deleteStation.Click += deleteStation_Click;
            // 
            // addStation
            // 
            addStation.Location = new Point(551, 525);
            addStation.Margin = new Padding(4, 5, 4, 5);
            addStation.Name = "addStation";
            addStation.Size = new Size(234, 128);
            addStation.TabIndex = 4;
            addStation.Text = "dodaj";
            addStation.UseVisualStyleBackColor = true;
            addStation.Click += addStation_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(userTable);
            tabPage3.Controls.Add(deleteAccounts);
            tabPage3.Controls.Add(addAccounts);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1101, 672);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "konta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.AllowUserToDeleteRows = false;
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            userTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Columns.AddRange(new DataGridViewColumn[] { accountT_Id, accountT_uname, accountT_type, accountT_balance });
            userTable.Location = new Point(4, 5);
            userTable.MultiSelect = false;
            userTable.Name = "userTable";
            userTable.ReadOnly = true;
            userTable.RowHeadersVisible = false;
            userTable.RowHeadersWidth = 120;
            userTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTable.Size = new Size(1078, 502);
            userTable.TabIndex = 7;
            // 
            // accountT_Id
            // 
            accountT_Id.HeaderText = "Id";
            accountT_Id.MinimumWidth = 8;
            accountT_Id.Name = "accountT_Id";
            accountT_Id.Width = 64;
            // 
            // accountT_uname
            // 
            accountT_uname.HeaderText = "Nazwa użytkownika";
            accountT_uname.MinimumWidth = 8;
            accountT_uname.Name = "accountT_uname";
            accountT_uname.Width = 186;
            // 
            // accountT_type
            // 
            accountT_type.HeaderText = "Typ";
            accountT_type.MinimumWidth = 8;
            accountT_type.Name = "accountT_type";
            accountT_type.Width = 76;
            // 
            // accountT_balance
            // 
            accountT_balance.HeaderText = "Saldo";
            accountT_balance.MinimumWidth = 8;
            accountT_balance.Name = "accountT_balance";
            accountT_balance.Width = 93;
            // 
            // deleteAccounts
            // 
            deleteAccounts.Location = new Point(313, 520);
            deleteAccounts.Margin = new Padding(4, 5, 4, 5);
            deleteAccounts.Name = "deleteAccounts";
            deleteAccounts.Size = new Size(234, 128);
            deleteAccounts.TabIndex = 5;
            deleteAccounts.Text = "usuń";
            deleteAccounts.UseVisualStyleBackColor = true;
            deleteAccounts.Click += deleteAccounts_Click;
            // 
            // addAccounts
            // 
            addAccounts.Location = new Point(556, 520);
            addAccounts.Margin = new Padding(4, 5, 4, 5);
            addAccounts.Name = "addAccounts";
            addAccounts.Size = new Size(234, 128);
            addAccounts.TabIndex = 4;
            addAccounts.Text = "dodaj";
            addAccounts.UseVisualStyleBackColor = true;
            addAccounts.Click += addAccounts_Click;
            // 
            // reports
            // 
            reports.Location = new Point(1009, 12);
            reports.Margin = new Padding(4, 5, 4, 5);
            reports.Name = "reports";
            reports.Size = new Size(107, 38);
            reports.TabIndex = 1;
            reports.Text = "zgłoszenia";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(reports);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "admin";
            Text = "admin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bikeTable).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stationTable).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
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
        private Button deleteBike;
        private Button deleteStation;
        private Button deleteAccounts;
        private ListView userList;
        private DataGridView bikeTable;
        private DataGridViewTextBoxColumn bikesT_id;
        private DataGridViewTextBoxColumn bikesT_model;
        private DataGridViewTextBoxColumn bikesT_station;
        private DataGridViewTextBoxColumn bikesT_borrowed;
        private DataGridViewTextBoxColumn bikesT_maintenance;
        private DataGridView stationTable;
        private DataGridViewTextBoxColumn stationT_id;
        private DataGridViewTextBoxColumn stationT_name;
        private DataGridViewTextBoxColumn stationT_bikeCount;
        private DataGridView userTable;
        private DataGridViewTextBoxColumn accountT_Id;
        private DataGridViewTextBoxColumn accountT_uname;
        private DataGridViewTextBoxColumn accountT_type;
        private DataGridViewTextBoxColumn accountT_balance;
    }
}