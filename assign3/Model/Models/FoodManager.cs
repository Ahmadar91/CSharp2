using System;
using System.Collections.Generic;
using Model.Models.AnimalModel;

namespace Model.Models
{
	public class FoodManager : ListManager<FoodItem>
	{
		private readonly Dictionary<string, FoodItem> _animalFood;

		/// <summary>Initializes a new instance of the <see cref="FoodManager" /> class.</summary>
		public FoodManager()
		{
			_animalFood = new Dictionary<string, FoodItem>();
		}

		/// <summary>Connects the food and animal.</summary>
		/// <param name="key">The key.</param>
		/// <param name="food">The food.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool ConnectFoodAndAnimal(string key, FoodItem food)
		{
			if (_animalFood.ContainsKey(key))
			{
				return false;
			}
			_animalFood.Add(key, food);
			return true;
		}

		/// <summary>Determines whether the specified key contains key.</summary>
		/// <param name="key">The key.</param>
		/// <returns>
		///   <c>true</c> if the specified key contains key; otherwise, <c>false</c>.</returns>
		public bool ContainsKey(string key)
		{
			if (_animalFood.ContainsKey(key))
			{
				return true;
			}
			return false;
		}
	}
}