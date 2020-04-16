using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Buffer {

		public static readonly char[][] buffer = new char[Program.wWidth][];

		public static void Init () {
			for (int x = 0; x < buffer.Length; x++) {
				buffer[x] = new char[Program.wHeight];
			}
		}
		public static void Draw () {
			string _buffer = "";
			int _cursorTop = Console.CursorTop;
			int _cursorLeft = Console.CursorLeft;
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
			for (int y = 0; y < buffer.GetLength(0); y++) {
				for (int x = 0; x < buffer[y].GetLength(0); x++) {
					_buffer += buffer[x][y];
				}
			}
			Console.Write(_buffer);
			Console.SetCursorPosition(_cursorLeft, _cursorTop);
			Console.CursorVisible = true;
		}
		public static void Clear () {
			for (int x = 0; x < buffer.GetLength(0); x++) {
				for (int y = 0; y < buffer[x].GetLength(0); y++) {
					buffer[x][y] = ' ';
				}
			}
			BuildDefaultUI();
		}
		public static void BuildSplash () {
			// Load Splash screen and Draw it
		}
		public static void BuildDefaultUI () {
			// Box in the terminal and divide into output (top) and input (bottom)	
		}

		public static void AddHorizontalLine (char c, int y) {
			if (y >= Program.wWidth)
				return;

			for (int i = 0; i < Program.wWidth; i++) {
				buffer[i][y] = c;
			}
		}
		public static void AddHorizontalLine (char c, int y, int startX, uint length) {
			if (y >= Program.wWidth)
				return;

			int runoutLength = Program.wWidth - startX;
			if (runoutLength <= 0)
				return;
			if (length > runoutLength)
				length = (uint)runoutLength;

			for (int i = 0; i < length; i++) {
				buffer[startX + i][y] = c;
			}
		}
		public static void AddVerticalLine (char c, int x) {
			if (x >= Program.wHeight)
				return;

			for (int i = 0; i < Program.wHeight; i++) {
				buffer[x][i] = c;
			}
		}
		public static void AddVerticalLine (char c, int x, int startY, uint length) {
			if (x >= Program.wHeight)
				return;

			int runoutLength = Program.wHeight - startY;
			if (runoutLength <= 0)
				return;
			if (length > runoutLength)
				length = (uint)runoutLength;

			for (int i = 0; i < length; i++) {
				buffer[x][startY + i] = c;
			}
		}
		public static void AddChar (char c, int x, int y) {
			if (y >= Program.wWidth)
				return;
			if (x >= Program.wHeight)
				return;

			buffer[x][y] = c;
		}
		public static void AddHorizontalText (string s, int y, int startX) {
			if (y >= Program.wWidth)
				return;

			int runoutLength = Program.wWidth - startX;
			if (runoutLength <= 0)
				return;
			if (s.Length > runoutLength)
				return;

			for (int i = 0; i < s.Length; i++) {
				buffer[startX + i][y] = s[i];
			}
		}
		public static void AddVerticalText (string s, int x, int startY) {
			if (x >= Program.wHeight)
				return;

			int runoutLength = Program.wHeight - startY;
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
