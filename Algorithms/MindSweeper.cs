using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class MindSweeper
	{
		public string[,] matrix;
		private int x;
		private int y;
		public MindSweeper(int x, int y)
		{
			matrix = new string[x, y];
			this.x = x;
			this.y = y;
		}

		public string[,] FillMatrix(string[,]input)
		{
			for(int i = 0; i < input.GetLength(0); i++ )
			{
				for(int j = 0; j < input.GetLength(1); j++)
				{
					if (input[i,j] != "*")
					{
						input[i, j] = "0";
					}
				}
			//	Console.WriteLine(input[i, 0] + " " + input[i,1] + " " + input[i, 2] + " " + input[i, 3]);
				matrix = input;
			}
			return input;
		}

		public void Compute(string[,] input)
		{
			for(int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input.GetLength(1); j++)
				{
					if (input[i, j] == "*")
					{
						if (i == 0)
						{
							if (j == 0)
							{
								input[i, j + 1] = input[i, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i, j + 1]) + 1).ToString();
								input[i + 1, j] = input[i + 1, j].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j]) + 1).ToString();
								input[i + 1, j + 1] = input[i + 1, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j + 1]) + 1).ToString();
							}
							if (j > 0 && j < input.GetLength(1))
							{
								input[i, j - 1] = input[i,j - 1].ToString() == "*" ? "*" : (Int32.Parse(input[i, j - 1]) + 1).ToString();
								if (i != input.GetLength(0) - 1)
								{
									input[i + 1, j - 1] = input[i + 1, j - 1].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j - 1]) + 1).ToString();
									input[i + 1, j] = input[i + 1, j].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j]) + 1).ToString();
								}
								if (j != input.GetLength(1) - 1)
								{
									input[i, j + 1] = input[i, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i, j + 1]) + 1).ToString();
									input[i + 1, j + 1] = input[i + 1, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j + 1]) + 1).ToString();
								}
							}
							if (i == input.GetLength(0))
							{
								input[i, j - 1] = input[i, j - 1].ToString() == "*" ? "*" : (Int32.Parse(input[i, j - 1]) + 1).ToString();
								input[i + 1, j - 1] = input[i + 1, j - 1].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j - 1]) + 1).ToString();
								input[i + 1, j] = input[i + 1, j].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j]) + 1).ToString();
							}
						}

						if (i > 0 && i < input.GetLength(0))
						{
							if (j == 0)
							{
								input[i - 1, j] = input[i - 1, j].ToString() == "*" ? "*" : (Int32.Parse(input[i - 1, j]) + 1).ToString();
								input[i - 1, j + 1] = input[i - 1, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i - 1, j + 1]) + 1).ToString();
								input[i, j + 1] = input[i, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i, j + 1]) + 1).ToString();
								input[i + 1, j] = input[i + 1, j].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j]) + 1).ToString();
								input[i + 1, j + 1] = input[i + 1, j + 1].ToString() == "*" ? "*" : (Int32.Parse(input[i + 1, j + 1]) + 1).ToString();
							}

							if (j > 0 && j < input.GetLength(1))
							{
								input[i - 1, j - 1] = input[i - 1, j - 1].ToString() == "*" ? "*" : (Int32.Parse(input[i - 1, j - 1]) + 1).ToString();
								input[i - 1, j] = input[i - 1, j] == "*" ? "*" : (Int32.Parse(input[i - 1, j]) + 1).ToString();
								input[i, j - 1] = input[i, j - 1] == "*" ? "*" : (Int32.Parse(input[i, j - 1]) + 1).ToString();

								if (j != input.GetLength(1) - 1)
								{
									input[i - 1, j + 1] = input[i - 1, j + 1] == "*" ? "*" : (Int32.Parse(input[i - 1, j + 1]) + 1).ToString();
									input[i, j + 1] = input[i, j + 1] == "*" ? "*" : (Int32.Parse(input[i, j + 1]) + 1).ToString();
								}
								if ( i != input.GetLength(0) - 1)
								{
									input[i + 1, j - 1] = input[i + 1, j - 1] == "*" ? "*" : (Int32.Parse(input[i + 1, j - 1]) + 1).ToString();
									input[i + 1, j] = input[i + 1, j] == "*" ? "*" : (Int32.Parse(input[i + 1, j]) + 1).ToString();
									input[i + 1, j + 1] = input[i + 1, j + 1] == "*" ? "*" : (Int32.Parse(input[i + 1, j + 1]) + 1).ToString();
								}
								
							}
							if (j == input.GetLength(1))
							{
								input[i - 1, j - 1] = input[i - 1, j - 1] == "*" ? "*" : (Int32.Parse(input[i - 1, j - 1]) + 1).ToString();
								input[i - 1, j] = input[i - 1, j] == "*" ? "*" : (Int32.Parse(input[i - 1, j]) + 1).ToString();
								input[i + 1, j - 1] = input[i + 1, j - 1] == "*" ? "*" : (Int32.Parse(input[i + 1, j - 1]) + 1).ToString();
							}
						}

						//if ( i == input.GetLength(0))
						//{
						//	if (j == 0)
						//	{
						//		input[i - 1, j] = (Int32.Parse(input[i - 1, j]) + 1).ToString();
						//		input[i - 1, j + 1] = (Int32.Parse(input[i - 1, j + 1]) + 1).ToString();
						//		input[i, j + 1] = (Int32.Parse(input[i, j + 1]) + 1).ToString();
						//	}

						//	if (j > 0 && j < input.GetLength(1))
						//	{
						//		input[i - 1, j - 1] = (Int32.Parse(input[i - 1, j - 1]) + 1).ToString();
						//		input[i - 1, j] = (Int32.Parse(input[i - 1, j]) + 1).ToString();
						//		input[i - 1, j + 1] = (Int32.Parse(input[i - 1, j + 1]) + 1).ToString();
						//		input[i, j - 1] = (Int32.Parse(input[i, j - 1]) + 1).ToString();
						//		input[i, j + 1] = (Int32.Parse(input[i, j + 1]) + 1).ToString();
						//	}

						//	if (j == input.GetLength(1))
						//	{
						//		input[i, j - 1] = (Int32.Parse(input[i, j - 1]) + 1).ToString();
						//		input[i -1 , j - 1] = (Int32.Parse(input[i - 1, j - 1]) + 1).ToString();
						//		input[i - 1, j] = (Int32.Parse(input[i - 1, j]) + 1).ToString();
						//	}
						//}
					}
					
				}
			}
			for (int i = 0; i < input.GetLength(0); i++)
			{
				string output = String.Empty;
				for (int j = 0; j < input.GetLength(1); j ++)
				{
					output += input[i, j] + " ";
				}
				Console.WriteLine(output);
			}
		}
	}
}
