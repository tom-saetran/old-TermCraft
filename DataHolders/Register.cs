using System.Collections.Generic;

namespace TermCraft {
	static class Register {
		public static List<AI> AIs { get; private set; } 
		public static List<Building> Buildings { get; private set; }

		public static void Init () {
			AIs = new List<AI>();
			Buildings = new List<Building>();
		}

		public static void AddToRegister (AI ai) { AIs.Add(ai); }
		public static void AddToRegister (Building building) { Buildings.Add(building); }
		public static void RemoveFromRegister (AI ai) { 
			AIs.Remove(ai);
		}
		public static void RemoveFromRegister (Building building) {
			Buildings.Remove(building);
		}
	}
}
