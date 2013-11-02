namespace Talker
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
            this.numberOfTimes = new System.Windows.Forms.NumericUpDown();
            this.numberOfTimesLabel = new System.Windows.Forms.Label();
            this.sayThisTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speakToMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfTimes
            // 
            this.numberOfTimes.Location = new System.Drawing.Point(78, 36);
            this.numberOfTimes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfTimes.Name = "numberOfTimes";
            this.numberOfTimes.Size = new System.Drawing.Size(49, 20);
            this.numberOfTimes.TabIndex = 0;
            this.numberOfTimes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numberOfTimesLabel
            // 
            this.numberOfTimesLabel.AutoSize = true;
            this.numberOfTimesLabel.Location = new System.Drawing.Point(16, 38);
            this.numberOfTimesLabel.Name = "numberOfTimesLabel";
            this.numberOfTimesLabel.Size = new System.Drawing.Size(56, 13);
            this.numberOfTimesLabel.TabIndex = 1;
            this.numberOfTimesLabel.Text = "# of times:";
            // 
            // sayThisTextBox
            // 
            this.sayThisTextBox.Location = new System.Drawing.Point(78, 10);
            this.sayThisTextBox.Name = "sayThisTextBox";
            this.sayThisTextBox.Size = new System.Drawing.Size(308, 20);
            this.sayThisTextBox.TabIndex = 2;
            this.sayThisTextBox.Text = "Hello!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Say this:";
            // 
            // speakToMe
            // 
            this.speakToMe.Location = new System.Drawing.Point(152, 62);
            this.speakToMe.Name = "speakToMe";
            this.speakToMe.Size = new System.Drawing.Size(121, 23);
            this.speakToMe.TabIndex = 4;
            this.speakToMe.Text = "Speak to me!";
            this.speakToMe.UseVisualStyleBackColor = true;
            this.speakToMe.Click += new System.EventHandler(this.speakToMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 93);
            this.Controls.Add(this.speakToMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sayThisTextBox);
            this.Controls.Add(this.numberOfTimesLabel);
            this.Controls.Add(this.numberOfTimes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Talker";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfTimes;
        private System.Windows.Forms.Label numberOfTimesLabel;
        private System.Windows.Forms.TextBox sayThisTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button speakToMe;
    }
}

