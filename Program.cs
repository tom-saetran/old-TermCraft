using System;
using System.Runtime.InteropServices;

namespace TermCraft {
	class Program {

		public const int wHeight = 36;
		public const int wWidth = 120;

		public static bool inputCaptured = false;

		[DllImport("user32.dll")]
		public static extern int DeleteMenu (IntPtr hMenu, int nPosition, int wFlags);

		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu (IntPtr hWnd, bool bRevert);

		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow ();

		private static void Main () {
			PreInitConsole();
			InitConsole();
			PostInitConsole();
			DebugConsole();
			CaptureInput();
		}
		private static void PreInitConsole () {
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF030, 0);
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF000, 0);

			Console.SetWindowSize(wWidth, wHeight);
			Console.SetBufferSize(wWidth, wHeight);
			Console.SetCursorPosition(0, wHeight - 1);
		}
		private static void InitConsole () {
			Register.Init();
			Player.Init();
			Name.Init();	
			Database.Init();
			Buffer.Init();
		}
		private static void PostInitConsole() {
			// show splash screen then menu screen
		}
		private static void CaptureInput () {
			inputCaptured = true;
			while (inputCaptured)
				Actions.DoAction(Console.ReadLine());

			// When program gets here, it will terminate!
		}
		private static void DebugConsole () {
			for (int i = 0; i < 10; i++) {
				AI ai = new AI(AI.Type.Investor, Name.Set(Name.Gender.Female));
				Console.WriteLine("{0} - {1}", ai.inventory.bankAccountNumberFormatted, ai.name);
			}
			Console.WriteLine();
			for (int i = 0; i < 10; i++) {
				AI ai = new AI(AI.Type.Investor, Name.Set(Name.Gender.Male));
				Console.WriteLine("{0} - {1}", ai.inventory.bankAccountNumberFormatted, ai.name);
			}
		}
	}
}
