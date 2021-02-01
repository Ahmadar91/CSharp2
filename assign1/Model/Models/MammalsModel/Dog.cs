using System.Security.Cryptography;

namespace Model.Models.MammalsModel
{
	public class Dog : Mammal
	{
		public Size Size { get; set; }
		public string Breed { get; set; }

		public override string GetName()
		{
			return base.GetName();
		}
	}
}