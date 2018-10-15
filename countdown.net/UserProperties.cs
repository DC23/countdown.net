using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CountdownTimer
{
    [Serializable]
    public sealed class UserProperties : ICloneable
    {
        public class VersionMismatchException : Exception
        {
            public VersionMismatchException()
            {
            }

            public VersionMismatchException(string message)
                : base(message)
            {
            }

            public VersionMismatchException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }

        public enum InitialSessionType
        {
            None,
            Practice,
            Pomodoro,
        }

        private const int version = 4;

        [Category("Properties Version")]
        public int Version { get; private set; }

        public UserProperties()
        {
            Version = version;
        }

        private UserProperties(UserProperties that)
        {
            Size = that.Size;
            Version = that.Version;
            BackgroundColor = that.BackgroundColor;
            FontColor = that.FontColor;
            Border = that.Border;
            Opacity = that.Opacity;
            TimerFont = (Font)that.TimerFont.Clone();
            PopupDing = that.PopupDing;
            AudioDing = that.AudioDing;
            TopMost = that.TopMost;
            AutoRestart = that.AutoRestart;
            Presets = (TimeSpan[])that.Presets.Clone();
            SequenceItemBuffer = that.SequenceItemBuffer;
            SessionGenerationScript = that.SessionGenerationScript;
            SessionDuration = that.SessionDuration;
            PracticeItemsSpreadsheet = that.PracticeItemsSpreadsheet;
            IgnoreEssentialFlag = that.IgnoreEssentialFlag;
            IgnoreCategoryMinItemLimit = that.IgnoreCategoryMinItemLimit;
            IgnoreCategoryMaxItemLimit = that.IgnoreCategoryMaxItemLimit;
            ShortSessionThreshold = that.ShortSessionThreshold;
            InitialSession = that.InitialSession;
            TimeScale = that.TimeScale;
            UseOneWorksheetPerCategory = that.UseOneWorksheetPerCategory;
            Python = that.Python;
        }

        public void Save(string filename = "countdown.net.userproperties.bin")
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }
        }

        public static UserProperties Load(string filename = "countdown.net.userproperties.bin", UserProperties defaults = null)
        {
            UserProperties userProperties = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    UserProperties temp = (UserProperties)formatter.Deserialize(stream);
                    if (temp.Version != version)
                        throw new VersionMismatchException();

                    userProperties = temp;
                }
            }
            catch (Exception)
            {
                // If failure, return defaults
                userProperties = defaults == null ? new UserProperties() : defaults;
            }

            return userProperties;
        }

        public object Clone()
        {
            return new UserProperties(this);
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Size), "1085 x 617")]
        [Description("Size")]
        public Size Size { get; set; } = new Size(1085, 617);

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "LightSteelBlue")]
        [Description("Background colour")]
        public Color BackgroundColor { get; set; } = Color.LightSteelBlue;

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("Timer font colour")]
        public Color FontColor { get; set; } = Color.Black;

        [Category("Appearance")]
        [DefaultValue(typeof(FormBorderStyle), "Sizable")]
        [Description("Application border style")]
        public FormBorderStyle Border { get; set; } = FormBorderStyle.Sizable;

        [Category("Appearance")]
        [DefaultValue(1.0)]
        [Description("Application opacity")]
        public double Opacity { get; set; } = 1.0;

        [Category("Appearance")]
        [DefaultValue(typeof(Font), "Monospace, 48pt")]
        [Description("Main timer font")]
        public Font TimerFont { get; set; } = new Font("Monospace", 48);

        [Category("Behaviour")]
        [DefaultValue(false)]
        [Description("Determines whether a message box is created when the timer is finished")]
        public bool PopupDing { get; set; } = false;

        [Category("Behaviour")]
        [DefaultValue(true)]
        [Description("Determines whether an bell is sounded when the timer is finished")]
        public bool AudioDing { get; set; } = true;

        [Category("Behaviour")]
        [DefaultValue(false)]
        [Description("Controls whether the application is always on top")]
        public bool TopMost { get; set; } = false;

        [Category("Behaviour")]
        [DefaultValue(true)]
        [Description("Should the next timer start automatically?")]
        public bool AutoRestart { get; set; } = true;

        [Category("Session Generation")]
        [DefaultValue(typeof(TimeSpan), "00:00:00")]
        [Description("Time buffer in hours:minutes:seconds that is automatically added to the timer for each sequence item")]
        public TimeSpan SequenceItemBuffer { get; set; } = TimeSpan.Zero;

        [Category("Session Generation")]
        [Editor(typeof(System.Windows.Forms.Design.FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [DefaultValue("")]
        [Description("Full path to the practice-randomiser.py script, or to the practice-randomiser.exe")]
        public string SessionGenerationScript { get; set; } = "";

        [Category("Session Generation")]
        [Editor(typeof(System.Windows.Forms.Design.FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [DefaultValue("")]
        [Description("Your practice items spreadsheet")]
        public string PracticeItemsSpreadsheet { get; set; } = "";

        [Category("Session Generation")]
        [DefaultValue(30)]
        [Description("Practice session total duration in minutes")]
        public int SessionDuration { get; set; } = 30;

        [Category("Session Generation")]
        [DefaultValue(15)]
        [Description("Threshold in minutes for determining a short session. Short sessions ignore the essential flag and min item limits.")]
        public int ShortSessionThreshold { get; set; } = 15;

        [Category("Session Generation")]
        [DefaultValue(1.0)]
        [Description("Item min and max time scale.")]
        public float TimeScale { get; set; } = 1.0f;

        [Category("Session Generation")]
        [DefaultValue(false)]
        [Description("Should the essential flag be ignored?")]
        public bool IgnoreEssentialFlag { get; set; } = false;

        [Category("Session Generation")]
        [DefaultValue(false)]
        [Description("Should the per-category max item count limit setting be ignored?")]
        public bool IgnoreCategoryMaxItemLimit { get; set; } = false;

        [Category("Session Generation")]
        [DefaultValue(false)]
        [Description("Should the per-category min item count limit setting be ignored?")]
        public bool IgnoreCategoryMinItemLimit { get; set; } = false;

        [Category("Session Generation")]
        [DefaultValue(InitialSessionType.None)]
        [Description("Which type of session should be created on application start")]
        public InitialSessionType InitialSession { get; set; } = InitialSessionType.None;

        [Category("Session Generation")]
        [DefaultValue(false)]
        [Description("Use the new one-worksheet-per-category spreadsheet format")]
        public bool UseOneWorksheetPerCategory { get; set; } = false;

        [Category("Session Generation")]
        [DefaultValue("python")]
        [Description("Python to use")]
        public string Python { get; set; } = "python";


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
        [Category("Preset Times")]
        public TimeSpan Preset0
        {
            get { return Presets[0]; }
            set { Presets[0] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset1
        {
            get { return Presets[1]; }
            set { Presets[1] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset2
        {
            get { return Presets[2]; }
            set { Presets[2] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset3
        {
            get { return Presets[3]; }
            set { Presets[3] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset4
        {
            get { return Presets[4]; }
            set { Presets[4] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset5
        {
            get { return Presets[5]; }
            set { Presets[5] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset6
        {
            get { return Presets[6]; }
            set { Presets[6] = value; }
        }

        [Category("Preset Times")]
        public TimeSpan Preset7
        {
            get { return Presets[7]; }
            set { Presets[7] = value; }
        }
    }
}
