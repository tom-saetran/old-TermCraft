using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	static class Register {
		public static List<AI> AIs { get; private set; } 
		public static List<Building> Buildings { get; private set; }

		public static void Init () {
			AIs = new List<AI>();
			Buildings = new List<Building>();
		}

		public static bool BankAccountNumberInUse (long bankAccountNumber) {
			if (Player.inventory != null && Player.inventory.bankAccountNumber == bankAccountNumber)
				return true;
		
			for (int i = 0; i < AIs.Count; i++) {
				if (AIs[i].inventory.bankAccountNumber == bankAccountNumber)
					return true;
			}
			for (int i = 0; i < Buildings.Count; i++) {
				if (Buildings[i].inventory.bankAccountNumber == bankAccountNumber)
					return true;
			}
			return false;
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
