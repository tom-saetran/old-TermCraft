using System;

namespace TermCraft {
	public static class Draw {

		public static void DrawBuffer () {
			string _buffer = "";
			int _cursorTop = Console.CursorTop;
			int _cursorLeft = Console.CursorLeft;
			
			Console.CursorVisible = false;
			
			Console.SetCursorPosition(0, 0);
			for (int x = 0; x < Buffer.buffer.GetLength(0); x++) {
				for (int y = 0; y < Buffer.buffer[x].GetLength(0); y++) {
					_buffer += Buffer.buffer[x][y];
				}
			}
			Console.Write(_buffer);
			Console.SetCursorPosition(_cursorLeft, _cursorTop);
			Console.CursorVisible = true;
		}
	}
}
