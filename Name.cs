using System;
using System.Collections.Generic;

namespace TermCraft {
	public static class Name {
		private static string[] femaleFirstNames;
		private static string[] femaleMiddleNames;

		private static string[] maleFirstNames;
		private static string[] maleMiddleNames;

		private static string[] lastNames;

		public enum Gender { Female, Male }

		private const float middleNameChance = 0.33f;
		private const float doubleLastNameChance = 0.20f;

		public static void Init () {
			FemaleFirstNames();
			FemaleMiddleNames();			
			MaleFirstNames();
			MaleMiddleNames();
			LastNames();
		}
		public static string Set (Gender gender) {
			Random rnd = new Random();
			bool setMiddleName = false;
			bool setDoubleLastName = false;
			if (rnd.NextDouble() < middleNameChance) setMiddleName = true;
			if (rnd.NextDouble() < doubleLastNameChance) setDoubleLastName = true;
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
			if (setDoubleLastName) {
				name += lastNames[rnd.Next(0, lastNames.Length)];
				name += " ";
			}
			name += lastNames[rnd.Next(0, lastNames.Length)];
			return name;
		}
		private static void FemaleFirstNames () {
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
		private static void FemaleMiddleNames () {
			femaleMiddleNames = new string[] {
			"Fredrikke",
			"Leonora",
			"Belladonna",
			"Margareth"
			};
		}
		private static void MaleFirstNames () {
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
		private static void MaleMiddleNames () {
			maleMiddleNames = new string[] {
			"O'Brian",
			"Henry",
			"Walter",
			"Helmut"
			};
		}
		private static void LastNames () {
			lastNames = new string[] {
				"Wood",
				"Sullivan",
				"Myers",
				"Peterson",
				"Miller",
				"Murphy",
				"Fisher",
				"Fox",
				"Cook",
				"Long",
				"Baker",
				"Hughes",
				"Kelly",
				"Nelson",
				"Roberts",
				"Russell",
				"Bennett",
				"Phillips",
				"Morgan",
				"Rogers",
				"Ward",
				"Anderson",
				"Martin",
				"Clark",
				"Campbell",
				"Adams",
				"Price",
				"Morris",
				"Hall",
				"Bailey",
				"Collins",
				"Reed",
				"Smith",
				"King",
				"Thompson",
				"Foster",
				"Stewart",
				"Parker",
				"Ross",
				"Gray",
				"Perry",
				"Evans",
				"Cooper",
				"Allen",
				"Powell",
				"Wilson",
				"Young",
				"Moore",
				"Watson",
				"Wright",
				"White",
				"Taylor",
				"Barnes",
				"Hill",
				"Howard",
				"Turner",
				"Edwards",
				"Butler",
				"Davis",
				"Bell",
				"Mitchell",
				"Sanders",
				"Brooks",
				"Scott",
				"Richardson",
				"Johnson",
				"Walker",
				"Lewis",
				"Brown",
				"Carter",
				"Jenkins",
				"Green",
				"Jones",
				"Thomas",
				"James",
				"Harris",
				"Robinson",
				"Williams",
				"Jackson",
				"Lee"
			};
		}

	}
}
