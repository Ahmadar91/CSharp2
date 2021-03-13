using System;
using System.Runtime.InteropServices.ComTypes;
using Model.Interfaces;
using Model.Models.MammalsModel;


namespace Model.Models.AnimalModel
{
	public abstract class Animal : IAnimal
	{
		/// <summary>Gets or sets the identifier.</summary>
		/// <value>The identifier.</value>
		public string Id { get; set; }
		/// <summary>Gets or sets the name.</summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		/// <summary>Gets or sets the age.</summary>
		/// <value>The age.</value>
		public int Age { get; set; }
		/// <summary>Gets or sets the gender.</summary>
		/// <value>The gender.</value>
		public Gender Gender { get; set; }
		/// <summary>Gets or sets a value indicating whether this instance is predator.</summary>
		/// <value>
		///   <c>true</c> if this instance is predator; otherwise, <c>false</c>.</value>
		public bool IsPredator { get; set; }
		/// <summary>Gets or sets the category.</summary>
		/// <value>The category.</value>
		public Category Category { get; set; }

		protected Animal()
		{
			Reset();
			Id = Guid.NewGuid().ToString();
		}

		/// <summary>Resets this instance.</summary>
		private void Reset()
		{
			Name = "NoName";
			Gender = Gender.Unknown;
			Age = 0;
			IsPredator = false;
		}

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			string strOut = $"{"ID",-15} {Id,6}\n{"Name:",-15} {Name,6}\n {"Age",-15} {Age,6}\n";

			strOut += $"{"Gender:",-15} {Gender,6}\n{"Category:",-15} {Category,6}\n";

			return strOut;
		}

		/// <summary>Gets the food schedule.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public abstract FoodSchedule GetFoodSchedule();

		public virtual string GetExtraInfo() => $"{"Category:",-15} {Category,10}\n";


	}
}