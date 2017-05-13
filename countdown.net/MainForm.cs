using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();
        TimeSpan setTime = new TimeSpan();
        TimeSpan originalSetTime = new TimeSpan();
        TimeSpan sessionDuration;
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
        }

        private void UpdateProperties()
        {
            labelTimer.ForeColor = UserProperties.FontColor;
            labelTimer.Font = UserProperties.TimerFont;
            Opacity = UserProperties.Opacity;
            SetFormColor(UserProperties.BackgroundColor);
            FormBorderStyle = UserProperties.Border;
            TopMost = UserProperties.TopMost;
            UpdatePresets();
        }

        void UpdateStatusText()
        {
            string status = string.Format(
                "Uptime: {0:D2}:{1:D2}\t",
                Uptime.Hours,
                Uptime.Minutes);

            if (SessionDuration.Ticks > 0)
                status += string.Format(
                    "    Total Session: {0}",
                    SessionDuration.ToString());

            uptimeLabel.Text = status;
        }

        private void Reset()
        {
            timer.Reset();
            SetTime = originalSetTime; // set the current set time back into itself. Hacky way to refresh the display
        }

        void Stop()
        {
            if (IsRunning)
                ToggleTimerState();
        }

        void Start()
        {
            if (!IsRunning)
                ToggleTimerState();
        }

        private void ToggleTimerState()
        {
            if (IsRunning)
            {
                // pause/abort
                timer.Stop();
                buttonStartPause.Text = "&Start";
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
            currentPracticeItem.BackColor = color;
        }

        private void AdjustTime(TimeSpan interval)
        {
            var newTime = SetTime.Add(interval);
            if (newTime >= TimeSpan.Zero)
                SetTime = newTime;
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
            
        private void buttonGenerateSession_Click(object sender, EventArgs e)
        {
            // configuration of the Python script
            string generateScript = UserProperties.SessionGenerationScript;
            string practiceItemsFile = UserProperties.PracticeItemsSpreadsheet;
            int sessionDuration = UserProperties.SessionDuration;
            string sessionFile = Path.ChangeExtension(Path.GetTempFileName(), "csv");

            // Build the command
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "python";
            startInfo.Arguments = String.Format(
                "{0} --input-file {1} --output-csv-file {2} --duration {3}",
                generateScript,
                practiceItemsFile,
                sessionFile,
                sessionDuration.ToString());
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0)
            {
                // Open the file as a stream and load the session
                LoadSession(File.OpenRead(sessionFile));
            }
        }

        private void buttonLoadSession_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Comma-separated Value Files|*.csv";
            dlg.Title = "Select a CSV timer session file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var stream = dlg.OpenFile();
                LoadSession(stream);
            }
        }

        private void LoadSession(Stream stream)
        {
            if (stream != null)
            {
                // Stop the timer
                Stop();

                var csv = new CsvReader(new StreamReader(stream));
                var sessionItems = csv.GetRecords<SessionItem>().ToList();
                practiceSessionGrid.DataSource = sessionItems;
                practiceSessionGrid.Rows[0].Selected = true;
                practiceSessionGrid.CurrentCell = practiceSessionGrid.SelectedRows[0].Cells[0];

                // adjust the column fill weights
                int[] weights = { 80, 40, 40, 150, 30 };
                for (int i = 0; i < weights.Length; i++)
                    practiceSessionGrid.Columns[i].FillWeight = weights[i];

                // calculate total session duration in minutes
                int totalMinutes = sessionItems.Sum(item => item.Duration);
                long bufferTicks = UserProperties.SequenceItemBuffer.Ticks * sessionItems.Count;
                TimeSpan buffer = new TimeSpan(bufferTicks);
                SessionDuration = new TimeSpan(0, totalMinutes, 0).Add(buffer);
            }
        }

        private void buttonDec10Secs_Click(object sender, EventArgs e)
        {
            AdjustTime(new TimeSpan(0, 0, -10));
        }

        private void buttonInc10Secs_Click(object sender, EventArgs e)
        {
            AdjustTime(new TimeSpan(0, 0, 10));
        }

        private void buttonDecMinute_Click(object sender, EventArgs e)
        {
            AdjustTime(new TimeSpan(0, -1, 0));
        }

        private void buttonIncMinute_Click(object sender, EventArgs e)
        {
            AdjustTime(new TimeSpan(0, 1, 0));
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int resetNextNTicks = 0;
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
                    Stop();
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

                    if (UserProperties.AutoRestart)
                        resetNextNTicks = 2;

                    // Update the timer sequence
                    int numRows = practiceSessionGrid.Rows.Count;
                    if (numRows > 0)
                    {
                        int nextRowIndex = practiceSessionGrid.SelectedRows[0].Index + 1;
                        if (nextRowIndex < numRows)
                        {
                            // select next row
                            practiceSessionGrid.Rows[nextRowIndex].Selected = true;
                            practiceSessionGrid.CurrentCell = practiceSessionGrid.SelectedRows[0].Cells[0];
                        }
                        else
                        {
                            // Out of rows. Stop timing
                            Stop();
                            resetNextNTicks = 0;  // hacky side-effect method to prevent restarting the timer if AutoLoop is true
                            practiceSessionGrid.Rows[0].Selected = true;
                            practiceSessionGrid.CurrentCell = practiceSessionGrid.SelectedRows[0].Cells[0];
                        }
                    }

                    Reset();
                }
            }
            else if (resetNextNTicks > 0)
            {
                resetNextNTicks--;
                if (resetNextNTicks == 0)
                    ToggleTimerState();
            }

            UpdateStatusText();
        }

        private void buttonPreset_Click(object sender, EventArgs e)
        {
            Debug.Assert(sender is Button);
            SetTime = (TimeSpan)((Button)sender).Tag;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            ToggleTimerState();
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
            if (stf.ShowDialog() == DialogResult.OK)
                SetTime = stf.Time;

            TopMost = topMostSetting;
        }

        private void practiceSessionGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (practiceSessionGrid.SelectedRows.Count > 0)
            {
                bool running = IsRunning;
                Stop();

                // update the info box
                currentPracticeItem.Text = Environment.NewLine;
                currentPracticeItem.Text += practiceSessionGrid.SelectedCells[0].Value.ToString() + Environment.NewLine + Environment.NewLine;
                currentPracticeItem.Text += "Tempo: " + practiceSessionGrid.SelectedCells[2].Value.ToString() + Environment.NewLine + Environment.NewLine;
                currentPracticeItem.Text += "Notes: " + practiceSessionGrid.SelectedCells[3].Value.ToString();

                // set timer to the selected row
                int minutes = (int)practiceSessionGrid.SelectedCells[4].Value;
                SetTime = new TimeSpan(0, minutes, 0) + userProperties.SequenceItemBuffer;

                if (running)
                    Start();
            }
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
                setTime = value;

                if (IsStopped)
                {
                    originalSetTime = value;
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

        TimeSpan SessionDuration
        {
            get
            {
                return sessionDuration;
            }
            set
            {
                sessionDuration = value;
                UpdateStatusText();
            }
        }

        #endregion

    }
}
