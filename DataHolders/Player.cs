namespace TermCraft {
	class Player {
		public Inventory inventory { get; private set; }
		public short level { get; private set; }

		public Player () {
			inventory = new Inventory();
			level = 1;
		}
		public Player (Inventory inventory, short level) {
			this.inventory = inventory;
			this.level = level;
		}
	}
}
