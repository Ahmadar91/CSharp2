﻿using System;
using Model.Models.AnimalModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using controller.Interface;

namespace controller.AnimalManager
{
	public class AnimalManager : IAnimalManager
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
		/// <summary>Adds the specified value.</summary>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool Add(Animal value)
		{
			if (value == null) return false;
			AnimalList.Add(value);
			return true;
		}


		/// <summary>Gets the animal at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public Animal GetAnimalAt(int index)
		{
			if (!CheckIndex(index)) return null;
			return AnimalList[index];
		}

		/// <summary>Gets the animal list information strings.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public ListViewItem[] GetAnimalListInfoStrings()
		{

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


		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool CheckIndex(int index) => index < AnimalList.Count && index >= 0;


		/// <summary>Deletes at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool DeleteAt(int index)
		{
			if (!CheckIndex(index)) return false;
			AnimalList.RemoveAt(index);
			return true;
		}

	}
}