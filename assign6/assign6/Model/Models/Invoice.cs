using System;
using System.Linq;

namespace Model.Models
{
	public class Invoice
	{
		/// <summary>Gets or sets the invoice number.</summary>
		/// <value>The invoice number.</value>
		public string InvoiceNumber { get; set; }
		/// <summary>Gets or sets the invoice date.</summary>
		/// <value>The invoice date.</value>
		public DateTime InvoiceDate { get; set; }
		/// <summary>Gets or sets the due date.</summary>
		/// <value>The due date.</value>
		public DateTime DueDate { get; set; }
		/// <summary>Gets or sets the name of the receiver company.</summary>
		/// <value>The name of the receiver company.</value>
		public string ReceiverCompanyName { get; set; }
		/// <summary>Gets or sets the name of the receiver.</summary>
		/// <value>The name of the receiver.</value>
		public string ReceiverName { get; set; }
		/// <summary>Gets or sets the receiver street address.</summary>
		/// <value>The receiver street address.</value>
		public string ReceiverStreetAddress { get; set; }
		/// <summary>Gets or sets the receiver zip code.</summary>
		/// <value>The receiver zip code.</value>
		public string ReceiverZipCode { get; set; }
		/// <summary>Gets or sets the receiver city.</summary>
		/// <value>The receiver city.</value>
		public string ReceiverCity { get; set; }
		/// <summary>Gets or sets the receiver country.</summary>
		/// <value>The receiver country.</value>
		public string ReceiverCountry { get; set; }
		/// <summary>Gets or sets the number of items.</summary>
		/// <value>The number of items.</value>
		public int NumberOfItems { get; set; }
		/// <summary>Gets or sets the items.</summary>
		/// <value>The items.</value>
		public Item[] Items { get; set; }
		/// <summary>Gets or sets the name of the sender company.</summary>
		/// <value>The name of the sender company.</value>
		public string SenderCompanyName { get; set; }
		/// <summary>Gets or sets the sender street address.</summary>
		/// <value>The sender street address.</value>
		public string SenderStreetAddress { get; set; }
		/// <summary>Gets or sets the sender zip code.</summary>
		/// <value>The sender zip code.</value>
		public string SenderZipCode { get; set; }
		/// <summary>Gets or sets the sender city.</summary>
		/// <value>The sender city.</value>
		public string SenderCity { get; set; }
		/// <summary>Gets or sets the sender country.</summary>
		/// <value>The sender country.</value>
		public string SenderCountry { get; set; }
		/// <summary>Gets or sets the sender phone number.</summary>
		/// <value>The sender phone number.</value>
		public string SenderPhoneNumber { get; set; }
		/// <summary>Gets or sets the sender URL.</summary>
		/// <value>The sender URL.</value>
		public string SenderUrl { get; set; }
		/// <summary>Gets or sets the discount.</summary>
		/// <value>The discount.</value>
		public decimal Discount { get; set; }
		public decimal TotalAmount => Items.Sum(x => x.Total - Discount);
	}
}