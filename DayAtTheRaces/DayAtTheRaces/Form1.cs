using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Guy[] guyArray;             // Array to hold the Guys
        Greyhound[] greyhoundArray; // Array to hold the Greyhounds
        Random random;              // Used to calculate greyhound moves

        int guyIndex;

        public Form1()
        {
            InitializeComponent();
            initializeGuy(); 
            initializeBoard();
            initializeGreyhound();            
        }

        private void initializeBoard()
        {
            timer1.Enabled = false;
            random = new Random();
            minimumBetLabel.Text = "Minimum bet: " + betNumericUpDown.Minimum;
            ControlsGroupBox.Enabled = true;

            // Set 1st player to Joe
            this.joeRadioButton.Checked = true;
        }
        
        private void initializeGuy()
        {
            guyArray = new Guy[3];

            guyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            guyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            guyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            foreach (Guy newGuy in guyArray)
            {
                newGuy.ClearBet();
                newGuy.UpdateLabels();
            }
        }

        private void initializeGreyhound()
        {
            greyhoundArray = new Greyhound[4];

            greyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox1,
                StartingPosition = trackPictureBox.Left,
                RacetrackLength = trackPictureBox.Width + trackPictureBox.Left - greyhoundPictureBox1.Width,
                Randomizer = random
            };

            greyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox2,
                StartingPosition = trackPictureBox.Left,
                RacetrackLength = trackPictureBox.Width + trackPictureBox.Left - greyhoundPictureBox2.Width,
                Randomizer = random
            };

            greyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox3,
                StartingPosition = trackPictureBox.Left,
                RacetrackLength = trackPictureBox.Width + trackPictureBox.Left - greyhoundPictureBox3.Width,
                Randomizer = random
            };

            greyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox4,
                StartingPosition = trackPictureBox.Left,
                RacetrackLength = trackPictureBox.Width + trackPictureBox.Left - greyhoundPictureBox4.Width,
                Randomizer = random
            };
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateNameLabel(guyIndex = 0);
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateNameLabel(guyIndex = 1);
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateNameLabel(guyIndex = 2);
        }

        private void updateNameLabel(int index)
        {
            nameLabel.Text = guyArray[index].Name;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            // Create a new bet
            guyArray[guyIndex].MyBet = new Bet()
            {
                Amount = (int)betNumericUpDown.Value,
                Dog = (int)dogNumericUpDown.Value,
                Bettor = guyArray[guyIndex]
            };
            
            // Place bet and check if they have enough cash to bet
            if (!guyArray[guyIndex].PlaceBet())
            {
                MessageBox.Show("Sorry " + guyArray[guyIndex].Name + ", you don't have enough $$");
                guyArray[guyIndex].ClearBet();
            }

            guyArray[guyIndex].UpdateLabels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int greyhoundNumber = 0;  // Track which Greyhound we are using
            foreach (Greyhound hound in greyhoundArray)
            {
                if (hound.Run())
                {
                    // We have a winner!
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show("Greyhound #" + (greyhoundNumber + 1) + " has won!");
                    
                    // Pay up fellas
                    foreach (Guy theGuy in guyArray)
                    {
                        theGuy.Collect(greyhoundNumber);
                        theGuy.ClearBet();
                        theGuy.UpdateLabels();
                    }

                    ControlsGroupBox.Enabled = true;  // Allow betting again
                    break;
                }
                greyhoundNumber++;
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            // Send the greyhounds back to their starting positions
            foreach (Greyhound hound in greyhoundArray)
            {
                hound.TakeStartingPosition();
            }

            // Check if someone has made a bet. I mean, really, what would the point be?
            if (guyArray[0].MyBet.Amount + guyArray[1].MyBet.Amount + guyArray[2].MyBet.Amount == 0)
            {
                MessageBox.Show("No one has bet yet");
            }
            else
            {
                ControlsGroupBox.Enabled = false;   // Make sure no one can change their bet after the race starts
                timer1.Enabled = true;
                timer1.Start();                     // Go!
            }
        }
    }
}
