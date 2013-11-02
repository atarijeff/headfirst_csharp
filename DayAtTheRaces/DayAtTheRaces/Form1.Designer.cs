namespace DayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            this.trackPictureBox = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox1 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox2 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox3 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox4 = new System.Windows.Forms.PictureBox();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.raceButton = new System.Windows.Forms.Button();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox4)).BeginInit();
            this.ControlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // trackPictureBox
            // 
            this.trackPictureBox.Image = global::DayAtTheRaces.Properties.Resources.racetrack;
            this.trackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.trackPictureBox.Name = "trackPictureBox";
            this.trackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.trackPictureBox.TabIndex = 0;
            this.trackPictureBox.TabStop = false;
            // 
            // greyhoundPictureBox1
            // 
            this.greyhoundPictureBox1.Image = global::DayAtTheRaces.Properties.Resources.dog;
            this.greyhoundPictureBox1.Location = new System.Drawing.Point(12, 21);
            this.greyhoundPictureBox1.Name = "greyhoundPictureBox1";
            this.greyhoundPictureBox1.Size = new System.Drawing.Size(75, 20);
            this.greyhoundPictureBox1.TabIndex = 1;
            this.greyhoundPictureBox1.TabStop = false;
            // 
            // greyhoundPictureBox2
            // 
            this.greyhoundPictureBox2.Image = global::DayAtTheRaces.Properties.Resources.dog;
            this.greyhoundPictureBox2.Location = new System.Drawing.Point(12, 69);
            this.greyhoundPictureBox2.Name = "greyhoundPictureBox2";
            this.greyhoundPictureBox2.Size = new System.Drawing.Size(75, 20);
            this.greyhoundPictureBox2.TabIndex = 2;
            this.greyhoundPictureBox2.TabStop = false;
            // 
            // greyhoundPictureBox3
            // 
            this.greyhoundPictureBox3.Image = global::DayAtTheRaces.Properties.Resources.dog;
            this.greyhoundPictureBox3.Location = new System.Drawing.Point(12, 123);
            this.greyhoundPictureBox3.Name = "greyhoundPictureBox3";
            this.greyhoundPictureBox3.Size = new System.Drawing.Size(75, 20);
            this.greyhoundPictureBox3.TabIndex = 3;
            this.greyhoundPictureBox3.TabStop = false;
            // 
            // greyhoundPictureBox4
            // 
            this.greyhoundPictureBox4.Image = global::DayAtTheRaces.Properties.Resources.dog;
            this.greyhoundPictureBox4.Location = new System.Drawing.Point(12, 175);
            this.greyhoundPictureBox4.Name = "greyhoundPictureBox4";
            this.greyhoundPictureBox4.Size = new System.Drawing.Size(75, 20);
            this.greyhoundPictureBox4.TabIndex = 4;
            this.greyhoundPictureBox4.TabStop = false;
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.bobRadioButton);
            this.ControlsGroupBox.Controls.Add(this.raceButton);
            this.ControlsGroupBox.Controls.Add(this.joeRadioButton);
            this.ControlsGroupBox.Controls.Add(this.alBetLabel);
            this.ControlsGroupBox.Controls.Add(this.alRadioButton);
            this.ControlsGroupBox.Controls.Add(this.bobBetLabel);
            this.ControlsGroupBox.Controls.Add(this.joeBetLabel);
            this.ControlsGroupBox.Controls.Add(this.label3);
            this.ControlsGroupBox.Controls.Add(this.dogNumericUpDown);
            this.ControlsGroupBox.Controls.Add(this.label2);
            this.ControlsGroupBox.Controls.Add(this.betNumericUpDown);
            this.ControlsGroupBox.Controls.Add(this.betsButton);
            this.ControlsGroupBox.Controls.Add(this.nameLabel);
            this.ControlsGroupBox.Controls.Add(this.minimumBetLabel);
            this.ControlsGroupBox.Location = new System.Drawing.Point(13, 219);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(599, 153);
            this.ControlsGroupBox.TabIndex = 5;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Betting Parlor";
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 64);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(456, 31);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(118, 80);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 41);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(177, 87);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(242, 16);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 87);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(177, 64);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(242, 16);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(177, 41);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(242, 16);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bets";
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(267, 119);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.dogNumericUpDown.TabIndex = 8;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "bucks on dog number";
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(103, 119);
            this.betNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.betNumericUpDown.TabIndex = 6;
            this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(50, 118);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(47, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 382);
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.greyhoundPictureBox4);
            this.Controls.Add(this.greyhoundPictureBox3);
            this.Controls.Add(this.greyhoundPictureBox2);
            this.Controls.Add(this.greyhoundPictureBox1);
            this.Controls.Add(this.trackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox4)).EndInit();
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trackPictureBox;
        private System.Windows.Forms.PictureBox greyhoundPictureBox1;
        private System.Windows.Forms.PictureBox greyhoundPictureBox2;
        private System.Windows.Forms.PictureBox greyhoundPictureBox3;
        private System.Windows.Forms.PictureBox greyhoundPictureBox4;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Timer timer1;
    }
}

