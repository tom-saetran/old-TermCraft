using System;
using System.Collections.Generic;

namespace TermCraft {

	/// <summary>
	/// Data class for <see cref="Inventory"/>. Used by other entites such as <see cref="AI"/>/<see cref="Building"/>/<see cref="Market"/>/<see cref="Player"/>
	/// </summary>
	public class Inventory {

		/// <summary>
		/// A list of type <see cref="Tuple{T1, T2}"/> containing the current amount of <see cref="Item"/> held in this <see cref="Inventory"/>
		/// </summary>
		public List<Tuple <Item, int>> contents { get; private set; }

		/// <summary>
		/// The current set balance of this <see cref="Inventory"/>
		/// </summary>
		public double bankBalance { get; private set; }

		/// <summary>
		/// Holds an eleven-digit unique number
		/// </summary>
		public long bankAccountNumber { get; private set; }

		/// <summary>
		/// A <see cref="string"/> representation of <see cref="bankAccountNumber"/> formatted to xxxx.xx.xxxxx
		/// </summary>
		public string bankAccountNumberFormatted { get; private set; }

		/// <summary>
		/// The maximum negative number <see cref="bankBalance"/> can be set to
		/// </summary>
		public double grantedCredit { get; private set; }

		/// <summary>
		/// Sets <see cref="bankAccountNumber"/> to an unique value and initializes <see cref="contents"/>
		/// </summary>
		public Inventory () {
			bankAccountNumber = Bank.AddAccount();

			bankAccountNumberFormatted = bankAccountNumber.ToString(new System.Globalization.CultureInfo("en-US", false));
			bankAccountNumberFormatted = bankAccountNumberFormatted.Insert(4, ".");
			bankAccountNumberFormatted = bankAccountNumberFormatted.Insert(7, ".");

			bankBalance = 0;
			grantedCredit = 0;
			contents = new List<Tuple<Item, int>>();
		}

		/// <summary>
		/// Sets <see cref="grantedCredit"/> to <paramref name="limit"/>
		/// </summary>
		/// <param name="limit">The maximum number that can be set negative</param>
		public void SetCreditLimit (double limit) { grantedCredit = limit; }

		/// <summary>
		/// Adds the specified <paramref name="amount"/> of type <see cref="Item"/>
		/// </summary>
		/// <param name="item">The <see cref="Item"/> to add</param>
		/// <param name="amount">The amount of <paramref name="item"/> to add</param>
		public void AddItem (Item item, int amount) { }

		/// <summary>
		/// Removes the specified <paramref name="amount"/> of type <see cref="Item"/>
		/// </summary>
		/// <param name="item">The <see cref="Item"/> to remove</param>
		/// <param name="amount">The amount of <paramref name="item"/> to remove</param>
		public void RemoveItem (Item item, int amount) { }

		/// <summary>
		/// Adds the specified <paramref name="amounts"/>[] of type <see cref="Item"/>[]
		/// </summary>
		/// <param name="items">The array of type <see cref="Item"/> to add</param>
		/// <param name="amounts">The array of amount of <paramref name="items"/> to add</param>
		public void AddItems (Item[] items, int[] amounts) {
			for (int i = 0; i < items.Length; i++) {
				AddItem(items[i], amounts[i]);
			}
		}

		/// <summary>
		/// Removes the specified <paramref name="amounts"/>[] of type <see cref="Item"/>[]
		/// </summary>
		/// <param name="items">The array of type <see cref="Item"/> to remove</param>
		/// <param name="amounts">The array of amount of <paramref name="items"/> to remove</param>
		public void RemoveItems (Item[] items, int[] amounts) {
			for (int i = 0; i < items.Length; i++) {
				RemoveItem(items[i], amounts[i]);
			}
		}

		/// <summary>
		/// Adds <paramref name="amount"/> to <see cref="bankBalance"/>.
		/// Number can be negative for subtraction
		/// </summary>
		/// <param name="amount">The amount to add to <see cref="bankBalance"/></param>
		/// <returns><see langword="true"/> if successful, <see langword="false"/> if failed</returns>
		public bool ChangeBalance(double amount) { 
			if (bankBalance + amount >= grantedCredit) {
				bankBalance += amount;
				return true;
			}
			return false;
		}
	}
}
