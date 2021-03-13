using Model.Models.AnimalModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace controller.Interface
{
	public interface IAnimalManager
	{
		/// <summary>Gets or sets the animal list.</summary>
		/// <value>The animal list.</value>
		List<Animal> AnimalList { get; set; }
		/// <summary>Gets or sets the start identifier.</summary>
		/// <value>The start identifier.</value>
		string StartId { get; set; }

		/// <summary>Adds the specified value.</summary>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <br />
		/// </returns>
		bool Add(Animal value);

		/// <summary>Gets the animal at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		Animal GetAnimalAt(int index);

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		bool CheckIndex(int index);

		/// <summary>Deletes at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		bool DeleteAt(int index);

		/// <summary>Gets the animal list information strings.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		ListViewItem[] GetAnimalListInfoStrings();

	}
}