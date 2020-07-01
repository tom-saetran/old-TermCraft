using System;
using System.Collections.Generic;
using System.Text;

namespace TermCraft {
	public static class Debug {

		static string s = null;

		public static void Init () { }
		public static bool? Return3 (bool b) {
			if (s == null)
				return null;

			if (b)
				return true;

			return false;
		} 
	}
}
