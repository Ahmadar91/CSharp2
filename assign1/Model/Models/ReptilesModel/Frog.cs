using Model.Models.AnimalModel;

namespace Model.Models.ReptilesModel
{
	public class Frog : Reptile
	{
		public string Color { get; set; }
		public Frog(bool canLiveOnBothWaterAndLand, double weight, Category category) : base(canLiveOnBothWaterAndLand, weight, category)
		{
			Color = "Green";
		}
		public override string ToString()
		{
			var str = base.ToString();
			str += $"Color {Color}";
			return str;
		}
	}
}