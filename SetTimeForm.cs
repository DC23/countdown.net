using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class SetTimeForm : Form
    {
        public SetTimeForm()
        {
            InitializeComponent();
        }

        public TimeSpan Time { get; private set; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Time = new TimeSpan((int)numericUpDownHours.Value, (int)numericUpDownMinutes.Value, (int)numericUpDownSeconds.Value);
        }
    }
}
