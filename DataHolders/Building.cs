namespace TermCraft {
	public class Building {

		public Inventory inventory { get; private set; }

		public string name { get; private set; }
		public string desc { get; private set; }
		public double value { get; private set; }
		public short level { get; private set; }

		public readonly string[] availableCommands = new string[4] { "produce", "cancel", "upgrade", "etc" };


		public enum Type { Bank, Store, Home, Quarry, etc }
		public Type type { get; private set; }

		public Building (Type type, double value, string name, string desc) {
			this.type = type;
			this.value = value;
			this.name = name;
			this.desc = desc;
			inventory = new Inventory();
			level = 1;
		}
		public Building (Type type, double value, string name, string desc, Inventory inventory, short level) {
			this.type = type;
			this.value = value;
			this.name = name;
			this.desc = desc;
			this.inventory = inventory;
			this.level = level;
		}
	}
}
