using System;
using System.ComponentModel;
using System.Globalization;

namespace CountdownTimer
{
	/// <summary>
	/// A basic stopwatch. Provides elapsed time measurement, stopping, starting etc.
	/// </summary>
    public class StopWatch : System.IComparable, CountdownTimer.IStopWatch
	{
		private System.DateTime m_startTime = new DateTime();
		private bool m_bIsTiming = false;
		private long m_ticks = 0;

		#region Properties
		[Description("Is the stopwatch running")]
		[Category("Stopwatch")]
		public bool IsTiming
		{
			get
			{
				return m_bIsTiming;
			}
		}

		[Category("Stopwatch")]
		private System.DateTime StartTime
		{
			get
			{
				return m_startTime;
			}

			set
			{
				m_startTime = value;
			}
		}

		[Category("Stopwatch")]
		public System.TimeSpan ElapsedTime
		{
			get 
			{
				AccumulateTicks();
				return new TimeSpan(m_ticks);
			}
		}
		#endregion

		#region Methods
		
		public StopWatch()
		{
			Reset();
		}

		public string ToLongTimeString()
		{
			AccumulateTicks();
			DateTimeFormatInfo format = new DateTimeFormatInfo();
			DateTime elapsed = new DateTime(m_ticks);
			return elapsed.ToString(format.LongTimePattern);
		}

		public string ToShortTimeString()
		{
			AccumulateTicks();
			DateTimeFormatInfo format = new DateTimeFormatInfo();
			DateTime elapsed = new DateTime(m_ticks);
			return elapsed.ToString(format.ShortTimePattern);
		}

		public void Reset()
		{
			m_ticks = 0;
		}

		public void Start()
		{
			StartTime = DateTime.Now;
			m_bIsTiming = true;
		}

		public void Stop()
		{
			// if we are currently timing, then add the elapsed time between now 
			// and the the last saved timestamp to the accumulated ticks
			AccumulateTicks();
			m_bIsTiming = false;
		}

		private void AccumulateTicks()
		{
			if (this.IsTiming)
			{
				DateTime now = DateTime.Now;
				TimeSpan elapsed = now - StartTime;
				m_ticks += elapsed.Ticks;
				StartTime = now;
			}
		}

		#endregion

		#region IComparable Members

		public int CompareTo(object obj)
		{
			if(obj is StopWatch) 
			{
				return ElapsedTime.CompareTo(((StopWatch)obj).ElapsedTime);
			}
        
			throw new ArgumentException("object is not a Stopwatch");
		}

		#endregion
	}
}
