using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTheKeys
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats;
        bool
        
        public Form1()
        {
            InitializeComponent();
            //startGame();
            button1.Visible = false;
        }

        private void startGame()
        {
            button1.Visible = false;
            stats = new Stats();
            updateStatusStrip();
            this.KeyPreview = true;
            listBox1.Items.Clear();
            timer1.Interval = 800;
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Add a random key to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
                this.KeyPreview = false;
                button1.Visible = true;
                stats = null;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed a key that's in the listbox, remove it
            // and then make the game a little faster
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                if (timer1.Interval > 250)
                {
                    timer1.Interval -= 7;
                }
                if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }
                difficultyProgressBar.Value = 800 - timer1.Interval;

                // The user pressed a correct key, so update the Stats object
                // by calling its Update() method with the argument true
                stats.Update(true);
            }
            else
            {
                // The user pressed an incorrect key, so update the Stats object
                // by calling its Update method the the arguement false
                stats.Update(false);
            }
            updateStatusStrip();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void updateStatusStrip()
        {
            // Update the labels on the StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
