using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace assign5
{
	public partial class FlightWindow
	{
		private readonly FlightInfoEventHandler _flightEventHandler;
		private string Code { get; }
		/// <summary>Initializes a new instance of the <see cref="FlightWindow" /> class.</summary>
		/// <param name="code">The code.</param>
		/// <param name="flightEventHandler">The flight event handler.</param>
		public FlightWindow(string code, FlightInfoEventHandler flightEventHandler)
		{
			_flightEventHandler = flightEventHandler;
			InitializeComponent();
			InitializeGUI();
			Code = code;
			ChooseImage(code);
			Title = code;
			Event("Sent to runway");
		}
		/// <summary>Initializes the GUI.</summary>
		private void InitializeGUI()
		{
			land.IsEnabled = false;
			combo.IsEnabled = false;
			combo.ItemsSource = new List<string> { "30 deg", "Berlin", "Stockholm", "London" };
		}
		/// <summary>Chooses the image.</summary>
		/// <param name="code">The code.</param>
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
			else
			{
				Image.Source = new BitmapImage(new Uri($@"pack://application:,,,{Resource.def}", UriKind.RelativeOrAbsolute));
			}
		}
		/// <summary>Handles the Start event of the Button_Click control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
		private void Button_Click_Start(object sender, RoutedEventArgs e)
		{
			land.IsEnabled = true;
			combo.IsEnabled = true;
			start.IsEnabled = false;
			Event("Started");
		}
		/// <summary>Handles the Land event of the Button_Click control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
		private void Button_Click_Land(object sender, RoutedEventArgs e) => Event("Landed");
		/// <summary>Handles the SelectionChanged event of the ComboBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var route = $"Now Heading to {combo.SelectedItem}";
			Event(route);
		}
		/// <summary>Events the specified route.</summary>
		/// <param name="route">The route.</param>
		private void Event(string route) => _flightEventHandler(new FlightInfoEventArgs(Code, route));
	}
}
