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
            bikeList = new ListBox();
            tabPage2 = new TabPage();
            repairList = new ListBox();
            groupBox1 = new GroupBox();
            deleteBike = new RadioButton();
            toStation = new RadioButton();
            label2 = new Label();
            reports = new Button();
            logOut = new Button();
            reportsList = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toRepair
            // 
            toRepair.Location = new Point(629, 300);
            toRepair.Name = "toRepair";
            toRepair.Size = new Size(139, 81);
            toRepair.TabIndex = 2;
            toRepair.Text = "Do naprawy";
            toRepair.UseVisualStyleBackColor = true;
            toRepair.Click += toRepair_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(629, 300);
            confirm.Name = "confirm";
            confirm.Size = new Size(139, 81);
            confirm.TabIndex = 3;
            confirm.Text = "Potwierdz akcję";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // nrStation
            // 
            nrStation.Location = new Point(629, 271);
            nrStation.Name = "nrStation";
            nrStation.Size = new Size(139, 23);
            nrStation.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 405);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addBike);
            tabPage1.Controls.Add(toRepair);
            tabPage1.Controls.Add(bikeList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(781, 377);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Przenoszenie z stacji";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addBike
            // 
            addBike.Location = new Point(629, 218);
            addBike.Name = "addBike";
            addBike.Size = new Size(139, 73);
            addBike.TabIndex = 4;
            addBike.Text = "Dodaj rower";
            addBike.UseVisualStyleBackColor = true;
            addBike.Click += addBike_Click;
            // 
            // bikeList
            // 
            bikeList.FormattingEnabled = true;
            bikeList.ItemHeight = 15;
            bikeList.Location = new Point(6, 6);
            bikeList.Margin = new Padding(2);
            bikeList.Name = "bikeList";
            bikeList.Size = new Size(769, 364);
            bikeList.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(repairList);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(confirm);
            tabPage2.Controls.Add(nrStation);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(781, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przenoszenie z naprawy";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // repairList
            // 
            repairList.FormattingEnabled = true;
            repairList.ItemHeight = 15;
            repairList.Location = new Point(6, 5);
            repairList.Margin = new Padding(2);
            repairList.Name = "repairList";
            repairList.Size = new Size(573, 364);
            repairList.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBike);
            groupBox1.Controls.Add(toStation);
            groupBox1.Location = new Point(625, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 76);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podjęta akcja";
            // 
            // deleteBike
            // 
            deleteBike.AutoSize = true;
            deleteBike.Location = new Point(17, 47);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(85, 19);
            deleteBike.TabIndex = 11;
            deleteBike.TabStop = true;
            deleteBike.Text = "Usuń rower";
            deleteBike.UseVisualStyleBackColor = true;
            // 
            // toStation
            // 
            toStation.AutoSize = true;
            toStation.Location = new Point(17, 22);
            toStation.Name = "toStation";
            toStation.Size = new Size(105, 19);
            toStation.TabIndex = 9;
            toStation.TabStop = true;
            toStation.Text = "Zwrot na stację";
            toStation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 279);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Stacja";
            label2.Click += label2_Click;
            // 
            // reports
            // 
            reports.Location = new Point(713, 2);
            reports.Name = "reports";
            reports.Size = new Size(75, 28);
            reports.TabIndex = 8;
            reports.Text = "zgłoś";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // logOut
            // 
            logOut.BackColor = SystemColors.ActiveCaption;
            logOut.Location = new Point(713, 419);
            logOut.Name = "logOut";
            logOut.Size = new Size(75, 23);
            logOut.TabIndex = 9;
            logOut.Text = "WYLOGUJ";
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += logOut_Click;
            // 
            // reportsList
            // 
            reportsList.Location = new Point(632, 2);
            reportsList.Name = "reportsList";
            reportsList.Size = new Size(75, 28);
            reportsList.TabIndex = 10;
            reportsList.Text = "lista zgłoszeń";
            reportsList.UseVisualStyleBackColor = true;
            reportsList.Click += reportsList_Click;
            // 
            // engineer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportsList);
            Controls.Add(logOut);
            Controls.Add(reports);
            Controls.Add(tabControl1);
            Name = "engineer";
            Text = "engineer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private ListBox bikeList;
        private ListBox repairList;
        private Button addBike;
        private Button logOut;
        private Button reportsList;
    }
}