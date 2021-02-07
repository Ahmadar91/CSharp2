using System;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;

namespace Model.Models.ReptilesModel
{
	public class Reptile : Animal
	{
		public bool CanLiveOnBothWaterAndLand { get; set; }
		public double Weight { get; set; }

		public Reptile(bool canLiveOnBothWaterAndLand, double weight, Category category)
		{
			CanLiveOnBothWaterAndLand = canLiveOnBothWaterAndLand;
			Weight = weight;
			Category = category;
		}

		public Reptile()
		{

		}
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
		public override string ToString()
		{
			var str = base.ToString();
			str += $"{"Can live on Land:",-15} {CanLiveOnBothWaterAndLand,6}\n{"Weight",-15} {Weight,6}\n";
			return str;
		}

	}
}