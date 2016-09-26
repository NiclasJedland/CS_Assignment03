using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
	public class Tile
	{
		public bool Visited { get; set; }
		public bool Searched { get; set; }
		public TileType Type { get; set; }
		public float Cost { get; set; } 
		public float SearchCost { get; set; }
		public Color Color { get; set; }
		public List<ItemClass> Item { get; set; } = new List<ItemClass>();
		public string Story { get; set; }

		public Tile(TileType type, bool visited, bool searched, float cost, float searchCost, Color color, List<ItemClass> item, string story)
		{
			Type = type;
			Visited = visited;
			Searched = searched;
			Cost = cost;
			SearchCost = searchCost;
			Color = color;
			Item = item;
			Story = story;
		}

		public enum TileType
		{
			Mountain, Plains, Swamp, Water, Forest, Village, Cave, Monolith, End
		}
	}
}
