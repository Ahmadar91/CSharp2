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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assign5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (ReadInput())
			{
				FlightInfoEventHandler flightHandler = OnTransmit;
				FlightWindow flightWindow = new FlightWindow(Box.Text, flightHandler);
				flightWindow.Show();
			}
		}

		public void OnTransmit(FlightInfoEventArgs e) => listView.Items.Add(e);

		private bool ReadInput()
		{
			if (string.IsNullOrEmpty(Box.Text))
			{
				MessageBox.Show("Flight code must be inserted");
				return false;
			}
			return true;
		}

	}
}
