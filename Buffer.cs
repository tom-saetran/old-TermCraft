using System;
using System.Collections.Generic;
using System.Text;


namespace TermCraft {

	/// <summary>
	/// Handles the output buffer and output to console
	/// </summary>
	public static class Buffer {

		/// <summary>
		/// Drawable <see cref="char[][]"/> buffer
		/// </summary>
		public static readonly char[][] buffer = new char[Program.wHorizontal][];

		/// <summary>
		/// Current character set
		/// </summary>
		static string borderCharSet;

		/// <summary>
		/// Character sets
		/// </summary>
		public enum CharSet { Default, Thin, Full }

		/// <summary>
		/// Initialize <see cref="buffer"/>
		/// </summary>
		public static void Init () {
			for (int x = 0; x < buffer.Length; x++) {
				buffer[x] = new char[Program.wVertical];
			}

			for (int x = 0; x < Program.wHorizontal; x++) {
				for (int y = 0; y < Program.wVertical; y++) {
					buffer[x][y] = ' ';
				}
			}
			SetBorderCharSet(CharSet.Default);
		}

		/// <summary>
		/// Sets the <see cref="CharSet"/> used for the borders
		/// </summary>
		/// <param name="charSet">Selected <see cref="CharSet"/></param>
		public static void SetBorderCharSet (CharSet charSet) {
			switch (charSet) {
				case (CharSet.Default):
					borderCharSet = "═║╔╗╚╝╠╣╦╩╬";
					break;
				case (CharSet.Thin):
					borderCharSet = "─│┌┐└┘├┤┬┴┼";
					break;
				case (CharSet.Full):
					borderCharSet = "███████████";
					break;
				default:
					break;
			}
			Clear();
		}

		/// <summary>
		/// Draws <see cref="buffer"/> to <see cref="Console"/>
		/// </summary>
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

		/// <summary>
		/// Replaces <see cref="buffer"/> content with <see cref="' '"/>.
		/// Calls <see cref="BuildDefaultUI"/> after completion
		/// </summary>
		public static void Clear () {
			for (int x = 0; x < Program.wHorizontal; x++) {
				for (int y = 0; y < Program.wVertical; y++) {
					buffer[x][y] = ' ';
				}
			}
			BuildDefaultUI();
		}

		/// <summary>
		/// Adds splash screen data to <see cref="buffer"/>.
		/// Calls <see cref="Draw"/> after completion
		/// </summary>
		public static void BuildSplash () {
			// Load Splash screen and Draw it

			// TEMP
			BuildDefaultUI();
		}

		/// <summary>
		/// Builds the default UI with the set <see cref="CharSet"/>.
		/// Called after <see cref="Clear"/>
		/// </summary>
		public static void BuildDefaultUI () {
			// Box in the terminal and divide into output (top) and input (bottom)	
			WriteHorizontalLine(borderCharSet[0], 0);
			WriteHorizontalLine(borderCharSet[0], 4);
			WriteHorizontalLine(borderCharSet[0], Program.wVertical - 1);
			WriteHorizontalLine(borderCharSet[0], Program.wVertical - 3);
			WriteHorizontalLine(borderCharSet[0], Program.wVertical - 7);
			AddVerticalLine(borderCharSet[1], 0);
			AddVerticalLine(borderCharSet[1], Program.wHorizontal - 1);
			AddVerticalLine(borderCharSet[1], 82, 1, 3);
			AddVerticalLine(borderCharSet[1], 36, 5, 24);
			AddChar(borderCharSet[2], 0, 0);
			AddChar(borderCharSet[3], Program.wHorizontal - 1, 0);
			AddChar(borderCharSet[4], 0, Program.wVertical - 1);
			AddChar(borderCharSet[5], Program.wHorizontal - 1, Program.wVertical - 1);
			AddChar(borderCharSet[6], 0, 4);
			AddChar(borderCharSet[6], 0, Program.wVertical - 3);
			AddChar(borderCharSet[6], 0, Program.wVertical - 7);
			AddChar(borderCharSet[7], Program.wHorizontal - 1, 4);
			AddChar(borderCharSet[7], Program.wHorizontal - 1, Program.wVertical - 3);
			AddChar(borderCharSet[7], Program.wHorizontal - 1, Program.wVertical - 7);
			AddChar(borderCharSet[8], 82, 0);
			AddChar(borderCharSet[8], 36, 4);
			AddChar(borderCharSet[9], 82, 4);
			AddChar(borderCharSet[9], 36, 29);
			//AddHorizontalText("--- ....SCROLLING TEXT GO HERE.... --- ....SCROLLING TEXT GO HERE.... ---", Program.wVertical - 2, 1);
			//AddVerticalText("Vertical Text :D", 1, 1);
		}

		/// <summary>
		/// Writes a full length horizontal line to <see cref="buffer"/>
		/// </summary>
		/// <param name="c"><see cref="char"/> to use</param>
		/// <param name="y">Vertical placement</param>
		public static void WriteHorizontalLine (char c, int y) {
			if (y >= Program.wVertical)
				return;

			for (int i = 0; i < Program.wHorizontal; i++) {
				buffer[i][y] = c;
			}
		}

		/// <summary>
		/// Writes a specified <paramref name="length"/> horizontal line to <see cref="buffer"/> from <paramref name="startX"/>
		/// </summary>
		/// <param name="c"><see cref="char"/> to use</param>
		/// <param name="y">Vertical placement</param>
		/// <param name="startX">Horizontal start of the line</param>
		/// <param name="length">Length of the line</param>
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

		/// <summary>
		/// Adds a full length vertical line to <see cref="buffer"/>
		/// </summary>
		/// <param name="c"><see cref="char"/> to use</param>
		/// <param name="x">Horizontal placement</param>
		public static void AddVerticalLine (char c, int x) {
			if (x >= Program.wHorizontal)
				return;

			for (int i = 0; i < Program.wVertical; i++) {
				buffer[x][i] = c;
			}
		}

		/// <summary>
		/// Adds a specified <paramref name="length"/> vertical line to <see cref="buffer"/> from <paramref name="startY"/>
		/// </summary>
		/// <param name="c"><see cref="char"/> to use</param>
		/// <param name="x">Horizontal placement</param>
		/// <param name="startY">Vertical start of the line</param>
		/// <param name="length">Length of the line</param>
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

		/// <summary>
		/// Adds the specified <see cref="char"/> to <see cref="buffer"/>
		/// </summary>
		/// <param name="c">Character to add</param>
		/// <param name="x">Horizontal placement</param>
		/// <param name="y">Vertical placement</param>
		public static void AddChar (char c, int x, int y) {
			if (y >= Program.wVertical)
				return;
			if (x >= Program.wHorizontal)
				return;

			buffer[x][y] = c;
		}

		/// <summary>
		/// Adds <paramref name="input"/> horizontally to <see cref="buffer"/> from <paramref name="startX"/>
		/// </summary>
		/// <param name="input">Text to add</param>
		/// <param name="y">Vertical placement</param>
		/// <param name="startX">Horizontal placement of the first input character</param>
		public static void AddHorizontalText (string input, int y, int startX) {
			if (y >= Program.wVertical)
				return;

			int runoutLength = Program.wHorizontal - startX;
			if (runoutLength <= 0)
				return;
			if (input.Length > runoutLength)
				return;

			for (int i = 0; i < input.Length; i++) {
				buffer[startX + i][y] = input[i];
			}
		}

		/// <summary>
		/// Adds <paramref name="input"/> vertically to <see cref="buffer"/> from <paramref name="startY"/>
		/// </summary>
		/// <param name="input">Text to add</param>
		/// <param name="x">Horizontal placement</param>
		/// <param name="startY">Vertical placement of the first input character</param>
		public static void AddVerticalText (string input, int x, int startY) {
			if (x >= Program.wHorizontal)
				return;

			int runoutLength = Program.wVertical - startY;
			if (runoutLength <= 0)
				return;

			if (input.Length > runoutLength)
				return;

			for (int i = 0; i < input.Length; i++) {
				buffer[x][startY + i] = input[i];
			}
		}
	}
}
