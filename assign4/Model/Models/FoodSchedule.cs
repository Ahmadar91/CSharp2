using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Models
{
	[Serializable]

	public class FoodSchedule
	{
		/// <summary>Gets or sets the type of the eater.</summary>
		/// <value>The type of the eater.</value>
		public EaterType EaterType { get; set; }
		/// <summary>Gets or sets the food list.</summary>
		/// <value>The food list.</value>
		public List<string> FoodList { get; set; }

		/// <summary>Gets the count.</summary>
		/// <value>The count.</value>
		public int Count => FoodList.Count;

		/// <summary>Initializes a new instance of the <see cref="FoodSchedule" /> class.</summary>
		public FoodSchedule()
		{
			FoodList = new List<string>();
		}
		/// <summary>Adds the specified value.</summary>
		/// <param name="value">The value.</param>
		public void Add(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				FoodList.Add(value);
			}
		}


		/// <summary>Changes at.</summary>
		/// <param name="index">The index.</param>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool ChangeAt(int index, string value)
		{
			if (string.IsNullOrEmpty(value) || !CheckIndex(index)) return false;
			FoodList.Insert(index, value);
			return true;

		}

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool CheckIndex(int index) => index < FoodList.Count && index >= 0;


		/// <summary>Deletes at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool DeleteAt(int index)
		{
			if (!CheckIndex(index)) return false;
			FoodList.RemoveAt(index);
			return true;
		}

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			var strOut = new StringBuilder();
			foreach (var food in FoodList)
			{
				strOut.AppendLine($"{food}");
			}

			return strOut.ToString();
		}

		/// <summary>Gets the food list information strings.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public ListViewItem[] GetFoodListInfoStrings()
		{
			var listViewItems = new List<ListViewItem>();

			foreach (var food in FoodList)
			{
				listViewItems.Add(new ListViewItem(food));
			}
			return listViewItems.ToArray();
		}
	}

	public enum EaterType
	{
		Carnivore,
		Herbivore,
		Omnivorous
	}
}