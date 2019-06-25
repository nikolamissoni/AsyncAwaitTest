namespace AsyncAwaitSoap
{
    partial class Form1
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
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.showMBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(97, 83);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNumTextBox.TabIndex = 0;
            this.firstNumTextBox.Text = "3";
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(202, 83);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondNumTextBox.TabIndex = 1;
            this.secondNumTextBox.Text = "4";
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(94, 60);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(87, 17);
            this.firstNumLabel.TabIndex = 2;
            this.firstNumLabel.Text = "First number";
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Location = new System.Drawing.Point(199, 60);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(108, 17);
            this.secondNumLabel.TabIndex = 3;
            this.secondNumLabel.Text = "Second number";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(97, 112);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(205, 27);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(97, 166);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(205, 22);
            this.resultTextBox.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(94, 146);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result";
            // 
            // showMBoxButton
            // 
            this.showMBoxButton.Location = new System.Drawing.Point(97, 194);
            this.showMBoxButton.Name = "showMBoxButton";
            this.showMBoxButton.Size = new System.Drawing.Size(205, 26);
            this.showMBoxButton.TabIndex = 7;
            this.showMBoxButton.Text = "Show MBox";
            this.showMBoxButton.UseVisualStyleBackColor = true;
            this.showMBoxButton.Click += new System.EventHandler(this.showMBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 425);
            this.Controls.Add(this.showMBoxButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondNumLabel);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button showMBoxButton;
    }
}

