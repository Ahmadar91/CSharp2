using System;

namespace Model.Models.AnimalModel
{
	public abstract class Animal
	{
		public string Id { get; set; }

		public string Name { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public bool IsPredator { get; set; }
		public Category Category { get; set; }
		protected Animal()
		{
			Id = Guid.NewGuid().ToString();
			Reset();
		}

		private void Reset()
		{
			Name = "NoName";
			Gender = Gender.Unknown;
			Age = 0;
			IsPredator = false;

		}

		public override string ToString()
		{
			string strOut = $"{"ID",-15} {Id,6}\n{"Name:",-15} {Name,6}\n {"Age",-15} {Age,6}\n";

			strOut += $"{"Gender:",-15} {Gender,6}\n{"Category:",-15} {Category,6}\n";

			return strOut;
		}
	}
}
