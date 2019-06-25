namespace WithoutAsyncAwaitSoap
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
            this.firstNumTextBoxNoAsync = new System.Windows.Forms.TextBox();
            this.secondNumTextBoxNoAsync = new System.Windows.Forms.TextBox();
            this.calculateButtonNoAsync = new System.Windows.Forms.Button();
            this.resultTextBoxNoAsync = new System.Windows.Forms.TextBox();
            this.showMBoxButtonNoAsync = new System.Windows.Forms.Button();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumTextBoxNoAsync
            // 
            this.firstNumTextBoxNoAsync.Location = new System.Drawing.Point(187, 76);
            this.firstNumTextBoxNoAsync.Name = "firstNumTextBoxNoAsync";
            this.firstNumTextBoxNoAsync.Size = new System.Drawing.Size(100, 22);
            this.firstNumTextBoxNoAsync.TabIndex = 0;
            this.firstNumTextBoxNoAsync.Text = "22";
            // 
            // secondNumTextBoxNoAsync
            // 
            this.secondNumTextBoxNoAsync.Location = new System.Drawing.Point(304, 76);
            this.secondNumTextBoxNoAsync.Name = "secondNumTextBoxNoAsync";
            this.secondNumTextBoxNoAsync.Size = new System.Drawing.Size(100, 22);
            this.secondNumTextBoxNoAsync.TabIndex = 1;
            this.secondNumTextBoxNoAsync.Text = "33";
            // 
            // calculateButtonNoAsync
            // 
            this.calculateButtonNoAsync.Location = new System.Drawing.Point(187, 105);
            this.calculateButtonNoAsync.Name = "calculateButtonNoAsync";
            this.calculateButtonNoAsync.Size = new System.Drawing.Size(217, 25);
            this.calculateButtonNoAsync.TabIndex = 2;
            this.calculateButtonNoAsync.Text = "Calculate";
            this.calculateButtonNoAsync.UseVisualStyleBackColor = true;
            this.calculateButtonNoAsync.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTextBoxNoAsync
            // 
            this.resultTextBoxNoAsync.Location = new System.Drawing.Point(187, 147);
            this.resultTextBoxNoAsync.Name = "resultTextBoxNoAsync";
            this.resultTextBoxNoAsync.Size = new System.Drawing.Size(217, 22);
            this.resultTextBoxNoAsync.TabIndex = 3;
            // 
            // showMBoxButtonNoAsync
            // 
            this.showMBoxButtonNoAsync.Location = new System.Drawing.Point(187, 176);
            this.showMBoxButtonNoAsync.Name = "showMBoxButtonNoAsync";
            this.showMBoxButtonNoAsync.Size = new System.Drawing.Size(217, 25);
            this.showMBoxButtonNoAsync.TabIndex = 4;
            this.showMBoxButtonNoAsync.Text = "Show MBox";
            this.showMBoxButtonNoAsync.UseVisualStyleBackColor = true;
            this.showMBoxButtonNoAsync.Click += new System.EventHandler(this.button2_Click);
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Location = new System.Drawing.Point(301, 56);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(108, 17);
            this.secondNumLabel.TabIndex = 6;
            this.secondNumLabel.Text = "Second number";
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(184, 56);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(87, 17);
            this.firstNumLabel.TabIndex = 5;
            this.firstNumLabel.Text = "First number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 357);
            this.Controls.Add(this.secondNumLabel);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.showMBoxButtonNoAsync);
            this.Controls.Add(this.resultTextBoxNoAsync);
            this.Controls.Add(this.calculateButtonNoAsync);
            this.Controls.Add(this.secondNumTextBoxNoAsync);
            this.Controls.Add(this.firstNumTextBoxNoAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTextBoxNoAsync;
        private System.Windows.Forms.TextBox secondNumTextBoxNoAsync;
        private System.Windows.Forms.Button calculateButtonNoAsync;
        private System.Windows.Forms.TextBox resultTextBoxNoAsync;
        private System.Windows.Forms.Button showMBoxButtonNoAsync;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Label firstNumLabel;
    }
}

