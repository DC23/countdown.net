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
        public Color TimerColor
        {
            get { return timerColor; }
            set { SetProperty(ref timerColor, value); }
        }
        Color timerColor = Color.SteelBlue;

        [CategoryAttribute("Appearance")]
        public Color FontColor
        {
            get { return fontColor; }
            set { SetProperty(ref fontColor, value); }
        }
        Color fontColor = Color.Black;

        [CategoryAttribute("Appearance")]
        public Color PomodoroColor
        {
            get { return pomodoroColor; }
            set { SetProperty(ref pomodoroColor, value); }
        }
        Color pomodoroColor = Color.Tomato;

        [CategoryAttribute("Appearance")]
        public Color PomodoroBreakColor
        {
            get { return pomodoroBreakColor; }
            set { SetProperty(ref pomodoroBreakColor, value); }
        }
        Color pomodoroBreakColor = Color.LightSteelBlue;

        [CategoryAttribute("Appearance")]
        public FormBorderStyle Border
        {
            get { return border; }
            set { SetProperty(ref border, value); }
        }
        FormBorderStyle border = FormBorderStyle.None;

        [CategoryAttribute("Appearance")]
        public double Opacity
        {
            get { return opacity; }
            set { SetProperty(ref opacity, value); }
        }
        double opacity = 1;

        [CategoryAttribute("Appearance")]
        public Font TimerFont
        {
            get { return timerFont; }
            set { SetProperty(ref timerFont, value); }
        }
        Font timerFont = new Font("Monospace", 48);

        [CategoryAttribute("Behaviour")]
        public bool PomodoroMode
        {
            get { return pomodoroMode; }
            set { SetProperty(ref pomodoroMode, value); }
        }
        private bool pomodoroMode = false;

        [CategoryAttribute("Behaviour")]
        public bool PopupDing
        {
            get { return popupDing; }
            set { SetProperty(ref popupDing, value); }
        }
        bool popupDing = false;

        [CategoryAttribute("Behaviour")]
        public bool AudioDing
        {
            get { return audioDing; }
            set { SetProperty(ref audioDing, value); }
        }
        bool audioDing = false;

        [CategoryAttribute("Behaviour")]
        public bool TopMost
        {
            get { return topmost; }
            set { SetProperty(ref topmost, value); }
        }
        bool topmost = false;

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
