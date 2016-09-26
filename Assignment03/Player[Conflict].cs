using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
	public class Player
	{
		public static Player player = new Player();
		public Tile North { get; set; }
		public Tile South { get; set; }
		public Tile East { get; set; }
		public Tile West { get; set; }
		public Tile NorthEast { get; set; }
		public Tile NorthWest { get; set; }
		public Tile SouthEast { get; set; }
		public Tile SouthWest { get; set; }
		public Tile CurrentLocationTile { get; set; }
		public int CurrentXLocation { get; set; }
		public int CurrentYLocation { get; set; }
		public bool MapState { get; set; }
		public float DaysLeft { get; set; } = 1;

		public float ChangeDaysLeft(float change)
		{
			return DaysLeft += change;
		}

		public void GameOver(string winner)
		{
			//TODO: Gameover
			MessageBox.Show(winner);
		}

		public void StartLocation()
		{
			var startLoc = Map.map.GetRandomLocation(1, Map.gridSize - 1, 5, Map.gridSize - 1);

			while(Map.GameMap[CurrentXLocation, CurrentYLocation].Item.Count > 0)
			{
				startLoc = Map.map.GetRandomLocation(1, Map.gridSize - 1, 5, Map.gridSize - 1);
			}
			CurrentXLocation = startLoc[0];
			CurrentYLocation = startLoc[1];

			CurrentLocationTile = Map.GameMap[CurrentXLocation, CurrentYLocation];
			Map.GameMap[CurrentXLocation, CurrentYLocation].Visited = true;
			Map.GameMap[CurrentXLocation, CurrentYLocation].Searched = true;
			Map.GameMap[CurrentXLocation, CurrentYLocation].Item.Add(Inventory.inventory.SmallPaper);
			Map.GameMap[CurrentXLocation, CurrentYLocation].Item.Add(Inventory.inventory.LargeRation);
		}

		public void GetSurrounding()
		{
			North = Map.GameMap[CurrentXLocation, CurrentYLocation - 1];
			South = Map.GameMap[CurrentXLocation, CurrentYLocation + 1];
			East = Map.GameMap[CurrentXLocation + 1, CurrentYLocation];
			West = Map.GameMap[CurrentXLocation - 1, CurrentYLocation];

			NorthEast = Map.GameMap[CurrentXLocation + 1, CurrentYLocation - 1];
			NorthWest = Map.GameMap[CurrentXLocation - 1, CurrentYLocation - 1];
			SouthEast = Map.GameMap[CurrentXLocation + 1, CurrentYLocation + 1];
			SouthWest = Map.GameMap[CurrentXLocation - 1, CurrentYLocation + 1];

			CurrentLocationTile = Map.GameMap[CurrentXLocation, CurrentYLocation];
			Map.GameMap[CurrentXLocation, CurrentYLocation].Visited = true;
		}

		#region Buttons
		public void GoNorth(Label lblDaysLeft)
		{
			if(player.North.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.North.Cost, lblDaysLeft);
				player.CurrentYLocation--;
			}
		}

		public void GoSouth(Label lblDaysLeft)
		{
			if(player.South.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.South.Cost, lblDaysLeft);
				player.CurrentYLocation++;
			}
		}

		public void GoEast(Label lblDaysLeft)
		{
			if(player.East.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.East.Cost, lblDaysLeft);
				player.CurrentXLocation++;
			}
		}

		public void GoWest(Label lblDaysLeft)
		{
			if(player.West.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.West.Cost, lblDaysLeft);
				player.CurrentXLocation--;
			}
		}

		public void GoNorthEast(Label lblDaysLeft)
		{
			if(player.NorthEast.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.NorthEast.Cost, lblDaysLeft);
				player.CurrentYLocation--;
				player.CurrentXLocation++;
			}
		}

		public void GoNorthWest(Label lblDaysLeft)
		{
			if(player.NorthWest.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.NorthWest.Cost, lblDaysLeft);
				player.CurrentYLocation--;
				player.CurrentXLocation--;
			}
		}

		public void GoSouthEast(Label lblDaysLeft)
		{
			if(player.SouthEast.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.SouthEast.Cost, lblDaysLeft);
				player.CurrentYLocation++;
				player.CurrentXLocation++;
			}
		}

		public void GoSouthWest(Label lblDaysLeft)
		{
			if(player.SouthWest.Type != Tile.TileType.Mountain)
			{
				DaysLeftText(player.SouthWest.Cost, lblDaysLeft);
				player.CurrentYLocation++;
				player.CurrentXLocation--;
			}
		}

		public void SearchTile(Label lblDaysLeft)
		{
			if(!Map.GameMap[player.CurrentXLocation, player.CurrentYLocation].Searched)
			{
				DaysLeftText(player.CurrentLocationTile.SearchCost, lblDaysLeft);
				Map.GameMap[player.CurrentXLocation, player.CurrentYLocation].Searched = true;
			}
		}

		public void DaysLeftText(float change, Label lblDaysLeft)
		{
			lblDaysLeft.Text = player.ChangeDaysLeft(change).ToString();
			if(player.DaysLeft < 0)
				player.GameOver("You were eaten by a grue!");			
		}
		#endregion

	}
}
