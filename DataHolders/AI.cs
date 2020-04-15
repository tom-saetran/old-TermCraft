namespace TermCraft {
	public class AI {
		public Inventory inventory { get; private set; }
		public string name { get; private set; }
		public short level { get; private set; }

		public enum Type { Investor, Banker, Secretary, Advisor, etc }
		public Type type { get; private set; }

		public AI (Type type, string name) {
			this.type = type;
			this.name = name;
			level = 1;
			inventory = new Inventory();
			Register.AddToRegister(this);
		}
		public AI (Type type, string name, Inventory inventory, short level) {
			this.type = type;
			this.name = name;
			this.level = level;
			this.inventory = inventory;
			Register.AddToRegister(this);
		}
		// uses same classes as player have access to to operate
	}
}
