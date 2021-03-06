using System.Collections.Generic;

namespace TermCraft {
	/// <summary>
	/// Database class
	/// </summary>
	public static class Database {

		/// <summary>
		/// A list of all spawnable entities of type <see cref="Item"/>
		/// </summary>
		public static List<Item> items { get; private set; }

		/// <summary>
		/// A list of all spawnable entities of type <see cref="Building"/>
		/// </summary>
		public static List<Building> buildings { get; private set; }

		/// <summary>
		/// Initializes the <see cref="Database"/> and populates it
		/// </summary>
		public static void Init () {
			items = new List<Item>();
			buildings = new List<Building>();

			AddItems();
			AddBuildings();
		}

		/// <summary>
		/// Adds all premade items of type <see cref="Item"/> to <see cref="items"/>
		/// </summary>
		private static void AddItems() {
			// items.Add(new Item(Item.Type, Item.Unit, 0.00d, "", ""));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.01d, "1c", "One Fraction is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.02d, "2c", "Two Fractions is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.05d, "5c", "Five Fractions is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.10d, "10c", "Ten Fractions is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.20d, "20c", "Twenty Fractions is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 0.50d, "50c", "Fifty Fractions is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 1.00d, "100c", "One is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 2.00d, "200c", "Two is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 5.00d, "500c", "Five is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 10.00d, "1000c", "Ten is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Coin, 20.00d, "2000c", "Twenty is stamped on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Banknote, 50.00d, "5000c", "Fifty is printed on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Banknote, 100.00d, "10000c", "One Hundred is printed on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Banknote, 200.00d, "20000c", "Two Hundred is printed on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Banknote, 500.00d, "50000c", "Five Hundred is printed on one side"));
			items.Add(new Item(Item.Type.Currency, Item.Unit.Banknote, 1000.00d, "100000c", "One Thousand is printed on one side"));

			items.Add(new Item(Item.Type.RawResource, Item.Unit.Ton, 21.33d, "Sand", "Extremely annoying to get in your eyes"));
			items.Add(new Item(Item.Type.RawResource, Item.Unit.m3, 3.21d, "Water", "Proven to be possible to carry in a sieve"));
			items.Add(new Item(Item.Type.RawResource, Item.Unit.Kilogram, 4.20d, "Salt", "Makes milk taste very unpleasant"));
			items.Add(new Item(Item.Type.RawResource, Item.Unit.Gram, 42.0d, "Gold Ore", "This isn't shiny at all.."));
		}

		/// <summary>
		/// Adds all premade buildings of type <see cref="Building"/> to <see cref="buildings"/>
		/// </summary>
		private static void AddBuildings() {
			// buildings.Add(new Building(Building.Type, 0.00d, "", ""));
			buildings.Add(new Building(Building.Type.Bank, 5000000.00d, "First Bank", "A place for cash to live together", true));
			buildings.Add(new Building(Building.Type.Quarry, 232000.00d, "Sand Quarry", "A place where sand is bred and born", true));
		}
	}
}
