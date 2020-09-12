using System;

namespace Summator
{
	public class Summator
	{
		public static double AlgbAverage(string[] numsStr)
		{
			if (numsStr.Length == 0) 
			{
				Console.WriteLine("Nothing was input");
				System.Environment.Exit(1);
			}

			double result = 0;
			double number = 0;

			for (int i = 0; i < numsStr.Length; i++) 
			{
				if (double.TryParse(numsStr [i], out number)) 
				{
					result += number;
				} 
				else 
				{
					if (numsStr [i].Length > 1) 
					{
						Console.WriteLine("input non integer and non character string");
						System.Environment.Exit(2);
					}

					result += (int)numsStr[i].ToCharArray()[0];
				}
			}

			return result / numsStr.Length;
		}

		public static double GeomAverage(string[] numsStr)
		{
			if (numsStr.Length == 0) 
			{
				Console.WriteLine("Nothing will input");
				System.Environment.Exit(1);
			}

			double result = 1;
			double number = 0;

			for (int i = 0; i < numsStr.Length; i++) 
			{
				if (double.TryParse(numsStr [i], out number)) 
				{
					result *= number;
				} 
				else 
				{
					Console.WriteLine("incorrect character");
					System.Environment.Exit(1);
				}
			}
			return Math.Pow(result, 1.0 / numsStr.Length);
		}
	}
}
