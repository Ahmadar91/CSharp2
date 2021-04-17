using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace assign5
{
	public partial class FlightWindow : Window
	{
		private readonly FlightInfoEventArgs _eventMessage;
		public FlightWindow(string code)
		{
			InitializeComponent();
			InitializeGUI();
			ChooseImage(code);
			_eventMessage = new FlightInfoEventArgs(code, "Started");
		}

		private void InitializeGUI()
		{
		
			land.IsEnabled = false;
			combo.IsEnabled = false;
			combo.ItemsSource = new List<string> { "30 deg", "Berlin", "Stockholm", "London" };
		}

		private void ChooseImage(string code)
		{
			if (code.ToLower().StartsWith("sk"))
			{
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.Sas}", UriKind.RelativeOrAbsolute));

			}
			else if (code.ToLower().StartsWith("ek"))
			{
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.fe}", UriKind.RelativeOrAbsolute));
			}
		}

		private void Button_Click_Start(object sender, RoutedEventArgs e)
		{
			land.IsEnabled = true;
			combo.IsEnabled = true;
			start.IsEnabled = false;
			_eventMessage.DateTime = DateTime.Now;
		}

		private void Button_Click_Land(object sender, RoutedEventArgs e)
		{
			_eventMessage.Status = $"Landed";
			_eventMessage.DateTime = DateTime.Now;
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			_eventMessage.Status = $"Now Heading to {combo.SelectedItem}";
			_eventMessage.DateTime = DateTime.Now;
		}
	}
}
