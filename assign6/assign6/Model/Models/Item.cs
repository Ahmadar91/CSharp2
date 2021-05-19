using System;

namespace Model.Models
{
	public class Item
	{
		public string Description { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public int Tax { get; set; }
		public decimal TotalTax => Math.Round((Quantity * UnitPrice * Tax / 100), 3, MidpointRounding.AwayFromZero);
		public decimal Total => Math.Round((Quantity * UnitPrice + TotalTax), 3, MidpointRounding.AwayFromZero);
	}
}