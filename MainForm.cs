using System;
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
        bool pomodoroMode = false;
        bool pomodoroBreak = false;
        Color oldBackColour;
        DateTime start = DateTime.Now;

        TimeSpan[] presets = new TimeSpan[4]
        {
            new TimeSpan(0,1,15),
            new TimeSpan(0,3,0),
            new TimeSpan(0,15,0),
            new TimeSpan(0,25,0),
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

            alwaysOnTopToolStripMenuItem.Checked = TopMost;

            oldBackColour = BackColor;
            statusStrip1.BackColor = BackColor;

            UpdateStatusText();
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
            buttonPresetOne.Enabled = IsStopped && !PomodoroMode;
            buttonPresetTwo.Enabled = IsStopped && !PomodoroMode;
            buttonPresetThree.Enabled = IsStopped && !PomodoroMode;
            buttonPresetFour.Enabled = IsStopped && !PomodoroMode;
            buttonSet.Enabled = IsStopped && !PomodoroMode;
            buttonReset.Enabled = IsStopped;
            radioButtonStopwatch.Enabled = false;// IsStopped;
            radioButtonTimer.Enabled = IsStopped;
        }

        void UpdateStatusText()
        {
            TimeSpan up = Uptime;
            if (PomodoroMode)
            {
                toolStripStatusLabel1.Text = string.Format("Completed: {0}    Aborted: {1}",
                    CompletedPomodoroCount, 
                    AbortedPomodoroCount);

            }
            else
            {
                toolStripStatusLabel1.Text = string.Format("Uptime: {0:D2}:{1:D2}",
                    up.Hours,
                    up.Minutes);
            }
        }

        void Stop()
        {
            if (IsRunning)
                ToggleTimerState(false);
        }

        private void ToggleTimerState(bool canceled)
        {
            if (IsRunning)
            {
                // pause/abort
                timer.Stop();
                buttonStartPause.Text = "&Start";
                updateTick.Enabled = false;

                if (PomodoroMode)
                {
                    // If on a break, cancel it.
                    if (PomodoroBreak)
                    {
                        PomodoroBreak = false;
                    }
                    // If running a pomodoro, cancel it but do not enter a break
                    else
                    {
                        SetTime = PomodoroTime;
                        if (canceled)
                            AbortedPomodoroCount++;
                    }
                }
            }
            else
            {
                // start
                updateTick.Enabled = true;
                timer.Start();
                if (PomodoroMode)
                    buttonStartPause.Text = "&Abort";
                else
                    buttonStartPause.Text = "&Pause";
            }

            UpdateStatusText();
            UpdateButtonStates();
        }

        private void UpdateTimeDisplay(TimeSpan time)
        {
            labelTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
            if (!PomodoroMode && IsRunning && time.TotalMinutes < 1)
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
                    ToggleTimerState(false);
                    UpdateTimeDisplay(TimeSpan.Zero);
                    soundPlayer.PlayLooping();
                    MessageBox.Show("Time's Up!!", "Ding!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    soundPlayer.Stop();

                    // If running in pomodoro mode, toggle between the pomodoro and the break
                    if (PomodoroMode)
                        if (!PomodoroBreak)
                            CompletedPomodoroCount++;
                        PomodoroBreak = !PomodoroBreak;

                }
            }

            UpdateStatusText();
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
            // if pomodoro mode, then pass true to the cancelled argument
            ToggleTimerState(PomodoroMode);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Reset();
            SetTime = SetTime; // set the current set time back into itself. Hacky way to refresh the display
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            SetTimeForm stf = new SetTimeForm(SetTime);
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

        TimeSpan PomodoroTime { get; set; } = new TimeSpan(0, 00, 5);
        TimeSpan PomodoroBreakTime { get; set; } = new TimeSpan(0, 0, 3);

        bool PomodoroMode
        {
            get
            {
                return pomodoroMode;
            }
            set
            {
                pomodoroMode = value;
                UpdateButtonStates();

                if (pomodoroMode)
                {
                    ForeColor = Color.Black;
                    PomodoroBreak = false;
                    Stop();
                }
                else
                {
                    BackColor = oldBackColour;
                }
            }
        }

        bool PomodoroBreak
        {
            get
            {
                return pomodoroBreak;
            }
            set
            {
                pomodoroBreak = value;
                if (pomodoroBreak)
                {
                    SetTime = PomodoroBreakTime;
                    BackColor = oldBackColour;
                    statusStrip1.BackColor = oldBackColour;
                }
                else
                {
                    SetTime = PomodoroTime;
                    BackColor = Color.Tomato;
                    statusStrip1.BackColor = Color.Tomato;
                }
            }
        }

        TimeSpan Uptime
        {
            get
            {
                return DateTime.Now - start;
            }
        }

        int CompletedPomodoroCount { get; set; } = 0;
        int AbortedPomodoroCount { get; set; } = 0;

        #endregion

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            alwaysOnTopToolStripMenuItem.Checked = TopMost;
        }

        private void pomodoroModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PomodoroMode = !PomodoroMode;
            pomodoroModeToolStripMenuItem.Checked = PomodoroMode;
        }
    }
}
