using System;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;

namespace Model.Models.ReptilesModel
{
	public class Reptile : Animal
	{
		public bool CanLiveOnBothWaterAndLand { get; set; }

		public override Animal Create<T>(Enum type, T value2, T value3)
		{
			Reptile mammal = null;
			switch (type)
			{
				case ReptileSpecies.Frog:
					mammal = new Frog();
					break;
				case ReptileSpecies.Snake:
					mammal = new Snake();
					break;
			}
			return mammal;
		}
	}
}