using controller.AnimalManager;
using Model.Interfaces;
using Model.Models;
using Model.Models.AnimalModel;
using Model.Models.MammalsModel;
using Model.Models.ReptilesModel;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace assignment1
{
	public partial class Form1 : Form
	{
		private string Species { get; set; }
		private Category Category { get; set; }
		private IAnimal _animal;
		private AnimalManager _animalManager;
		private FoodManager _foodManager;
		public string FileName { set; get; }
		public string Filter { get; set; }


		/// <summary>Initializes a new instance of the <see cref="Form1" /> class.</summary>
		public Form1()
		{
			InitializeComponent();
			InitializeGUI();
			_animalManager = new AnimalManager();
			_foodManager = new FoodManager();
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
			txtBreed.Visible = true;
			animalInfo.Text = "";
			cmbBool.Items.Add("false");
			cmbBool.Items.Add("true");
			cmbBool.SelectedIndex = 1;
			label3Spec.Text = "Skin type";
			Omni.Text = "";
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
			_animalManager.Add(animal);
			animalList.Items.Clear();
			foreach (var animalInfo in _animalManager.ToStringArray())
			{
				animalList.Items.Add(animalInfo);
			}
			Omni.Text = animal.GetFoodSchedule().EaterType.ToString();
			foodList.Items.Clear();
			foodList.Items.AddRange(animal.GetFoodSchedule().GetFoodListInfoStrings());
		}

		/// <summary>Reads the input.</summary>
		/// <returns>
		///   Animal
		/// </returns>
		private Animal ReadInput()
		{
			Category = ListAll.Checked ? ReadSpecies() : ReadCategory();

			Animal animal = null;
			switch (Category)
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
			switch (species)
			{
				case (ReptileSpecies)0:
				case (ReptileSpecies)2:
					_animal = new Frog(canLiveOnLand, weight, Category);
					((Frog)_animal).Color = txtBreed.Text;
					break;

				case (ReptileSpecies)1:
				case (ReptileSpecies)3:
					_animal = new Snake(canLiveOnLand, weight, Category);
					((Snake)_animal).PoisonLevel = (PoisonLevel)cmbCuteness.SelectedIndex;
					break;
			}
			return _animal as Animal;
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
			if (!double.TryParse(txtSpec2.Text, out var tailLength))
			{
				MessageBox.Show("Please give a valid valiue for tail length");
				return null;
			}

			var skin = cmbSpec3.SelectedIndex;
			MammalSpecies species = ReadMammalSpecies();
			switch (species)
			{
				case MammalSpecies.Dog:
					_animal = new Dog(numOfTeeth, tailLength, Category, (SkinType)skin);
					((Dog)_animal).Breed = txtBreed.Text;
					break;

				case MammalSpecies.Cat:
					_animal = new Cat(numOfTeeth, tailLength, Category, (SkinType)skin);
					((Cat)_animal).Cuteness = (Cuteness)cmbCuteness.SelectedIndex;
					break;
			}

			return _animal as Animal;
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

		/// <summary>Gets the reptile properties.</summary>
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

		/// <summary>Gets the mammal properties.</summary>
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

		/// <summary>Reads the species.</summary>
		/// <returns>
		///   <br />
		/// </returns>
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

		/// <summary>Handles the SelectedIndexChanged event of the animalList control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void animalList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = animalList.FocusedItem.Index;
			if (index >= 0 && animalList.FocusedItem != null)
			{
				var selectedAnimal = _animalManager.GetAt(index);
				animalInfo.Text = selectedAnimal.ToString();
				foodList.Items.Clear();
				Omni.Text = selectedAnimal.GetFoodSchedule().EaterType.ToString();
				var food = selectedAnimal.GetFoodSchedule().GetFoodListInfoStrings();
				foodList.Items.AddRange(food);
				if (selectedAnimal.Category == Category.Mammal)
				{
					var dog = selectedAnimal as Dog;
					if (dog?.Breed != null)
					{
						AnimalName.Text = dog.Name;
						Age.Text = dog.Age.ToString();
						txtBreed.Text = dog.Breed;
						txtSpec1.Text = dog.NumOfTeeth.ToString();
						txtSpec2.Text = dog.TailLength.ToString(CultureInfo.InvariantCulture);
						cmbGender.SelectedIndex = (int)dog.Gender;
					}
					else
					{
						AnimalName.Text = ((Cat)selectedAnimal).Name;
						Age.Text = ((Cat)selectedAnimal).Age.ToString();
						cmbCuteness.SelectedIndex = (int)((Cat)selectedAnimal).Cuteness;
						txtSpec1.Text = ((Cat)selectedAnimal).NumOfTeeth.ToString();
						txtSpec2.Text = ((Cat)selectedAnimal).TailLength.ToString(CultureInfo.InvariantCulture);
						cmbGender.SelectedIndex = (int)((Cat)selectedAnimal).Gender;

					}

				}
				if (selectedAnimal.Category == Category.Reptile)
				{

					if (((Frog)selectedAnimal).Color != null)
					{
						AnimalName.Text = ((Frog)selectedAnimal).Name;
						Age.Text = ((Frog)selectedAnimal).Age.ToString();
						txtBreed.Text = ((Frog)selectedAnimal).Color;
						cmbBool.SelectedIndex = ((Frog)selectedAnimal).CanLiveOnBothWaterAndLand ? 1 : 0;
						txtSpec2.Text = ((Frog)selectedAnimal).Weight.ToString(CultureInfo.InvariantCulture);
						cmbGender.SelectedIndex = (int)((Frog)selectedAnimal).Gender;
					}
					else
					{
						AnimalName.Text = ((Snake)selectedAnimal).Name;
						Age.Text = ((Snake)selectedAnimal).Age.ToString();
						cmbCuteness.SelectedIndex = (int)((Snake)selectedAnimal).PoisonLevel;
						cmbBool.SelectedIndex = ((Snake)selectedAnimal).CanLiveOnBothWaterAndLand ? 1 : 0;
						txtSpec2.Text = ((Snake)selectedAnimal).Weight.ToString(CultureInfo.InvariantCulture);
						cmbGender.SelectedIndex = (int)((Snake)selectedAnimal).Gender;

					}
				}

			}
		}

		/// <summary>Handles the Click event of the RemoveBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void RemoveBtm_Click(object sender, EventArgs e)
		{
			var index = animalList.FocusedItem.Index;
			if (index >= 0 && animalList.FocusedItem != null)
			{
				animalList.Items.RemoveAt(index);
				_animalManager.RemoveAt(index);
			}
			else
			{
				MessageBox.Show("Select an item to delete!");
			}
		}

		/// <summary>Handles the Click event of the foodItemsBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void foodItemsBtm_Click(object sender, EventArgs e)
		{
			var recipeForm = new FoodItemForm();
			if (recipeForm.ShowDialog() == DialogResult.OK)
			{
				if (recipeForm.FoodItem.Ingredients == null || recipeForm.FoodItem.Name == null) return;
				listBox.Items.Clear();
				_foodManager.Add(recipeForm.FoodItem);
				foreach (var recipe in _foodManager.ToStringList())
					listBox.Items.Add(recipe);
			}
		}

		/// <summary>Handles the Click event of the connectBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void connectBtm_Click(object sender, EventArgs e)
		{
			var animalIndex = animalList.FocusedItem.Index;
			var food = listBox.SelectedIndex;
			if ((animalIndex >= 0 && animalList.FocusedItem != null) && (food >= 0 && listBox.SelectedItem != null))
			{
				var animal = _animalManager.GetAt(animalIndex);
				var selectedFood = _foodManager.GetAt(food);
				var result = _foodManager.ConnectFoodAndAnimal(animal.Id, selectedFood);
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show(@"Are you sure you want to exit without saving the current session?", @"Exit", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Reset();
			}
		}

		private void Reset()
		{
			MessageBox.Show("Reset");
			InitializeGUI();
			_animalManager = new AnimalManager();
			_foodManager = new FoodManager();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FileName))
			{
				saveAsToolStripMenuItem_Click(sender, e);
			}
			else SaveToFile();
		}

		private void SaveToFile()
		{


		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Filter = @"Text Files | *.txt";
				var startup = Application.StartupPath;
				var newPath = Path.GetFullPath(Path.Combine(startup, @"..\..\Demo"));
				openFileDialog1.InitialDirectory = newPath;
				openFileDialog1.Filter = Filter;
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileName = openFileDialog1.FileName;
				}

				if (!string.IsNullOrEmpty(FileName))
				{
					//_animalManager.XmlSerialize(FileName);
					//_FillAnimalsList();
					//_isText = true;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), @"Error!");
			}

		}

		private void binaryFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Filter = @"Binary Files | *.dat; *.bin";
				var startup = Application.StartupPath;
				var newPath = Path.GetFullPath(Path.Combine(startup, @"..\..\Demo"));
				openFileDialog1.InitialDirectory = newPath;
				openFileDialog1.Filter = Filter;
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileName = openFileDialog1.SafeFileName;
					var msg = ReadFile();
					if (!string.IsNullOrEmpty(msg))
					{
						MessageBox.Show(msg);
					}
					else
					{
						UpdateListBox();
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), @"Error!");
			}

		}

		private void UpdateListBox()
		{
			throw new NotImplementedException();
		}

		private string ReadFile()
		{
			throw new NotImplementedException();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textFileToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Filter = @"Text Files | *.txt";
				var startup = Application.StartupPath;
				var newPath = Path.GetFullPath(Path.Combine(startup, @"..\..\Demo"));
				saveFileDialog1.InitialDirectory = newPath;
				saveFileDialog1.Filter = Filter;
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileName = saveFileDialog1.FileName;
					_animalManager.XmlSerialize(FileName);
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), @"Error!");
			}
		}

		private void binaryFileToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Filter = @"Binary Files | *.dat; *.bin";
				var startup = Application.StartupPath;
				var newPath = Path.GetFullPath(Path.Combine(startup, @"..\..\Demo"));
				saveFileDialog1.InitialDirectory = newPath;
				saveFileDialog1.Filter = Filter;
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileName = saveFileDialog1.FileName;
					_animalManager.BinarySerializer(FileName);
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), @"Error!");
			}
		}
	}
}