using System;
using ConverterNumSys;

namespace lab_4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] values = new int[2];
			string[] valuesStr = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (valuesStr.Length != 2) 
			{
				Console.WriteLine("incorrect count of arguments");
				System.Environment.Exit(1);
			}

			if (!(int.TryParse(valuesStr[0], out values[0])) || !(int.TryParse(valuesStr[1], out values[1]))) 
			{
				Console.WriteLine("arguments is not integers");
				System.Environment.Exit(2);
			}

			Console.WriteLine(valuesStr[0] + " in " + valuesStr[1] + " = " + ConverterNumSys.ConverterNumSys.Converter(values[0], values[1]));
		}
	}
}
