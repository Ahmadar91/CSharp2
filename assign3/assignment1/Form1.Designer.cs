
namespace assignment1
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RemoveBtm = new System.Windows.Forms.Button();
			this.upload = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.speciesSpec = new System.Windows.Forms.GroupBox();
			this.cmbCuteness = new System.Windows.Forms.ComboBox();
			this.txtBreed = new System.Windows.Forms.TextBox();
			this.lblSpeciesSpec1 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.speciesList = new System.Windows.Forms.ListBox();
			this.categoryList = new System.Windows.Forms.ListBox();
			this.ListAll = new System.Windows.Forms.CheckBox();
			this.Age = new System.Windows.Forms.TextBox();
			this.AnimalName = new System.Windows.Forms.TextBox();
			this.specifications = new System.Windows.Forms.GroupBox();
			this.cmbSpec3 = new System.Windows.Forms.ComboBox();
			this.label3Spec = new System.Windows.Forms.Label();
			this.cmbBool = new System.Windows.Forms.ComboBox();
			this.txtSpec2 = new System.Windows.Forms.TextBox();
			this.txtSpec1 = new System.Windows.Forms.TextBox();
			this.lblSpec2 = new System.Windows.Forms.Label();
			this.lblspec1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.Omni = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.foodList = new System.Windows.Forms.ListView();
			this.foodColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.animalList = new System.Windows.Forms.ListView();
			this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.animalInfo = new System.Windows.Forms.Label();
			this.foodItemsBtm = new System.Windows.Forms.Button();
			this.connectBtm = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.speciesSpec.SuspendLayout();
			this.specifications.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RemoveBtm);
			this.groupBox1.Controls.Add(this.upload);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.speciesSpec);
			this.groupBox1.Controls.Add(this.cmbGender);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.AddButton);
			this.groupBox1.Controls.Add(this.speciesList);
			this.groupBox1.Controls.Add(this.categoryList);
			this.groupBox1.Controls.Add(this.ListAll);
			this.groupBox1.Controls.Add(this.Age);
			this.groupBox1.Controls.Add(this.AnimalName);
			this.groupBox1.Controls.Add(this.specifications);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1007, 456);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Animal Specifications";
			// 
			// RemoveBtm
			// 
			this.RemoveBtm.Location = new System.Drawing.Point(622, 370);
			this.RemoveBtm.Name = "RemoveBtm";
			this.RemoveBtm.Size = new System.Drawing.Size(148, 38);
			this.RemoveBtm.TabIndex = 18;
			this.RemoveBtm.Text = "Remove";
			this.RemoveBtm.UseVisualStyleBackColor = true;
			this.RemoveBtm.Click += new System.EventHandler(this.RemoveBtm_Click);
			// 
			// upload
			// 
			this.upload.Location = new System.Drawing.Point(819, 289);
			this.upload.Name = "upload";
			this.upload.Size = new System.Drawing.Size(145, 38);
			this.upload.TabIndex = 16;
			this.upload.Text = "Upload a picture";
			this.upload.UseVisualStyleBackColor = true;
			this.upload.Click += new System.EventHandler(this.upload_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(798, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 180);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(574, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Species";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(307, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Category";
			// 
			// speciesSpec
			// 
			this.speciesSpec.Controls.Add(this.cmbCuteness);
			this.speciesSpec.Controls.Add(this.txtBreed);
			this.speciesSpec.Controls.Add(this.lblSpeciesSpec1);
			this.speciesSpec.Location = new System.Drawing.Point(352, 282);
			this.speciesSpec.Name = "speciesSpec";
			this.speciesSpec.Size = new System.Drawing.Size(260, 149);
			this.speciesSpec.TabIndex = 12;
			this.speciesSpec.TabStop = false;
			// 
			// cmbCuteness
			// 
			this.cmbCuteness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCuteness.FormattingEnabled = true;
			this.cmbCuteness.Location = new System.Drawing.Point(98, 52);
			this.cmbCuteness.Name = "cmbCuteness";
			this.cmbCuteness.Size = new System.Drawing.Size(140, 24);
			this.cmbCuteness.TabIndex = 3;
			// 
			// txtBreed
			// 
			this.txtBreed.Location = new System.Drawing.Point(98, 52);
			this.txtBreed.Name = "txtBreed";
			this.txtBreed.Size = new System.Drawing.Size(140, 22);
			this.txtBreed.TabIndex = 1;
			// 
			// lblSpeciesSpec1
			// 
			this.lblSpeciesSpec1.AutoSize = true;
			this.lblSpeciesSpec1.Location = new System.Drawing.Point(6, 59);
			this.lblSpeciesSpec1.Name = "lblSpeciesSpec1";
			this.lblSpeciesSpec1.Size = new System.Drawing.Size(0, 17);
			this.lblSpeciesSpec1.TabIndex = 0;
			// 
			// cmbGender
			// 
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Location = new System.Drawing.Point(114, 131);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(121, 24);
			this.cmbGender.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "GenderType";
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(622, 326);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(148, 38);
			this.AddButton.TabIndex = 9;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// speciesList
			// 
			this.speciesList.FormattingEnabled = true;
			this.speciesList.ItemHeight = 16;
			this.speciesList.Location = new System.Drawing.Point(517, 46);
			this.speciesList.Name = "speciesList";
			this.speciesList.Size = new System.Drawing.Size(205, 180);
			this.speciesList.TabIndex = 8;
			this.speciesList.SelectedIndexChanged += new System.EventHandler(this.speciesList_SelectedIndexChanged);
			// 
			// categoryList
			// 
			this.categoryList.FormattingEnabled = true;
			this.categoryList.ItemHeight = 16;
			this.categoryList.Location = new System.Drawing.Point(262, 46);
			this.categoryList.Name = "categoryList";
			this.categoryList.Size = new System.Drawing.Size(205, 180);
			this.categoryList.TabIndex = 7;
			this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
			// 
			// ListAll
			// 
			this.ListAll.AutoSize = true;
			this.ListAll.Location = new System.Drawing.Point(553, 245);
			this.ListAll.Name = "ListAll";
			this.ListAll.Size = new System.Drawing.Size(122, 21);
			this.ListAll.TabIndex = 6;
			this.ListAll.Text = "List all animals";
			this.ListAll.UseVisualStyleBackColor = true;
			this.ListAll.CheckedChanged += new System.EventHandler(this.ListAll_CheckedChanged);
			// 
			// Age
			// 
			this.Age.Location = new System.Drawing.Point(135, 91);
			this.Age.Name = "Age";
			this.Age.Size = new System.Drawing.Size(100, 22);
			this.Age.TabIndex = 5;
			// 
			// AnimalName
			// 
			this.AnimalName.Location = new System.Drawing.Point(135, 60);
			this.AnimalName.Name = "AnimalName";
			this.AnimalName.Size = new System.Drawing.Size(100, 22);
			this.AnimalName.TabIndex = 4;
			// 
			// specifications
			// 
			this.specifications.Controls.Add(this.cmbSpec3);
			this.specifications.Controls.Add(this.label3Spec);
			this.specifications.Controls.Add(this.cmbBool);
			this.specifications.Controls.Add(this.txtSpec2);
			this.specifications.Controls.Add(this.txtSpec1);
			this.specifications.Controls.Add(this.lblSpec2);
			this.specifications.Controls.Add(this.lblspec1);
			this.specifications.Location = new System.Drawing.Point(23, 282);
			this.specifications.Name = "specifications";
			this.specifications.Size = new System.Drawing.Size(308, 149);
			this.specifications.TabIndex = 3;
			this.specifications.TabStop = false;
			// 
			// cmbSpec3
			// 
			this.cmbSpec3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSpec3.FormattingEnabled = true;
			this.cmbSpec3.Location = new System.Drawing.Point(150, 117);
			this.cmbSpec3.Name = "cmbSpec3";
			this.cmbSpec3.Size = new System.Drawing.Size(121, 24);
			this.cmbSpec3.TabIndex = 9;
			// 
			// label3Spec
			// 
			this.label3Spec.AutoSize = true;
			this.label3Spec.Location = new System.Drawing.Point(19, 126);
			this.label3Spec.Name = "label3Spec";
			this.label3Spec.Size = new System.Drawing.Size(46, 17);
			this.label3Spec.TabIndex = 8;
			this.label3Spec.Text = "spec3";
			// 
			// cmbBool
			// 
			this.cmbBool.FormattingEnabled = true;
			this.cmbBool.Location = new System.Drawing.Point(150, 36);
			this.cmbBool.Name = "cmbBool";
			this.cmbBool.Size = new System.Drawing.Size(140, 24);
			this.cmbBool.TabIndex = 7;
			// 
			// txtSpec2
			// 
			this.txtSpec2.Location = new System.Drawing.Point(150, 80);
			this.txtSpec2.Name = "txtSpec2";
			this.txtSpec2.Size = new System.Drawing.Size(140, 22);
			this.txtSpec2.TabIndex = 6;
			// 
			// txtSpec1
			// 
			this.txtSpec1.Location = new System.Drawing.Point(150, 36);
			this.txtSpec1.Name = "txtSpec1";
			this.txtSpec1.Size = new System.Drawing.Size(140, 22);
			this.txtSpec1.TabIndex = 6;
			// 
			// lblSpec2
			// 
			this.lblSpec2.AutoSize = true;
			this.lblSpec2.Location = new System.Drawing.Point(16, 80);
			this.lblSpec2.Name = "lblSpec2";
			this.lblSpec2.Size = new System.Drawing.Size(74, 17);
			this.lblSpec2.TabIndex = 1;
			this.lblSpec2.Text = "Tail lenght";
			// 
			// lblspec1
			// 
			this.lblspec1.AutoSize = true;
			this.lblspec1.Location = new System.Drawing.Point(16, 36);
			this.lblspec1.Name = "lblspec1";
			this.lblspec1.Size = new System.Drawing.Size(82, 17);
			this.lblspec1.TabIndex = 0;
			this.lblspec1.Text = "No. of teeth";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Age";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.Omni);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.foodList);
			this.groupBox4.Controls.Add(this.animalList);
			this.groupBox4.Location = new System.Drawing.Point(12, 501);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1285, 314);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "List of registred animals";
			// 
			// Omni
			// 
			this.Omni.AutoSize = true;
			this.Omni.Location = new System.Drawing.Point(1118, 21);
			this.Omni.Name = "Omni";
			this.Omni.Size = new System.Drawing.Size(46, 17);
			this.Omni.TabIndex = 3;
			this.Omni.Text = "label4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(917, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Eater Type:";
			// 
			// foodList
			// 
			this.foodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.foodColumn});
			this.foodList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.foodList.HideSelection = false;
			this.foodList.LabelWrap = false;
			this.foodList.Location = new System.Drawing.Point(907, 49);
			this.foodList.Name = "foodList";
			this.foodList.Size = new System.Drawing.Size(360, 239);
			this.foodList.TabIndex = 1;
			this.foodList.UseCompatibleStateImageBehavior = false;
			this.foodList.View = System.Windows.Forms.View.List;
			// 
			// foodColumn
			// 
			this.foodColumn.Text = "food";
			this.foodColumn.Width = 197;
			// 
			// animalList
			// 
			this.animalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.IdHeader,
			this.NameHeader,
			this.AgeHeader,
			this.GenderHeader});
			this.animalList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.animalList.HideSelection = false;
			this.animalList.Location = new System.Drawing.Point(337, 21);
			this.animalList.Name = "animalList";
			this.animalList.Size = new System.Drawing.Size(549, 267);
			this.animalList.TabIndex = 0;
			this.animalList.UseCompatibleStateImageBehavior = false;
			this.animalList.View = System.Windows.Forms.View.Details;
			this.animalList.SelectedIndexChanged += new System.EventHandler(this.animalList_SelectedIndexChanged);
			// 
			// IdHeader
			// 
			this.IdHeader.Text = "Id";
			this.IdHeader.Width = 97;
			// 
			// NameHeader
			// 
			this.NameHeader.Text = "Name";
			// 
			// AgeHeader
			// 
			this.AgeHeader.Text = "Age";
			// 
			// GenderHeader
			// 
			this.GenderHeader.Text = "Gender";
			this.GenderHeader.Width = 134;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.animalInfo);
			this.groupBox5.Location = new System.Drawing.Point(12, 550);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(331, 239);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Animal Info";
			// 
			// animalInfo
			// 
			this.animalInfo.AutoSize = true;
			this.animalInfo.Location = new System.Drawing.Point(10, 34);
			this.animalInfo.Name = "animalInfo";
			this.animalInfo.Size = new System.Drawing.Size(31, 17);
			this.animalInfo.TabIndex = 0;
			this.animalInfo.Text = "info";
			// 
			// foodItemsBtm
			// 
			this.foodItemsBtm.Location = new System.Drawing.Point(1108, 380);
			this.foodItemsBtm.Name = "foodItemsBtm";
			this.foodItemsBtm.Size = new System.Drawing.Size(148, 38);
			this.foodItemsBtm.TabIndex = 10;
			this.foodItemsBtm.Text = "Food Items";
			this.foodItemsBtm.UseVisualStyleBackColor = true;
			this.foodItemsBtm.Click += new System.EventHandler(this.foodItemsBtm_Click);
			// 
			// connectBtm
			// 
			this.connectBtm.Location = new System.Drawing.Point(1108, 447);
			this.connectBtm.Name = "connectBtm";
			this.connectBtm.Size = new System.Drawing.Size(148, 38);
			this.connectBtm.TabIndex = 12;
			this.connectBtm.Text = "ConnectFood";
			this.connectBtm.UseVisualStyleBackColor = true;
			this.connectBtm.Click += new System.EventHandler(this.connectBtm_Click);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(1045, 62);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(289, 292);
			this.listBox.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1384, 860);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.connectBtm);
			this.Controls.Add(this.foodItemsBtm);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "AnimalManager";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.speciesSpec.ResumeLayout(false);
			this.speciesSpec.PerformLayout();
			this.specifications.ResumeLayout(false);
			this.specifications.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ListBox speciesList;
		private System.Windows.Forms.ListBox categoryList;
		private System.Windows.Forms.CheckBox ListAll;
		private System.Windows.Forms.TextBox Age;
		private System.Windows.Forms.TextBox AnimalName;
		private System.Windows.Forms.GroupBox specifications;
		private System.Windows.Forms.TextBox txtSpec2;
		private System.Windows.Forms.TextBox txtSpec1;
		private System.Windows.Forms.Label lblSpec2;
		private System.Windows.Forms.Label lblspec1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox speciesSpec;
		private System.Windows.Forms.TextBox txtBreed;
		private System.Windows.Forms.Label lblSpeciesSpec1;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label animalInfo;
		private System.Windows.Forms.ComboBox cmbCuteness;
		private System.Windows.Forms.ComboBox cmbBool;
		private System.Windows.Forms.ComboBox cmbSpec3;
		private System.Windows.Forms.Label label3Spec;
		private System.Windows.Forms.Button upload;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView foodList;
		private System.Windows.Forms.ListView animalList;
		private System.Windows.Forms.ColumnHeader IdHeader;
		private System.Windows.Forms.ColumnHeader NameHeader;
		private System.Windows.Forms.ColumnHeader AgeHeader;
		private System.Windows.Forms.ColumnHeader GenderHeader;
		private System.Windows.Forms.ColumnHeader foodColumn;
		private System.Windows.Forms.Label Omni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button RemoveBtm;
		private System.Windows.Forms.Button foodItemsBtm;
		private System.Windows.Forms.Button connectBtm;
		private System.Windows.Forms.ListBox listBox;
	}
}

