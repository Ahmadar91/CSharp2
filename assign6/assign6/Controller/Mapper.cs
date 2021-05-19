using System;
using System.Collections.Generic;
using Model.Models;

namespace Controller
{
	public class Mapper
	{

		public Invoice Map(string[] content)
		{
			if (content.Length - 1 >= 0 && content.Length > content.Length - 1)
				return new Invoice
				{
					InvoiceNumber = content[0],
					InvoiceDate = DateTime.Parse(content[1]),
					DueDate = DateTime.Parse(content[2]),
					ReceiverCompanyName = content[3],
					ReceiverName = content[4],
					ReceiverStreetAddress = content[5],
					ReceiverZipCode = content[6],
					ReceiverCity = content[7],
					ReceiverCountry = content[8],
					NumberOfItems = int.Parse(content[9]),
					Items = MapItems(content, (int.Parse(content[9]) * 4), 10),
					SenderCompanyName = content[^7],
					SenderStreetAddress = content[^6],
					SenderZipCode = content[^5],
					SenderCity = content[^4],
					SenderCountry = content[^3],
					SenderPhoneNumber = content[^2],
					SenderUrl = content[^1]
				};
			return null;
		}

		private Item[] MapItems(string[] content, int length, int index)
		{
			var items = new string[length];
			Array.Copy(content, index, items, 0, length);
			var results = new List<Item>();
			for (int i = 0; i < length; i += 4)
			{
				results.Add(new Item
				{
					Description = items[i],
					Quantity = int.Parse(items[i + 1]),
					UnitPrice = decimal.Parse(items[i + 2]),
					Tax = int.Parse(items[i + 3])
				});

			}
			return results.ToArray();
		}
	}
}