using System;
using Model.Models.AnimalModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using controller.Interface;

namespace controller.AnimalManager
{
	public class AnimalManager : IAnimalManager
	{
		public List<Animal> AnimalList { get; set; }
		public string StartId { get; set; }

		public AnimalManager()
		{
			AnimalList = new List<Animal>();
			StartId = Guid.NewGuid().ToString();
		}
		public bool Add(Animal value)
		{
			if (value == null) return false;
			AnimalList.Add(value);
			return true;
		}


		public Animal GetAnimalAt(int index)
		{
			if (!CheckIndex(index)) return null;
			return AnimalList[index];
		}

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


		public bool CheckIndex(int index) => index < AnimalList.Count && index >= 0;


		public bool DeleteAt(int index)
		{
			if (!CheckIndex(index)) return false;
			AnimalList.RemoveAt(index);
			return true;
		}

	}
}