using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace TermCraft {
	class Task {
		bool runInstantly = false;
		long spawnTime = DateTimeOffset.Now.ToUnixTimeSeconds();
		long expiryTime;

		/*  use timestamps to add tasks to an array, sort on insert
		 *  taskthread counts time and executes tasks when they have 
		 *  count past their expiry time
		 *  
		 */ 
	}
}
