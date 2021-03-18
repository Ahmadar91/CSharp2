using System.Collections.Generic;
using Model.Models.AnimalModel;

namespace Model.Models
{
	public class FoodManager : ListManager<FoodItem>
	{
		public Dictionary<string, FoodItem> AnimalFood { get; set; }

		public FoodManager()
		{
			AnimalFood = new Dictionary<string, FoodItem>();
		}
	}
}