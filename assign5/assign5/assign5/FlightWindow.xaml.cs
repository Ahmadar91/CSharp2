using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace assign5
{
	public partial class FlightWindow
	{
		private readonly FlightInfoEventHandler _flightHandler;
		private string Code { get; }
		public FlightWindow(string code, FlightInfoEventHandler flightHandler)
		{
			_flightHandler = flightHandler;
			InitializeComponent();
			InitializeGUI();
			Code = code;
			ChooseImage(code);
			Title = code;
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
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.sas}", UriKind.RelativeOrAbsolute));

			}
			else if (code.ToLower().StartsWith("ek"))
			{
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.fe}", UriKind.RelativeOrAbsolute));
			}
			else if (code.ToLower().StartsWith("ba"))
			{
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.br}", UriKind.RelativeOrAbsolute));
			}
		}

		private void Button_Click_Start(object sender, RoutedEventArgs e)
		{
			land.IsEnabled = true;
			combo.IsEnabled = true;
			start.IsEnabled = false;
			Event("Started");
		}

		private void Button_Click_Land(object sender, RoutedEventArgs e) => Event("Landed");

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var route = $"Now Heading to {combo.SelectedItem}";
			Event(route);
		}
		private void Event(string route) => _flightHandler(new FlightInfoEventArgs(Code, route));

	}
}
