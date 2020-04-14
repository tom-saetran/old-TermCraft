using System;

namespace TermCraft {
	public static class Draw {

		static readonly char[][] buffer = new char[Program.wWidth][];

		const int cursorPosX = 0;
		const int cursorPosY = Program.wHeight - 1;

		public static void InitBuffer () {
			for (int x = 0; x < buffer.Length; x++) {
				buffer[x] = new char[Program.wHeight];
			}
		}
		public static void DrawBufferToConsole (char[][] buffer) {
			string _buffer = "";
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
			for (int x = 0; x < buffer.GetLength(0); x++) {
				for (int y = 0; y < buffer[x].GetLength(0); y++) {
					_buffer += buffer[x][y];
				}
			}
			Console.Write(_buffer);
			Console.SetCursorPosition(cursorPosX, cursorPosY);
			Console.CursorVisible = true;
		}

		public static void HorizontalLine (char c, int y) { }
		public static void HorizontalLine (char c, int y, int startX, int length) { }
		public static void VerticalLine (char c, int x) { }
		public static void VerticalLine (char c, int x, int startY, int length) { }

		public static void HorizontalText (string s, int y, int startX) { }
		public static void VerticalText (string s, int x, int startY) { }

		public static void TestFlood (char c) {
			InitBuffer();
			for (int x = 0; x < Program.wWidth; x++) {
				for (int y = 0; y < Program.wHeight; y++) {
					buffer[x][y] = c;
				}
			}
			DrawBufferToConsole(buffer);
		}
	}
}
