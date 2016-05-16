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
        bool useModalDing = false;
        bool useAudioDing = true;
        Color oldBackColour;
        DateTime start = DateTime.Now;
        string originalResetButtonText;

        TimeSpan[] presets = new TimeSpan[4]
        {
            new TimeSpan(0,1,15),
            new TimeSpan(0,5,0),
            new TimeSpan(0,15,0),
            new TimeSpan(0,30,0),
        };

        public MainForm()
        {
            InitializeComponent();

            originalResetButtonText = buttonReset.Text;

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

            PomodoroMode = false;
            UseAudioDing = useAudioDing;
            UseModalDing = useModalDing;
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
            if (PomodoroMode)
            {
                buttonPresetOne.Visible = false;
                buttonPresetTwo.Visible = false;
                buttonPresetThree.Visible = false;
                buttonPresetFour.Visible = false;
                buttonSet.Visible = false;
                buttonReset.Visible = PomodoroBreak;
            }
            else
            {
                buttonPresetOne.Visible = true;
                buttonPresetTwo.Visible = true;
                buttonPresetThree.Visible = true;
                buttonPresetFour.Visible = true;
                buttonSet.Visible = true;
                buttonReset.Visible = true;
                buttonPresetOne.Enabled = IsStopped;
                buttonPresetTwo.Enabled = IsStopped;
                buttonPresetThree.Enabled = IsStopped;
                buttonPresetFour.Enabled = IsStopped;
                buttonSet.Enabled = IsStopped;
                buttonReset.Enabled = IsStopped;
            }

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

                // special-case handling for when this method is called from the abort button
                if (PomodoroMode && canceled)
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

                    if (UseAudioDing)
                        soundPlayer.Play();

                    if (UseModalDing)
                    {
                        // preserve, clear, and restore the TopMost setting, otherwise the modal dialog can be blocked by the top most main window.
                        bool currentTopMost = TopMost;
                        TopMost = false;
                        MessageBox.Show(TimesUpMessage, "Ding!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TopMost = currentTopMost;
                    }

                    // If running in pomodoro mode, toggle between the pomodoro and the break
                    if (PomodoroMode)
                    {
                        if (!PomodoroBreak)
                            CompletedPomodoroCount++;

                        PomodoroBreak = !PomodoroBreak;
                    }
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

            // skip the break and change state back to the next pomodoro
            if (PomodoroMode && PomodoroBreak)
                PomodoroBreak = !PomodoroBreak;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            SetTimeForm stf = new SetTimeForm(SetTime);
            // fix bug where the set window can be inaccessible if the main window is set to top-most
            bool topMostSetting = TopMost;
            TopMost = false;
            if (stf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetTime = stf.Time;
            }
            TopMost = topMostSetting;
        }
        #endregion

        #region Properties
        string TimesUpMessage
        {
            get
            {
                if (!PomodoroMode)
                {
                    return "Time's Up!!";
                }
                else
                {
                    if (PomodoroBreak)
                        return "Break's Over";
                    else
                        return "Time for a break!";
                }
            }
        }

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

#if (DEBUG)
        TimeSpan PomodoroTime { get; set; } = new TimeSpan(0, 0, 4);
        TimeSpan PomodoroBreakTime { get; set; } = new TimeSpan(0, 0, 2);
#else
        TimeSpan PomodoroTime { get; set; } = new TimeSpan(0, 25, 0);
        TimeSpan PomodoroBreakTime { get; set; } = new TimeSpan(0, 5, 0);
#endif

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
                pomodoroModeToolStripMenuItem.Checked = value;

                if (pomodoroMode)
                {
                    ForeColor = Color.Black;
                    PomodoroBreak = false;
                    Stop();
                }
                else
                {
                    BackColor = oldBackColour;
                    statusStrip1.BackColor = oldBackColour;
                }

                UpdateStatusText();
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
                    originalResetButtonText = buttonReset.Text;
                    buttonReset.Text = "&Skip";
                }
                else
                {
                    SetTime = PomodoroTime;
                    BackColor = Color.Tomato;
                    statusStrip1.BackColor = Color.Tomato;
                    buttonReset.Text = originalResetButtonText;
                }

                UpdateButtonStates();
            }
        }

        bool UseModalDing
        {
            get
            {
                return useModalDing;
            }
            set
            {
                useModalDing = value;
                popupDingToolStripMenuItem.Checked = value;
            }
        }

        bool UseAudioDing
        {
            get
            {
                return useAudioDing;
            }
            set
            {
                useAudioDing = value;
                audioDingToolStripMenuItem.Checked = value;
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
        }

        private void popupDingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseModalDing = !UseModalDing;
        }

        private void audioDingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseAudioDing = !UseAudioDing;
        }
    }
}
