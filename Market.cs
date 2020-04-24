namespace TermCraft {
	public static class Market {
		public static Inventory inventory { get; private set; }

		public static void Init () { inventory = new Inventory(); }
		private static bool isActive;
		public static readonly string[] availableCommands = new string[4] { "buy", "sell", "leave", "etc" };

		public static void AddToMarket (Item item, int amount, double price) { }
		public static void AddToMarket (Item[] items, int[] amounts, double[] prices) { }
		public static void BuyFromMarket (Item item, int amount) { }
		public static void BuyFromMarket (Item[] items, int[] amounts) { }
	}
}
