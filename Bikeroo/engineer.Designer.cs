namespace Bikeroo
{
    partial class engineer
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
            toRepair = new Button();
            confirm = new Button();
            nrStation = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            addBike = new Button();
            bikeList = new DataGridView();
            available_Id = new DataGridViewTextBoxColumn();
            available_Model = new DataGridViewTextBoxColumn();
            available_Station = new DataGridViewTextBoxColumn();
            available_status = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            repairList = new DataGridView();
            service_Id = new DataGridViewTextBoxColumn();
            service_Model = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            deleteBike = new RadioButton();
            toStation = new RadioButton();
            label2 = new Label();
            reports = new Button();
            logOut = new Button();
            reportsList = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repairList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toRepair
            // 
            toRepair.Location = new Point(899, 500);
            toRepair.Margin = new Padding(4, 5, 4, 5);
            toRepair.Name = "toRepair";
            toRepair.Size = new Size(199, 135);
            toRepair.TabIndex = 2;
            toRepair.Text = "Do naprawy";
            toRepair.UseVisualStyleBackColor = true;
            toRepair.Click += toRepair_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(899, 500);
            confirm.Margin = new Padding(4, 5, 4, 5);
            confirm.Name = "confirm";
            confirm.Size = new Size(199, 135);
            confirm.TabIndex = 3;
            confirm.Text = "Potwierdz akcję";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // nrStation
            // 
            nrStation.Location = new Point(899, 452);
            nrStation.Margin = new Padding(4, 5, 4, 5);
            nrStation.Name = "nrStation";
            nrStation.Size = new Size(197, 31);
            nrStation.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 20);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1127, 675);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addBike);
            tabPage1.Controls.Add(toRepair);
            tabPage1.Controls.Add(bikeList);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1119, 637);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rowery dostępne";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addBike
            // 
            addBike.Location = new Point(899, 363);
            addBike.Margin = new Padding(4, 5, 4, 5);
            addBike.Name = "addBike";
            addBike.Size = new Size(199, 122);
            addBike.TabIndex = 4;
            addBike.Text = "Dodaj rower";
            addBike.UseVisualStyleBackColor = true;
            addBike.Click += addBike_Click;
            // 
            // bikeList
            // 
            bikeList.AllowUserToAddRows = false;
            bikeList.AllowUserToDeleteRows = false;
            bikeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bikeList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bikeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bikeList.Columns.AddRange(new DataGridViewColumn[] { available_Id, available_Model, available_Station, available_status });
            bikeList.Location = new Point(9, 10);
            bikeList.MultiSelect = false;
            bikeList.Name = "bikeList";
            bikeList.ReadOnly = true;
            bikeList.RowHeadersVisible = false;
            bikeList.RowHeadersWidth = 62;
            bikeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bikeList.Size = new Size(858, 604);
            bikeList.TabIndex = 5;
            // 
            // available_Id
            // 
            available_Id.HeaderText = "Id";
            available_Id.MinimumWidth = 8;
            available_Id.Name = "available_Id";
            available_Id.ReadOnly = true;
            available_Id.Width = 64;
            // 
            // available_Model
            // 
            available_Model.HeaderText = "Model";
            available_Model.MinimumWidth = 8;
            available_Model.Name = "available_Model";
            available_Model.ReadOnly = true;
            available_Model.Width = 99;
            // 
            // available_Station
            // 
            available_Station.HeaderText = "Stacja";
            available_Station.MinimumWidth = 8;
            available_Station.Name = "available_Station";
            available_Station.ReadOnly = true;
            available_Station.Width = 93;
            // 
            // available_status
            // 
            available_status.HeaderText = "Wypożyczony?";
            available_status.MinimumWidth = 8;
            available_status.Name = "available_status";
            available_status.ReadOnly = true;
            available_status.Width = 167;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(repairList);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(confirm);
            tabPage2.Controls.Add(nrStation);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1119, 637);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rowery serwisowane";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // repairList
            // 
            repairList.AllowUserToAddRows = false;
            repairList.AllowUserToDeleteRows = false;
            repairList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            repairList.Columns.AddRange(new DataGridViewColumn[] { service_Id, service_Model });
            repairList.Location = new Point(9, 8);
            repairList.MultiSelect = false;
            repairList.Name = "repairList";
            repairList.ReadOnly = true;
            repairList.RowHeadersVisible = false;
            repairList.RowHeadersWidth = 62;
            repairList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            repairList.Size = new Size(817, 604);
            repairList.TabIndex = 12;
            // 
            // service_Id
            // 
            service_Id.HeaderText = "Id";
            service_Id.MinimumWidth = 8;
            service_Id.Name = "service_Id";
            service_Id.ReadOnly = true;
            service_Id.Width = 150;
            // 
            // service_Model
            // 
            service_Model.HeaderText = "Model";
            service_Model.MinimumWidth = 8;
            service_Model.Name = "service_Model";
            service_Model.ReadOnly = true;
            service_Model.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBike);
            groupBox1.Controls.Add(toStation);
            groupBox1.Location = new Point(893, 315);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(204, 127);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podjęta akcja";
            // 
            // deleteBike
            // 
            deleteBike.AutoSize = true;
            deleteBike.Location = new Point(24, 78);
            deleteBike.Margin = new Padding(4, 5, 4, 5);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(127, 29);
            deleteBike.TabIndex = 11;
            deleteBike.TabStop = true;
            deleteBike.Text = "Usuń rower";
            deleteBike.UseVisualStyleBackColor = true;
            // 
            // toStation
            // 
            toStation.AutoSize = true;
            toStation.Location = new Point(24, 37);
            toStation.Margin = new Padding(4, 5, 4, 5);
            toStation.Name = "toStation";
            toStation.Size = new Size(156, 29);
            toStation.TabIndex = 9;
            toStation.TabStop = true;
            toStation.Text = "Zwrot na stację";
            toStation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(834, 452);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 8;
            label2.Text = "Stacja";
            label2.Click += label2_Click;
            // 
            // reports
            // 
            reports.Location = new Point(1019, 3);
            reports.Margin = new Padding(4, 5, 4, 5);
            reports.Name = "reports";
            reports.Size = new Size(107, 47);
            reports.TabIndex = 8;
            reports.Text = "zgłoś";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // logOut
            // 
            logOut.BackColor = SystemColors.ActiveCaption;
            logOut.Location = new Point(1019, 698);
            logOut.Margin = new Padding(4, 5, 4, 5);
            logOut.Name = "logOut";
            logOut.Size = new Size(107, 38);
            logOut.TabIndex = 9;
            logOut.Text = "WYLOGUJ";
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += logOut_Click;
            // 
            // reportsList
            // 
            reportsList.Location = new Point(903, 3);
            reportsList.Margin = new Padding(4, 5, 4, 5);
            reportsList.Name = "reportsList";
            reportsList.Size = new Size(107, 47);
            reportsList.TabIndex = 10;
            reportsList.Text = "lista zgłoszeń";
            reportsList.UseVisualStyleBackColor = true;
            reportsList.Click += reportsList_Click;
            // 
            // engineer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(reportsList);
            Controls.Add(logOut);
            Controls.Add(reports);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "engineer";
            Text = "engineer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bikeList).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repairList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button toRepair;
        private Button confirm;
        private TextBox nrStation;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton deleteBike;
        private RadioButton toStation;
        private Button reports;
        private Button addBike;
        private Button logOut;
        private Button reportsList;
        private DataGridView bikeList;
        private DataGridViewTextBoxColumn available_Id;
        private DataGridViewTextBoxColumn available_Model;
        private DataGridViewTextBoxColumn available_Station;
        private DataGridViewTextBoxColumn available_status;
        private DataGridView repairList;
        private DataGridViewTextBoxColumn service_Id;
        private DataGridViewTextBoxColumn service_Model;
    }
}