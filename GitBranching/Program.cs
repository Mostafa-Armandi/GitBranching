using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranching
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("First Commit Change");
			Console.WriteLine(BugFix());
			Console.WriteLine(FixAnotherBug());
		}

		private static string BugFix()
		{
			return "First BugFix!";
		}

		private static string FixAnotherBug()
		{
			return "Fixed another bug!";
		}
	}
}
