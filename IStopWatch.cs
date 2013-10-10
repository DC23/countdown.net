using System;

namespace CountdownTimer
{
	/// <summary>
	/// StopWatch interface.
	/// </summary>
	public interface IStopWatch
	{
		#region Attributes
		bool IsTiming
		{
			get;
		}

		System.TimeSpan ElapsedTime
		{
			get;
		}
		#endregion
		#region Methods
		
		string ToShortTimeString();
		string ToLongTimeString();

		void Reset();
		void Start();
		void Stop();

		#endregion
	}
}
