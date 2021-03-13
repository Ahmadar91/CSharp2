using System;
using Model.Models.AnimalModel;
using System.Windows.Forms;

namespace assignment1
{
	public partial class AnimalForm : Form
	{
		private Animal _animal;
		private bool isCorrect;
		public bool IsCorrect
		{
			get => isCorrect;
			set => isCorrect = value;
		}
		public AnimalForm(Animal animal)
		{
			InitializeComponent();
			_animal = animal;
			InitializeGUI();
		}
		private void InitializeGUI()
		{

			
		}
	}
}
