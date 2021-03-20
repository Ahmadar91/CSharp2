using System;
using System.Collections.Generic;
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
			string strOut = $"{"ID:",-5} {Id,-48}\n{"Name:",-2} {Name,-10}\n {"Age:",-2} {Age,-10}\n";

			strOut += $"{"Gender:",-2} {Gender,-10}\n{"Category:",-2} {Category,-10}\n";

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