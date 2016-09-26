using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
	public class ItemClass
	{
		public string Name { get; set; }
		public int ItemPotency { get; set; }
		public string Description { get; set; }
		
		public ItemClass (string name,int itemPotency, string description)
		{
			Name = name;
			ItemPotency = itemPotency;
			Description = description;			
		}
	}
}
