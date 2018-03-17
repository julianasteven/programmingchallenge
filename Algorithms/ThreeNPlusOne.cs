using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class ThreeNPlusOne
	{
		public int i;
		public int j;

		public ThreeNPlusOne()
		{

		}

		public ThreeNPlusOne(int i, int j)
		{
			this.i = i;
			this.j = j;
		}
		public ThreeNPlusOne(int i)
		{
			this.i = i;
			this.j = -1;
		}

		public void Compute()
		{
			String output = String.Empty;
			List<int> iterationCount = new List<int>();
			if (j == -1)
			{
				j = i;
			}
			if (i <= 0 || j == 0 || j < i || i > 1000000 || j > 1000000) 
			{
				Console.WriteLine("Bad Input");
				return;
			}
			int startNum = i;
			while ( i <= j)
			{
				int iteration = 1;
				int k = i;
				while (k != 1)
				{
					iteration++;
					output += k.ToString() + " ";
					k = Recurse(k);
				}
				output += k.ToString() + " ";
				iterationCount.Add(iteration);
				i++;
			}
			//Console.WriteLine("iteration:" + iteration);
			Console.WriteLine("{0} {1} {2}", startNum, j, iterationCount.Max());
		}

		private int Recurse(int i)
		{
			if (i % 2 == 0)
			{
				i =  i / 2;
			} else
			{
				i = (i * 3) + 1;
			}
			return i;
		}
	}
}
