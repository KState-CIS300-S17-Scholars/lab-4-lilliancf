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
            this.label1 = new System.Windows.Forms.Label();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxFindPrimeButton = new System.Windows.Forms.Button();
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter positive bound: ";
            // 
            // uxInput
            // 
            this.uxInput.Location = new System.Drawing.Point(230, 47);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(217, 30);
            this.uxInput.TabIndex = 1;
            // 
            // uxFindPrimeButton
            // 
            this.uxFindPrimeButton.Location = new System.Drawing.Point(132, 99);
            this.uxFindPrimeButton.Name = "uxFindPrimeButton";
            this.uxFindPrimeButton.Size = new System.Drawing.Size(197, 50);
            this.uxFindPrimeButton.TabIndex = 2;
            this.uxFindPrimeButton.Text = "Find Primes";
            this.uxFindPrimeButton.UseVisualStyleBackColor = true;
            this.uxFindPrimeButton.Click += new System.EventHandler(this.uxFindPrimeButton_Click);
            // 
            // uxOutput
            // 
            this.uxOutput.Location = new System.Drawing.Point(28, 173);
            this.uxOutput.Multiline = true;
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.ReadOnly = true;
            this.uxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxOutput.Size = new System.Drawing.Size(418, 235);
            this.uxOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 428);
            this.Controls.Add(this.uxOutput);
            this.Controls.Add(this.uxFindPrimeButton);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.Button uxFindPrimeButton;
        private System.Windows.Forms.TextBox uxOutput;
    }
}

