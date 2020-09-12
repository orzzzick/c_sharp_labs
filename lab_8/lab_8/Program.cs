using System;
using System.Text;
using TextSearcher;

namespace lab_8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var mainStr = Console.ReadLine().Split(new char[] { ' ' , '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (mainStr.Length == 0) 
			{
				Console.WriteLine("Nothing was input");
				System.Environment.Exit(1);
			}

			Console.Write("Input a word: ");
			var word = Console.ReadLine().Split(new char[] { ' ' , '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (word.Length != 1) 
			{
				Console.WriteLine("incorrect input");
				System.Environment.Exit(1);
			}

			Console.WriteLine("Count: " + TextSearcher.TextSearcher.SearchWord(mainStr, word[0]));


			Console.WriteLine("Input a change word: ");
			var changeWord = Console.ReadLine().Split(new char[] { ' ' , '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (changeWord.Length != 1) 
			{
				Console.WriteLine("incorrect input");
				System.Environment.Exit(1);
			}

			TextSearcher.TextSearcher.Change(mainStr, changeWord[0]);

			Console.Write("New String: ");
			foreach (string str in mainStr)
				Console.Write(str + " ");
					

			Console.WriteLine("\ninput k: ");
			var kStr = Console.ReadLine().Trim().Split(new char[] { ' ' , '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (kStr.Length != 1) 
			{
				Console.WriteLine("incorrect input");
				System.Environment.Exit(1);
			}

			int k = 0;
			if (!int.TryParse(kStr[0], out k)) 
			{
				Console.WriteLine("k is not integer");
				System.Environment.Exit(1);
			}

			Console.WriteLine("Upper k-word: " + TextSearcher.TextSearcher.SeachKUpper(mainStr, k));
		}
	}
}
