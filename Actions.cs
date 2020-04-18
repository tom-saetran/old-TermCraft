using System;

namespace TermCraft {

	/// <summary>
	/// Handles user input and selects actions to do
	/// </summary>
	public static class Actions {

		/// <summary>
		/// Reads from <see cref="Console.ReadLine"/> and compares it to known commands, then executes that commands function.
		/// Not case sensitive
		/// </summary>
		/// <param name="input">Set by <see cref="Console.ReadLine"/></param>
		public static void DoAction (string input) {
			switch (input.ToLower()) {
				case string s when (s == "c" || s == "char" || s == "character"):
					OpenCharacter();
					break;

				case string s when (s == "e" || s == "exit" || s == "back"):
					ReturnToLastScreen();
					break;

				case string s when (s == "h" || s == "help" || s == "?"):
					OpenHelp();
					break;

				case string s when (s == "i" || s == "inv" || s == "inventory"):
					OpenInventory();
					break;

				case string s when (s == "m" || s == "mar" || s == "market"):
					OpenMarket();
					break;

				case string s when (s == "p" || s == "pat" || s == "patreon"):
					OpenPatreon();
					break;

				case string s when (s == "q" || s == "quit"):
					Terminate();
					break;

				case string s when (s == "s" || s == "sel" || s == "select"):
					Select();
					break;

				default:
					InvalidInput();
					break;
			}
		}

		/// <summary>
		/// Builds <see cref="Pages.Help"/> to <see cref="Buffer.buffer"/> and calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void OpenHelp () {
			Pages.Help();
			Buffer.Draw();
		}

		/// <summary>
		/// Builds the <see cref="Inventory"/> of the selected <see cref="Player"/>/<see cref="AI"/>/<see cref="Building"/> to <see cref="Buffer.buffer"/> then calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void OpenInventory () {
			Pages.Help();
			Buffer.Draw();
		}

		/// <summary>
		/// Builds <see cref="Pages.Patreon"/> to <see cref="Buffer.buffer"/> and calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void OpenPatreon () {
			Pages.Patreon();
			Buffer.Draw();
		}

		/// <summary>
		/// Builds <see cref="Pages.Market"/> to <see cref="Buffer.buffer"/> and calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void OpenMarket () {
			Pages.Market();
			Buffer.Draw();
		}

		/// <summary>
		/// Builds <see cref="Pages.Character"/> to <see cref="Buffer.buffer"/> and calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void OpenCharacter () {
			Pages.Character();
			Buffer.Draw();
		}

		/// <summary>
		/// NYI: Require multi word input read
		/// </summary>
		static void Select () {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sets the <see cref="Buffer.buffer"/> to <see cref="Pages.lastPage"/> then calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void ReturnToLastScreen () {
			Pages.RecallLastPage();
			Buffer.Draw();
		}

		/// <summary>
		/// Signals to <see cref="Program"/> that we no longer wish to run <see cref="Program.CaptureInput"/>.
		/// This will terminate the application!
		/// </summary>
		static void Terminate () {
			Program.SetCapture(false);
		}

		/// <summary>
		/// No valid input detected. Calls <see cref="Buffer.Draw"/>
		/// </summary>
		static void InvalidInput () {
			// TODO: add error message print to user
			Buffer.Draw();
		}
	}
}
