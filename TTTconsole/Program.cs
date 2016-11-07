using System;

namespace TTTconsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
		static char[] LoadGrid()
		{
			for (int i = 1; i < 10; i++)
			{		
				grid[i] = (char)(i + 48);
			}
			return grid;
		}
	}
}