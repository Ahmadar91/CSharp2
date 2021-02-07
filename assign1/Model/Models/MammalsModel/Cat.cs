using Model.Models.AnimalModel;

namespace Model.Models.MammalsModel
{
	public class Cat : Mammal
	{
		public Cuteness Cuteness { get; set; }

		public Cat(int numOfTeeth, double tailLength, Category category, SkinType skin) : base(numOfTeeth, tailLength, category, skin)
		{
			Cuteness = Cuteness.Normal;

		}

		public override string Action()
		{
			var x = "";
			return base.Action();
		}

		public override string ToString()
		{
			var str = base.ToString();
			str += $"Cuteness {Cuteness}";
			return str;
		}
	}
}