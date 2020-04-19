using System;
using System.Runtime.InteropServices;

namespace TermCraft {

	/// <summary>
	/// Main class
	/// </summary>
	class Program {

		/// <summary>
		/// Horizontal length of the <see cref="Console"/>
		/// </summary>
		public const int wHorizontal = 120;

		/// <summary>
		/// Vertical length of the <see cref="Console"/>
		/// </summary>
		public const int wVertical = 36;

		/// <summary>
		/// Indicates if the application is currently reading user input
		/// </summary>
		private static bool inputCaptured = false;

		/// <summary>
		/// External
		/// </summary>
		[DllImport("user32.dll")]
		public static extern int DeleteMenu (IntPtr hMenu, int nPosition, int wFlags);

		/// <summary>
		/// External
		/// </summary>
		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu (IntPtr hWnd, bool bRevert);

		/// <summary>
		/// External
		/// </summary>
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow ();

		/// <summary>
		/// Starting point of the application.
		/// Configures <see cref="Console"/> in multiple steps, then starts capturing input.
		/// </summary>
		private static void Main () {
			PreInitConsole();
			InitConsole();
			PostInitConsole();
			CaptureInput();
		}

		/// <summary>
		/// Stage 1 <see cref="Console"/> configuration.
		/// Locks the size controls and sets the <see cref="Console"/> size
		/// </summary>
		private static void PreInitConsole () {
			_ = DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF030, 0);
			_ = DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), 0xF000, 0);

			Console.SetWindowSize(wHorizontal, wVertical);
			Console.SetBufferSize(wHorizontal, wVertical);
			Console.SetCursorPosition(1, wVertical - 2); // not default resting position
		}

		/// <summary>
		/// Stage 2 <see cref="Console"/> configuration.
		/// Initializes all static classes
		/// </summary>
		private static void InitConsole () {
			Register.Init();
			Player.Init();
			Name.Init();	
			Database.Init();
			Buffer.Init();
			Pages.Init();
			Update.Init();
		}

		/// <summary>
		/// Stage 3 <see cref="Console"/> configuration.
		/// Starts timed events and displays the splash screen
		/// </summary>
		private static void PostInitConsole() {
			// Start timed classes here
		}

		/// <summary>
		/// Begins input capture
		/// </summary>
		private static void CaptureInput () {
			SetCapture(true);
			while (inputCaptured)
				Actions.DoAction(Console.ReadLine());

			Terminate();
		}

		/// <summary>
		/// Called after <see cref="CaptureInput"/> stops running.
		/// Saves and terminates the application
		/// </summary>
		private static void Terminate () {
			
		}

		/// <summary>
		/// Sets the state of <see cref="inputCaptured"/>
		/// </summary>
		/// <param name="state">New state</param>
		public static void SetCapture(bool state) { inputCaptured = state; }
	}
}
