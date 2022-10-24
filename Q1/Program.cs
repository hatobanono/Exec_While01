using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int limit = 105;
			int currentNumber = 0;
			int sum = 0;

			while (sum < limit)
			{
				currentNumber++;
				sum += currentNumber;
			}
			Console.WriteLine(currentNumber-1);
		}
	}
}
