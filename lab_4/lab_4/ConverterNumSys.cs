using System;

namespace ConverterNumSys
{
	public class ConverterNumSys
	{
		private static string Correct(int remains)
		{
			string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
				"N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

			string remainStr = "";
			string result = "";

			if (remains > 9) 
			{
				remainStr = remains.ToString();
				remainStr = letters[int.Parse(remainStr) - 10];
				result = remainStr + result;
			} 
			else 
			{
				result = Convert.ToString(remains) + result;
			}

			return result;
		}

		public static string  Converter(int number, int numBase) 
		{
			string result = "";
			int remains = 0;

			if (number > 0) 
			{
				while (number / numBase != 0) 
				{
					remains = number % numBase;
					result = Correct(remains) + result;
					number = number / numBase;
				}

				result = Convert.ToString(Correct(number % numBase)) + result;
			}

			return result;
		}
	}
}
