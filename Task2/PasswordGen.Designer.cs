namespace Task2
{
    partial class PasswordGen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            generatePasswordButton = new Button();
            lengthBox = new TextBox();
            uppercaseBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lowercaseBox = new TextBox();
            label4 = new Label();
            numbersBox = new TextBox();
            passwordBox = new TextBox();
            label5 = new Label();
            specialBox = new TextBox();
            SuspendLayout();
            // 
            // generatePasswordButton
            // 
            generatePasswordButton.Location = new Point(333, 257);
            generatePasswordButton.Name = "generatePasswordButton";
            generatePasswordButton.Size = new Size(116, 45);
            generatePasswordButton.TabIndex = 0;
            generatePasswordButton.Text = "Generate ";
            generatePasswordButton.UseVisualStyleBackColor = true;
            generatePasswordButton.Click += generatePasswordButton_Click;
            // 
            // lengthBox
            // 
            lengthBox.Location = new Point(12, 186);
            lengthBox.Name = "lengthBox";
            lengthBox.Size = new Size(100, 23);
            lengthBox.TabIndex = 1;
            // 
            // uppercaseBox
            // 
            uppercaseBox.Location = new Point(179, 186);
            uppercaseBox.Name = "uppercaseBox";
            uppercaseBox.Size = new Size(100, 23);
            uppercaseBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter a length of password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 151);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter a % of uppercase letters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 151);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 6;
            label3.Text = "Enter a % of lowercase letters";
            // 
            // lowercaseBox
            // 
            lowercaseBox.Location = new Point(347, 186);
            lowercaseBox.Name = "lowercaseBox";
            lowercaseBox.Size = new Size(100, 23);
            lowercaseBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 151);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 8;
            label4.Text = "Enter a % of numbers";
            // 
            // numbersBox
            // 
            numbersBox.Location = new Point(515, 186);
            numbersBox.Name = "numbersBox";
            numbersBox.Size = new Size(100, 23);
            numbersBox.TabIndex = 7;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 308);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(776, 130);
            passwordBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(641, 151);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 11;
            label5.Text = "Enter a % of special digits";
            // 
            // specialBox
            // 
            specialBox.Location = new Point(641, 186);
            specialBox.Name = "specialBox";
            specialBox.Size = new Size(100, 23);
            specialBox.TabIndex = 10;
            // 
            // PasswordGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(specialBox);
            Controls.Add(passwordBox);
            Controls.Add(label4);
            Controls.Add(numbersBox);
            Controls.Add(label3);
            Controls.Add(lowercaseBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uppercaseBox);
            Controls.Add(lengthBox);
            Controls.Add(generatePasswordButton);
            Name = "PasswordGen";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generatePasswordButton;
        private TextBox lengthBox;
        private TextBox uppercaseBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lowercaseBox;
        private Label label4;
        private TextBox numbersBox;
        private TextBox passwordBox;
        private Label label5;
        private TextBox specialBox;
    }
}
