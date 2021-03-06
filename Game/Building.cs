namespace TermCraft {

	/// <summary>
	/// Data class for <see cref="Building"/>
	/// </summary>
	public class Building {

		/// <summary>
		/// The <see cref="Inventory"/> attached to this <see cref="Building"/>
		/// </summary>
		public Inventory inventory { get; private set; }

		/// <summary>
		/// The name of this <see cref="Building"/>
		/// </summary>
		public string name { get; private set; }

		/// <summary>
		/// The description of this <see cref="Building"/>
		/// </summary>
		public string desc { get; private set; }

		/// <summary>
		/// The value of this <see cref="Building"/>
		/// </summary>
		public double value { get; private set; }

		/// <summary>
		/// The level of this <see cref="Building"/>
		/// </summary>
		public short level { get; private set; }

		// TODO: Fix this
		/// <summary>
		/// A list of available commands for this <see cref="Building"/>
		/// </summary>
		public readonly string[] availableCommands = new string[4] { "produce", "cancel", "upgrade", "etc" };

		/// <summary>
		/// Enumerable list of <see cref="Type"/>
		/// </summary>
		public enum Type { 
			/// <summary>
			/// This <see cref="Building"/> is behaving as a Bank
			/// </summary>
			Bank,

			/// <summary>
			/// This <see cref="Building"/> is behaving as a Store
			/// </summary>
			Store,

			/// <summary>
			/// This <see cref="Building"/> is behaving as the Home of the <see cref="Player"/>
			/// </summary>
			Home,

			/// <summary>
			/// This <see cref="Building"/> is behaving as a Quarry
			/// </summary>
			Quarry
		}

		/// <summary>
		/// The <see cref="Type"/> of this <see cref="Building"/>
		/// </summary>
		public Type type { get; private set; }

		/// <summary>
		/// Creates a new <see cref="Building"/> of <see cref="Type"/> <paramref name="type"/> with the set parameters and adds it to the <see cref="Register"/>
		/// </summary>
		/// <param name="type">The <see cref="Type"/> of <see cref="Building"/></param>
		/// <param name="value">The value of this <see cref="Building"/></param>
		/// <param name="name">The name of this <see cref="Building"/></param>
		/// <param name="desc">The description of this <see cref="Building"/></param>
		/// <param name="noInv">Set to <see langword="true"/> if populating <see cref="Database"/></param>
		public Building (Type type, double value, string name, string desc, bool noInv = false) {
			this.type = type;
			this.value = value;
			this.name = name;
			this.desc = desc;
			level = 1;
			if (!noInv) {
				inventory = new Inventory();
				Register.AddToRegister(this);
			}
		}

		/// <summary>
		/// Loads the specified <see cref="Building"/> of <see cref="Type"/> <paramref name="type"/> with the set parameters and adds it to the <see cref="Register"/>
		/// </summary>
		/// <param name="type">The <see cref="Type"/> of <see cref="Building"/></param>
		/// <param name="value">The value of this <see cref="Building"/></param>
		/// <param name="name">The name of this <see cref="Building"/></param>
		/// <param name="desc">The description of this <see cref="Building"/></param>
		/// <param name="inventory">The <see cref="Inventory"/> of this <see cref="Building"/></param>
		/// <param name="level">The level of this <see cref="Building"/></param>
		public Building (Type type, double value, string name, string desc, Inventory inventory, short level) {
			this.type = type;
			this.value = value;
			this.name = name;
			this.desc = desc;
			this.inventory = inventory;
			this.level = level;
			Register.AddToRegister(this);
		}

		/// <summary>
		/// Removes <see langword="this"/> <see cref="Building"/> from the <see cref="Register"/>
		/// </summary>
		public void Remove () {
			Register.RemoveFromRegister(this);
		}
	}
}
