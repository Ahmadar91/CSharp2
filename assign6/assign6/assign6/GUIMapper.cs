using Model.Models;
using System.Globalization;

namespace assign6
{
	public class GUIMapper : IGUIMapper
	{

		/// <summary>Maps the specified main window.</summary>
		/// <param name="mainWindow">The main window.</param>
		/// <param name="invoice">The invoice.</param>
		public void Map(MainWindow mainWindow, Invoice invoice)
		{
			mainWindow.companyName.Text = invoice.ReceiverCompanyName;
			mainWindow.receiverAddress.Text = $"{invoice.ReceiverStreetAddress} \n{invoice.ReceiverZipCode} \n{invoice.ReceiverCity}" +
											  $" \n{invoice.ReceiverCountry} \n{invoice.ReceiverName}";
			mainWindow.InvoiceNumber.Text = invoice.InvoiceNumber;
			mainWindow.InvoiceDate.SelectedDate = invoice.InvoiceDate;
			mainWindow.DueDate.SelectedDate = invoice.DueDate;
			foreach (var item in invoice.Items)
				mainWindow.listView.Items.Add(item);
			mainWindow.senderContact.Text = $"{invoice.SenderPhoneNumber} \n{invoice.SenderUrl}";
			mainWindow.senderAddress.Text =
				$"{invoice.SenderCompanyName} \n{invoice.SenderStreetAddress} \n" +
				$"{invoice.SenderZipCode} {invoice.SenderCity} \n{invoice.SenderCountry}";
			mainWindow.totalBox.Text = invoice.TotalAmount.ToString(CultureInfo.InvariantCulture);
		}
	}
}