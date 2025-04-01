using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Game.Items;

namespace Text_Game
{
    public class Inventory
    {
        public List<Item> list;
        public Inventory()
        {
            list = new List<Item>();
        }

        public void AddItem(Item item)
        {
            list.Add(item);
        }

        public void RemoveItem(Item item)
        {
            list.Remove(item);
        }
    }
}
