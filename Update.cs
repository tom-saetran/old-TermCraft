using System;
using System.Collections.Generic;
using System.Threading;

namespace TermCraft {

	/// <summary>
	/// <see cref="Tick"/> is running without regards to time passed.
	/// </summary>
	static class Update {

		/// <summary>
		/// The main <see cref="Thread"/>. It calls <see cref="Tick"/>
		/// </summary>
		private static Thread updateThread;

		/// <summary>
		/// Is set to <see cref="true"/> when started.
		/// <see cref="updateThread"/> stops when set to <see cref="false"/>
		/// </summary>
		private static bool isRunning;

		/// <summary>
		/// <list type="number">
		/// <item><description>Creates <see cref="Thread"/> <see cref="updateThread"/> and affiliates it with method <see cref="Tick"/></description></item>
		/// <item><description>Sets <see cref="isRunning"/> to <see cref="true"/></description></item>
		/// <item><description>Starts executing <see cref="Tick"/> until <see cref="isRunning"/> is set to <see cref="false"/></description></item>
		/// </list>
		/// </summary>
		public static void Init () {
			updateThread = new Thread(Tick);
			isRunning = true;
			updateThread.Start();
		}

		/// <summary>
		/// <see cref="Tick"/> runs in <see cref="updateThread"/> until <see cref="isRunning"/> is set to <see cref="false"/>
		/// </summary>
		private static void Tick () {
			do {
				// Insert loopable code here
				if (true)
					isRunning = false;

			} while (isRunning);
		}
	}
}
