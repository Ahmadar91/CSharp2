namespace Model.Models.AnimalModel
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public bool IsPredator { get; set; }


		public abstract string Predator();

	}
}
