using System;
using MathConst;

namespace lab_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			decimal pi = 0;
			decimal e = 0;
			decimal ln2 = 0;

			MathConst.MathConst.Calcul(out pi, out e, out ln2);
			Console.WriteLine(" Pi = " + pi);
			Console.WriteLine("  E = " + e);
			Console.WriteLine("ln2 = " + ln2);
		}
	}
}
