using System;
using System.Text;

namespace SortingStr
{
	public class SortingStr
	{
		public static StringBuilder Sorting(StringBuilder str)
		{
			for (int i = 0; i < str.Length - 1; i++) 
			{
				for (int j = 0; j < str.Length - i - 1; j++) 
				{
					if (str[j + 1] < str[j]) 
					{
						var temp = str[j + 1];
						str[j + 1] = str[j];
						str[j] = temp;
					}
				}
			}

			return str;
		}
	}
}
