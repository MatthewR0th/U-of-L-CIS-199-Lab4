namespace Lab4
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
            this.acceptedOutputLabel = new System.Windows.Forms.Label();
            this.rejectedOutputLabel = new System.Windows.Forms.Label();
            this.runningTotalTitle = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.acceptanceLabel = new System.Windows.Forms.Label();
            this.calculationButton = new System.Windows.Forms.Button();
            this.admissionScoreInput = new System.Windows.Forms.TextBox();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.admissionScoreLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptedOutputLabel
            // 
            this.acceptedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedOutputLabel.Location = new System.Drawing.Point(502, 118);
            this.acceptedOutputLabel.Name = "acceptedOutputLabel";
            this.acceptedOutputLabel.Size = new System.Drawing.Size(128, 18);
            this.acceptedOutputLabel.TabIndex = 23;
            // 
            // rejectedOutputLabel
            // 
            this.rejectedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedOutputLabel.Location = new System.Drawing.Point(502, 191);
            this.rejectedOutputLabel.Name = "rejectedOutputLabel";
            this.rejectedOutputLabel.Size = new System.Drawing.Size(128, 18);
            this.rejectedOutputLabel.TabIndex = 22;
            // 
            // runningTotalTitle
            // 
            this.runningTotalTitle.AutoSize = true;
            this.runningTotalTitle.Location = new System.Drawing.Point(499, 66);
            this.runningTotalTitle.Name = "runningTotalTitle";
            this.runningTotalTitle.Size = new System.Drawing.Size(77, 13);
            this.runningTotalTitle.TabIndex = 21;
            this.runningTotalTitle.Text = "Running Total:";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(267, 322);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(99, 15);
            this.resultLabel.TabIndex = 20;
            // 
            // acceptanceLabel
            // 
            this.acceptanceLabel.AutoSize = true;
            this.acceptanceLabel.Location = new System.Drawing.Point(108, 322);
            this.acceptanceLabel.Name = "acceptanceLabel";
            this.acceptanceLabel.Size = new System.Drawing.Size(126, 13);
            this.acceptanceLabel.TabIndex = 19;
            this.acceptanceLabel.Text = "Your Acceptance Status:";
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(193, 268);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(75, 23);
            this.calculationButton.TabIndex = 18;
            this.calculationButton.Text = "Submit";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // admissionScoreInput
            // 
            this.admissionScoreInput.Location = new System.Drawing.Point(266, 207);
            this.admissionScoreInput.Name = "admissionScoreInput";
            this.admissionScoreInput.Size = new System.Drawing.Size(100, 20);
            this.admissionScoreInput.TabIndex = 17;
            // 
            // gpaInput
            // 
            this.gpaInput.Location = new System.Drawing.Point(266, 138);
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Size = new System.Drawing.Size(100, 20);
            this.gpaInput.TabIndex = 16;
            // 
            // admissionScoreLabel
            // 
            this.admissionScoreLabel.AutoSize = true;
            this.admissionScoreLabel.Location = new System.Drawing.Point(108, 207);
            this.admissionScoreLabel.Name = "admissionScoreLabel";
            this.admissionScoreLabel.Size = new System.Drawing.Size(116, 13);
            this.admissionScoreLabel.TabIndex = 15;
            this.admissionScoreLabel.Text = "Enter Admission Score:";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(108, 141);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(60, 13);
            this.gpaLabel.TabIndex = 14;
            this.gpaLabel.Text = "Enter GPA:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(190, 66);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 13);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Admission Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acceptedOutputLabel);
            this.Controls.Add(this.rejectedOutputLabel);
            this.Controls.Add(this.runningTotalTitle);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.acceptanceLabel);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.admissionScoreInput);
            this.Controls.Add(this.gpaInput);
            this.Controls.Add(this.admissionScoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acceptedOutputLabel;
        private System.Windows.Forms.Label rejectedOutputLabel;
        private System.Windows.Forms.Label runningTotalTitle;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label acceptanceLabel;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.TextBox admissionScoreInput;
        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.Label admissionScoreLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

