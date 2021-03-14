
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
			this.label2 = new System.Windows.Forms.Label();
			this.ingredientTxt = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.addBtm = new System.Windows.Forms.Button();
			this.changeBtm = new System.Windows.Forms.Button();
			this.removeBtm = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.g.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(340, 101);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(715, 44);
			this.NameTxt.TabIndex = 1;
			// 
			// g
			// 
			this.g.Controls.Add(this.button5);
			this.g.Controls.Add(this.button4);
			this.g.Controls.Add(this.removeBtm);
			this.g.Controls.Add(this.changeBtm);
			this.g.Controls.Add(this.addBtm);
			this.g.Controls.Add(this.listView1);
			this.g.Controls.Add(this.ingredientTxt);
			this.g.Controls.Add(this.label2);
			this.g.Location = new System.Drawing.Point(49, 224);
			this.g.Name = "g";
			this.g.Size = new System.Drawing.Size(1070, 982);
			this.g.TabIndex = 2;
			this.g.TabStop = false;
			this.g.Text = "Ingredients";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ingredient";
			// 
			// ingredientTxt
			// 
			this.ingredientTxt.Location = new System.Drawing.Point(291, 110);
			this.ingredientTxt.Name = "ingredientTxt";
			this.ingredientTxt.Size = new System.Drawing.Size(715, 44);
			this.ingredientTxt.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(291, 288);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(685, 456);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// addBtm
			// 
			this.addBtm.Location = new System.Drawing.Point(28, 306);
			this.addBtm.Name = "addBtm";
			this.addBtm.Size = new System.Drawing.Size(213, 77);
			this.addBtm.TabIndex = 3;
			this.addBtm.Text = "Add";
			this.addBtm.UseVisualStyleBackColor = true;
			// 
			// changeBtm
			// 
			this.changeBtm.Location = new System.Drawing.Point(28, 462);
			this.changeBtm.Name = "changeBtm";
			this.changeBtm.Size = new System.Drawing.Size(213, 77);
			this.changeBtm.TabIndex = 4;
			this.changeBtm.Text = "Change";
			this.changeBtm.UseVisualStyleBackColor = true;
			// 
			// removeBtm
			// 
			this.removeBtm.Location = new System.Drawing.Point(28, 624);
			this.removeBtm.Name = "removeBtm";
			this.removeBtm.Size = new System.Drawing.Size(213, 77);
			this.removeBtm.TabIndex = 5;
			this.removeBtm.Text = "Remove";
			this.removeBtm.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(291, 810);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(288, 110);
			this.button4.TabIndex = 6;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(688, 810);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(288, 110);
			this.button5.TabIndex = 7;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// FoodItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 1239);
			this.Controls.Add(this.g);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button removeBtm;
		private System.Windows.Forms.Button changeBtm;
		private System.Windows.Forms.Button addBtm;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox ingredientTxt;
		private System.Windows.Forms.Label label2;
	}
}