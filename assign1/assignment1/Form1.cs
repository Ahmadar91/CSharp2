using Controller;
using System.Windows.Forms;

namespace assignment1
{
	public partial class Form1 : Form
	{
		private AnimalManager _animalManager;
		public Form1()
		{
			InitializeComponent();

			_animalManager = new AnimalManager();
		}


	}
}
