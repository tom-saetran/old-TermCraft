using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Draw {

		public static char[][] buffer = new char[Program.wHeight][];

		public const int cursorPosX = 0;
		public const int cursorPosY = Program.wHeight - 1;

		public static void InitBuffer () {
			for (int x = 0; x < buffer.Length; x++) {
				buffer[x] = new char[Program.wWidth];
			}
		}
		public static void DrawBufferToConsole (char[][] buffer) {
			string _buffer = "";
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
			for (int i = 0; i < buffer.GetLength(0); i++) {
				for (int j = 0; j < buffer[i].GetLength(0); j++) {
					_buffer += buffer[i][j];
				}
			}
			Console.Write(_buffer);
			Console.SetCursorPosition(cursorPosX, cursorPosY);
			Console.CursorVisible = true;
		}

		public static void HLine (char c, int y) { }
		public static void HLine (char c, int y, int startX, int length) { }
		public static void VLine (char c, int x) { }
		public static void VLine (char c, int x, int startY, int length) { }

		public static void HText (string s, int y, int startX) { }
		public static void VText (string s, int x, int startY) { }

		public static void TestFlood (char c) {
			InitBuffer();
			for (int x = 0; x < Program.wHeight; x++) {
				for (int y = 0; y < Program.wWidth; y++) {
					buffer[x][y] = c;
				}
			}
			DrawBufferToConsole(buffer);
		}
	}
}
