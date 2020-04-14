namespace TermCraft {
	public static class Actions {
		public static void DoAction (string input) {
			switch (input.ToLower()) {
				case string s when (s == "a"):
					//
					break;

				case string s when (s == "b"):
					//
					break;

				case string s when (s == "c" || s == "char" || s == "character"):
					OpenCharacter();
					break;

				case string s when (s == "d"):
					//
					break;

				case string s when (s == "e" || s == "exit" || s == "back"):
					ReturnToLastScreen();
					break;

				case string s when (s == "f"):
					//
					break;

				case string s when (s == "g"):
					//
					break;

				case string s when (s == "h" || s == "help" || s == "?"):
					Help();
					break;

				case string s when (s == "i" || s == "inv" || s == "inventory"):
					OpenInventory();
					break;

				case string s when (s == "j"):
					//
					break;

				case string s when (s == "k"):
					//
					break;

				case string s when (s == "l"):
					//
					break;

				case string s when (s == "m" || s == "mar" || s == "market"):
					OpenMarket();
					break;

				case string s when (s == "n"):
					//
					break;

				case string s when (s == "o"):
					//
					break;

				case string s when (s == "p" || s == "pat" || s == "patreon"):
					OpenPatreon();
					break;

				case string s when (s == "q" || s == "quit"):
					Terminate();
					break;

				case string s when (s == "r"):
					//
					break;

				case string s when (s == "s" || s == "sel" || s == "select"):
					Select();
					break;

				case string s when (s == "t"):
					//
					break;

				case string s when (s == "u"):
					//
					break;

				case string s when (s == "v"):
					//
					break;

				case string s when (s == "w"):
					//
					break;

				case string s when (s == "x"):
					//
					break;

				case string s when (s == "y"):
					//
					break;

				case string s when (s == "z"):
					//
					break;

				default:
					InvalidInput();
					break;
			}
		}

		static void Help () {  }
		static void OpenInventory () {  }
		static void OpenPatreon () {  }
		static void OpenMarket () {  }
		static void OpenCharacter () {  }
		static void g () {  }
		static void Select () {  }
		static void i () {  }
		static void j () {  }
		static void k () {  }
		static void ReturnToLastScreen () {  }
		static void Terminate () {  }
		static void InvalidInput	() {  }
	}
}
