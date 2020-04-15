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

		public static void AddHorizontalLine (char c, int y) { }
		public static void AddHorizontalLine (char c, int y, int startX, int length) { }
		public static void AddVerticalLine (char c, int x) { }
		public static void AddVerticalLine (char c, int x, int startY, int length) { }
		public static void AddChar (char c, int x, int y) { }
		public static void HorizontalText (string s, int y, int startX) { }
		public static void VerticalText (string s, int x, int startY) { }
	}
}
