using System;

namespace assign5
{
	public class FlightInfo
	{
		public string FlightCode { get; set; }
		public string Status { get; set; }
		public DateTime DateTime { get; set; }
		public FlightInfo(FlightInfoEventArgs eventMessage)
		{
			FlightCode = eventMessage.FlightCode;
			Status = eventMessage.Status;
			DateTime = eventMessage.DateTime;
		}
	}
}