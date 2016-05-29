﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CountdownTimer
{
    [Serializable]
    public sealed class UserProperties : ICloneable
    {
        public UserProperties()
        {
        }

        private UserProperties(UserProperties that)
        {
            TimerColor = that.TimerColor;
            FontColor = that.FontColor;
            PomodoroColor = that.PomodoroColor;
            PomodoroBreakColor = that.PomodoroBreakColor;
            Border = that.Border;
            Opacity = that.Opacity;
            TimerFont = (Font)that.TimerFont.Clone();
            PomodoroMode = that.PomodoroMode;
            PopupDing = that.PopupDing;
            AudioDing = that.AudioDing;
            TopMost = that.TopMost;
            Presets = (TimeSpan[])that.Presets.Clone();
        }

        [CategoryAttribute("Appearance")]
        public Color TimerColor { get; set; } = Color.SteelBlue;

        [CategoryAttribute("Appearance")]
        public Color FontColor { get; set; } = Color.Black;

        [CategoryAttribute("Appearance")]
        public Color PomodoroColor { get; set; } = Color.Tomato;

        [CategoryAttribute("Appearance")]
        public Color PomodoroBreakColor { get; set; } = Color.SteelBlue;

        [CategoryAttribute("Appearance")]
        public FormBorderStyle Border { get; set; } = FormBorderStyle.None;

        [CategoryAttribute("Appearance")]
        public double Opacity { get; set; } = 1.0;

        [CategoryAttribute("Appearance")]
        public Font TimerFont { get; set; } = new Font("Monospace", 48);

        [CategoryAttribute("Behaviour")]
        public bool PomodoroMode { get; set; } = false;

        [CategoryAttribute("Behaviour")]
        public bool PopupDing { get; set; } = false;

        [CategoryAttribute("Behaviour")]
        public bool AudioDing { get; set; } = true;

        [CategoryAttribute("Behaviour")]
        public bool TopMost { get; set; } = false;

        public TimeSpan[] Presets =
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

        // Yes, I could have used code generation from a TT file here, but I am tired and there are only 8 presets...
        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset0
        {
            get { return Presets[0]; }
            set { Presets[0] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset1
        {
            get { return Presets[1]; }
            set { Presets[1] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset2
        {
            get { return Presets[2]; }
            set { Presets[2] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset3
        {
            get { return Presets[3]; }
            set { Presets[3] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset4
        {
            get { return Presets[4]; }
            set { Presets[4] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset5
        {
            get { return Presets[5]; }
            set { Presets[5] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset6
        {
            get { return Presets[6]; }
            set { Presets[6] = value; }
        }

        [CategoryAttribute("Preset Times")]
        public TimeSpan Preset7
        {
            get { return Presets[7]; }
            set { Presets[7] = value; }
        }

        public void Save(string filename = "countdown.net.userproperties.bin")
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
        }

        public static UserProperties Load(string filename, UserProperties defaults = null)
        {
            return null;
        }

        public object Clone()
        {
            return new UserProperties(this);
        }
    }
}
