namespace Bikeroo
{
    partial class daneUżytkownicy
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
            addUser = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login = new TextBox();
            password = new TextBox();
            groupBox1 = new GroupBox();
            clientAdd = new RadioButton();
            engenierAdd = new RadioButton();
            adminAdd = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // addUser
            // 
            addUser.Location = new Point(20, 205);
            addUser.Name = "addUser";
            addUser.Size = new Size(101, 37);
            addUser.TabIndex = 0;
            addUser.Text = "potwierdz";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += addUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "hasło";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 3;
            label3.Text = "Uzupełnij dane";
            // 
            // login
            // 
            login.Location = new Point(43, 42);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 4;
            // 
            // password
            // 
            password.Location = new Point(43, 71);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clientAdd);
            groupBox1.Controls.Add(engenierAdd);
            groupBox1.Controls.Add(adminAdd);
            groupBox1.Location = new Point(3, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 99);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Typ konta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // clientAdd
            // 
            clientAdd.AutoSize = true;
            clientAdd.Location = new Point(40, 74);
            clientAdd.Name = "clientAdd";
            clientAdd.Size = new Size(55, 19);
            clientAdd.TabIndex = 2;
            clientAdd.TabStop = true;
            clientAdd.Text = "Klient";
            clientAdd.UseVisualStyleBackColor = true;
            // 
            // engenierAdd
            // 
            engenierAdd.AutoSize = true;
            engenierAdd.Location = new Point(40, 49);
            engenierAdd.Name = "engenierAdd";
            engenierAdd.Size = new Size(66, 19);
            engenierAdd.TabIndex = 1;
            engenierAdd.TabStop = true;
            engenierAdd.Text = "Inżynier";
            engenierAdd.UseVisualStyleBackColor = true;
            // 
            // adminAdd
            // 
            adminAdd.AutoSize = true;
            adminAdd.Location = new Point(40, 24);
            adminAdd.Name = "adminAdd";
            adminAdd.Size = new Size(61, 19);
            adminAdd.TabIndex = 0;
            adminAdd.TabStop = true;
            adminAdd.Text = "Admin";
            adminAdd.UseVisualStyleBackColor = true;
            adminAdd.CheckedChanged += adminAdd_CheckedChanged;
            // 
            // daneUżytkownicy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(166, 256);
            Controls.Add(groupBox1);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addUser);
            Name = "daneUżytkownicy";
            Text = "daneUżytkownicy";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox login;
        private TextBox password;
        private GroupBox groupBox1;
        private RadioButton clientAdd;
        private RadioButton engenierAdd;
        private RadioButton adminAdd;
    }
}