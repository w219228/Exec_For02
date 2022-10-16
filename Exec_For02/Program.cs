using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 9; i += 2) 
			{
				int countOfStar = i;
				int countOfEmpty = (9 - i)/2;

				string row = new string(' ',countOfEmpty)+new string('*',countOfStar)+new string(' ',countOfEmpty);
				Console.WriteLine(row);
			}
		}
	}
}
