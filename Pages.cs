using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Pages {

		public enum Page { Menu, Help, Inventory, Settings, Market, Patreon, Character, etc }
		static Page currentPage;
		public static Page lastPage { get; private set; }

		static void SetLastPage (Page page) {
			lastPage = page;
		}

		public static void Init () {
			currentPage = Page.Menu;
			lastPage = Page.Menu;
		}

		public static void Help () {
			SetLastPage(currentPage);
		}


		public static void Inventory () {
			SetLastPage(currentPage);
		}


		public static void Menu () {
			SetLastPage(currentPage);
		}


		public static void Settings () {
			SetLastPage(currentPage);
		}


		public static void Market () {
			SetLastPage(currentPage);
		}


		public static void Patreon () {
			SetLastPage(currentPage);
		}


		public static void Character () {
			SetLastPage(currentPage);
		}


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
			}
		}


	}
}
