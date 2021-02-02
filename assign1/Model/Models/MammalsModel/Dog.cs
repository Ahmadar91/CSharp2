using System.Security.Cryptography;

namespace Model.Models.MammalsModel
{
	public class Dog : Mammal
	{

		public Size Size { get; set; }
		public string Breed { get; set; }

		public Dog(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
		{
			Breed = "Unknown";
		}
		public override string GetName()
		{
			var x = "";
			return base.GetName();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}