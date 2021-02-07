using System.Security.Cryptography;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Dog : Mammal
	{

		public Size Size { get; set; }
		public string Breed { get; set; }

		public Dog(int numOfTeeth, double tailLength, Category category, SkinType skin) : base(numOfTeeth, tailLength, category, skin)
		{
			Breed = "Unknown";
		}
		public override string Action()
		{
			var x = "";
			return base.Action();
		}

		public override string ToString()
		{
			var str = base.ToString();
			str += $"Breed {Breed}";
			return str;
		}
	}
}