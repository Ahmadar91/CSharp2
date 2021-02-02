using System;
using System.Runtime.InteropServices;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Mammal : Animal
	{
		public SkinType SkinType { get; set; }
		public bool Water { get; set; }

		public int NumOfTeeth { get; set; }
		public double TailLength { get; set; }
		public Mammal()
		{

		}

		public Mammal(int numOfTeeth, double tailLength)
		{
			NumOfTeeth = numOfTeeth;
			TailLength = tailLength;
		}
		public virtual string GetName()
		{
			return "";
		}


		public override Animal Create<T>(Enum type, T value2, T value3)
		{
			Mammal mammal = null;
			switch (type)
			{
				case MammalSpecies.Dog:
					mammal = new Dog(Convert.ToInt32(value2), Convert.ToDouble(value3));
					break;
				case MammalSpecies.Cat:
					mammal = new Cat();
					break;
			}
			return mammal;
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}