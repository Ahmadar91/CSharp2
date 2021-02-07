using Controller;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;
using Model.Models.ReptilesModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace assignment1
{
	public partial class Form1 : Form
	{
		private AnimalManager _animalManager;
		public string Species { get; set; }
		public Form1()
		{
			InitializeComponent();
			_animalManager = new AnimalManager();
			InitializeGUI();

		}

		private void InitializeGUI()
		{
			cmbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
			cmbGender.SelectedIndex = 2;
			categoryList.Text = "";
			speciesList.Text = "";
			categoryList.Items.AddRange(Enum.GetNames(typeof(Category)));
			categoryList.SelectedIndex = 0;
			specifications.Text = $"{(Category)categoryList.SelectedIndex}  specifications";
			cmbCuteness.Visible = false;
			txtBreed.Visible = false;
			animalInfo.Text = "";
			cmbBool.Items.Add("false");
			cmbBool.Items.Add("true");
			cmbBool.SelectedIndex = 1;
			label3Spec.Text = "";

		}

		private Category ReadCategory()
		{
			Category category;
			var selectedIndex = categoryList.SelectedIndex;
			if (selectedIndex >= 0)
			{
				category = (Category)selectedIndex;
			}
			else
			{
				const string error = "Please Select a Category!";
				MessageBox.Show(error);
				category = Category.Mammal;
			}

			return category;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			Animal animal = ReadInput();
			if (animal == null)
			{
				return;
			}
			animalInfo.Text = animal.ToString();
		}

		private Animal ReadInput()
		{
			var category = ReadCategory();
			Animal animal = null;
			switch (category)
			{
				case Category.Mammal:
					animal = CreateMammal();
					break;
				case Category.Reptile:
					animal = CreateReptile();
					break;
				default:
					animal = null;
					break;
			}

			if (animal != null)
			{
				ReadCommonValues(ref animal);
			}

			return animal;
		}

		private void ReadCommonValues(ref Animal animal)
		{
			animal.Name = AnimalName.Text;
			if (int.TryParse(Age.Text, out var age))
			{
				animal.Age = age;
			}
			animal.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.Text);

		}

		private Animal CreateReptile()
		{
			var canLiveOnLand = cmbBool.SelectedIndex == 1;

			if (!double.TryParse(txtSpec2.Text, out var weight))
			{
				MessageBox.Show("Please give a valid weight");
				return null;
			}

			ReptileSpecies species = ReadReptileSpecies();
			Animal animal = new Reptile().Create(species, canLiveOnLand, weight, ReadCategory());
			if (species == ReptileSpecies.Frog)
			{
				((Frog)animal).Color = txtBreed.Text;
			}
			else if (species == ReptileSpecies.Snake)
			{
				((Snake)animal).PoisonLevel = (PoisonLevel)cmbCuteness.SelectedIndex;
			}
			return animal;

		}
		private Animal CreateMammal()
		{
			if (!int.TryParse(txtSpec1.Text, out var numOfTeeth))
			{
				MessageBox.Show("Please give a valid valiue for number of teeth");
				return null;
			}
			if (!double.TryParse(txtSpec1.Text, out var tailLength))
			{
				MessageBox.Show("Please give a valid valiue for tail length");
				return null;
			}

			var skin = cmbSpec3.SelectedIndex;
			MammalSpecies species = ReadMammalSpecies();
			Animal animal = new Mammal().Create(species, numOfTeeth, tailLength, ReadCategory(), (SkinType)skin);
			switch (species)
			{
				case MammalSpecies.Dog:
					((Dog)animal).Breed = txtBreed.Text;
					break;
				case MammalSpecies.Cat:
					((Cat)animal).Cuteness = (Cuteness)cmbCuteness.SelectedIndex;
					break;
			}

			return animal;
		}
		private ReptileSpecies ReadReptileSpecies()
		{
			ReptileSpecies species;
			var selectedIndex = speciesList.SelectedIndex;
			if (selectedIndex >= 0)
			{
				species = (ReptileSpecies)selectedIndex;
			}
			else
			{
				const string error = "Please Select a Category!";
				MessageBox.Show(error);
				species = ReptileSpecies.Frog;
			}
			return species;
		}



		private MammalSpecies ReadMammalSpecies()
		{
			MammalSpecies species;
			var selectedIndex = speciesList.SelectedIndex;
			if (selectedIndex >= 0)
			{
				species = (MammalSpecies)selectedIndex;
			}
			else
			{
				const string error = "Please Select a Category!";
				MessageBox.Show(error);
				species = MammalSpecies.Cat;
			}
			return species;

		}

		private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
		{
			speciesList.Items.Clear();

			switch ((Category)categoryList.SelectedIndex)
			{
				case Category.Mammal:
					cmbSpec3.Items.Clear();
					specifications.Text = "Mammal Specifications";
					lblspec1.Text = "No.Of teeth;";
					lblSpec2.Text = "Legnth of tail:";
					txtSpec1.Visible = true;
					cmbBool.Visible = false;
					Species = "Mammal";
					label3Spec.Text = "Skin Type";
					cmbSpec3.Visible = true;
					cmbSpec3.Items.AddRange(Enum.GetNames(typeof(SkinType)));
					cmbSpec3.SelectedIndex = 0;
					speciesList.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
					break;
				case Category.Reptile:
					specifications.Text = "Reptile Specifications";
					lblspec1.Text = "Can live on land;";
					lblSpec2.Text = "weight:";
					speciesList.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));
					txtSpec1.Visible = false;
					cmbBool.Visible = true;
					cmbSpec3.Visible = false;
					label3Spec.Text = "";
					Species = "Reptile";
					break;
			}
		}

		private void speciesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbCuteness.Items.Clear();

			if (Species == "Mammal")
			{
				switch ((MammalSpecies)speciesList.SelectedIndex)
				{

					case MammalSpecies.Dog:
						txtBreed.Text = "";
						speciesSpec.Text = "Dog Specifications";
						lblSpeciesSpec1.Text = "Breed";
						cmbCuteness.Visible = false;
						txtBreed.Visible = true;
						break;
					case MammalSpecies.Cat:
						speciesSpec.Text = "Cat Specifications";
						lblSpeciesSpec1.Text = "Cuteness";
						cmbCuteness.Items.AddRange(Enum.GetNames(typeof(Cuteness)));
						cmbCuteness.SelectedIndex = 2;
						cmbCuteness.Visible = true;
						txtBreed.Visible = false;
						break;
				}
			}
			else if (Species == "Reptile")
			{
				switch ((ReptileSpecies)speciesList.SelectedIndex)
				{

					case ReptileSpecies.Frog:
						txtBreed.Text = "";
						speciesSpec.Text = "Frog Specifications";
						lblSpeciesSpec1.Text = "Color";
						cmbCuteness.Visible = false;
						txtBreed.Visible = true;
						break;
					case ReptileSpecies.Snake:
						speciesSpec.Text = "Snake Specifications";
						lblSpeciesSpec1.Text = "PoisonLevel";
						cmbCuteness.Items.AddRange(Enum.GetNames(typeof(PoisonLevel)));
						cmbCuteness.SelectedIndex = 2;
						cmbCuteness.Visible = true;
						txtBreed.Visible = false;
						break;
				}
			}

		}

		private void ListAll_CheckedChanged(object sender, EventArgs e)
		{
			speciesList.Items.Clear();
			categoryList.Enabled = !categoryList.Enabled;
			if (!categoryList.Enabled)
			{
				speciesList.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
				speciesList.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));


			}


		}

		private void upload_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog
			{
				Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
			};
			if (op.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = new Bitmap(op.FileName);
			}
		}
	}
}
