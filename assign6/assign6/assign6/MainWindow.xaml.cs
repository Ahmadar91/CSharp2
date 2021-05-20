using Controller;
using Microsoft.Win32;
using Model.Models;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace assign6
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private Invoice _invoice;
		private readonly IGUIMapper _guiMapper;
		private readonly IMapper _mapper;
		public MainWindow()
		{
			_guiMapper = new GUIMapper();
			_mapper = new Mapper();
			InitializeComponent();
			InitializeGUI();
		}

		/// <summary>Initializes the GUI.</summary>
		private void InitializeGUI()
		{
			listView.Visibility = Visibility.Hidden;
			InvoiceDate.Visibility = Visibility.Hidden;
			totalBox.Visibility = Visibility.Hidden;
			DiscountLabel.Visibility = Visibility.Hidden;
			TotalLabel.Visibility = Visibility.Hidden;
			AddressLabel.Visibility = Visibility.Hidden;
			ContactLabel.Visibility = Visibility.Hidden;
			DueDateLabel.Visibility = Visibility.Hidden;
			DateLabel.Visibility = Visibility.Hidden;
			InvoiceNumberLabel.Visibility = Visibility.Hidden;
			discountBox.Visibility = Visibility.Hidden;
			DueDate.Visibility = Visibility.Hidden;
		}

		/// <summary>Handles the OnClick event of the Exit control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
		private void Exit_OnClick(object sender, RoutedEventArgs e)
		{
			Close();
		}

		/// <summary>Handles the OnClick event of the OpenInvoice control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
		private void OpenInvoice_OnClick(object sender, RoutedEventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Text files|*.txt",
				Title = "Open Invoice"
			};
			openFileDialog.ShowDialog();
			var path = openFileDialog.FileName;
			if (path != "")
			{
				try
				{
					ToggleVisibility();
					_invoice = _mapper.Map(FileParser.ReadFile(path));
					_guiMapper.Map(this, _invoice);
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message);
				}
			}
			else
				MessageBox.Show("select a correct file path");
		}

		/// <summary>Toggles the visibility.</summary>
		private void ToggleVisibility()
		{
			listView.Visibility = Visibility.Visible;
			InvoiceDate.Visibility = Visibility.Visible;
			totalBox.Visibility = Visibility.Visible;
			DiscountLabel.Visibility = Visibility.Visible;
			TotalLabel.Visibility = Visibility.Visible;
			AddressLabel.Visibility = Visibility.Visible;
			ContactLabel.Visibility = Visibility.Visible;
			DueDateLabel.Visibility = Visibility.Visible;
			DateLabel.Visibility = Visibility.Visible;
			InvoiceNumberLabel.Visibility = Visibility.Visible;
			discountBox.Visibility = Visibility.Visible;
			DueDate.Visibility = Visibility.Visible;
		}

		/// <summary>Handles the TextChanged event of the discountBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="TextChangedEventArgs" /> instance containing the event data.</param>
		private void discountBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!decimal.TryParse((sender as TextBox)?.Text, out var discount))
			{
				MessageBox.Show("Invalid input. please insert a number");
				return;
			}
			_invoice.Discount = discount;
			totalBox.Text = _invoice.TotalAmount.ToString(CultureInfo.InvariantCulture);
		}
	}
}
