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
		/// <summary>Gets or sets the start identifier.</summary>
		/// <value>The start identifier.</value>
		public string StartId { get; set; }
		/// <summary>Initializes a new instance of the <see cref="AnimalManager" /> class.</summary>
		public AnimalManager()
		{
			StartId = Guid.NewGuid().ToString();
		}
	}
}