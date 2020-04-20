namespace TermCraft {

	/// <summary>
	/// Data class for <see cref="Item"/>
	/// </summary>
	public class Item {

		/// <summary>
		/// The name of this <see cref="Item"/>
		/// </summary>
		public string name { get; private set; }

		/// <summary>
		/// The description of this <see cref="Item"/>
		/// </summary>
		public string desc { get; private set; }

		/// <summary>
		/// The value of this <see cref="Item"/>
		/// </summary>
		public double baseValue { get; private set; }

		/// <summary>
		/// Indicates if this <see cref="Item"/> is special
		/// </summary>
		public bool special { get; private set; }

		/// <summary>
		/// Enumerable list of type <see cref="Item.Unit"/>
		/// </summary>
		public enum Unit { Coin, Banknote, Gram, Kilogram, Ton, m3, Milliliter, Liter, Barrel, Unit, Pallet, Container }
		
		/// <summary>
		/// The <see cref="Unit"/> of this instance of <see cref="Item"/>
		/// </summary>
		public Unit unit { get; private set; }

		/// <summary>
		/// Enumerable list of type <see cref="Type"/>
		/// </summary>
		public enum Type { Currency, RawResource, RefinedResource, ProcessedResource }

		/// <summary>
		/// The <see cref="Type"/> of this instance of <see cref="Item"/>
		/// </summary>
		public Type type { get; private set; }

		/// <summary>
		/// Creates a new <see cref="Item"/> with the given parameters
		/// </summary>
		/// <param name="type"><see cref="Type"/> of <see cref="Item"/></param>
		/// <param name="unit"><see cref="Unit"/> of <see cref="Item"/></param>
		/// <param name="baseValue">The value of the <see cref="Item"/></param>
		/// <param name="name">The name of the <see cref="Item"/></param>
		/// <param name="desc">The description of the <see cref="Item"/></param>
		public Item (Type type, Unit unit, double baseValue, string name, string desc) {
			this.type = type;
			this.unit = unit;
			this.baseValue = baseValue;
			this.name = name;
			this.desc = desc;
			special = false;
		}

		/// <summary>
		/// Sets the <see cref="special"/> boolean of this <see cref="Item"/> to the value of <paramref name="special"/>
		/// </summary>
		/// <param name="special">The state to set <see cref="special"/> too</param>
		public void SetSpecial (bool special) { this.special = special; }
	}
}
