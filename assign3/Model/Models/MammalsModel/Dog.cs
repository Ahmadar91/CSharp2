using System.Collections.Generic;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Dog : Mammal
	{

		/// <summary>Gets or sets the size.</summary>
		/// <value>The size.</value>
		public Size Size { get; set; }
		/// <summary>Gets or sets the breed.</summary>
		/// <value>The breed.</value>
		public string Breed { get; set; }

		/// <summary>Gets or sets the food schedule.</summary>
		/// <value>The food schedule.</value>
		public FoodSchedule FoodSchedule { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Dog" /> class.</summary>
		/// <param name="numOfTeeth">The number of teeth.</param>
		/// <param name="tailLength">Length of the tail.</param>
		/// <param name="category">The category.</param>
		/// <param name="skin">The skin.</param>
		public Dog(int numOfTeeth, double tailLength, Category category, SkinType skin) : base(numOfTeeth, tailLength, category, skin)
		{
			Breed = "Unknown";
		}
		/// <summary>Actions this instance.</summary>
		/// <returns>
		///   <br />
		/// </returns>


		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"Breed: {Breed}";
			return str;
		}

		/// <summary>Sets the food schedule.</summary>
		private void SetFoodSchedule()
		{
			FoodSchedule = new FoodSchedule
			{
				EaterType = EaterType.Omnivorous
			};
			FoodSchedule.Add("Morning: Flakes and Milk");
			FoodSchedule.Add("Lunch: bones and Flakes");
			FoodSchedule.Add("Evening: any meat dish");
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