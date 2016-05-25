using System;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class SetTimeForm : Form
    {
        public SetTimeForm(TimeSpan initialTime = new TimeSpan())
        {
            InitializeComponent();
            numericUpDownHours.Value = initialTime.Hours;
            numericUpDownMinutes.Value = initialTime.Minutes;
            numericUpDownSeconds.Value = initialTime.Seconds;
        }

        public TimeSpan Time { get; private set; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Time = new TimeSpan((int)numericUpDownHours.Value, (int)numericUpDownMinutes.Value, (int)numericUpDownSeconds.Value);
        }
    }
}
