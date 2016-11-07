using NUnit.Framework;
using System;
using TTTconsole;

namespace TTTconsole.tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void MustPass()
		{
			int expected = 1;
			int actual = 1;
			Assert.AreEqual(expected, actual);
		}

		public void CreateTTTBoard()
		{
			char[] ExpectedGrid = new char[10];
			for (int i = 1; i < 10; i++)
			{
				ExpectedGrid[i] = (char)(i + 48);
			}

			char[] ActualGrid = LoadGrid();

			Assert.AreSame(ExpectedGrid, ActualGrid);
		}
	}
}