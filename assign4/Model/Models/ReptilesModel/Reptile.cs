using System;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;

namespace Model.Models.ReptilesModel
{
	[Serializable]

	public abstract class Reptile : Animal
	{
		public Reptile()
		{

		}
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
		protected Reptile(bool canLiveOnBothWaterAndLand, double weight, Category category)
		{
			CanLiveOnBothWaterAndLand = canLiveOnBothWaterAndLand;
			Weight = weight;
			Category = category;
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