using System;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	[Serializable]

	public class Cat : Mammal
	{
		public Cat()
		{

		}
		/// <summary>Gets or sets the cuteness.</summary>
		/// <value>The cuteness.</value>
		public Cuteness Cuteness { get; set; }
		/// <summary>Gets or sets the food schedule.</summary>
		/// <value>The food schedule.</value>
		public FoodSchedule FoodSchedule { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Cat" /> class.</summary>
		/// <param name="numOfTeeth">The number of teeth.</param>
		/// <param name="tailLength">Length of the tail.</param>
		/// <param name="category">The category.</param>
		/// <param name="skin">The skin.</param>
		public Cat(int numOfTeeth, double tailLength, Category category, SkinType skin) : base(numOfTeeth, tailLength, category, skin)
		{
			Cuteness = Cuteness.Normal;

		}

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"Cuteness: {Cuteness}";
			return str;
		}

		/// <summary>Sets the food schedule.</summary>
		private void SetFoodSchedule()
		{
			FoodSchedule = new FoodSchedule
			{
				EaterType = EaterType.Carnivore
			};
			FoodSchedule.Add("Morning: Milk");
			FoodSchedule.Add("Lunch: Tuna");
			FoodSchedule.Add("Evening: Cat Treats");
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