using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CountdownTimer
{
	/// <summary>
	/// Summary description for StopWatchControl.
	/// </summary>
    public class StopWatchControl : System.Windows.Forms.UserControl, CountdownTimer.IStopWatch
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StopWatchControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			updateTimer.Elapsed +=new System.Timers.ElapsedEventHandler(updateTimer_Elapsed);
			updateTimer.Interval = this.UpdateInterval;

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.display = new System.Windows.Forms.TextBox();
			this.updateTimer = new System.Timers.Timer();
			((System.ComponentModel.ISupportInitialize)(this.updateTimer)).BeginInit();
			this.SuspendLayout();
			// 
			// display
			// 
			this.display.Location = new System.Drawing.Point(1, 1);
			this.display.Name = "display";
			this.display.ReadOnly = true;
			this.display.Size = new System.Drawing.Size(80, 20);
			this.display.TabIndex = 0;
			this.display.Text = "00:00:00";
			this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// updateTimer
			// 
			this.updateTimer.Enabled = true;
			this.updateTimer.Interval = 1000;
			this.updateTimer.SynchronizingObject = this;
			// 
			// StopWatchControl
			// 


			this.Controls.Add(this.display);
			this.Name = "StopWatchControl";
			this.Size = new System.Drawing.Size(82, 22);
			((System.ComponentModel.ISupportInitialize)(this.updateTimer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.TextBox display;
		private System.Timers.Timer updateTimer;

		#region IStopWatch Members

		/// <summary>
		/// Provides the implementation of IStopWatch
		/// </summary>
		private StopWatch m_stopWatch = new StopWatch();

		public bool IsTiming
		{
			get
			{
				return m_stopWatch.IsTiming;
			}
		}

		public TimeSpan ElapsedTime
		{
			get
			{
				return m_stopWatch.ElapsedTime;
			}
		}

		public string ToShortTimeString()
		{
			return m_stopWatch.ToShortTimeString();
		}

		public string ToLongTimeString()
		{
			return m_stopWatch.ToLongTimeString();
		}

		public void Reset()
		{
			m_stopWatch.Reset();
		}

		public void Start()
		{
			m_stopWatch.Start();
		}

		public void Stop()
		{
			m_stopWatch.Stop();
		}

		#endregion

		#region Properties

		public enum DisplayMode
		{
			LongTimeString,
			ShortTimeString
		}

		private DisplayMode m_eDisplayMode = DisplayMode.LongTimeString;
		[Category("Display Properties")]
		[Description("String format used for display")]
		[DefaultValue(DisplayMode.LongTimeString)]
		public DisplayMode DisplayFormat
		{
			get
			{
				return m_eDisplayMode;
			}

			set
			{
				m_eDisplayMode = value;
			}
		}

		[Category("Display Properties")]
		[Description("Defines the update frequency of the stopwatch display, in milliseconds")]
		[DefaultValue(1000)]
		public double UpdateInterval
		{
			get
			{
				return updateTimer.Interval;
			}

			set
			{
				updateTimer.Interval = value;
			}
		}
		#endregion

		private void updateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (this.DisplayFormat == DisplayMode.LongTimeString)
				display.Text = m_stopWatch.ToLongTimeString();
			else
				display.Text = m_stopWatch.ToShortTimeString();

			// todo - should throw an exception on invalid displayFormat
		}
	}
}
