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
			Console.WriteLine(FixAnotherBug());
		}

		private static string FixAnotherBug()
		{
			return "Fixed another bug!";
		}
	}
}
