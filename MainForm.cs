﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace CountdownTimer
{
    public partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();
        TimeSpan setTime = new TimeSpan();
        Timer updateTick = new Timer();
        SoundPlayer soundPlayer = new SoundPlayer();
        Color colourNormal = Color.Black;
        Color colourNearlyThere = Color.Firebrick;
        
        TimeSpan[] presets = new TimeSpan[4] 
        { 
            new TimeSpan(0,1,15),
            new TimeSpan(0,3,0),
            new TimeSpan(0,5,0),
            new TimeSpan(0,10,0),
        };

        public MainForm()
        {
            InitializeComponent();

            SetButtonText(buttonPresetOne, presets[0]);
            SetButtonText(buttonPresetTwo, presets[1]);
            SetButtonText(buttonPresetThree, presets[2]);
            SetButtonText(buttonPresetFour, presets[3]);

            UpdateButtonStates();

            updateTick.Tick += updateTick_Tick;
            updateTick.Interval = 200;

            soundPlayer.SoundLocation = "TimesUp.wav";
            soundPlayer.Load();
        }
        
        void SetButtonText(Button button, TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 0)
                button.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            else
                button.Text = String.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }

        void UpdateButtonStates()
        {
            buttonPresetOne.Enabled = IsStopped;
            buttonPresetTwo.Enabled = IsStopped;
            buttonPresetThree.Enabled = IsStopped;
            buttonPresetFour.Enabled = IsStopped;
            buttonSet.Enabled = IsStopped;
            buttonReset.Enabled = IsStopped;
            radioButtonStopwatch.Enabled = false;// IsStopped;
            radioButtonTimer.Enabled = IsStopped;
        }

        private void ToggleTimerState()
        {
            if (IsRunning)
            {
                // pause
                timer.Stop();
                buttonStartPause.Text = "&Start";
                updateTick.Enabled = false;
            }
            else
            {
                // start
                updateTick.Enabled = true;
                timer.Start();
                buttonStartPause.Text = "&Pause";
            }

            UpdateButtonStates();
        }

        private void UpdateTimeDisplay(TimeSpan time)
        {
            labelTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
            if (time.TotalMinutes < 1)
                labelTimer.ForeColor = colourNearlyThere;
            else
                labelTimer.ForeColor = colourNormal;
        }

        #region Event Handlers
        void updateTick_Tick(object sender, EventArgs e)
        {
            if (IsRunning && IsTimer)
            {
                TimeSpan remaining = setTime - timer.Elapsed;
                if (remaining.TotalMilliseconds > 0)
                {
                    // not done yet
                    UpdateTimeDisplay(remaining);
                }
                else
                {
                    // time's up
                    ToggleTimerState();
                    UpdateTimeDisplay(TimeSpan.Zero);
                    soundPlayer.PlayLooping();
                    MessageBox.Show("Time's Up!!", "Ding!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    soundPlayer.Stop();
                }
            }
        }

        private void radioButtonStopwatch_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonTimer_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttonPresetOne_Click(object sender, EventArgs e)
        {
            SetTime = presets[0];
        }

        private void buttonPresetTwo_Click(object sender, EventArgs e)
        {
            SetTime = presets[1];
        }

        private void buttonPresetThree_Click(object sender, EventArgs e)
        {
            SetTime = presets[2];
        }

        private void buttonPresetFour_Click(object sender, EventArgs e)
        {
            SetTime = presets[3];
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            ToggleTimerState();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Reset();
            SetTime = SetTime; // set the current set time back into itself. Hacky way to refresh the display
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            SetTimeForm stf = new SetTimeForm();
            if (stf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetTime = stf.Time;
            }
        }
        #endregion

        #region Properties
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

        bool IsStopped
        {
            get
            {
                return !IsRunning;
            }
        }

        TimeSpan SetTime
        {
            get
            {
                return setTime;
            }

            set
            {
                // Only allow sets when stopped in timer mode
                if (IsStopped && IsTimer)
                {
                    setTime = value;
                    timer.Reset();
                    UpdateTimeDisplay(setTime);
                }
            }
        }

        
        #endregion
    }
}