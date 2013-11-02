using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speakToMe_Click(object sender, EventArgs e)
        {
            int length = Talker.moreTalkers.Blah(sayThisTextBox.Text,(int)numberOfTimes.Value);
            MessageBox.Show("String length is " + length);
        }
    }
}
