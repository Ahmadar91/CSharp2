using System;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;

namespace Model.Models.ReptilesModel
{
	public class Reptile : Animal
	{
		/// <summary>Gets or sets a value indicating whether this instance can live on both water and land.</summary>
		/// <value>
		///   <c>true</c> if this instance can live on both water and land; otherwise, <c>false</c>.</value>
		public bool CanLiveOnBothWaterAndLand { get; set; }
		/// <summary>Gets or sets the weight.</summary>
		/// <value>The weight.</value>
		public double Weight { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Reptile" /> class.</summary>
		/// <param name="canLiveOnBothWaterAndLand">if set to <c>true</c> [can live on both water and land].</param>
		/// <param name="weight">The weight.</param>
		/// <param name="category">The category.</param>
		public Reptile(bool canLiveOnBothWaterAndLand, double weight, Category category)
		{
			CanLiveOnBothWaterAndLand = canLiveOnBothWaterAndLand;
			Weight = weight;
			Category = category;
		}

		/// <summary>Initializes a new instance of the <see cref="Reptile" /> class.</summary>
		public Reptile()
		{

		}
		/// <summary>Creates the specified type.</summary>
		/// <param name="type">The type.</param>
		/// <param name="value2">if set to <c>true</c> [value2].</param>
		/// <param name="value3">The value3.</param>
		/// <param name="category">The category.</param>
		/// <returns>
		///   Reptile
		/// </returns>
		public Reptile Create(ReptileSpecies type, bool value2, double value3, Category category)
		{
			Reptile reptile = null;
			switch (type)
			{
				case ReptileSpecies.Frog:
					reptile = new Frog(value2, value3, category);
					break;
				case ReptileSpecies.Snake:
					reptile = new Snake(value2, value3, category);
					break;
			}
			return reptile;
		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"{"Can live on Land:",-15} {CanLiveOnBothWaterAndLand,6}\n{"Weight",-15} {Weight,6}\n";
			return str;
		}

	}
}