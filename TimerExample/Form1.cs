using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        // will be incremented to using the countTimer
        int counter = 0;

        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // if the countTimer is not running start it and change the button text to "Pause"
            if (countTimer.Enabled == false)
            {
                countTimer.Enabled = true;
                startButton.Text = "Pause";

                myWatch.Reset();
                myWatch.Start();
            }
            // if the countTimer is running stop it and set button text to "Start"
            else
            {
                countTimer.Enabled = false;
                startButton.Text = "Start";

                myWatch.Stop();
                timeOutput.Text = myWatch.Elapsed + "";
                timeOutput.Text = myWatch.ElapsedMilliseconds + "";
                timeOutput.Text = myWatch.Elapsed.ToString(@"ss\:ff");
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            // add 1 to the counter and display the current value
            counter++;
            counterLabel.Text = $"{counter} ";


            // based on the value of the counter a different colour is shown

            if (counter == 1)
            {
                colourLabel.BackColor = Color.LightGreen;
            }
            else if (counter == 2)
            {
                colourLabel.BackColor = Color.DodgerBlue;
            }
            else
            {
                colourLabel.BackColor = Color.Yellow;
                counter = 0;
            }


            if (colourLabel.BackColor == Color.Yellow)
            {
                colourLabel.BackColor = Color.LightGreen;
            }
            else if (colourLabel.BackColor == Color.LightGreen)
            {
                colourLabel.BackColor = Color.DodgerBlue;
            }
            else
            {
                colourLabel.BackColor = Color.Yellow;
            }

            if (counter % 3 == 0)
            {
                if (colourLabel.BackColor == Color.Yellow)
                {
                    colourLabel.BackColor = Color.LightGreen;
                }
                else if (colourLabel.BackColor == Color.LightGreen)
                {
                    colourLabel.BackColor = Color.DodgerBlue;
                }
                else
                {
                    colourLabel.BackColor = Color.Yellow;
                }
            }

            if (counter % 3 == 1)
            {
                colourLabel.BackColor = Color.LightGreen;
            }
            else if (counter % 3 == 2)
            {
                colourLabel.BackColor = Color.DodgerBlue;
            }
            else
            {
                colourLabel.BackColor = Color.Yellow;
            }
        }
    }
}
