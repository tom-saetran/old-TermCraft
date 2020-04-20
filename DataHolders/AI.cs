namespace TermCraft {
	
	/// <summary>
	/// Data class for <see cref="AI"/>
	/// </summary>
	public class AI {

		/// <summary>
		/// The <see cref="Inventory"/> attached to this <see cref="AI"/>
		/// </summary>
		public Inventory inventory { get; private set; }

		/// <summary>
		/// The name of this <see cref="AI"/>
		/// </summary>
		public string name { get; private set; }

		/// <summary>
		/// The level of tihs <see cref="AI"/>
		/// </summary>
		public short level { get; private set; }

		/// <summary>
		/// Enumerable list of <see cref="Type"/>
		/// </summary>
		public enum Type {
			/// <summary>
			/// <see cref="AI"/> will behave as an Investor
			/// </summary>
			Investor,

			/// <summary>
			/// <see cref="AI"/> will behave as a Banker
			/// </summary>
			Banker,

			/// <summary>
			/// <see cref="AI"/> will behave as a Secretary
			/// </summary>
			Secretary,

			/// <summary>
			/// <see cref="AI"/> will behave as an Advisor
			/// </summary>
			Advisor
		}

		/// <summary>
		/// The <see cref="Type"/> of this <see cref="AI"/>
		/// </summary>
		public Type type { get; private set; }

		/// <summary>
		/// Creates a new <see cref="AI"/> of <see cref="Type"/> <paramref name="type"/> with the set <paramref name="name"/> and adds it to the <see cref="Register"/>
		/// </summary>
		/// <param name="type">The <see cref="Type"/> of <see cref="AI"/></param>
		/// <param name="name">The name of the <see cref="AI"/></param>
		public AI (Type type, string name) {
			this.type = type;
			this.name = name;
			level = 1;
			inventory = new Inventory();
			Register.AddToRegister(this);
		}

		/// <summary>
		/// Loads an <see cref="AI"/> to the <see cref="Register"/> with the set parameters
		/// </summary>
		/// <param name="type">The <see cref="Type"/> of <see cref="AI"/></param>
		/// <param name="name">The name of the <see cref="AI"/></param>
		/// <param name="inventory">The <see cref="Inventory"/> of the <see cref="AI"/></param>
		/// <param name="level">The level of the <see cref="AI"/></param>
		public AI (Type type, string name, Inventory inventory, short level) {
			this.type = type;
			this.name = name;
			this.level = level;
			this.inventory = inventory;
			Register.AddToRegister(this);
		}

		/// <summary>
		/// Removes <see langword="this"/> <see cref="AI"/> from the <see cref="Register"/>
		/// </summary>
		public void Remove () {
			Register.RemoveFromRegister(this);
		}
	}
}
