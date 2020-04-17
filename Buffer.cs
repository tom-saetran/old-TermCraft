using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Buffer {

		private const int a = 3;

		public static readonly char[][] buffer = new char[Program.wHorizontal][];

		public static void Init () {
			for (int x = 0; x < buffer.Length; x++) {
				buffer[x] = new char[Program.wVertical];
			}

			for (int x = 0; x < Program.wHorizontal; x++) {
				for (int y = 0; y < Program.wVertical; y++) {
					buffer[x][y] = ' ';
				}
			}
		}
		public static void Draw () {
			string _buffer = "";
			int _cursorTop = Console.CursorTop;
			int _cursorLeft = Console.CursorLeft;
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
			for (int y = 0; y < Program.wVertical; y++) {
				for (int x = 0; x < Program.wHorizontal; x++) {
					_buffer += buffer[x][y];
				}
			}
			Console.Write(_buffer);
			Console.SetCursorPosition(_cursorLeft, _cursorTop);
			Console.CursorVisible = true;
		}
		public static void Clear () {
			for (int x = 0; x < Program.wHorizontal; x++) {
				for (int y = 0; y < Program.wVertical; y++) {
					buffer[x][y] = ' ';
				}
			}
			BuildDefaultUI();
		}
		public static void BuildSplash () {
			// Load Splash screen and Draw it

			// TEMP
			BuildDefaultUI();
		}
		public static void BuildDefaultUI () {
			// Box in the terminal and divide into output (top) and input (bottom)	
			AddHorizontalLine('=', 0);
			AddHorizontalLine('=', Program.wVertical - 1);
			AddHorizontalLine('=', Program.wVertical - 3);
			AddVerticalLine('|', 0);
			AddVerticalLine('|', Program.wHorizontal - 1);
			AddHorizontalText("--- ....SCROLLING TEXT GO HERE.... --- ....SCROLLING TEXT GO HERE.... ---", Program.wVertical - 2, 1);

		}

		public static void AddHorizontalLine (char c, int y) {
			if (y >= Program.wVertical)
				return;

			for (int i = 0; i < Program.wHorizontal; i++) {
				buffer[i][y] = c;
			}
		}
		public static void AddHorizontalLine (char c, int y, int startX, uint length) {
			if (y >= Program.wVertical)
				return;

			int runoutLength = Program.wHorizontal - startX;
			if (runoutLength <= 0)
				return;
			if (length > runoutLength)
				length = (uint)runoutLength;

			for (int i = 0; i < length; i++) {
				buffer[startX + i][y] = c;
			}
		}
		public static void AddVerticalLine (char c, int x) {
			if (x >= Program.wHorizontal)
				return;

			for (int i = 0; i < Program.wVertical; i++) {
				buffer[x][i] = c;
			}
		}
		public static void AddVerticalLine (char c, int x, int startY, uint length) {
			if (x >= Program.wHorizontal)
				return;

			int runoutLength = Program.wVertical - startY;
			if (runoutLength <= 0)
				return;
			if (length > runoutLength)
				length = (uint)runoutLength;

			for (int i = 0; i < length; i++) {
				buffer[x][startY + i] = c;
			}
		}
		public static void AddChar (char c, int x, int y) {
			if (y >= Program.wVertical)
				return;
			if (x >= Program.wHorizontal)
				return;

			buffer[x][y] = c;
		}
		public static void AddHorizontalText (string s, int y, int startX) {
			if (y >= Program.wVertical)
				return;

			int runoutLength = Program.wHorizontal - startX;
			if (runoutLength <= 0)
				return;
			if (s.Length > runoutLength)
				return;

			for (int i = 0; i < s.Length; i++) {
				buffer[startX + i][y] = s[i];
			}
		}
		public static void AddVerticalText (string s, int x, int startY) {
			if (x >= Program.wHorizontal)
				return;

			int runoutLength = Program.wVertical - startY;
			if (runoutLength <= 0)
				return;

			if (s.Length > runoutLength)
				return;

			for (int i = 0; i < s.Length; i++) {
				buffer[x][startY + i] = s[i];
			}
		}
	}
}
