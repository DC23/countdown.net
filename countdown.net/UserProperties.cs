using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CountdownTimer
{
    class UserProperties : INotifyPropertyChanged
    {
        [CategoryAttribute("Appearance")]
        public Color TimerColor { get; set; }

        [CategoryAttribute("Appearance")]
        public Color NormalFontColor { get; set; }

        [CategoryAttribute("Appearance")]
        public Color NearlyThereFontColor { get; set; }

        [CategoryAttribute("Appearance")]
        public Color PomodoroColor { get; set; }

        [CategoryAttribute("Appearance")]
        public Color PomodoroBreakColor { get; set; }

        [CategoryAttribute("Appearance")]
        public FormBorderStyle Border { get; set; }

        [CategoryAttribute("Appearance")]
        public double Opacity
        {
            get { return opacity; }
            set { SetProperty(ref opacity, value); }
        }
        double opacity = 1;

        [CategoryAttribute("Appearance")]
        public Font TimerFont { get; set; }

        [CategoryAttribute("Behaviour")]
        public bool PomodoroMode
        {
            get { return pomodoroMode; }
            set { SetProperty(ref pomodoroMode, value); }
        }
        private bool pomodoroMode = false;

        [CategoryAttribute("Behaviour")]
        public bool PopupDing { get; set; }

        [CategoryAttribute("Behaviour")]
        public bool AudioDing { get; set; }

        [CategoryAttribute("Behaviour")]
        public bool AlwaysOnTop { get; set; }

        List<TimeSpan> presets = new List<TimeSpan>
        {
            new TimeSpan(00,01,05),
            new TimeSpan(00,02,00),
            new TimeSpan(00,05,00),
            new TimeSpan(00,10,00),
            new TimeSpan(00,15,00),
            new TimeSpan(00,20,00),
            new TimeSpan(00,25,00),
            new TimeSpan(00,30,00),
        };

        public List<TimeSpan> Presets
        {
            get
            {
                return presets;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string name = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                var handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
        }

    }
}
