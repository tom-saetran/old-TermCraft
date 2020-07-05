using System;
using System.Collections.Generic;

namespace TermCraft {

	/// <summary>
	/// The <see cref="Name"/> class is used to generate psuedorandom names
	/// </summary>
	public static class Name {

		/// <summary>
		/// Female First Names
		/// </summary>
		private static string[] femaleFirstNames;

		/// <summary>
		/// Female Middle Names
		/// </summary>
		private static string[] femaleMiddleNames;

		/// <summary>
		/// Male First Names
		/// </summary>
		private static string[] maleFirstNames;

		/// <summary>
		/// Males Middle Names
		/// </summary>
		private static string[] maleMiddleNames;

		/// <summary>
		/// Gender-neutral Last Names
		/// </summary>
		private static string[] lastNames;

		/// <summary>
		/// Which <see cref="Gender"/> to select
		/// </summary>
		public enum Gender {

			/// <summary>
			/// <see cref="Gender"/>is set to Female
			/// </summary>
			Female,
			
			/// <summary>
			/// <see cref="Gender"/> is set to Male
			/// </summary>
			Male
		}

		/// <summary>
		/// Sets the chance of getting a middle name (0 - 1)
		/// </summary>
		private const float middleNameChance = 0.285f;

		/// <summary>
		/// Sets the chance of getting two last names (0 - 1)
		/// </summary>
		private const float doubleLastNameChance = 0.135f;

		/// <summary>
		/// Initializes the various arrays containing names
		/// </summary>
		public static void Init () {
			FemaleFirstNames();
			FemaleMiddleNames();			
			MaleFirstNames();
			MaleMiddleNames();
			LastNames();
		}

		/// <summary>
		/// Creates a new name and returns it
		/// </summary>
		/// <param name="gender">Which <see cref="Gender"/> to use</param>
		/// <returns>The newly generated name</returns>
		public static string Create (Gender gender) {
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

		/// <summary>
		/// Female First Names
		/// </summary>
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

		/// <summary>
		/// Female Middle Names
		/// </summary>
		private static void FemaleMiddleNames () {
			femaleMiddleNames = new string[] {
			"Fredrikke",
			"Leonora",
			"Belladonna",
			"Margareth"
			};
		}

		/// <summary>
		/// Male First Names
		/// </summary>
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

		/// <summary>
		/// Male Middle Names
		/// </summary>
		private static void MaleMiddleNames () {
			maleMiddleNames = new string[] {
			"O'Brian",
			"Henry",
			"Walter",
			"Helmut"
			};
		}

		/// <summary>
		/// Gender Neutral Last Names
		/// </summary>
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
