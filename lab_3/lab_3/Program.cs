using System;
using Summator;

namespace lab_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("nums for algeb sum: ");
			string inputStr = Console.ReadLine();
			inputStr = inputStr.Replace(",", ".");
			string[] nums = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine("Average algebraic sum: " + Summator.Summator.AlgbAverage(nums));

			Console.WriteLine("nums for geometric sum: ");
			inputStr = Console.ReadLine();
			inputStr = inputStr.Replace(",", ".");
			nums = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine("Average geom sum: " + Summator.Summator.GeomAverage(nums));
		}
	}
}
