using System;
using System.Runtime.InteropServices;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Mammal : Animal
	{
		/// <summary>Gets or sets the type of the skin.</summary>
		/// <value>The type of the skin.</value>
		public SkinType SkinType { get; set; }
		/// <summary>Gets or sets the number of teeth.</summary>
		/// <value>The number of teeth.</value>
		public int NumOfTeeth { get; set; }
		/// <summary>Gets or sets the length of the tail.</summary>
		/// <value>The length of the tail.</value>
		public double TailLength { get; set; }
		/// <summary>Initializes a new instance of the <see cref="Mammal" /> class.</summary>
		public Mammal()
		{

		}

		/// <summary>Initializes a new instance of the <see cref="Mammal" /> class.</summary>
		/// <param name="numOfTeeth">The number of teeth.</param>
		/// <param name="tailLength">Length of the tail.</param>
		/// <param name="category">The category.</param>
		/// <param name="skin">The skin.</param>
		public Mammal(int numOfTeeth, double tailLength, Category category, SkinType skin)
		{
			NumOfTeeth = numOfTeeth;
			TailLength = tailLength;
			Category = category;
			SkinType = SkinType.Fur;
		}


		/// <summary>Creates the specified type.</summary>
		/// <param name="type">The type.</param>
		/// <param name="value2">The value2.</param>
		/// <param name="value3">The value3.</param>
		/// <param name="category">The category.</param>
		/// <param name="skin">The skin.</param>
		/// <returns>
		///   Mammal
		/// </returns>
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

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"{"Tail length(CM):",-15} {TailLength,6}\n{"No.Of teeth:",-15} {NumOfTeeth,6}\n";
			return str;
		}
	}
}