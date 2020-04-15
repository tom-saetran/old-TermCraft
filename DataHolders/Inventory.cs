using System;
using System.Collections.Generic;

namespace TermCraft {
	public class Inventory {
		public List<Tuple <Item, int>> contents { get; private set; }
		public double bankBalance { get; private set; }
		public long bankAccountNumber { get; private set; }
		public string bankAccountNumberFormatted { get; private set; }
		public double grantedCredit { get; private set; }

		public Inventory () {
			bankAccountNumber = SetBankAccountNumber(20000000000, 99999999999);

			if (Register.BankAccountNumberInUse(bankAccountNumber))
				bankAccountNumber = SetBankAccountNumber(20000000000, 99999999999);

			bankAccountNumberFormatted = bankAccountNumber.ToString();
			bankAccountNumberFormatted = bankAccountNumberFormatted.Insert(4, ".");
			bankAccountNumberFormatted = bankAccountNumberFormatted.Insert(7, ".");

			bankBalance = 0;
			grantedCredit = 0;
			contents = new List<Tuple<Item, int>>();
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
		public void SetCreditLimit (double limit) { grantedCredit = limit; }
		public void AddItem (Item item, int amount) { }
		public void RemoveItem (Item item, int amount) { }
		public void AddItems (Item[] items, int[] amounts) {
			for (int i = 0; i < items.Length; i++) {
				AddItem(items[i], amounts[i]);
			}
		}
		public void RemoveItems (Item[] items, int[] amounts) {
			for (int i = 0; i < items.Length; i++) {
				RemoveItem(items[i], amounts[i]);
			}
		}
		public bool ChangeBalance(double amount) { 
			if (bankBalance + amount >= grantedCredit) {
				bankBalance += amount;
				return true;
			}
			return false;
		}
	}
}
