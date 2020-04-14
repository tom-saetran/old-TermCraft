using System;
using System.Collections.Generic;

namespace TermCraft {
	public static class Name {
		static string[] firstNames;
		static string[] middleNames;
		static string[] lastNames;

		const float middleNameChance = 0.2f;

		public static void Init () {
			FirstNames();
			MiddleNames();
			LastNames();
		}

		//sepereate gendered names to avoid male-female or female-male names with middle names.
		static void FirstNames () {
			firstNames = new string[] {
			"Mike",
			"Eva",
			"Gabriel",
			"Olga",
			"Thomas",
			"Peter",
			"Gus",
			"Glen",
			"Sandra"
			};
		}
		static void MiddleNames () {
			middleNames = new string[] {
			"O'Brian",
			"Henry",
			"Simone",
			"Helmut"
			};
		}
		static void LastNames () {
			lastNames = new string[] {
			"Smith",
			"Johnson",
			"Brown",
			"White",
			"Fox",
			"Clarkson",
			"Henderson",
			"Mauritz",
			"Wolfe"
			};
		}

		public static string Set () {
			Random rnd = new Random();
			bool setMiddleName = false;
			if (rnd.NextDouble() < middleNameChance) setMiddleName = true;

			string name = "";
			name += firstNames[rnd.Next(0, firstNames.Length)];
			name += " ";
			if (setMiddleName) {
				name += middleNames[rnd.Next(0, middleNames.Length)]; ;
				name += " ";
			}
			name += lastNames[rnd.Next(0, lastNames.Length)];

			return name;
		}
	}
}
