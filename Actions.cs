using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Actions {
		public static void TestInput (string input) {
			switch (input.ToLower()) {
				case string s when (s == "h" || s == "help" || s == "?"):
					Help();
					break;

				case string s when (s == "i" || s == "inv" || s == "inventory"):
					OpenInventory();
					break;

				case string s when (s == "" || s == "" || s == ""):
					OpenInventory();
					break;

				case string s when (s == "q" || s == "quit"):
					Terminate();
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
		public static void Terminate () {  }
		public static void InvalidInput	() {  }
	}
}
