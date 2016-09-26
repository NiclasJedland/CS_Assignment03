namespace Assignment03
{
	partial class MainScreen
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
			if(disposing && (components != null))
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
			this.btnNorth = new System.Windows.Forms.Button();
			this.btnWest = new System.Windows.Forms.Button();
			this.btnEast = new System.Windows.Forms.Button();
			this.btnSouth = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.pnlControls = new System.Windows.Forms.Panel();
			this.btnSouthEast = new System.Windows.Forms.Button();
			this.btnSouthWest = new System.Windows.Forms.Button();
			this.btnNorthWest = new System.Windows.Forms.Button();
			this.btnNorthEast = new System.Windows.Forms.Button();
			this.btnPickUpItem = new System.Windows.Forms.Button();
			this.btnMergeItems = new System.Windows.Forms.Button();
			this.btnDropItem = new System.Windows.Forms.Button();
			this.btnUseItem = new System.Windows.Forms.Button();
			this.btnMap = new System.Windows.Forms.Button();
			this.lblDaysLeft = new System.Windows.Forms.Label();
			this.lblDaysLeftText = new System.Windows.Forms.Label();
			this.pnlMinimap = new System.Windows.Forms.Panel();
			this.pnlFullmap = new System.Windows.Forms.Panel();
			this.pnlDescription = new System.Windows.Forms.Panel();
			this.lblListViewItemDescription = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.pnlItems = new System.Windows.Forms.Panel();
			this.lstInventory = new System.Windows.Forms.ListView();
			this.pnlControls.SuspendLayout();
			this.pnlDescription.SuspendLayout();
			this.pnlItems.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNorth
			// 
			this.btnNorth.Location = new System.Drawing.Point(656, 4);
			this.btnNorth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNorth.Name = "btnNorth";
			this.btnNorth.Size = new System.Drawing.Size(152, 66);
			this.btnNorth.TabIndex = 0;
			this.btnNorth.Text = "North";
			this.btnNorth.UseVisualStyleBackColor = true;
			this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
			// 
			// btnWest
			// 
			this.btnWest.Location = new System.Drawing.Point(496, 78);
			this.btnWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnWest.Name = "btnWest";
			this.btnWest.Size = new System.Drawing.Size(152, 66);
			this.btnWest.TabIndex = 1;
			this.btnWest.Text = "West";
			this.btnWest.UseVisualStyleBackColor = true;
			this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
			// 
			// btnEast
			// 
			this.btnEast.Location = new System.Drawing.Point(816, 78);
			this.btnEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEast.Name = "btnEast";
			this.btnEast.Size = new System.Drawing.Size(152, 66);
			this.btnEast.TabIndex = 2;
			this.btnEast.Text = "East";
			this.btnEast.UseVisualStyleBackColor = true;
			this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
			// 
			// btnSouth
			// 
			this.btnSouth.Location = new System.Drawing.Point(656, 151);
			this.btnSouth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSouth.Name = "btnSouth";
			this.btnSouth.Size = new System.Drawing.Size(152, 66);
			this.btnSouth.TabIndex = 3;
			this.btnSouth.Text = "South";
			this.btnSouth.UseVisualStyleBackColor = true;
			this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(656, 78);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(152, 66);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// pnlControls
			// 
			this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlControls.Controls.Add(this.btnSouthEast);
			this.pnlControls.Controls.Add(this.btnSouthWest);
			this.pnlControls.Controls.Add(this.btnNorthWest);
			this.pnlControls.Controls.Add(this.btnNorthEast);
			this.pnlControls.Controls.Add(this.btnPickUpItem);
			this.pnlControls.Controls.Add(this.btnMergeItems);
			this.pnlControls.Controls.Add(this.btnDropItem);
			this.pnlControls.Controls.Add(this.btnUseItem);
			this.pnlControls.Controls.Add(this.btnMap);
			this.pnlControls.Controls.Add(this.btnNorth);
			this.pnlControls.Controls.Add(this.btnSearch);
			this.pnlControls.Controls.Add(this.btnWest);
			this.pnlControls.Controls.Add(this.btnSouth);
			this.pnlControls.Controls.Add(this.btnEast);
			this.pnlControls.Location = new System.Drawing.Point(16, 418);
			this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(1013, 233);
			this.pnlControls.TabIndex = 5;
			// 
			// btnSouthEast
			// 
			this.btnSouthEast.Location = new System.Drawing.Point(816, 151);
			this.btnSouthEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSouthEast.Name = "btnSouthEast";
			this.btnSouthEast.Size = new System.Drawing.Size(152, 66);
			this.btnSouthEast.TabIndex = 15;
			this.btnSouthEast.Text = "South East";
			this.btnSouthEast.UseVisualStyleBackColor = true;
			this.btnSouthEast.Click += new System.EventHandler(this.btnSouthEast_Click);
			// 
			// btnSouthWest
			// 
			this.btnSouthWest.Location = new System.Drawing.Point(496, 151);
			this.btnSouthWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSouthWest.Name = "btnSouthWest";
			this.btnSouthWest.Size = new System.Drawing.Size(152, 66);
			this.btnSouthWest.TabIndex = 14;
			this.btnSouthWest.Text = "South West";
			this.btnSouthWest.UseVisualStyleBackColor = true;
			this.btnSouthWest.Click += new System.EventHandler(this.btnSouthWest_Click);
			// 
			// btnNorthWest
			// 
			this.btnNorthWest.Location = new System.Drawing.Point(496, 4);
			this.btnNorthWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNorthWest.Name = "btnNorthWest";
			this.btnNorthWest.Size = new System.Drawing.Size(152, 66);
			this.btnNorthWest.TabIndex = 13;
			this.btnNorthWest.Text = "North West";
			this.btnNorthWest.UseVisualStyleBackColor = true;
			this.btnNorthWest.Click += new System.EventHandler(this.btnNorthWest_Click);
			// 
			// btnNorthEast
			// 
			this.btnNorthEast.Location = new System.Drawing.Point(816, 4);
			this.btnNorthEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNorthEast.Name = "btnNorthEast";
			this.btnNorthEast.Size = new System.Drawing.Size(152, 66);
			this.btnNorthEast.TabIndex = 12;
			this.btnNorthEast.Text = "North East";
			this.btnNorthEast.UseVisualStyleBackColor = true;
			this.btnNorthEast.Click += new System.EventHandler(this.btnNorthEast_Click);
			// 
			// btnPickUpItem
			// 
			this.btnPickUpItem.Location = new System.Drawing.Point(168, 4);
			this.btnPickUpItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPickUpItem.Name = "btnPickUpItem";
			this.btnPickUpItem.Size = new System.Drawing.Size(152, 66);
			this.btnPickUpItem.TabIndex = 11;
			this.btnPickUpItem.Text = "Pick Up Item";
			this.btnPickUpItem.UseVisualStyleBackColor = true;
			this.btnPickUpItem.Click += new System.EventHandler(this.btnPickUpItem_Click);
			// 
			// btnMergeItems
			// 
			this.btnMergeItems.Location = new System.Drawing.Point(8, 151);
			this.btnMergeItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMergeItems.Name = "btnMergeItems";
			this.btnMergeItems.Size = new System.Drawing.Size(152, 66);
			this.btnMergeItems.TabIndex = 10;
			this.btnMergeItems.Text = "Merge Items";
			this.btnMergeItems.UseVisualStyleBackColor = true;
			this.btnMergeItems.Click += new System.EventHandler(this.btnMergeItems_Click);
			// 
			// btnDropItem
			// 
			this.btnDropItem.Location = new System.Drawing.Point(8, 78);
			this.btnDropItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDropItem.Name = "btnDropItem";
			this.btnDropItem.Size = new System.Drawing.Size(152, 66);
			this.btnDropItem.TabIndex = 9;
			this.btnDropItem.Text = "Drop Item";
			this.btnDropItem.UseVisualStyleBackColor = true;
			this.btnDropItem.Click += new System.EventHandler(this.btnDropItem_Click);
			// 
			// btnUseItem
			// 
			this.btnUseItem.Location = new System.Drawing.Point(8, 4);
			this.btnUseItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUseItem.Name = "btnUseItem";
			this.btnUseItem.Size = new System.Drawing.Size(152, 66);
			this.btnUseItem.TabIndex = 8;
			this.btnUseItem.Text = "Use Item";
			this.btnUseItem.UseVisualStyleBackColor = true;
			this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
			// 
			// btnMap
			// 
			this.btnMap.Location = new System.Drawing.Point(168, 151);
			this.btnMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMap.Name = "btnMap";
			this.btnMap.Size = new System.Drawing.Size(152, 66);
			this.btnMap.TabIndex = 5;
			this.btnMap.Text = "Toggle Map";
			this.btnMap.UseVisualStyleBackColor = true;
			this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
			// 
			// lblDaysLeft
			// 
			this.lblDaysLeft.AutoSize = true;
			this.lblDaysLeft.Location = new System.Drawing.Point(93, 374);
			this.lblDaysLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDaysLeft.Name = "lblDaysLeft";
			this.lblDaysLeft.Size = new System.Drawing.Size(16, 17);
			this.lblDaysLeft.TabIndex = 7;
			this.lblDaysLeft.Text = "0";
			// 
			// lblDaysLeftText
			// 
			this.lblDaysLeftText.AutoSize = true;
			this.lblDaysLeftText.Location = new System.Drawing.Point(13, 374);
			this.lblDaysLeftText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDaysLeftText.Name = "lblDaysLeftText";
			this.lblDaysLeftText.Size = new System.Drawing.Size(72, 17);
			this.lblDaysLeftText.TabIndex = 6;
			this.lblDaysLeftText.Text = "Days Left:";
			// 
			// pnlMinimap
			// 
			this.pnlMinimap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlMinimap.Location = new System.Drawing.Point(16, 15);
			this.pnlMinimap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlMinimap.Name = "pnlMinimap";
			this.pnlMinimap.Size = new System.Drawing.Size(296, 201);
			this.pnlMinimap.TabIndex = 6;
			// 
			// pnlFullmap
			// 
			this.pnlFullmap.Location = new System.Drawing.Point(16, 15);
			this.pnlFullmap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlFullmap.Name = "pnlFullmap";
			this.pnlFullmap.Size = new System.Drawing.Size(1015, 396);
			this.pnlFullmap.TabIndex = 7;
			// 
			// pnlDescription
			// 
			this.pnlDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlDescription.Controls.Add(this.lblListViewItemDescription);
			this.pnlDescription.Controls.Add(this.lblDescription);
			this.pnlDescription.Controls.Add(this.lblDaysLeftText);
			this.pnlDescription.Controls.Add(this.lblDaysLeft);
			this.pnlDescription.Location = new System.Drawing.Point(317, 15);
			this.pnlDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlDescription.Name = "pnlDescription";
			this.pnlDescription.Size = new System.Drawing.Size(712, 395);
			this.pnlDescription.TabIndex = 8;
			// 
			// lblListViewItemDescription
			// 
			this.lblListViewItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblListViewItemDescription.Location = new System.Drawing.Point(17, 260);
			this.lblListViewItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblListViewItemDescription.Name = "lblListViewItemDescription";
			this.lblListViewItemDescription.Size = new System.Drawing.Size(669, 101);
			this.lblListViewItemDescription.TabIndex = 9;
			this.lblListViewItemDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblDescription
			// 
			this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescription.Location = new System.Drawing.Point(17, 87);
			this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(669, 166);
			this.lblDescription.TabIndex = 8;
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlItems
			// 
			this.pnlItems.Controls.Add(this.lstInventory);
			this.pnlItems.Location = new System.Drawing.Point(16, 224);
			this.pnlItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlItems.Name = "pnlItems";
			this.pnlItems.Size = new System.Drawing.Size(297, 187);
			this.pnlItems.TabIndex = 0;
			// 
			// lstInventory
			// 
			this.lstInventory.Location = new System.Drawing.Point(8, 4);
			this.lstInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lstInventory.MultiSelect = false;
			this.lstInventory.Name = "lstInventory";
			this.lstInventory.Size = new System.Drawing.Size(284, 179);
			this.lstInventory.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lstInventory.TabIndex = 1;
			this.lstInventory.UseCompatibleStateImageBehavior = false;
			this.lstInventory.View = System.Windows.Forms.View.List;
			this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 660);
			this.Controls.Add(this.pnlDescription);
			this.Controls.Add(this.pnlItems);
			this.Controls.Add(this.pnlMinimap);
			this.Controls.Add(this.pnlFullmap);
			this.Controls.Add(this.pnlControls);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Main Screen";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.pnlControls.ResumeLayout(false);
			this.pnlDescription.ResumeLayout(false);
			this.pnlDescription.PerformLayout();
			this.pnlItems.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNorth;
		private System.Windows.Forms.Button btnWest;
		private System.Windows.Forms.Button btnEast;
		private System.Windows.Forms.Button btnSouth;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Button btnMap;
		private System.Windows.Forms.Panel pnlMinimap;
		private System.Windows.Forms.Panel pnlFullmap;
		private System.Windows.Forms.Panel pnlDescription;
		private System.Windows.Forms.Panel pnlItems;
		private System.Windows.Forms.Label lblDaysLeft;
		private System.Windows.Forms.Label lblDaysLeftText;
		private System.Windows.Forms.Button btnDropItem;
		private System.Windows.Forms.Button btnUseItem;
		private System.Windows.Forms.Button btnMergeItems;
		private System.Windows.Forms.Button btnPickUpItem;
		private System.Windows.Forms.ListView lstInventory;
		private System.Windows.Forms.Button btnSouthEast;
		private System.Windows.Forms.Button btnSouthWest;
		private System.Windows.Forms.Button btnNorthWest;
		private System.Windows.Forms.Button btnNorthEast;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblListViewItemDescription;
	}
}

