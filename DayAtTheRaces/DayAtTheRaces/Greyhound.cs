using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;            // Where my PictureBox starts
        public int RacetrackLength;             // How long the racetrack is
        public PictureBox MyPictureBox;         // My PictureBox object
        public Random Randomizer;               // An instance of Random

        public bool Run()
        {
            // Move forward either 1, 2, 3, or 4 spaces at random
            // Update the position of PictureBox on the form
            // Return True if I won the race
            MyPictureBox.Left += Randomizer.Next(1, 4);
            if (RacetrackLength - MyPictureBox.Left <= 0)
            {
                // You won!
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            // Reset my location to 0 and my PictureBox to starting position
            MyPictureBox.Left = StartingPosition;
        }

    }
}
