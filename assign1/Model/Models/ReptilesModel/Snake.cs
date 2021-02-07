using Model.Models.AnimalModel;

namespace Model.Models.ReptilesModel
{
	public class Snake : Reptile
	{
		public PoisonLevel PoisonLevel { get; set; }
		public Snake(bool canLiveOnBothWaterAndLand, double weight, Category category) : base(canLiveOnBothWaterAndLand, weight, category)
		{
			PoisonLevel = PoisonLevel.None;

		}
		public override string ToString()
		{
			var str = base.ToString();
			str += $"PoisonLevel {PoisonLevel}";
			return str;
		}
	}
}