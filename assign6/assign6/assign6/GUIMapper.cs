using Model.Models;

namespace assign6
{
	public class GUIMapper
	{


		public void Map(MainWindow mainWindow, Invoice invoice)
		{
			mainWindow.companyName.Text = invoice.ReceiverCompanyName;
			foreach (var item in invoice.Items)
				mainWindow.listView.Items.Add(item);
		}
	}
}