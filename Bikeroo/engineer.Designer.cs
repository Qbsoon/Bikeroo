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
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            deleteBike = new RadioButton();
            toStation = new RadioButton();
            label2 = new Label();
            reports = new Button();
            bikeList = new ListBox();
            repairList = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toRepair
            // 
            toRepair.Location = new Point(899, 532);
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
            confirm.Location = new Point(899, 535);
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
            nrStation.Location = new Point(899, 483);
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
            tabControl1.Size = new Size(1127, 723);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(toRepair);
            tabPage1.Controls.Add(bikeList);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1119, 685);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Przenoszenie z stacji";
            tabPage1.UseVisualStyleBackColor = true;
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
            tabPage2.Size = new Size(1119, 685);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przenoszenie z naprawy";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBike);
            groupBox1.Controls.Add(toStation);
            groupBox1.Location = new Point(893, 347);
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
            label2.Location = new Point(836, 488);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 8;
            label2.Text = "Stacja";
            // 
            // reports
            // 
            reports.Location = new Point(1019, -3);
            reports.Margin = new Padding(4, 5, 4, 5);
            reports.Name = "reports";
            reports.Size = new Size(107, 38);
            reports.TabIndex = 8;
            reports.Text = "zgłoszenia";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // bikeList
            // 
            bikeList.FormattingEnabled = true;
            bikeList.ItemHeight = 25;
            bikeList.Location = new Point(9, 10);
            bikeList.Name = "bikeList";
            bikeList.Size = new Size(1097, 654);
            bikeList.TabIndex = 3;
            // 
            // repairList
            // 
            repairList.FormattingEnabled = true;
            repairList.ItemHeight = 25;
            repairList.Location = new Point(9, 8);
            repairList.Name = "repairList";
            repairList.Size = new Size(817, 654);
            repairList.TabIndex = 11;
            // 
            // engineer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(reports);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}