using System;

namespace TextSearcher
{
	public class TextSearcher
	{
		public static int SearchWord(string[] strArr, string word) 
		{
			int count = 0;

			foreach (string str in strArr) 
			{
				if (str.Equals (word))
					++count;		
			}

			return count;
		}

		public static void Change(string[] strArr, string word) 
		{
			if (strArr.Length < 2) 
			{
				Console.WriteLine("less than 2 words in string");
				System.Environment.Exit(1);
			}

			strArr[strArr.Length - 2] = word;
		}

		public static string SeachKUpper(string[] strArr, int k) 
		{
			if (k < 0) 
			{
				Console.WriteLine("incorrect k");
				System.Environment.Exit(2);
			}

			var counter = 0;
			for (int i = 0; i < strArr.Length; i++) 
			{
				if (strArr[i][0].Equals(strArr[i].ToUpper()[0])) 
				{
					++counter;

					if (k == counter) 
					{
						return strArr[i];
					}
				}
			}

			if (k > counter) 
			{
				Console.WriteLine("not enough uppercase words");
				System.Environment.Exit(3);
			}

			return " ";
		}
	}
}
