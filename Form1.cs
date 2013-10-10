using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CountdownTimer
{
    public partial class Timer : Form
    {
        Stopwatch timer = new Stopwatch();
        TimeSpan setTime = new TimeSpan();

        public Timer()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void radioButtonStopwatch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPresetOne_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresetTwo_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresetThree_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresetFour_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
        bool IsStopwatch 
        { 
            get 
            {
                return this.radioButtonStopwatch.Checked;
            } 
        }

        bool IsTimer
        {
            get
            {
                return this.radioButtonTimer.Checked;
            }
        }

        bool IsRunning
        {
            get
            {
                return timer.IsRunning;
            }
        }
    }
}
