namespace Task1
{
    partial class Form1
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
            enterTextBox = new TextBox();
            enterLabel = new Label();
            submitButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // enterTextBox
            // 
            enterTextBox.Location = new Point(355, 185);
            enterTextBox.Name = "enterTextBox";
            enterTextBox.Size = new Size(100, 23);
            enterTextBox.TabIndex = 0;
            // 
            // enterLabel
            // 
            enterLabel.AutoSize = true;
            enterLabel.Location = new Point(355, 148);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new Size(88, 15);
            enterLabel.TabIndex = 1;
            enterLabel.Text = "Enter a number";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(355, 239);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(100, 23);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(355, 307);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 3;
            resultLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(submitButton);
            Controls.Add(enterLabel);
            Controls.Add(enterTextBox);
            Name = "Form1";
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox enterTextBox;
        private Label enterLabel;
        private Button submitButton;
        private Label resultLabel;
    }
}
