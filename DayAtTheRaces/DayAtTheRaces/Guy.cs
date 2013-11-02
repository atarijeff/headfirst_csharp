using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet;   // An instance of Bet that has his bet
        public int Cash;    // How much cash he has

        // The last 2 fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;   // My RadioButton
        public Label MyLabel;               // My Label

        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label on
            // my RadioButton to show my cash ("Joe has 43 bucks")
            this.MyLabel.Text = MyBet.GetDescription();
            this.MyRadioButton.Text = this.Name + " has " + this.Cash + " bucks";
        }

        public void ClearBet()
        {
            // Reset my bet so it is 0
            this.MyBet = new Bet()
            {
                Amount = 0,
                Bettor = this
            };
        }

        public bool PlaceBet()
        {
            // Place a new bet and store it in my bet field
            // Return True if the guy had enough money to bet
            if (Cash - MyBet.Amount >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
