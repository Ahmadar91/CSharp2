using System;
using System.Runtime.InteropServices;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	[Serializable]

	public abstract class Mammal : Animal
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
		/// <param name="numOfTeeth">The number of teeth.</param>
		/// <param name="tailLength">Length of the tail.</param>
		/// <param name="category">The category.</param>
		/// <param name="skin">The skin.</param>
		protected Mammal(int numOfTeeth, double tailLength, Category category, SkinType skin)
		{
			NumOfTeeth = numOfTeeth;
			TailLength = tailLength;
			Category = category;
			SkinType = SkinType.Fur;
		}
		public Mammal()
		{

		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var str = base.ToString();
			str += $"{"Tail length(CM):",-2} {TailLength,-10}\n{"No.Of teeth:",-2} {NumOfTeeth,-10}\n";
			return str;
		}


	}
}