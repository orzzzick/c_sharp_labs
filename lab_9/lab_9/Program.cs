using System;
using Dihotomy;

namespace lab_9
{
	class MainClass
	{
		// our function
		public static double EquationGet(double x) 
		{
			return Math.Pow(x, 2) - 3 * x + 2;
		}

		public static void Main (string[] args)
		{
			var GetEq = new Dihotomy.delegateEquation(EquationGet);

			double lwrBrd = 0.0;
			double uppBrd = 0.0;
			double accur = 0.0;

			Console.WriteLine("Lower border: ");
			var lowerBorder = Console.ReadLine().Trim();

			if (!double.TryParse(lowerBorder, out lwrBrd)) 
			{
				Console.WriteLine("Lower bound is not integer");
				Environment.Exit(1);
			}

			Console.WriteLine("Upper border: ");
			var upperBorder = Console.ReadLine().Trim();

			if (!double.TryParse(upperBorder, out uppBrd)) 
			{
				Console.WriteLine("Upper bound is not integer");
				Environment.Exit(2);
			}

			if (lwrBrd.CompareTo(uppBrd) > 0) 
			{
				Console.WriteLine("Lower bound greater than upper");
				Environment.Exit(3);
			}

			Console.WriteLine("accuracy: ");
			var accuracy = Console.ReadLine().Trim();

			if (!double.TryParse(accuracy, out accur)) 
			{
				Console.WriteLine("accuracy is not integer");
				Environment.Exit(4);
			}

			Console.WriteLine(Dihotomy.Dihotomy.DichotomySolve(lwrBrd, uppBrd, GetEq, accur));
		}
	}
}
