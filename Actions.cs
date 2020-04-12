using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Actions {
		public static void Input (string input) {
			switch (input) {
				case string s when (s == "h" || s == "help" || s == "?"):
					Help();
					break;

				case string s when (s == "i" || s == "inv" || s == "inventory"):
					OpenInventory();
					break;

				default:
					InvalidInput();
					break;
			}
		}

		public static void Help () {  }
		public static void OpenInventory () {  }
		public static void d () {  }
		public static void e () {  }
		public static void f () {  }
		public static void g () {  }
		public static void h () {  }
		public static void i () {  }
		public static void j () {  }
		public static void k () {  }
		public static void l () {  }
		public static void m () {  }
		public static void InvalidInput () {  }
	}
}
