using System.Windows;

namespace assign5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		/// <summary>Initializes a new instance of the <see cref="MainWindow" /> class.</summary>
		public MainWindow()
		{
			InitializeComponent();
		}
		/// <summary>Handles the Click event of the Button control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (!ReadInput()) return;
			FlightInfoEventHandler flightHandler = OnTransmit;
			var flightWindow = new FlightWindow(Box.Text, flightHandler);
			flightWindow.Show();
		}
		/// <summary>Raises the <see cref="E:Transmit" /> event.</summary>
		/// <param name="flightInfo">The <see cref="FlightInfoEventArgs" /> instance containing the event data.</param>
		public void OnTransmit(FlightInfoEventArgs flightInfo) => listView.Items.Add(flightInfo);
		/// <summary>Reads the input.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		private bool ReadInput()
		{
			if (!string.IsNullOrEmpty(Box.Text)) return true;
			MessageBox.Show("Flight code must be inserted");
			return false;
		}
	}
}
