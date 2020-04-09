using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class Item {
		public string name { get; private set; }
		public string desc { get; private set; }
		public double value { get; private set; }

		public enum Unit { Coin, Banknote, Gram, Kilogram, Ton, m3, Milliliter, Liter, Barrel, Unit, Pallet, Container }
		public Unit unit { get; private set; }

		public enum Type { Currency, RawResource, RefinedResource, ProcessedResource }
		public Type type { get; private set; }

		public Item (Type type, Unit unit, double value, string name, string desc) {
			this.type = type;
			this.unit = unit;
			this.value = value;
			this.name = name;
			this.desc = desc;
		}
	}
}
