using Model.Models.AnimalModel;

namespace Model.Models.ReptilesModel
{
	public class Snake : Reptile
	{
		/// <summary>Gets or sets the poison level.</summary>
		/// <value>The poison level.</value>
		public PoisonLevel PoisonLevel { get; set; }
		/// <summary>Gets or sets the food schedule.</summary>
		/// <value>The food schedule.</value>
		public FoodSchedule FoodSchedule { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Snake" /> class.</summary>
		/// <param name="canLiveOnBothWaterAndLand">if set to <c>true</c> [can live on both water and land].</param>
		/// <param name="weight">The weight.</param>
		/// <param name="category">The category.</param>
		public Snake(bool canLiveOnBothWaterAndLand, double weight, Category category) : base(canLiveOnBothWaterAndLand, weight, category)
		{
			PoisonLevel = PoisonLevel.None;

		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"PoisonLevel {PoisonLevel}";
			return str;
		}
		/// <summary>Sets the food schedule.</summary>
		private void SetFoodSchedule()
		{
			FoodSchedule = new FoodSchedule
			{
				EaterType = EaterType.Omnivorous
			};
			FoodSchedule.Add("Morning: Meat");
			FoodSchedule.Add("Lunch: Frogs");
			FoodSchedule.Add("Evening: Insects");
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