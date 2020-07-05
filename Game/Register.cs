using System.Collections.Generic;

namespace TermCraft {

	/// <summary>
	/// AI/Building Register
	/// </summary>
	static class Register {

		/// <summary>
		/// List of <see cref="AI"/>s in use
		/// </summary>
		public static List<AI> AIs { get; private set; }

		/// <summary>
		/// List of <see cref="Building"/>s in use
		/// </summary>
		public static List<Building> Buildings { get; private set; }

		/// <summary>
		/// Initializes <see cref="AIs"/> and <see cref="Buildings"/>
		/// </summary>
		public static void Init () {
			AIs = new List<AI>();
			Buildings = new List<Building>();
		}

		/// <summary>
		/// Adds a specified <see cref="AI"/> to the register
		/// </summary>
		/// <param name="ai">The <see cref="AI"/> to add</param>
		public static void AddToRegister (AI ai) { AIs.Add(ai); }

		/// <summary>
		/// Adds a specified <see cref="Building"/> to the register
		/// </summary>
		/// <param name="building">The <see cref="Building"/> to add</param>
		public static void AddToRegister (Building building) { Buildings.Add(building); }

		/// <summary>
		/// Removes the specified <see cref="AI"/> from the register
		/// </summary>
		/// <param name="ai">The <see cref="AI"/> to remove</param>
		public static void RemoveFromRegister (AI ai) { AIs.Remove(ai);	}

		/// <summary>
		/// Removes the specified <see cref="Building"/> from the register
		/// </summary>
		/// <param name="building">The <see cref="Building"/> to Remove</param>
		public static void RemoveFromRegister (Building building) { Buildings.Remove(building);	}
	}
}
