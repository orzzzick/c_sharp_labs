using System;
using System.Text;

namespace lab_6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var strs = Console.ReadLine().Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

			var alphOrderStr = new StringBuilder();
			var lastLtrStr = new StringBuilder();

			Orderer.Orderer.SortAlphOrder(strs, alphOrderStr, lastLtrStr);

			Console.WriteLine("alph oreder: " + alphOrderStr);
			Console.WriteLine("last characters: " + lastLtrStr);
		}
	}
}
