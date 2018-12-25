using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("pick 2 num");
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());
			if (x > y)

			{ Console.WriteLine(x); }
			else
			{ Console.WriteLine(y); }

			
		}
	}
}
