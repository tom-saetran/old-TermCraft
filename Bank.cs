using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	static class Bank {

		public static List<long> accountNumbersInUse { get; private set; }

		private static List<int> accountNumbersInUse1_4;
		private static List<int> accountNumbersInUse5_6;
		private static List<int> accountNumbersInUse7_11;

		public static void Init () {
			accountNumbersInUse = new List<long>();
			accountNumbersInUse1_4 = new List<int>();
			accountNumbersInUse5_6 = new List<int>();
			accountNumbersInUse7_11 = new List<int>();
		}

		private static bool IsAccountInUse (long accountNumber) {
			if (accountNumbersInUse1_4.Contains(int.Parse(accountNumber.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(0, 4))))
				if (accountNumbersInUse5_6.Contains(int.Parse(accountNumber.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(4, 2))))
					if (accountNumbersInUse7_11.Contains(int.Parse(accountNumber.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(6, 5))))
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
			int a = int.Parse(res.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(0, 4));
			int b = int.Parse(res.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(4, 2));
			int c = int.Parse(res.ToString(new System.Globalization.CultureInfo("en-US", false)).Substring(6, 5));

			accountNumbersInUse1_4.Add(a);
			accountNumbersInUse5_6.Add(b);
			accountNumbersInUse7_11.Add(c);
			return res;
		}

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

		public static void RemoveAccount (long accountNumber) { }
	}
}
