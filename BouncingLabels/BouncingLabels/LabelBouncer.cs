using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingLabels
{
    class LabelBouncer
    {
        public Label MyLabel;
        public bool GoingForward = true;

        public void Move()
        {
            int labelLeft;
            if (MyLabel != null)
            {
                labelLeft = MyLabel.Left;
                if (GoingForward)
                {
                    labelLeft += 5;
                    if (labelLeft >= MyLabel.Parent.Width - MyLabel.Width - 10)
                    {
                        MyLabel.Left = MyLabel.Parent.Width - MyLabel.Width - 10;
                        GoingForward = false;
                    }
                    else
                    {
                        MyLabel.Left = labelLeft;
                    }
                }
                else
                {
                    labelLeft -= 5;
                    if (labelLeft <= 0)
                    {
                        MyLabel.Left = 0;
                        GoingForward = true;
                    }
                    else
                    {
                        MyLabel.Left = labelLeft;
                    }
                }
            }
        }
    }
}
