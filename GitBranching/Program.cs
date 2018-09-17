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
			Console.WriteLine(FixAnotherExtraBug());
			Console.WriteLine("Made Remote Change!");
			Console.WriteLine("local change on local master");
		}

		private static string BugFix()
		{
			return "First BugFix!";
		}

		private static string FixAnotherBug()
		{
			return "Fixed another bug!";
		}

		private static string FixAnotherExtraBug()
		{
			return "Fixed another extra bug!";
		}

		private static int Sum(int first, int second)
		{
			var sum = first + second;
			return sum;
		}

	}
}
