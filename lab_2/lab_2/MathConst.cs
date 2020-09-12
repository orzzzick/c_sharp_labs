using System;

namespace MathConst
{
	public class MathConst
	{
		private static decimal Factor(int n)
		{
			if (n < 0) 
			{
				throw new ArithmeticException("factorial for negative number doesnt exists");
			}
			else if ((n == 0) || (n == 1))
			{
				return 1;
			}

			decimal factorial = 1;

			for (int i = 2; i <= n; i++)
			{
				factorial *= i;
			}

			return factorial;
		}

	
		public static void Calcul(out decimal pi, out decimal e, out decimal ln2) 
		{
			pi = 0;
			e = 0;
			ln2 = 0;

			for (int k = 0; k < 15; k++) 
			{
				pi = pi + (1 / (decimal)Math.Pow(16, k)) * (decimal.Divide(4, 8 * k + 1) - decimal.Divide(2, 8 * k + 4) - decimal.Divide(1, 8 * k + 5) - decimal.Divide(1, 8 * k + 6));
			}

			pi = Math.Round(pi, 15);

			// e = sum(1/n!)
			for (int n = 0; n <= 18; n++) 
			{
				e = decimal.Add(e, decimal.Divide(1, Factor(n)));
			}

			e = Math.Round(e, 15);

			// ln2 = sum(1/n*2^n)
			for (int n = 1; n < 50; n++) 
			{
				ln2 = decimal.Add(ln2, decimal.Divide(1, decimal.Multiply(n, (decimal)Math.Pow(2, n))));
			}

			ln2 = Math.Round(ln2, 15);
		}
	}
}
