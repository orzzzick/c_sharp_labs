using System;
using System.Text;
using SortingStr;

namespace lab_7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StringBuilder strBuild = new StringBuilder(Console.ReadLine().Trim());			
			Console.WriteLine("Sorted string: " + SortingStr.SortingStr.Sorting(strBuild));   
		}
	}
}
