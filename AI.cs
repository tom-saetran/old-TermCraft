using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class AI {
		public Inventory inventory { get; private set; }
		public AI () { inventory = new Inventory(); }
		// uses same classes as player have access to to operate
	}
}
