using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class Inventory {
		public List<Item> items { get; private set; }

		public void AddItem (int slot, Item item) {
			// evolve check logic, remove slot as requirement, find space
			items[slot] = item;
		}
		public void RemoveItem (int slot) {
			// evolve check logic, replace slot with item + amount
			items[slot] = null;
		}
	}
}
