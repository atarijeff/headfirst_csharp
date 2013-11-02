namespace MileageCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountOwedLabel = new System.Windows.Forms.Label();
            this.startingMileageNumeric = new System.Windows.Forms.NumericUpDown();
            this.endingMileageNumeric = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayMilesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startingMileageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed";
            // 
            // amountOwedLabel
            // 
            this.amountOwedLabel.AutoSize = true;
            this.amountOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwedLabel.Location = new System.Drawing.Point(126, 62);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(15, 20);
            this.amountOwedLabel.TabIndex = 3;
            this.amountOwedLabel.Text = "-";
            // 
            // startingMileageNumeric
            // 
            this.startingMileageNumeric.Location = new System.Drawing.Point(130, 13);
            this.startingMileageNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startingMileageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startingMileageNumeric.Name = "startingMileageNumeric";
            this.startingMileageNumeric.Size = new System.Drawing.Size(120, 20);
            this.startingMileageNumeric.TabIndex = 4;
            this.startingMileageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endingMileageNumeric
            // 
            this.endingMileageNumeric.Location = new System.Drawing.Point(130, 39);
            this.endingMileageNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endingMileageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endingMileageNumeric.Name = "endingMileageNumeric";
            this.endingMileageNumeric.Size = new System.Drawing.Size(120, 20);
            this.endingMileageNumeric.TabIndex = 5;
            this.endingMileageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(47, 92);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayMilesButton
            // 
            this.displayMilesButton.Location = new System.Drawing.Point(160, 92);
            this.displayMilesButton.Name = "displayMilesButton";
            this.displayMilesButton.Size = new System.Drawing.Size(90, 23);
            this.displayMilesButton.TabIndex = 7;
            this.displayMilesButton.Text = "Display Miles";
            this.displayMilesButton.UseVisualStyleBackColor = true;
            this.displayMilesButton.Click += new System.EventHandler(this.displayMilesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.displayMilesButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingMileageNumeric);
            this.Controls.Add(this.startingMileageNumeric);
            this.Controls.Add(this.amountOwedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startingMileageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amountOwedLabel;
        private System.Windows.Forms.NumericUpDown startingMileageNumeric;
        private System.Windows.Forms.NumericUpDown endingMileageNumeric;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayMilesButton;
    }
}

