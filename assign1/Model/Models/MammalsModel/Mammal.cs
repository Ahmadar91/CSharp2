using System.Runtime.InteropServices;
using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Mammal : Animal
	{
		public SkinType SkinType { get; set; }
		public bool Water { get; set; }
	}
}