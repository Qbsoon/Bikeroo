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
            rentList = new DataGridView();
            rent_Id = new DataGridViewTextBoxColumn();
            rent_Model = new DataGridViewTextBoxColumn();
            rent_Station = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            returnList = new DataGridView();
            return_Id = new DataGridViewTextBoxColumn();
            return_Model = new DataGridViewTextBoxColumn();
            return_Date = new DataGridViewTextBoxColumn();
            stationToReturn = new ComboBox();
            label1 = new Label();
            balanceLabel = new Label();
            button1 = new Button();
            addMoney = new Button();
            gambleButton = new Button();
            pointsLable = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnList).BeginInit();
            SuspendLayout();
            // 
            // reportButton
            // 
            reportButton.Location = new Point(1023, 5);
            reportButton.Margin = new Padding(4, 5, 4, 5);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(117, 55);
            reportButton.TabIndex = 0;
            reportButton.Text = "Zgłoś";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += reportButton_Click;
            // 
            // rentBtn
            // 
            rentBtn.Location = new Point(850, 562);
            rentBtn.Margin = new Padding(4, 5, 4, 5);
            rentBtn.Name = "rentBtn";
            rentBtn.Size = new Size(253, 92);
            rentBtn.TabIndex = 4;
            rentBtn.Text = "WYPOŻYCZ";
            rentBtn.UseVisualStyleBackColor = true;
            rentBtn.Click += rentBtn_click;
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(850, 563);
            returnBtn.Margin = new Padding(4, 5, 4, 5);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(253, 90);
            returnBtn.TabIndex = 5;
            returnBtn.Text = "ZWRÓĆ";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 20);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1123, 710);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rentList);
            tabPage1.Controls.Add(rentBtn);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1115, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Wypożycz";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rentList
            // 
            rentList.AllowUserToAddRows = false;
            rentList.AllowUserToDeleteRows = false;
            rentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rentList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentList.Columns.AddRange(new DataGridViewColumn[] { rent_Id, rent_Model, rent_Station });
            rentList.Location = new Point(9, 10);
            rentList.MultiSelect = false;
            rentList.Name = "rentList";
            rentList.ReadOnly = true;
            rentList.RowHeadersVisible = false;
            rentList.RowHeadersWidth = 62;
            rentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentList.Size = new Size(1097, 529);
            rentList.TabIndex = 5;
            // 
            // rent_Id
            // 
            rent_Id.HeaderText = "Id";
            rent_Id.MinimumWidth = 8;
            rent_Id.Name = "rent_Id";
            rent_Id.ReadOnly = true;
            rent_Id.Width = 64;
            // 
            // rent_Model
            // 
            rent_Model.HeaderText = "Model";
            rent_Model.MinimumWidth = 8;
            rent_Model.Name = "rent_Model";
            rent_Model.ReadOnly = true;
            rent_Model.Width = 99;
            // 
            // rent_Station
            // 
            rent_Station.HeaderText = "Stacja";
            rent_Station.MinimumWidth = 8;
            rent_Station.Name = "rent_Station";
            rent_Station.ReadOnly = true;
            rent_Station.Width = 93;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(returnList);
            tabPage2.Controls.Add(stationToReturn);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(returnBtn);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1115, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zwróć";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // returnList
            // 
            returnList.AllowUserToAddRows = false;
            returnList.AllowUserToDeleteRows = false;
            returnList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            returnList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            returnList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnList.Columns.AddRange(new DataGridViewColumn[] { return_Id, return_Model, return_Date });
            returnList.Location = new Point(9, 10);
            returnList.MultiSelect = false;
            returnList.Name = "returnList";
            returnList.ReadOnly = true;
            returnList.RowHeadersVisible = false;
            returnList.RowHeadersWidth = 62;
            returnList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            returnList.Size = new Size(1097, 529);
            returnList.TabIndex = 11;
            // 
            // return_Id
            // 
            return_Id.HeaderText = "Id";
            return_Id.MinimumWidth = 8;
            return_Id.Name = "return_Id";
            return_Id.ReadOnly = true;
            return_Id.Width = 64;
            // 
            // return_Model
            // 
            return_Model.HeaderText = "Model";
            return_Model.MinimumWidth = 8;
            return_Model.Name = "return_Model";
            return_Model.ReadOnly = true;
            return_Model.Width = 99;
            // 
            // return_Date
            // 
            return_Date.HeaderText = "Data wypożyczenia";
            return_Date.MinimumWidth = 8;
            return_Date.Name = "return_Date";
            return_Date.ReadOnly = true;
            return_Date.Width = 182;
            // 
            // stationToReturn
            // 
            stationToReturn.AllowDrop = true;
            stationToReturn.FormattingEnabled = true;
            stationToReturn.Location = new Point(561, 585);
            stationToReturn.Margin = new Padding(4, 5, 4, 5);
            stationToReturn.Name = "stationToReturn";
            stationToReturn.Size = new Size(278, 33);
            stationToReturn.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(9, 577);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(555, 38);
            label1.TabIndex = 7;
            label1.Text = "Podaj nazwa stacji do której zwracasz rower";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(537, 15);
            balanceLabel.Margin = new Padding(4, 0, 4, 0);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(61, 25);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "Saldo:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(1033, 723);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 8;
            button1.Text = "WYLOGUJ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addMoney
            // 
            addMoney.Location = new Point(421, 0);
            addMoney.Margin = new Padding(4, 5, 4, 5);
            addMoney.Name = "addMoney";
            addMoney.Size = new Size(107, 55);
            addMoney.TabIndex = 9;
            addMoney.Text = "Zasil konto";
            addMoney.UseVisualStyleBackColor = true;
            addMoney.Click += addMoney_Click;
            // 
            // gambleButton
            // 
            gambleButton.Location = new Point(679, 0);
            gambleButton.Margin = new Padding(4, 5, 4, 5);
            gambleButton.Name = "gambleButton";
            gambleButton.Size = new Size(107, 55);
            gambleButton.TabIndex = 10;
            gambleButton.Text = "Losuj";
            gambleButton.UseVisualStyleBackColor = true;
            gambleButton.Click += gambleButton_Click;
            // 
            // pointsLable
            // 
            pointsLable.AutoSize = true;
            pointsLable.Location = new Point(794, 15);
            pointsLable.Margin = new Padding(4, 0, 4, 0);
            pointsLable.Name = "pointsLable";
            pointsLable.Size = new Size(75, 25);
            pointsLable.TabIndex = 11;
            pointsLable.Text = "Punkty: ";
            // 
            // klient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 762);
            Controls.Add(pointsLable);
            Controls.Add(gambleButton);
            Controls.Add(addMoney);
            Controls.Add(button1);
            Controls.Add(balanceLabel);
            Controls.Add(reportButton);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "klient";
            Text = "klient";
            Load += klient_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rentList).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnList).EndInit();
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
        private Label balanceLabel;
        private Button button1;
        private ComboBox stationToReturn;
        private Button addMoney;
        private Button gambleButton;
        private Label pointsLable;
        private DataGridView rentList;
        private DataGridViewTextBoxColumn rent_Id;
        private DataGridViewTextBoxColumn rent_Model;
        private DataGridViewTextBoxColumn rent_Station;
        private DataGridView returnList;
        private DataGridViewTextBoxColumn return_Id;
        private DataGridViewTextBoxColumn return_Model;
        private DataGridViewTextBoxColumn return_Date;
    }
}