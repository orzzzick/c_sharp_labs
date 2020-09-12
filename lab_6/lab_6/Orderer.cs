using System;
using System.Text;

namespace Orderer
{
	public class Orderer
	{
		public static void SortAlphOrder(string[] strs, StringBuilder alphOrderStr, StringBuilder lastLtrStr) 
		{
			for (int i = 0; i < strs.Length - 1; i++) 
			{
				for (int j = 0; j < strs.Length - i - 1; j++) 
				{
					if (strs[j + 1].CompareTo(strs[j]) < 0) 
					{
						var temp = strs[j + 1];
						strs[j + 1] = strs[j];
						strs[j] = temp;
					}
				}
			}

			foreach (string str in strs) 
			{
				lastLtrStr.Append(str[str.Length - 1]);
				alphOrderStr.Append(str + ' ');
			}
		}
	}
}