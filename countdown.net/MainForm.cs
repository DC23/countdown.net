using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();
        TimeSpan setTime = new TimeSpan();
        Timer updateTick = new Timer();
        SoundPlayer soundPlayer = new SoundPlayer();
        DateTime start = DateTime.Now;
        List<Button> presetButtons = new List<Button>();
        UserProperties userProperties = null;

        public MainForm()
        {
            InitializeComponent();

            // preset buttons
            presetButtons.Add(buttonPreset1);
            presetButtons.Add(buttonPreset2);
            presetButtons.Add(buttonPreset3);
            presetButtons.Add(buttonPreset4);
            presetButtons.Add(buttonPreset5);
            presetButtons.Add(buttonPreset6);
            presetButtons.Add(buttonPreset7);
            presetButtons.Add(buttonPreset8);

            UserProperties = UserProperties.Load();

            // other setup
            updateTick.Tick += updateTick_Tick;
            updateTick.Interval = 200;

            soundPlayer.SoundLocation = "TimesUp.wav";
            soundPlayer.Load();

            UpdateStatusText();
        }

        private void UpdatePresets()
        {
            for (int i = 0; i < UserProperties.Presets.Length; i++)
            {
                if (i < presetButtons.Count)
                    SetPresetButtonTime(presetButtons[i], UserProperties.Presets[i]);
            }

            UpdateButtonStates();
        }

        void SetPresetButtonTime(Button button, TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 0)
                button.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            else
                button.Text = String.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);

            button.Tag = timeSpan;
        }

        void UpdateButtonStates()
        {
            foreach (var preset in presetButtons)
            {
                preset.Enabled = IsStopped;
            }

            buttonSet.Enabled = IsStopped;
            buttonReset.Enabled = IsStopped;
            buttonDownMinute.Enabled = IsStopped;
            buttonUpMinute.Enabled = IsStopped;
        }

        private void UpdateProperties()
        {
            labelTimer.ForeColor = UserProperties.FontColor;
            labelTimer.Font = UserProperties.TimerFont;
            Opacity = UserProperties.Opacity;
            SetFormColor(UserProperties.TimerColor);
            FormBorderStyle = UserProperties.Border;
            TopMost = UserProperties.TopMost;
            UpdatePresets();
        }

        void UpdateStatusText()
        {
            TimeSpan up = Uptime;
            uptimeLabel.Text = string.Format("Uptime: {0:D2}:{1:D2}",
                up.Hours,
                up.Minutes);
        }

        private void Reset()
        {
            timer.Reset();
            SetTime = SetTime; // set the current set time back into itself. Hacky way to refresh the display
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
            }
            else
            {
                // start
                updateTick.Enabled = true;
                timer.Start();
                buttonStartPause.Text = "&Pause";
            }

            UpdateStatusText();
            UpdateButtonStates();
        }

        private void UpdateTimeDisplay(TimeSpan time)
        {
            labelTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
        }

        private void SetFormColor(Color color)
        {
            BackColor = color;
        }

        #region DragMove implementation for borderless mode
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static bool IsLinux
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return (p == 4) || (p == 6) || (p == 128);
            }
        }

        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!IsLinux && e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Event Handlers
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserProperties.Save();
        }

        private void buttonDownMinute_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpMinute_Click(object sender, EventArgs e)
        {

        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var properties = new UserPropertiesForm();
            var tempProperties = (UserProperties)UserProperties.Clone();
            properties.SelectedObject = tempProperties;
            bool currentTopMost = TopMost;
            TopMost = false;
            var result = properties.ShowDialog();
            TopMost = currentTopMost;

            if (result == DialogResult.OK)
                UserProperties = (UserProperties)properties.SelectedObject;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void updateTick_Tick(object sender, EventArgs e)
        {
            if (IsRunning)
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

                    if (UserProperties.AudioDing)
                        soundPlayer.Play();

                    if (UserProperties.PopupDing)
                    {
                        // preserve, clear, and restore the TopMost setting, otherwise the modal dialog can be blocked by the top most main window.
                        bool currentTopMost = TopMost;
                        TopMost = false;
                        new TimesUp().ShowDialog();
                        TopMost = currentTopMost;
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

        private void buttonPreset_Click(object sender, EventArgs e)
        {
            Debug.Assert(sender is Button);
            SetTime = (TimeSpan)((Button)sender).Tag;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            ToggleTimerState(false);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            SetTimeForm stf = new SetTimeForm(SetTime);
            // fix bug where the set window can be inaccessible if the main window is set to top-most
            bool topMostSetting = TopMost;
            TopMost = false;
            if (stf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SetTime = stf.Time;

            TopMost = topMostSetting;
        }
        #endregion

        #region Properties

        string TimesUpMessage
        {
            get
            {
                return "Time's Up!!";
            }
        }

        bool IsRunning
        {
            get { return timer.IsRunning; }
        }

        bool IsStopped
        {
            get { return !IsRunning; }
        }

        TimeSpan SetTime
        {
            get
            {
                return setTime;
            }

            set
            {
                // Only allow sets when stopped
                if (IsStopped)
                {
                    setTime = value;
                    timer.Reset();
                    UpdateTimeDisplay(setTime);
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

        UserProperties UserProperties
        {
            get
            {
                return userProperties;
            }
            set
            {
                userProperties = value;
                UpdateProperties();
            }
        }

        #endregion
    }
}
