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
            bikeList = new ListView();
            repeir_List = new ListView();
            button1 = new Button();
            button2 = new Button();
            nrStation = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bikeList
            // 
            bikeList.Location = new Point(6, 6);
            bikeList.Name = "bikeList";
            bikeList.Size = new Size(769, 394);
            bikeList.TabIndex = 0;
            bikeList.UseCompatibleStateImageBehavior = false;
            bikeList.SelectedIndexChanged += bikeList_SelectedIndexChanged;
            // 
            // repeir_List
            // 
            repeir_List.Location = new Point(6, 5);
            repeir_List.Name = "repeir_List";
            repeir_List.Size = new Size(573, 397);
            repeir_List.TabIndex = 1;
            repeir_List.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(629, 319);
            button1.Name = "button1";
            button1.Size = new Size(139, 81);
            button1.TabIndex = 2;
            button1.Text = "Do naprawy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(629, 321);
            button2.Name = "button2";
            button2.Size = new Size(139, 81);
            button2.TabIndex = 3;
            button2.Text = "Potwierdz akcję";
            button2.UseVisualStyleBackColor = true;
            // 
            // nrStation
            // 
            nrStation.Location = new Point(629, 290);
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
            tabControl1.Size = new Size(789, 434);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(bikeList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(781, 406);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Przenoszenie z stacji";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(repeir_List);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(nrStation);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(781, 406);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przenoszenie z naprawy";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 293);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Stacja";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Zwrot na stację";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(625, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 76);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podjęta akcja";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Usuń rower";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // engineer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private ListView bikeList;
        private ListView repeir_List;
        private Button button1;
        private Button button2;
        private TextBox nrStation;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}