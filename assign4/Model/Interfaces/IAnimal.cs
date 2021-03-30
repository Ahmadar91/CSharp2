using System.Collections.Generic;
using Model.Models;
using Model.Models.AnimalModel;

namespace Model.Interfaces
{
	public interface IAnimal
	{
		string Id { get; set; }

		/// <summary>Gets or sets the name.</summary>
		/// <value>The name.</value>
		string Name { get; set; }

		/// <summary>Gets or sets the age.</summary>
		/// <value>The age.</value>
		int Age { get; set; }

		/// <summary>Gets or sets the gender.</summary>
		/// <value>The gender.</value>
		Gender Gender { get; set; }

		bool IsPredator { get; set; }

		/// <summary>Gets or sets the category.</summary>
		/// <value>The category.</value>
		Category Category { get; set; }

		/// <summary>Gets the food schedule.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		FoodSchedule GetFoodSchedule();
	}
}