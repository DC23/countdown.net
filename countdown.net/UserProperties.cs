using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CountdownTimer
{
    class UserProperties
    {
        public Color TimerColor { get; set; }
        public Color PomodoroColor { get; set; }
        public Color PomodoroBreakColor { get; set; }
        public bool ShowBorder { get; set; }
        public int Opacity { get; set; }
        Font TimerFont { get; set; }

        public bool PomodoroMode { get; set; }
        public bool PopupDing { get; set; }
        public bool AudioDing { get; set; }

        public TimeSpan Preset1 { get; set; } = new TimeSpan(0,1,05);
        public TimeSpan Preset2 { get; set; } = new TimeSpan(0,2,0);
        public TimeSpan Preset3 { get; set; } = new TimeSpan(0,5,0);
        public TimeSpan Preset4 { get; set; } = new TimeSpan(0,10,0);
        public TimeSpan Preset5 { get; set; } = new TimeSpan(0,15,0);
        public TimeSpan Preset6 { get; set; } = new TimeSpan(0,20,0);
        public TimeSpan Preset7 { get; set; } = new TimeSpan(0,25,0);
        public TimeSpan Preset8 { get; set; } = new TimeSpan(0,30,0);
    }
}
