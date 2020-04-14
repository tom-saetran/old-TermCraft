using System;
using System.Runtime.InteropServices;

namespace TermCraft {
	class Program {

		public const int wHeight = 48;
		public const int wWidth = 160;

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

			Console.SetWindowSize(wWidth, wHeight);
			Console.SetBufferSize(wWidth, wHeight);
			Console.SetCursorPosition(0, wHeight - 1);
		}
		private static void InitConsole () {
			Name.Init();	
		
			//Draw.TestFlood('x');
			for (int i = 0; i < 20; i++) {
				AI ai = new AI(AI.Type.Investor, Name.Set());
				Console.WriteLine("{0} - {1}", ai.inventory.bankAccountNumberFormatted, ai.name);
			}
			Console.ReadLine();
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
