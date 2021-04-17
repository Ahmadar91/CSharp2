using System;

namespace assign5
{
	public delegate void FlightInfoEventHandler(FlightInfoEventArgs eventArgs);
	public class FlightInfoEventArgs : EventArgs
	{
		public string FlightCode { get; set; }
		public string Status { get; set; }
		public DateTime DateTime { get; set; }
		public FlightInfoEventArgs( string flightNumber, string status)
		{
			DateTime = DateTime.Now;
			Status = status;
			FlightCode = flightNumber;
		}
	}
}