using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
	public class Inventory : Form
	{
		public static Inventory inventory = new Inventory();

		public static List<ItemClass> YourInventory = new List<ItemClass>();

		//List of all items in the game
		public ItemClass SmallRation = new ItemClass("Small Rations", 5, "Use to add rations for 2 more days!");
		public ItemClass Ration = new ItemClass("Rations", 12, "Use to add rations for 12 more days!");
		public ItemClass LargeRation = new ItemClass("Large Rations", 50, "Use to add rations for 50 more days!");

		public ItemClass PortalStone = new ItemClass("Portal Stone", 1, "Teleports you from one Portal to another.");
		public ItemClass MagicStone = new ItemClass("Magical Stone", 1, "Magical stone, does nothing on it's own.");
		public ItemClass MysteriousStone = new ItemClass("Mysterious Stone", 1, "Mysterious stone, does nothing on it's own.");

		public ItemClass SmallPaper = new ItemClass("Small Paper", 1, "Small paper you write important things on.");
		public ItemClass SmallMapActivated = new ItemClass("Small Map", 1, "Small Map you update on your travels.");

		public ItemClass LargePaper = new ItemClass("Magical Paper", 1, "A magical shiny paper. Wonder what you can do with this!");
		public ItemClass LargeMap = new ItemClass("Large Map", 1, "A large map");

		public void UseItem(Label lblDaysLeft, ListView lstInventory)
		{
			if(lstInventory.SelectedItems.Count > 0)
			{
				if(lstInventory.SelectedItems[0].Tag == inventory.PortalStone && Player.player.CurrentLocationTile.Type == Tile.TileType.Monolith)//teleport if on portal tile and have the portalstone
				{
					Player.player.DaysLeftText(Player.player.CurrentLocationTile.SearchCost, lblDaysLeft);
					Map.map.Teleport();
				}
				else if(lstInventory.SelectedItems[0].Tag == inventory.SmallPaper)//turn small paper into small map
				{
					YourInventory.Remove(inventory.SmallPaper);
					YourInventory.Add(inventory.SmallMapActivated);

					AddListViewItem(inventory.SmallMapActivated, lstInventory);
					RemoveListViewItem(inventory.SmallPaper, lstInventory);
				}
				else if(lstInventory.SelectedItems[0].Tag == inventory.SmallRation)//+5 days for small rations
				{
					Player.player.DaysLeftText(SmallRation.ItemPotency, lblDaysLeft);

					YourInventory.Remove((ItemClass)lstInventory.SelectedItems[0].Tag);
					RemoveListViewItem((ItemClass)lstInventory.SelectedItems[0].Tag, lstInventory);
				}
				else if(lstInventory.SelectedItems[0].Tag == inventory.Ration)//+10 days for small rations
				{
					Player.player.DaysLeftText(Ration.ItemPotency, lblDaysLeft);

					YourInventory.Remove((ItemClass)lstInventory.SelectedItems[0].Tag);
					RemoveListViewItem((ItemClass)lstInventory.SelectedItems[0].Tag, lstInventory);
				}

				else if(lstInventory.SelectedItems[0].Tag == inventory.LargeRation)//+50 days for rations
				{
					Player.player.DaysLeftText(LargeRation.ItemPotency, lblDaysLeft);

					YourInventory.Remove((ItemClass)lstInventory.SelectedItems[0].Tag);
					RemoveListViewItem((ItemClass)lstInventory.SelectedItems[0].Tag, lstInventory);
				}
				else
					lblDaysLeft.Text = "Can't use that item here!";

			}
		}

		public void PickUpItem(Label lblDaysLeft, ListView lstInventory)
		{
			if(Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item.Count > 0 && Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Searched)
			{
				foreach(var item in Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item)
				{
					YourInventory.Add(item);
					inventory.AddListViewItem(item, lstInventory);
					Player.player.DaysLeftText(Player.player.CurrentLocationTile.SearchCost, lblDaysLeft);
				}

				Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item.Clear();
			}
			else
				lblDaysLeft.Text = "No items to pick up!";
		}

		public void DropItem(Label lblDaysLeft, ListView lstInventory)
		{
			if(lstInventory.SelectedItems.Count > 0)
			{
				Map.GameMap[Player.player.CurrentXLocation, Player.player.CurrentYLocation].Item.Add((ItemClass)lstInventory.SelectedItems[0].Tag);

				YourInventory.Remove((ItemClass)lstInventory.SelectedItems[0].Tag);
				RemoveListViewItem((ItemClass)lstInventory.SelectedItems[0].Tag, lstInventory);

				Player.player.DaysLeftText(-0.25f, lblDaysLeft); //Fixed cost of dropping items
			}
			else
				lblDaysLeft.Text = "No item selected!";
		}

		public void MergeItem(Label lblDaysLeft, ListView lstInventory)
		{
			if(lstInventory.SelectedItems.Count > 0)
			{
				if(YourInventory.Contains(inventory.MagicStone) && YourInventory.Contains(inventory.MysteriousStone)
						&& (lstInventory.SelectedItems[0].Tag == inventory.MagicStone || lstInventory.SelectedItems[0].Tag == inventory.MysteriousStone))
				{
					YourInventory.Remove(inventory.MagicStone);
					YourInventory.Remove(inventory.MysteriousStone);
					YourInventory.Add(inventory.PortalStone);

					RemoveListViewItem(inventory.MagicStone, lstInventory);
					RemoveListViewItem(inventory.MysteriousStone, lstInventory);
					AddListViewItem(inventory.PortalStone, lstInventory);

					Player.player.DaysLeftText(Player.player.CurrentLocationTile.SearchCost, lblDaysLeft);
				}
				else if(YourInventory.Contains(inventory.LargePaper) && YourInventory.Contains(inventory.SmallMapActivated)
						&& (lstInventory.SelectedItems[0].Tag == inventory.LargePaper || lstInventory.SelectedItems[0].Tag == inventory.SmallMapActivated))
				{
					YourInventory.Remove(inventory.LargePaper);
					YourInventory.Add(inventory.LargeMap);

					RemoveListViewItem(inventory.LargePaper, lstInventory);
					AddListViewItem(inventory.LargeMap, lstInventory);

					Player.player.DaysLeftText(-3, lblDaysLeft); //3 days to scribble down the whole map
				}
				else if(YourInventory.GroupBy(n => n.Name == inventory.SmallRation.Name).Any(g => g.Count() > 1)
						&& lstInventory.SelectedItems[0].Tag == inventory.SmallRation)
				{
					YourInventory.Remove(inventory.SmallRation);
					YourInventory.Remove(inventory.SmallRation);
					YourInventory.Add(inventory.Ration);

					RemoveListViewItem(inventory.SmallRation, lstInventory);
					RemoveListViewItem(inventory.SmallRation, lstInventory);
					AddListViewItem(inventory.Ration, lstInventory);

					Player.player.DaysLeftText(-0.5f, lblDaysLeft); //0.5 days to combine rations
				}
				else if(YourInventory.GroupBy(n => n.Name == inventory.Ration.Name).Any(g => g.Count() > 1)
						&& lstInventory.SelectedItems[0].Tag == inventory.Ration
						&& Player.player.CurrentLocationTile.Type == Tile.TileType.Village)
				{
					YourInventory.Remove(inventory.Ration);
					YourInventory.Remove(inventory.Ration);
					YourInventory.Add(inventory.LargeRation);

					RemoveListViewItem(inventory.Ration, lstInventory);
					RemoveListViewItem(inventory.Ration, lstInventory);
					AddListViewItem(inventory.LargeRation, lstInventory);

					Player.player.DaysLeftText(2f, lblDaysLeft); //2 days to combine rations
				}
				else
					lblDaysLeft.Text = "Can't merge that item with anything in your inventory!";
			}
		}

		public void AddListViewItem(ItemClass obj, ListView lstInventory)
		{
			ListViewItem item = new ListViewItem();
			item.Tag = obj;
			item.Text = obj.Name;
			lstInventory.Items.Add(item);
		}

		public void RemoveListViewItem(ItemClass obj, ListView lstInventory)
		{
			ListViewItem listviewitem = new ListViewItem();
			listviewitem = GetItemtoDelete(obj.Name, lstInventory);
			if(listviewitem != null)
			{
				if(InvokeRequired)
					Invoke((MethodInvoker)delegate () { lstInventory.Items.Remove(listviewitem); });
				else
					lstInventory.Items.Remove(listviewitem);
			}
		}

		public ListViewItem GetItemtoDelete(string ClientName, ListView lstInventory)
		{
			ListViewItem listviewitem = new ListViewItem();
			for(int i = 0; i < lstInventory.Items.Count; i++)
			{
				listviewitem = lstInventory.Items[i];
				if(ClientName == listviewitem.Text)
					return listviewitem;
			}
			return null;
		}

		public void ShowItemDescription(Label lblListViewItemDescription, ListView lstInventory)
		{
			if(lstInventory.SelectedItems.Count > 0)
			{
				lblListViewItemDescription.Text += "\n" + ((ItemClass)lstInventory.SelectedItems[0].Tag).Description;
			}
		}
	}
}
