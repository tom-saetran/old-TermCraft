using System;
using System.Runtime.InteropServices;

namespace TermCraft {
	class Program {

		public const int wHorizontal = 120;
		public const int wVertical = 36;

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
			//DebugConsole();
			CaptureInput();
		}
		private static void PreInitConsole () {
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF030, 0);
			DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF000, 0);

			Console.SetWindowSize(wHorizontal, wVertical);
			Console.SetBufferSize(wHorizontal, wVertical);
			Console.SetCursorPosition(0, wVertical - 1); // not default resting position
		}
		private static void InitConsole () {
			Register.Init();
			Player.Init();
			Name.Init();	
			Database.Init();
			Buffer.Init();
		}
		private static void PostInitConsole() {
			Buffer.BuildSplash();
			Buffer.Draw();
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
