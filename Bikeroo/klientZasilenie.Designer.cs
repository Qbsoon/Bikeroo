namespace Bikeroo
{
    partial class klientZasilenie
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
            addMoneyButton = new Button();
            moneyAddText = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // addMoneyButton
            // 
            addMoneyButton.Location = new Point(12, 124);
            addMoneyButton.Name = "addMoneyButton";
            addMoneyButton.Size = new Size(360, 43);
            addMoneyButton.TabIndex = 0;
            addMoneyButton.Text = "zasil konto";
            addMoneyButton.UseVisualStyleBackColor = true;
            addMoneyButton.Click += addMoneyButton_Click;
            // 
            // moneyAddText
            // 
            moneyAddText.Location = new Point(138, 65);
            moneyAddText.Name = "moneyAddText";
            moneyAddText.Size = new Size(100, 23);
            moneyAddText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 47);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 2;
            label1.Text = "zasil konto następującą kwotą";
            // 
            // klientZasilenie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 179);
            Controls.Add(label1);
            Controls.Add(moneyAddText);
            Controls.Add(addMoneyButton);
            Name = "klientZasilenie";
            Text = "klientZasilenie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addMoneyButton;
        private TextBox moneyAddText;
        private Label label1;
    }
}