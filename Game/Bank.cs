using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {

	/// <summary>
	/// The <see cref="Bank"/> keeps track of which account numbers are in use
	/// </summary>
	static class Bank {

		/// <summary>
		/// A <see cref="List{T}"/> over the currently used account numbers
		/// </summary>
		public static List<long> accountNumbersInUse { get; private set; }

		/// <summary>
		/// First 4 digits of <see cref="accountNumbersInUse"/>
		/// </summary>
		private static List<int> accountNumbersInUse1_4;

		/// <summary>
		/// Middle 2 digits of <see cref="accountNumbersInUse"/>
		/// </summary>
		private static List<int> accountNumbersInUse5_6;

		/// <summary>
		/// Last 5 digits of <see cref="accountNumbersInUse"/>
		/// </summary>
		private static List<int> accountNumbersInUse7_11;

		/// <summary>
		/// Initializes <see cref="accountNumbersInUse"/>, <see cref="accountNumbersInUse1_4"/>, <see cref="accountNumbersInUse5_6"/> and <see cref="accountNumbersInUse7_11"/>
		/// </summary>
		public static void Init () {
			accountNumbersInUse = new List<long>();
			accountNumbersInUse1_4 = new List<int>();
			accountNumbersInUse5_6 = new List<int>();
			accountNumbersInUse7_11 = new List<int>();
		}

		/// <summary>
		/// Checks if <paramref name="accountNumber"/> is already in use
		/// </summary>
		/// <param name="accountNumber">The <paramref name="accountNumber"/> to check</param>
		/// <returns>Returns <see langword="true"/> if the account is in use</returns>
		private static bool IsAccountInUse (long accountNumber) {
			if (accountNumbersInUse1_4.Contains(int.Parse(accountNumber.ToString(Program.CultureInfo).Substring(0, 4), Program.CultureInfo)))
				if (accountNumbersInUse5_6.Contains(int.Parse(accountNumber.ToString(Program.CultureInfo).Substring(4, 2), Program.CultureInfo)))
					if (accountNumbersInUse7_11.Contains(int.Parse(accountNumber.ToString(Program.CultureInfo).Substring(6, 5), Program.CultureInfo)))
						return true;
			return false;
		}

		/// <summary>
		/// Returns a unique bank account number of type <see cref="long"/> and adds it to <see cref="accountNumbersInUse"/>
		/// </summary>
		/// <returns>A unique bank account number</returns>
		public static long AddAccount () {
			long res = GenerateNumber();

			if (IsAccountInUse(res))
				 res = GenerateNumber();

			accountNumbersInUse.Add(res);
			int a = int.Parse(res.ToString(Program.CultureInfo).Substring(0, 4), Program.CultureInfo);
			int b = int.Parse(res.ToString(Program.CultureInfo).Substring(4, 2), Program.CultureInfo);
			int c = int.Parse(res.ToString(Program.CultureInfo).Substring(6, 5), Program.CultureInfo);

			accountNumbersInUse1_4.Add(a);
			accountNumbersInUse5_6.Add(b);
			accountNumbersInUse7_11.Add(c);
			return res;
		}

		/// <summary>
		/// Genereates a random number from 20000000000 to 99999999999
		/// </summary>
		/// <returns>A random number from 20000000000 to 99999999999</returns>
		private static long GenerateNumber () {
			long min = 20000000000;
			long max = 99999999999;
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

		/// <summary>
		/// Removes the given <paramref name="accountNumber"/> if it exist
		/// </summary>
		/// <param name="accountNumber">The account number to remove</param>
		public static void RemoveAccount (long accountNumber) { }
	}
}
