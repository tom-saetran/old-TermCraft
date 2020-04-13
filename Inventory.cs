using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public class Inventory {
		public List<Item> items { get; private set; }
		public double bankBalance { get; private set; }
		public long bankAccountNumber { get; private set; }

		public Inventory () {
			bankAccountNumber = SetBankAccountNumber(20000000000, 99999999999);
		}

		long SetBankAccountNumber (long min, long max) {
			Random random = new Random();
			ulong uRange = (ulong)(max - min);
			ulong ulongRand;
			do {
				byte[] buf = new byte[8];
				random.NextBytes(buf);
				ulongRand = (ulong)BitConverter.ToInt64(buf, 0);
			} while (ulongRand > ulong.MaxValue - ((ulong.MaxValue % uRange) + 1) % uRange);
			return (long)(ulongRand % uRange) + min;
		}
		public void AddItem (int slot, Item item) {
			// evolve check logic, remove slot as requirement, find space
			items[slot] = item;
		}
		public void RemoveItem (int slot) {
			// evolve check logic, replace slot with item + amount
			items[slot] = null;
		}
		public void ChangeBalance(double amount) { bankBalance += amount; }
	}
}
