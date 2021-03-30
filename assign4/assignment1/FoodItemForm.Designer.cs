
namespace assignment1
{
	partial class FoodItemForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.g = new System.Windows.Forms.GroupBox();
			this.cancelBtm = new System.Windows.Forms.Button();
			this.okBtm = new System.Windows.Forms.Button();
			this.removeBtm = new System.Windows.Forms.Button();
			this.changeBtm = new System.Windows.Forms.Button();
			this.addBtm = new System.Windows.Forms.Button();
			this.ingredientTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.g.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(143, 44);
			this.NameTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(303, 22);
			this.NameTxt.TabIndex = 1;
			// 
			// g
			// 
			this.g.Controls.Add(this.listBox);
			this.g.Controls.Add(this.cancelBtm);
			this.g.Controls.Add(this.okBtm);
			this.g.Controls.Add(this.removeBtm);
			this.g.Controls.Add(this.changeBtm);
			this.g.Controls.Add(this.addBtm);
			this.g.Controls.Add(this.ingredientTxt);
			this.g.Controls.Add(this.label2);
			this.g.Location = new System.Drawing.Point(21, 97);
			this.g.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.g.Name = "g";
			this.g.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.g.Size = new System.Drawing.Size(451, 425);
			this.g.TabIndex = 2;
			this.g.TabStop = false;
			this.g.Text = "Ingredients";
			// 
			// cancelBtm
			// 
			this.cancelBtm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtm.Location = new System.Drawing.Point(290, 350);
			this.cancelBtm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.cancelBtm.Name = "cancelBtm";
			this.cancelBtm.Size = new System.Drawing.Size(121, 48);
			this.cancelBtm.TabIndex = 7;
			this.cancelBtm.Text = "Cancel";
			this.cancelBtm.UseVisualStyleBackColor = true;
			// 
			// okBtm
			// 
			this.okBtm.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okBtm.Location = new System.Drawing.Point(123, 350);
			this.okBtm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.okBtm.Name = "okBtm";
			this.okBtm.Size = new System.Drawing.Size(121, 48);
			this.okBtm.TabIndex = 6;
			this.okBtm.Text = "Ok";
			this.okBtm.UseVisualStyleBackColor = true;
			this.okBtm.Click += new System.EventHandler(this.okBtm_Click);
			// 
			// removeBtm
			// 
			this.removeBtm.Location = new System.Drawing.Point(12, 270);
			this.removeBtm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.removeBtm.Name = "removeBtm";
			this.removeBtm.Size = new System.Drawing.Size(90, 33);
			this.removeBtm.TabIndex = 5;
			this.removeBtm.Text = "Remove";
			this.removeBtm.UseVisualStyleBackColor = true;
			this.removeBtm.Click += new System.EventHandler(this.removeBtm_Click);
			// 
			// changeBtm
			// 
			this.changeBtm.Location = new System.Drawing.Point(12, 200);
			this.changeBtm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.changeBtm.Name = "changeBtm";
			this.changeBtm.Size = new System.Drawing.Size(90, 33);
			this.changeBtm.TabIndex = 4;
			this.changeBtm.Text = "Change";
			this.changeBtm.UseVisualStyleBackColor = true;
			this.changeBtm.Click += new System.EventHandler(this.changeBtm_Click);
			// 
			// addBtm
			// 
			this.addBtm.Location = new System.Drawing.Point(12, 132);
			this.addBtm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.addBtm.Name = "addBtm";
			this.addBtm.Size = new System.Drawing.Size(90, 33);
			this.addBtm.TabIndex = 3;
			this.addBtm.Text = "Add";
			this.addBtm.UseVisualStyleBackColor = true;
			this.addBtm.Click += new System.EventHandler(this.addBtm_Click);
			// 
			// ingredientTxt
			// 
			this.ingredientTxt.Location = new System.Drawing.Point(123, 48);
			this.ingredientTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.ingredientTxt.Name = "ingredientTxt";
			this.ingredientTxt.Size = new System.Drawing.Size(303, 22);
			this.ingredientTxt.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ingredient";
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(123, 118);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(302, 212);
			this.listBox.TabIndex = 8;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// FoodItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 536);
			this.Controls.Add(this.g);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "FoodItemForm";
			this.Text = "Form2";
			this.g.ResumeLayout(false);
			this.g.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameTxt;
		private System.Windows.Forms.GroupBox g;
		private System.Windows.Forms.Button cancelBtm;
		private System.Windows.Forms.Button okBtm;
		private System.Windows.Forms.Button removeBtm;
		private System.Windows.Forms.Button changeBtm;
		private System.Windows.Forms.Button addBtm;
		private System.Windows.Forms.TextBox ingredientTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox;
	}
}