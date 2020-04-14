namespace TermCraft {
	class Market {
		public Inventory inventory { get; private set; }

		public Market () { inventory = new Inventory(); }
		public Market (Inventory inventory) { this.inventory = inventory; }

		// runs in own thread, buy/sell and fluctuate prices

		public void AddToMarket (Item item, int amount, double price) { }
		public void AddToMarket (Item[] items, int[] amounts, double[] prices) { }
		public void BuyFromMarket (Item item, int amount) { }
		public void BuyFromMarket (Item[] items, int[] amounts) { }
	}
}
