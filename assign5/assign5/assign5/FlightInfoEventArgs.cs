using System;

namespace assign5
{
	public class FlightInfoEventArgs : EventArgs
	{
		public string FlightCode { get; set; }
		public string Status { get; set; }
		public DateTime DateTime { get; }
		/// <summary>Initializes a new instance of the <see cref="FlightInfoEventArgs" /> class.</summary>
		/// <param name="flightNumber">The flight number.</param>
		/// <param name="status">The status.</param>
		public FlightInfoEventArgs(string flightNumber, string status)
		{
			DateTime = DateTime.Now;
			Status = status;
			FlightCode = flightNumber;
		}
	}
	/// <summary>
	///   <br />
	/// </summary>
	/// <param name="eventArgs">The <see cref="FlightInfoEventArgs" /> instance containing the event data.</param>
	public delegate void FlightInfoEventHandler(FlightInfoEventArgs eventArgs);
}