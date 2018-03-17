using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Start
    {
		public const int THREE_N_PLUS_ON = 1;
		public const int MINDSWEEPER = 2;
		public const int DIGITALNUMBERS = 3;
		public static void Main(string[] args)
		{
			int seed = 22;
			

			int value = 3;
			switch(value)
			{
				case THREE_N_PLUS_ON:

					ThreeNPlusOne instance = new ThreeNPlusOne(900, 1000);
					instance.Compute();
					break;
				case MINDSWEEPER:
					int x = 8;
					int y = 8;
					MindSweeper mindSweeper = new MindSweeper(x, y);
					string[,] matrix = new string[x, y];
					matrix[0, 0] = "*";
					matrix[7, 6] = "*";
					matrix[2, 1] = "*";
					matrix[4, 2] = "*";
					matrix[5, 5] = "*";
					matrix[0, 5] = "*";
					matrix = mindSweeper.FillMatrix(matrix);
					mindSweeper.Compute(matrix);
					break;
				case DIGITALNUMBERS:
					DigitalNumbers dn = new DigitalNumbers();
					dn.Compute();
					break;
				default:
					break;
			}

		}
    }
}
