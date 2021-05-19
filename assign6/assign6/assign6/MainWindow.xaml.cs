using Controller;
using Microsoft.Win32;
using System.Windows;

namespace assign6
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			InitializeGUI();
		}

		private void InitializeGUI()
		{
			companyName.Text = "";
			listView.Visibility = 0;
			InvoiceDate.IsEnabled = false;
			totalBox.IsEnabled = false;
		}

		private void Exit_OnClick(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void OpenInvoice_OnClick(object sender, RoutedEventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Text files|*.txt",
				Title = "Import Invoice"
			};
			openFileDialog.ShowDialog();
			var path = openFileDialog.FileName;
			if (path != "")
			{
				var mapper = new Mapper();
				var invoice = mapper.Map(FileParser.ReadFile(path));
				var guiMapper = new GUIMapper();
				guiMapper.Map(this, invoice);
			}
		}
	}
}
