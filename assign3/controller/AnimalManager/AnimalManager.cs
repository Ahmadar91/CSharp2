using System;
using Model.Models.AnimalModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using controller.Interface;
using Model.Models;

namespace controller.AnimalManager
{
	public class AnimalManager : ListManager<Animal>
	{
		/// <summary>Gets or sets the animal list.</summary>
		/// <value>The animal list.</value>
		public List<Animal> AnimalList { get; set; }
		/// <summary>Gets or sets the start identifier.</summary>
		/// <value>The start identifier.</value>
		public string StartId { get; set; }

		/// <summary>Initializes a new instance of the <see cref="AnimalManager" /> class.</summary>
		public AnimalManager()
		{
			AnimalList = new List<Animal>();
			StartId = Guid.NewGuid().ToString();
		}
		/// <summary>Gets the animal list information strings.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public ListViewItem[] GetAnimalListInfoStrings()
		{
			AnimalList = GetAll();
			var listViewItems = new List<ListViewItem>();
			foreach (var animal in AnimalList)
			{
				ListViewItem item = new ListViewItem(animal.Id);
				item.SubItems.Add(animal.Name);
				item.SubItems.Add(animal.Age.ToString());
				item.SubItems.Add(animal.Gender.ToString());
				listViewItems.Add(item);
			}
			return listViewItems.ToArray();
		}
	}
}