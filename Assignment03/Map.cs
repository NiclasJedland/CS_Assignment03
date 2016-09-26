using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TEST
namespace Assignment03
{
	public class Map
	{
		public static Random rnd = new Random();
		public static Map map = new Map();

		public static int gridSize = 12;  //12 original
		public static Tile[,] GameMap = new Tile[gridSize, gridSize];

		public void PopulateMapWithTiles()
		{
			for(int y = 0; y < gridSize; y++)
			{
				for(int x = 0; x < gridSize; x++)
				{
					if(x == 0 || x == gridSize - 1 || y == 0 || y == gridSize - 1 || y == 4) //mountain around the playarea, and row 5
					{
						GameMap[x, y] = new Tile(Tile.TileType.Mountain, true, true, -100, -100, Color.Red, new List<ItemClass>() { },
							"");
						continue;
					}
					if(GetRandomRations(10))//10% tile of plains gives a ration
					{
						if(GetRandomRations(10))
							GameMap[x, y] = new Tile(Tile.TileType.Plains, false, false, -1, -0.25f, Color.White, new List<ItemClass>() { Inventory.inventory.Ration },
								"There are grass as far as the eye can see. Maybe some berries or fruit if you look hard enough!");
						else
							GameMap[x, y] = new Tile(Tile.TileType.Plains, false, false, -1, -0.25f, Color.White, new List<ItemClass>() { Inventory.inventory.SmallRation },
								"There are grass as far as the eye can see. Maybe some berries or fruit if you look hard enough!");
					}
					else
					{
						if(GetRandomRations(10))// 10% will give a false positive of ration
							GameMap[x, y] = new Tile(Tile.TileType.Plains, false, false, -1, -0.25f, Color.White, new List<ItemClass>() { },
								"There are grass as far as the eye can see. Maybe some berries or fruit if you look hard enough!");
						else
							GameMap[x, y] = new Tile(Tile.TileType.Plains, false, false, -1, -0.25f, Color.White, new List<ItemClass>() { },
								"There are grass as far as the eye can see.");
					}
				}
			}
			
			int mountains = 5;
			int cave = 2;
			bool caveItem = true;
			int village = 1;
			bool villageItem = true;
			int forest = 10;
			bool forestItem = true;
			int swamp = 5;
			bool swampItem = true;
			int water = 3;
			bool waterItem = true;

			while(mountains > 0)// randomize mountain tiles
			{
				mountains--;
				var mountainLocation = GetRandomLocation(2, gridSize - 2, 6, gridSize - 2); // not on the edges
				if(cave > 0)
				{
					cave--;
					if(caveItem)
					{
						caveItem = false;
						GameMap[mountainLocation[0], mountainLocation[1]] = new Tile(Tile.TileType.Cave, true, false, -3, -3, Color.Red, new List<ItemClass>() { Inventory.inventory.MysteriousStone },
							"A cave with a mysterious stone inside.");
					}
					else
						GameMap[mountainLocation[0], mountainLocation[1]] = new Tile(Tile.TileType.Cave, true, false, -3, -3, Color.Red, new List<ItemClass>() { Inventory.inventory.MagicStone},
							"A cave with a magical stone inside.");
				}
				else
					GameMap[mountainLocation[0], mountainLocation[1]] = new Tile(Tile.TileType.Mountain, true, true, -100, -100, Color.Red, new List<ItemClass>() { },
						"");
			}

			while(forest > 0)// randomize forest tiles
			{
				forest--;
				var forestLocation = GetRandomLocation(1, gridSize - 1, 5, gridSize - 1);
				if(forestItem)
				{
					forestItem = false;
					GameMap[forestLocation[0], forestLocation[1]] = new Tile(Tile.TileType.Forest, false, false, -2, -1, Color.DarkGreen, new List<ItemClass>() { Inventory.inventory.MysteriousStone },
						"A large forest. You happen apon a mysterious stone.");
				}
				else if(GetRandomRations(5))// 20% chance of a ration item
					GameMap[forestLocation[0], forestLocation[1]] = new Tile(Tile.TileType.Forest, false, false, -2, -1, Color.DarkGreen, new List<ItemClass>() { Inventory.inventory.SmallRation },
						"A large forest. Seems to be some mushrooms lying about.");
				else
					GameMap[forestLocation[0], forestLocation[1]] = new Tile(Tile.TileType.Forest, false, false, -2, -1, Color.DarkGreen, new List<ItemClass>() { },
						"A large forest.");
			}

			while(swamp > 0)// randomize swamp tiles
			{
				swamp--;
				var swampLocation = GetRandomLocation(1, gridSize - 1, 5, gridSize - 1);
				if(swampItem)
				{
					swampItem = false;
					GameMap[swampLocation[0], swampLocation[1]] = new Tile(Tile.TileType.Swamp, false, false, -5, -2.5f, Color.Chocolate, new List<ItemClass>() { Inventory.inventory.LargePaper },
						"You find a witch hut in the middle of the swamp. You find a magical paper inside.");
				}
				else if(GetRandomRations(2))// 50% chance of a ration item
				{
					if(GetRandomRations(2))// 50% chance to larger ration
					{
						if(GetRandomRations(10))// 10% chance to largest ration
						{
							GameMap[swampLocation[0], swampLocation[1]] = new Tile(Tile.TileType.Swamp, false, false, -5, -2.5f, Color.Chocolate, new List<ItemClass>() { Inventory.inventory.LargeRation },
								"Swampy Marsh. You happen apon a large dead bear you can harvest for a lot of ration.");
						}
						else
							GameMap[swampLocation[0], swampLocation[1]] = new Tile(Tile.TileType.Swamp, false, false, -5, -2.5f, Color.Chocolate, new List<ItemClass>() { Inventory.inventory.Ration},
								"A wetland. Looks like a good fishing spot.");
					}
					else
						GameMap[swampLocation[0], swampLocation[1]] = new Tile(Tile.TileType.Swamp, false, false, -5, -2.5f, Color.Chocolate, new List<ItemClass>() { Inventory.inventory.SmallRation },
							"A forest marsh. Seems to be some mushrooms lying about.");
				}
				else
					GameMap[swampLocation[0], swampLocation[1]] = new Tile(Tile.TileType.Swamp, false, false, -5, -2.5f, Color.Chocolate, new List<ItemClass>() { },
						"A large swampy marsh.");
			}

			while(water > 0)// randomize water tiles
			{
				water--;
				var waterLocation = GetRandomLocation(1, gridSize - 1, 5, gridSize - 1);
				if(waterItem)
				{
					waterItem = false;
					GameMap[waterLocation[0], waterLocation[1]] = new Tile(Tile.TileType.Water, false, false, -2, -1, Color.Blue, new List<ItemClass>() { Inventory.inventory.MagicStone },
						"A magical hot spring. A shimmering stone lies in the hot spring.");
				}
				else if(GetRandomRations(3))// 33% chance of a ration item
					GameMap[waterLocation[0], waterLocation[1]] = new Tile(Tile.TileType.Water, false, false, -2, -1, Color.Blue, new List<ItemClass>() { Inventory.inventory.SmallRation },
						"A river. Looks like a good fishing spot");
				else
					GameMap[waterLocation[0], waterLocation[1]] = new Tile(Tile.TileType.Water, false, false, -2, -1, Color.Blue, new List<ItemClass>() { },
						"A dead lake.");
			}

			while(village > 0)// randomize village tiles
			{
				village--;
				var villageLocation = GetRandomLocation(1, gridSize - 1, 5, gridSize - 1);
				if(villageItem)
				{
					villageItem = false;
					GameMap[villageLocation[0], villageLocation[1]] = new Tile(Tile.TileType.Village, false, false, -1, -0.5f, Color.Orange, new List<ItemClass>() { Inventory.inventory.MagicStone },
						"A villager has a magical stone. You can make large rations from 2 rations in a village.");
				}
				else
					GameMap[villageLocation[0], villageLocation[1]] = new Tile(Tile.TileType.Village, false, false, -1, -0.5f, Color.Orange, new List<ItemClass>() { Inventory.inventory.MysteriousStone },
						"A villager has a mysterious stone. You can make large rations from 2 rations in a village.");
			}

			var endLocation = GetRandomLocation(1, gridSize - 1, 1, 4); //End game, you win!
			GameMap[endLocation[0], endLocation[1]] = new Tile(Tile.TileType.End, true, true, 0, 0, Color.Turquoise, new List<ItemClass>() { },
				"Congratulations!\nYou reached the end of the game!");

			var portalLocation = GetRandomLocation(1, gridSize - 1, 5, gridSize - 1);//Startlocation teleport
			GameMap[portalLocation[0], portalLocation[1]] = new Tile(Tile.TileType.Monolith, false, false, -1, -0.5f, Color.Purple, new List<ItemClass>() { },  
				"You come across a mysterious monolith. There is a socket to put something in it.");

			var portalEndLocation = GetRandomLocation(1, gridSize - 1, 1, 4); //Endlocation teleport
			GameMap[portalEndLocation[0], portalEndLocation[1]] = new Tile(Tile.TileType.Monolith, false, false, -1, -0.5f, Color.Purple, new List<ItemClass>() { }, 
				"The monolith teleported you to another place.Are you closer to your destination?");
		}

		//Teleport from a monolith to another
		public void Teleport()
		{
			if(Inventory.YourInventory.Contains(Inventory.inventory.PortalStone))
			{
				int portal1y = -1;
				int portal1x = -1;
				int portal2y = -1;
				int portal2x = -1;
				int count = 0;

				if(Player.player.CurrentLocationTile.Type == Tile.TileType.Monolith)
				{
					for(int y = 0; y < gridSize; y++)
					{
						if(count == 2)
							break;
						for(int x = 0; x < gridSize; x++)
						{
							if(count == 2)
								break;
							if(GameMap[x, y].Type == Tile.TileType.Monolith)
							{
								if(count == 0)
								{
									portal1x = x;
									portal1y = y;
									count++;
								}
								else if(count == 1)
								{
									portal2x = x;
									portal2y = y;
									break;
								}
							}
						}
					}
				}

				if(portal1y == Player.player.CurrentYLocation && portal1x == Player.player.CurrentXLocation)
				{
					Player.player.CurrentXLocation = portal2x;
					Player.player.CurrentYLocation = portal2y;
				}
				else
				{
					Player.player.CurrentXLocation = portal1x;
					Player.player.CurrentYLocation = portal1y;
				}
			}
		}
		//Get a random location, not overlapping anything else than plains the majority will be plains.
		public List<int> GetRandomLocation(int startX, int endX, int startY, int endY)
		{
			int posX = rnd.Next(startX, endX);
			int posY = rnd.Next(startY, endY);
			while(GameMap[posX, posY].Type != Tile.TileType.Plains)
			{
				posX = rnd.Next(startX, endX);
				posY = rnd.Next(startY, endY);
			}
			return new List<int>() { posX, posY };
		}

		//x amount of times a tile will be have some rations.
		public bool GetRandomRations(int rate)
		{
			return rnd.Next(0, rate) == 0 ? true : false;
		}
		//Draw map and minimap
		public void DrawMap(Panel pnlFullmap, Panel pnlMinimap)
		{
			pnlFullmap.Invalidate();
			pnlMinimap.Invalidate();
			pnlFullmap.Update();
			pnlMinimap.Update();

			int xDisplaceFull = 250;
			int yDisplaceFull = 30;
			int pixFull = 22;
			Graphics fullMap = pnlFullmap.CreateGraphics();

			int xDisplaceMini = 100;
			int yDisplaceMini = 75;
			int pixMini = 25;
			Graphics minimap = pnlMinimap.CreateGraphics();

			Pen p = new Pen(Color.Black, 2);
			SolidBrush sb = new SolidBrush(Color.Gray);

			//Fullmap
			if(Inventory.YourInventory.Contains(Inventory.inventory.LargeMap))
			{
				for(int y = 0; y < gridSize; y++)
				{
					for(int x = 0; x < gridSize; x++)
					{
						sb.Color = Color.Gray;
						if(GameMap[x, y].Type == Tile.TileType.Mountain)
							sb.Color = GameMap[x, y].Color;
						if(GameMap[x, y].Visited)
							sb.Color = GameMap[x, y].Color;

						fullMap.DrawRectangle(p, pixFull * x + xDisplaceFull, pixFull * y + yDisplaceFull, pixFull, pixFull);
						fullMap.FillRectangle(sb, pixFull * x + xDisplaceFull, pixFull * y + yDisplaceFull, pixFull, pixFull);
					}
				}
			}

			//Minimap
			if(Inventory.YourInventory.Contains(Inventory.inventory.SmallMapActivated))
			{
				for(int y = -2; y < 3; y++)
				{
					for(int x = -2; x < 3; x++)
					{
						if(Player.player.CurrentXLocation + x >= 0 && Player.player.CurrentYLocation + y >= 0 && Player.player.CurrentXLocation + x < Map.gridSize && Player.player.CurrentYLocation + y < Map.gridSize)
						{
							sb.Color = Color.Gray;
							if(Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Type == Tile.TileType.Mountain)
								sb.Color = Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Color;
							if(Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Visited)
								sb.Color = Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Color;

							if(x == 0 && y == 0)
								sb.Color = Color.Black;

							minimap.DrawRectangle(p, pixMini * x + xDisplaceMini, pixMini * y + yDisplaceMini, pixMini, pixMini);
							minimap.FillRectangle(sb, pixMini * x + xDisplaceMini, pixMini * y + yDisplaceMini, pixMini, pixMini);

							if(Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Searched && Map.GameMap[Player.player.CurrentXLocation + x, Player.player.CurrentYLocation + y].Item.Count > 0)
							{
								sb.Color = Color.Black;
								minimap.DrawEllipse(p, pixMini * x + xDisplaceMini, pixMini * y + yDisplaceMini, 7.5f, 7.5f);
								minimap.FillEllipse(sb, pixMini * x + xDisplaceMini, pixMini * y + yDisplaceMini, 7.5f, 7.5f);
							}
						}
					}
				}
			}

			//the current tile
			sb.Color = Color.Black;
			fullMap.DrawRectangle(p, pixFull * Player.player.CurrentXLocation + xDisplaceFull, pixFull * Player.player.CurrentYLocation + yDisplaceFull, pixFull, pixFull);
			fullMap.FillRectangle(sb, pixFull * Player.player.CurrentXLocation + xDisplaceFull, pixFull * Player.player.CurrentYLocation + yDisplaceFull, pixFull, pixFull);
		}
	}
}