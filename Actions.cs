namespace TermCraft {
	public static class Actions {
		public static void TestInput (string input) {
			switch (input.ToLower()) {
				case string s when (s == "e" || s == "exit"):
					ReturnToLastScreen();
					break;

				case string s when (s == "h" || s == "help" || s == "?"):
					Help();
					break;

				case string s when (s == "i" || s == "inv" || s == "inventory"):
					OpenInventory();
					break;

				case string s when (s == "m" || s == "mar" || s == "market"):
					OpenMarket();
					break;

				case string s when (s == "p" || s == "pat" || s == "patreon"):
					OpenPatreon();
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
		public static void OpenPatreon () {  }
		public static void OpenMarket () {  }
		public static void f () {  }
		public static void g () {  }
		public static void h () {  }
		public static void i () {  }
		public static void j () {  }
		public static void k () {  }
		public static void ReturnToLastScreen () {  }
		public static void Terminate () {  }
		public static void InvalidInput	() {  }
	}
}
