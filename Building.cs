using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class Building {

		Inventory inventory;

		public string name { get; private set; }
		public string desc { get; private set; }
		public double value { get; private set; }

		public enum Type { Bank, Merchant, Home, Quarry, etc }
		public Type type { get; private set; }

		public Building (Type type, double value, string name, string desc) {
			this.type = type;
			this.value = value;
			this.name = name;
			this.desc = desc;
		}
	}
}
