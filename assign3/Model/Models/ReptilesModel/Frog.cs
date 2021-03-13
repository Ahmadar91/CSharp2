using Model.Models.AnimalModel;

namespace Model.Models.ReptilesModel
{
	public class Frog : Reptile
	{
		/// <summary>Gets or sets the color.</summary>
		/// <value>The color.</value>
		public string Color { get; set; }
		/// <summary>Gets or sets the food schedule.</summary>
		/// <value>The food schedule.</value>
		public FoodSchedule FoodSchedule { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Frog" /> class.</summary>
		/// <param name="canLiveOnBothWaterAndLand">if set to <c>true</c> [can live on both water and land].</param>
		/// <param name="weight">The weight.</param>
		/// <param name="category">The category.</param>
		public Frog(bool canLiveOnBothWaterAndLand, double weight, Category category) : base(canLiveOnBothWaterAndLand, weight, category)
		{
			Color = "Green";
		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"Color {Color}";
			return str;
		}

		/// <summary>Sets the food schedule.</summary>
		private void SetFoodSchedule()
		{
			FoodSchedule = new FoodSchedule
			{
				EaterType = EaterType.Omnivorous
			};
			FoodSchedule.Add("Morning: Bugs");
			FoodSchedule.Add("Lunch: Bugs");
			FoodSchedule.Add("Evening: Bugs");
		}

		/// <summary>Gets the food schedule.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public override FoodSchedule GetFoodSchedule()
		{
			SetFoodSchedule();
			return FoodSchedule;
		}
	}
}