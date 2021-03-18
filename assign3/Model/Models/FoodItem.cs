using System.Linq;

namespace Model.Models
{
	public class FoodItem
	{
		public string Name { get; set; }
		public ListManager<string> Ingredients { get; set; }
		/// <summary>Initializes a new instance of the <see cref="FoodItem" /> class.</summary>
		public FoodItem() { }
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return Ingredients == null ? "" : $"Name: {Name}, Ingredients: { Ingredients.ToStringList().Aggregate("", (x, y) => x + (y + ", "))}";
		}
	}
}