using System;

namespace Model.Models.AnimalModel
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public bool IsPredator { get; set; }


		public abstract Animal Create<T>(Enum type, T value2, T value3) where T : struct, IConvertible;
		public override string ToString()
		{
			return "base.ToString()";
		}
	}
}
