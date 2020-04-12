using System;
using System.Runtime.InteropServices;

namespace TermCraft {
	class Program {

		public const int wWidth = 48;
		public const int wHeight = 160;

		[DllImport("user32.dll")]
		public static extern int DeleteMenu (IntPtr hMenu, int nPosition, int wFlags);

		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu (IntPtr hWnd, bool bRevert);

		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow ();

		private static void Main () {
			PreInitConsole();
			InitConsole();
			ReadConsole();
		}
		private static void PreInitConsole () {
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF030, 0);
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF000, 0);

			Console.SetWindowSize(wHeight, wWidth);
			Console.SetBufferSize(wHeight, wWidth);
			Console.Beep();
		}
		private static void InitConsole () {
			// load splash screen
		}
		private static void ReadConsole () {
			// Code
			WriteConsole ();
		}
		private static void WriteConsole () {
			// 
		}
	}
}
