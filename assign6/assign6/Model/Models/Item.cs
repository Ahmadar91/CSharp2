using System;

namespace Model.Models
{
	public class Item
	{
		/// <summary>Gets or sets the description.</summary>
		/// <value>The description.</value>
		public string Description { get; set; }
		/// <summary>Gets or sets the quantity.</summary>
		/// <value>The quantity.</value>
		public int Quantity { get; set; }
		/// <summary>Gets or sets the unit price.</summary>
		/// <value>The unit price.</value>
		public decimal UnitPrice { get; set; }
		/// <summary>Gets or sets the tax.</summary>
		/// <value>The tax.</value>
		public int Tax { get; set; }
		public decimal TotalTax => Math.Round((Quantity * UnitPrice * Tax / 100), 2);
		public decimal Total => Math.Round((Quantity * UnitPrice + TotalTax), 2);
	}
}