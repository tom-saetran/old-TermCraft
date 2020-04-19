using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {

	/// <summary>
	/// Data class to draw the selected <see cref="Page"/> to <see cref="Buffer.buffer"/>.
	/// This class does not call <see cref="Buffer.Draw"/>
	/// </summary>
	public static class Pages {

		/// <summary>
		/// Enumerable list of drawable pages
		/// </summary>
		public enum Page { Splash, Menu, Help, Inventory, Settings, Market, Patreon, Character, etc }

		/// <summary>
		/// Indicates the <see cref="Page"/> that is last drawn to <see cref="Console"/>
		/// </summary>
		private static Page currentPage;

		/// <summary>
		/// Indicates the <see cref="Page"/> that was drawn prior to the <see cref="currentPage"/>
		/// </summary>
		public static Page lastPage { get; private set; }

		/// <summary>
		/// Sets <see cref="lastPage"/> to <paramref name="page"/>.
		/// Called when writing a <see cref="Page"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		/// <param name="page"></param>
		static void SetLastPage (Page page) {
			lastPage = page;
		}

		/// <summary>
		/// Initialize <see cref="Pages"/>
		/// </summary>
		public static void Init () {
			currentPage = Page.Splash;
			lastPage = Page.Splash;
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Help"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Help () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Inventory"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Inventory () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Menu"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Menu () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Settings"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Settings () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Market"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Market () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Patreon"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Patreon () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Character"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Character () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Sets <see cref="lastPage"/> to <see cref="currentPage"/>.
		/// Writes <see cref="Splash"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void Splash () {
			SetLastPage(currentPage);
		}

		/// <summary>
		/// Writes <see cref="lastPage"/> to <see cref="Buffer.buffer"/>
		/// </summary>
		public static void RecallLastPage () {
			switch (lastPage) {
				case Page.Help:
					Help();
					break;
				case Page.Inventory:
					Inventory();
					break;
				case Page.Menu:
					Menu();
					break;
				case Page.Settings:
					Settings();
					break;
				case Page.Market:
					Market();
					break;
				case Page.Patreon:
					Patreon();
					break;
				case Page.Character:
					Character();
					break;
				case Page.Splash:
					Splash();
					break;
			}
		}
	}
}
