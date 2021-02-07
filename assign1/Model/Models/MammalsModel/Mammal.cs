using System;
using System.Runtime.InteropServices;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Mammal : Animal
	{
		public SkinType SkinType { get; set; }
		public int NumOfTeeth { get; set; }
		public double TailLength { get; set; }
		public Mammal()
		{

		}

		public Mammal(int numOfTeeth, double tailLength, Category category, SkinType skin)
		{
			NumOfTeeth = numOfTeeth;
			TailLength = tailLength;
			Category = category;
			SkinType = SkinType.Fur;
		}
		public virtual string Action()
		{
			return "";
		}


		public Mammal Create(MammalSpecies type, int value2, double value3, Category category, SkinType skin)
		{
			Mammal mammal = null;
			switch (type)
			{
				case MammalSpecies.Dog:
					mammal = new Dog(value2, (value3), category, skin);
					break;
				case MammalSpecies.Cat:
					mammal = new Cat(value2, value3, category, skin);
					break;
			}

			return mammal;
		}

		public override string ToString()
		{
			var str = base.ToString();
			str += $"{"Tail length(CM):",-15} {TailLength,6}\n{"No.Of teeth:",-15} {NumOfTeeth,6}\n";
			return str;
		}
	}
}