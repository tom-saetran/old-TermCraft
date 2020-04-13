using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class AI {
		public Inventory inventory { get; private set; }
		public short level { get; private set; }

		public enum Type { Investor, Banker, Secretary, Advisor, etc }
		public Type type { get; private set; }

		public AI (Type type) {
			inventory = new Inventory();
			this.type = type;
			level = 1;
		}
		public AI (Type type, Inventory inventory, short level) {
			this.type = type;
			this.inventory = inventory;
			this.level = level;
		}
		// uses same classes as player have access to to operate
	}
}
