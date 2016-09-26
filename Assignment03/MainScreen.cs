using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			InitializeComponent();

			//Hide Fullmap, Show everything else
			pnlFullmap.Hide();
			pnlMinimap.Show();
			pnlItems.Show();
			pnlDescription.Show();
			pnlControls.Show();

			lblDaysLeft.Text = Player.player.DaysLeft.ToString();

			Map.map.PopulateMapWithTiles();
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{
			Player.player.StartLocation();

			foreach(var item in Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item)
			{
				lblDescription.Text += "\nYou found " + item.Name + ".";
			}

			GetSurroundingTilesToText();
			lblDescription.Text = "You wake up confused with a small map in your hands.\nYou find a small map and some rations beside you.";
		}

		public void GetSurroundingTilesToText()
		{
			Player.player.GetSurrounding();

			lblDescription.Text = Player.player.CurrentLocationTile.Story;

			btnNorth.Text = "North:\n" + Player.player.North.Type;
			btnSouth.Text = "South:\n" + Player.player.South.Type;
			btnEast.Text = "East:\n" + Player.player.East.Type;
			btnWest.Text = "West:\n" + Player.player.West.Type;

			btnNorthEast.Text = "North East:\n" + Player.player.NorthEast.Type;
			btnNorthWest.Text = "North West:\n" + Player.player.NorthWest.Type;
			btnSouthEast.Text = "South East:\n" + Player.player.SouthEast.Type;
			btnSouthWest.Text = "South West:\n" + Player.player.SouthWest.Type;

			btnSearch.Text = "Search:\n" + Player.player.CurrentLocationTile.Type;
			if(Player.player.CurrentLocationTile.Searched)
			{				
				btnSearch.Text += "\nAlready Searched";
				if(Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item.Count > 0)
				{
					foreach(var item in Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item)
					{
						lblDescription.Text += "\nYou found " + item.Name + ".";
					}
				}
				else
					lblDescription.Text += "\nYou didn't find anything.";
			}
			if(Player.player.CurrentLocationTile.Type == Tile.TileType.End)
			{
				Player.player.GameOver("Congratulations!\nYou Won!");
			}
			Player.player.GetSurrounding();
			Map.map.DrawMap(pnlFullmap, pnlMinimap);
		}
		
		private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblListViewItemDescription.Text = "";
			Inventory.inventory.ShowItemDescription(lblListViewItemDescription, lstInventory);
		}

		#region Buttons
		#region MovementButtons
		private void btnNorth_Click(object sender, EventArgs e)
		{
			Player.player.GoNorth(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnWest_Click(object sender, EventArgs e)
		{
			Player.player.GoWest(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnEast_Click(object sender, EventArgs e)
		{
			Player.player.GoEast(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnSouth_Click(object sender, EventArgs e)
		{
			Player.player.GoSouth(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnNorthWest_Click(object sender, EventArgs e)
		{
			Player.player.GoNorthWest(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnNorthEast_Click(object sender, EventArgs e)
		{
			Player.player.GoNorthEast(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnSouthWest_Click(object sender, EventArgs e)
		{
			Player.player.GoSouthWest(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}

		private void btnSouthEast_Click(object sender, EventArgs e)
		{
			Player.player.GoSouthEast(lblDaysLeft, lblListViewItemDescription);
			GetSurroundingTilesToText();
		}
		#endregion

		#region Misc Buttons
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Player.player.SearchTile(lblDaysLeft);
			GetSurroundingTilesToText();
		}

		private void btnUseItem_Click(object sender, EventArgs e)
		{
			Inventory.inventory.UseItem(lblDaysLeft, lstInventory);
			GetSurroundingTilesToText();
		}

		private void btnPickUpItem_Click(object sender, EventArgs e)
		{
			Inventory.inventory.PickUpItem(lblDaysLeft, lstInventory);
			GetSurroundingTilesToText();
		}

		private void btnDropItem_Click(object sender, EventArgs e)
		{
			Inventory.inventory.DropItem(lblDaysLeft, lstInventory);
			GetSurroundingTilesToText();
		}

		private void btnMergeItems_Click(object sender, EventArgs e)
		{
			Inventory.inventory.MergeItem(lblDaysLeft, lstInventory);
			GetSurroundingTilesToText();
		}

		private void btnMap_Click(object sender, EventArgs e)
		{
			Player.player.MapState = !Player.player.MapState;

			switch(Player.player.MapState)
			{
				case false://Minimap
					pnlFullmap.Hide();
					pnlMinimap.Show();
					pnlDescription.Show();
					pnlItems.Show();
					break;
				case true://Fullmap
					pnlFullmap.Show();
					pnlMinimap.Hide();
					pnlDescription.Hide();
					pnlItems.Hide();
					break;
				default:
					break;
			}
			Map.map.DrawMap(pnlFullmap, pnlMinimap);
		}
		#endregion

		#endregion
	}
}
