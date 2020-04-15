namespace TermCraft {
	public static class Player {
		public static Inventory inventory { get; private set; }
		public static short level { get; private set; }

		public static void Init () {
			inventory = new Inventory();
			level = 1;
		}
		public static void Init (Inventory _inventory, short _level) {
			inventory = _inventory;
			level = _level;
		}
	}
}
