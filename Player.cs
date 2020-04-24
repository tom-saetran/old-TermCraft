namespace TermCraft {

	/// <summary>
	/// Class of <see cref="Player"/>
	/// </summary>
	public static class Player {

		/// <summary>
		/// The <see cref="Inventory"/> attached to the <see cref="Player"/>
		/// </summary>
		public static Inventory inventory { get; private set; }

		/// <summary>
		/// The level of the <see cref="Player"/>
		/// </summary>
		public static short level { get; private set; }

		/// <summary>
		/// Initializes the <see cref="inventory"/> of <see cref="Player"/> and sets <see cref="level"/> to 1
		/// </summary>
		public static void Init () {
			inventory = new Inventory();
			level = 1;
		}

		/// <summary>
		/// Loads <paramref name="inventory"/> and <paramref name="level"/> to <see cref="inventory"/> and <see cref="level"/>
		/// </summary>
		/// <param name="inventory"></param>
		/// <param name="level"></param>
		public static void Init (Inventory inventory, short level) {
			Player.inventory = inventory;
			Player.level = level;
		}
	}
}
