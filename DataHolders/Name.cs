using System;
using System.Collections.Generic;

namespace TermCraft {
	public static class Name {
		static string[] femaleFirstNames;
		static string[] femaleMiddleNames;

		static string[] maleFirstNames;
		static string[] maleMiddleNames;

		static string[] lastNames;

		public enum Gender { Female, Male }
		private static readonly Gender gender;
		
		const float middleNameChance = 0.2f;

		public static void Init () {
			FemaleFirstNames();
			FemaleMiddleNames();			
			MaleFirstNames();
			MaleMiddleNames();
			LastNames();
		}

		static void FemaleFirstNames () {
			femaleFirstNames = new string[] {
			"Sara",
			"Eva",
			"Linda",
			"Olga",
			"Lucy",
			"Beatrix",
			"Gina",
			"Ronja",
			"Sandra"
			};
		}
		static void FemaleMiddleNames () {
			femaleMiddleNames = new string[] {
			"Fredrikke",
			"Leonora",
			"Belladonna",
			"Margareth"
			};
		}
		static void MaleFirstNames () {
			maleFirstNames = new string[] {
			"Mike",
			"Fritz",
			"Marco",
			"Tommy",
			"Thomas",
			"Peter",
			"Gus",
			"Glen",
			"Jim"
			};
		}
		static void MaleMiddleNames () {
			maleMiddleNames = new string[] {
			"O'Brian",
			"Henry",
			"Walter",
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
			"Wolfe",
			"James",
			"McDonald",
			"McDuck",
			"the Brave"
			};
		}
		public static string Set (Gender gender) {
			Random rnd = new Random();
			bool setMiddleName = false;
			if (rnd.NextDouble() < middleNameChance) setMiddleName = true;
			string name = "";
			if (gender == Gender.Female) {
				name += femaleFirstNames[rnd.Next(0, femaleFirstNames.Length)];
				name += " ";
				if (setMiddleName) {
					name += femaleMiddleNames[rnd.Next(0, femaleMiddleNames.Length)]; ;
					name += " ";
				}
			} else {
				name += maleFirstNames[rnd.Next(0, maleFirstNames.Length)];
				name += " ";
				if (setMiddleName) {
					name += maleMiddleNames[rnd.Next(0, maleMiddleNames.Length)]; ;
					name += " ";
				}
			}
			name += lastNames[rnd.Next(0, lastNames.Length)];
			return name;
		}
	}
}
