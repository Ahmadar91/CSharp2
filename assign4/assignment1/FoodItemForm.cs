using Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace assignment1
{
	public partial class FoodItemForm : Form
	{
		public FoodItem FoodItem { set; get; }
		/// <summary>Initializes a new instance of the <see cref="FoodItemForm" /> class.</summary>
		public FoodItemForm()
		{
			InitializeComponent();
			FoodItem = new FoodItem();
			UpdateGui();
		}

		private void UpdateGui()
		{
		}

		/// <summary>Handles the Click event of the okBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void okBtm_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(NameTxt.Text) || listBox.Items.Count == 0)
			{
				MessageBox.Show(@"Empty Input");
				return;
			}
			FoodItem.Name = NameTxt.Text;
			FoodItem.Ingredients = GetItems();
			Close();
		}

		/// <summary>Gets the items.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		private List<string> GetItems()
		{
			var listManager = new List<string>();
			var items = listBox.Items.Cast<string>();
			foreach (var item in items)
			{
				listManager.Add(item);
			}
			return listManager;
		}

		/// <summary>Handles the Click event of the changeBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void changeBtm_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedItem != null)
			{
				if (CheckInput())
				{
					MessageBox.Show("Empty Input");
					return;
				}
				else
				{
					listBox.Items.RemoveAt(listBox.SelectedIndex);
					listBox.Items.Add(ingredientTxt.Text);
				}
			}
			else
			{
				MessageBox.Show("No selected item");
			}
			ingredientTxt.Text = "";
		}

		/// <summary>Checks the input.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		private bool CheckInput()
		{
			return string.IsNullOrEmpty(NameTxt.Text) || string.IsNullOrEmpty(ingredientTxt.Text);
		}

		/// <summary>Handles the Click event of the addBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void addBtm_Click(object sender, EventArgs e)
		{
			if (CheckInput())
			{
				MessageBox.Show("Empty input");
				return;
			}
			listBox.Items.Add(ingredientTxt.Text);
			ingredientTxt.Text = "";
		}

		/// <summary>Handles the Click event of the removeBtm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void removeBtm_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedItem != null)
			{
				listBox.Items.RemoveAt(listBox.SelectedIndex);
			}
			else
			{
				MessageBox.Show("No selected item");
			}
			ingredientTxt.Text = "";
		}

		/// <summary>Handles the SelectedIndexChanged event of the listBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox.SelectedIndex >= 0)
			{
				ingredientTxt.Text = listBox.SelectedItem.ToString();
			}
		}
	}
}
