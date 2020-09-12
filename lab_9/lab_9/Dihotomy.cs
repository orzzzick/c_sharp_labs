using System;

namespace Dihotomy
{
	public delegate double delegateEquation(double x);

	public class Dihotomy
	{
		private const double Eps = 1e-15;

		public static double DichotomySolve(double borderFirst, double borderSecond, delegateEquation GetEq, double accuracy) 
		{
			double a = borderFirst, b = borderSecond, c = 0, fa, fb, fc;

			fa = GetEq(a);
			fb = GetEq(b);

			if (fa * fb > 0) 
			{
				Console.WriteLine("На данном промежутке нет корней");
				Environment.Exit(1);
			}

			if (Math.Abs(fa).CompareTo(accuracy) < 0) 
			{
				return a;       
			}

			if (Math.Abs(fb).CompareTo(accuracy) < 0) 
			{
				return b;
			}

			do
			{
				c = a + 0.5 * (b - a);
				fc = GetEq(c);

				if (Math.Abs(fc).CompareTo(accuracy) < 0) 
					break;

				if (fa * fc < 0) 
					b = c; 
				else 
					a = c;
			}
			while (Math.Abs(a - b).CompareTo(accuracy) > 0);

			return c;
		}
	}
}
