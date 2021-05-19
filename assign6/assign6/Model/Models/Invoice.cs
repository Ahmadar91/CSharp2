using System;

namespace Model.Models
{
	public class Invoice
	{
		public string InvoiceNumber { get; set; }
		public DateTime InvoiceDate { get; set; }
		public DateTime DueDate { get; set; }
		public string ReceiverCompanyName { get; set; }
		public string ReceiverName { get; set; }
		public string ReceiverStreetAddress { get; set; }
		public string ReceiverZipCode { get; set; }
		public string ReceiverCity { get; set; }
		public string ReceiverCountry { get; set; }
		public int NumberOfItems { get; set; }
		public Item[] Items { get; set; }
		public string SenderCompanyName { get; set; }
		public string SenderStreetAddress { get; set; }
		public string SenderZipCode { get; set; }
		public string SenderCity { get; set; }
		public string SenderCountry { get; set; }
		public string SenderPhoneNumber { get; set; }
		public string SenderUrl { get; set; }
	}
}