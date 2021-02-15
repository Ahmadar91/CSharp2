
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;
using Model.Models.ReptilesModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace assignment1
{
	public partial class Form1 : Form
	{
		/// <summary>The animal manager</summary>

		/// <summary>Gets or sets the species.</summary>
		/// <value>The species.</value>
		private string Species { get; set; }
		private Category _Category { get; set; }
		/// <summary>Initializes a new instance of the <see cref="Form1" /> class.</summary>
		public Form1()
		{
			InitializeComponent();

			InitializeGUI();

		}

		/// <summary>Initializes the GUI.</summary>
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
			label3Spec.Text = "Skin type";

		}

		/// <summary>Reads the category.</summary>
		/// <returns>
		///   Category of animals
		/// </returns>
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

		/// <summary>Handles the Click event of the AddButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			Animal animal = ReadInput();
			if (animal == null)
			{
				return;
			}
			animalInfo.Text = animal.ToString();
		}

		/// <summary>Reads the input.</summary>
		/// <returns>
		///   Animal
		/// </returns>
		private Animal ReadInput()
		{

			_Category = ListAll.Checked ? ReadSpecies() : ReadCategory();


			Animal animal = null;
			switch (_Category)
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

		/// <summary>Reads the common values.</summary>
		/// <param name="animal">The animal.</param>
		private void ReadCommonValues(ref Animal animal)
		{
			animal.Name = AnimalName.Text;
			if (int.TryParse(Age.Text, out var age))
			{
				animal.Age = age;
			}
			animal.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.Text);

		}

		/// <summary>Creates the reptile.</summary>
		/// <returns>
		///   Animal
		/// </returns>
		private Animal CreateReptile()
		{
			var canLiveOnLand = cmbBool.SelectedIndex == 1;

			if (!double.TryParse(txtSpec2.Text, out var weight))
			{
				MessageBox.Show("Please give a valid weight");
				return null;
			}

			ReptileSpecies species = ReadReptileSpecies();
			Animal animal = new Reptile().Create(species, canLiveOnLand, weight, _Category);
			switch (species)
			{
				case (ReptileSpecies)0:
				case (ReptileSpecies)2:
					((Frog)animal).Color = txtBreed.Text;
					break;
				case (ReptileSpecies)1:
				case (ReptileSpecies)3:
					((Snake)animal).PoisonLevel = (PoisonLevel)cmbCuteness.SelectedIndex;
					break;
			}
			return animal;

		}
		/// <summary>Creates the mammal.</summary>
		/// <returns>
		///   Animal
		/// </returns>
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
			Animal animal = new Mammal().Create(species, numOfTeeth, tailLength, _Category, (SkinType)skin);
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
		/// <summary>Reads the reptile species.</summary>
		/// <returns>
		///   ReptileSpecies
		/// </returns>
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



		/// <summary>Reads the mammal species.</summary>
		/// <returns>
		///  MammalSpecies
		/// </returns>
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

		/// <summary>Handles the SelectedIndexChanged event of the categoryList control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
		{
			speciesList.Items.Clear();
			switch ((Category)categoryList.SelectedIndex)
			{
				case Category.Mammal:
					speciesList.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
					speciesList.SelectedIndex = 0;
					break;
				case Category.Reptile:
					speciesList.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));
					speciesList.SelectedIndex = 0;
					break;
			}
		}

		private void GetReptileProperties()
		{
			specifications.Text = "Reptile Specifications";
			lblspec1.Text = "Can live on land;";
			lblSpec2.Text = "weight:";
			txtSpec1.Visible = false;
			cmbBool.Visible = true;
			cmbSpec3.Visible = false;
			label3Spec.Text = "";
			Species = "Reptile";
		}

		private void GetMammalProperties()
		{
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
		}

		/// <summary>Handles the SelectedIndexChanged event of the speciesList control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void speciesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbCuteness.Items.Clear();

			var selectedIndex = speciesList.SelectedItem.ToString();
			if (selectedIndex == MammalSpecies.Dog.ToString())
			{
				GetMammalProperties();
				txtBreed.Text = "";
				speciesSpec.Text = "Dog Specifications";
				lblSpeciesSpec1.Text = "Breed";
				cmbCuteness.Visible = false;
				txtBreed.Visible = true;
			}

			if (selectedIndex == MammalSpecies.Cat.ToString())
			{
				GetMammalProperties();
				speciesSpec.Text = "Cat Specifications";
				lblSpeciesSpec1.Text = "Cuteness";
				cmbCuteness.Items.AddRange(Enum.GetNames(typeof(Cuteness)));
				cmbCuteness.SelectedIndex = 2;
				cmbCuteness.Visible = true;
				txtBreed.Visible = false;

			}

			if (selectedIndex == ReptileSpecies.Frog.ToString())
			{
				GetReptileProperties();
				txtBreed.Text = "";
				speciesSpec.Text = "Frog Specifications";
				lblSpeciesSpec1.Text = "Color";
				cmbCuteness.Visible = false;
				txtBreed.Visible = true;
			}

			if (selectedIndex == ReptileSpecies.Snake.ToString())
			{
				GetReptileProperties();
				speciesSpec.Text = "Snake Specifications";
				lblSpeciesSpec1.Text = "PoisonLevel";
				cmbCuteness.Items.AddRange(Enum.GetNames(typeof(PoisonLevel)));
				cmbCuteness.SelectedIndex = 2;
				cmbCuteness.Visible = true;
				txtBreed.Visible = false;
			}

		}

		private Category ReadSpecies()
		{

			var selectedIndex = speciesList.SelectedItem.ToString();
			if (selectedIndex == MammalSpecies.Dog.ToString() || selectedIndex == MammalSpecies.Cat.ToString())
			{
				return Category.Mammal;
			}

			return Category.Reptile;

		}

		/// <summary>Handles the CheckedChanged event of the ListAll control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ListAll_CheckedChanged(object sender, EventArgs e)
		{
			categoryList.Enabled = !categoryList.Enabled;
			speciesList.Items.Clear();
			if (!categoryList.Enabled)
			{
				speciesList.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
				speciesList.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));
				speciesList.SelectedIndex = 0;
				return;
			}
			if ((Category)categoryList.SelectedIndex == Category.Mammal)
			{
				speciesList.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
				speciesList.SelectedIndex = 0;
			}
			if ((Category)categoryList.SelectedIndex == Category.Reptile)
			{
				speciesList.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));
				speciesList.SelectedIndex = 0;
			}
		}

		/// <summary>Handles the Click event of the upload control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
