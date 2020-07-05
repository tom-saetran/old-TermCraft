namespace TermCraft {

	/// <summary>
	/// The <see cref="Market"/> is used to convey items around
	/// </summary>
	public static class Market {

		/// <summary>
		/// The <see cref="Inventory"/> attached to this <see cref="Market"/>
		/// </summary>
		public static Inventory inventory { get; private set; }

		/// <summary>
		/// Initializes the <see cref="inventory"/> of the <see cref="Market"/> 
		/// </summary>
		public static void Init () { inventory = new Inventory(); }

		/// <summary>
		/// An array of the available commands at the <see cref="Market"/> 
		/// </summary>
		public static readonly string[] availableCommands = new string[4] { "buy", "sell", "leave", "etc" };

		/// <summary>
		/// Add a single <see cref="Item"/> to the <see cref="Market"/>
		/// </summary>
		/// <param name="item">The <see cref="Item"/> to add</param>
		/// <param name="amount">How many of the <see cref="Item"/> to add</param>
		/// <param name="price">The price of the <see cref="Item"/> to add</param>
		public static void AddToMarket (Item item, int amount, double price) { }

		/// <summary>
		/// Adds multiple <see cref="Item"/> to the <see cref="Market"/>
		/// </summary>
		/// <param name="items">The array of <see cref="Item"/> to add</param>
		/// <param name="amounts">How many of the various <see cref="Item"/> to add</param>
		/// <param name="prices">The price of the various <see cref="Item"/> to add</param>
		public static void AddToMarket (Item[] items, int[] amounts, double[] prices) { }

		/// <summary>
		/// Buys a specified <see cref="Item"/> from the <see cref="Market"/>
		/// </summary>
		/// <param name="item">What <see cref="Item"/> to buy</param>
		/// <param name="amount">How many of the <see cref="Item"/> to buy
		/// </param>
		public static void BuyFromMarket (Item item, int amount) { }
	}
}
