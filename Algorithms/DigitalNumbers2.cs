using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class DigitalNumbers2
	{

		List<string> one = new List<string>();
		List<string> two = new List<string>();
		List<String> three = new List<string>();
		List<string> four = new List<string>();
		List<string> five = new List<string>();
		List<string> six = new List<string>();
		List<string> seven = new List<string>();
		List<string> eight = new List<string>();
		List<string> nine = new List<string>();
		List<string> zero = new List<string>();
		
		public DigitalNumbers2()
		{
			one.Add("   ");
			one.Add(" | ");
			one.Add("   ");
			one.Add(" | ");
			one.Add("   ");

			two.Add(" - ");
			two.Add("  |");
			two.Add(" - ");
			two.Add("|  ");
			two.Add(" - ");

			three.Add(" - ");
			three.Add("  |");
			three.Add(" - ");
			three.Add("  |");
			three.Add(" - ");

			four.Add("   ");
			four.Add("| |");
			four.Add(" - ");
			four.Add("  |");
			four.Add("   ");

			five.Add(" - ");
			five.Add("|  ");
			five.Add(" - ");
			five.Add("  |");
			five.Add(" - ");

			six.Add(" - ");
			six.Add("|  ");
			six.Add(" - ");
			six.Add("| |");
			six.Add(" - ");

			seven.Add(" - ");
			seven.Add("  |");
			seven.Add("   ");
			seven.Add("  |");
			seven.Add("   ");

			eight.Add(" - ");
			eight.Add("| |");
			eight.Add(" - ");
			eight.Add("| |");
			eight.Add(" - ");

			nine.Add(" - ");
			nine.Add("| |");
			nine.Add(" - ");
			nine.Add("  |");
			nine.Add(" - ");

			zero.Add(" - ");
			zero.Add("| |");
			zero.Add("   ");
			zero.Add("| |");
			zero.Add(" - ");
		}


		public string Compute()
		{
			string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
			int expander = 3;
			List<string> newOne = new List<string>();
			List<string> newTwo = new List<string>();
			List<string> newThree = new List<string>();
			List<string> newFour = new List<string>();
			List<string> newFive = new List<string>();
			List<string> newSix = new List<string>();
			List<string> newSeven = new List<string>();
			List<string> newEight = new List<string>();
			List<string> newNine = new List<string>();
			List<string> newZero = new List<string>();


			for (int i=0;i< 5; i++)
			{
				string value = string.Empty;
				string requiredString = string.Empty;
				bool copy = false;
				foreach (string s in num)
				{
					switch (s)
					{
						case "1":
							value = one[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);
							
							newOne.Add(requiredString);
							if (copy)
									for (int j = 1; j < expander; j++)
										newOne.Add(requiredString);
							break;
						case "2":
							value = two[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newTwo.Add(requiredString);
							if (copy)
								for(int j = 1; j < expander; j++)
									newTwo.Add(requiredString);
							break;
						case "3":
							value = three[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);
							
							newThree.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newThree.Add(requiredString);
							break;
						case "4":
							value = four[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);
							newFour.Add(requiredString);
							if(copy)
								for (int j = 1; j < expander; j++)
									newFour.Add(requiredString);
							break;
						case "5":
							value = five[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);
							newFive.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newFive.Add(requiredString);
							break;
						case "6":
							value = six[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newSix.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newSix.Add(requiredString);
							break;
						case "7":
							value = seven[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newSeven.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newSeven.Add(requiredString);
							break;
						case "8":
							value = eight[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newEight.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newEight.Add(requiredString);
							break;
						case "9":
							value = nine[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newNine.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newNine.Add(requiredString);
							break;
						case "0":
							value = zero[i];
							requiredString = string.Empty;
							copy = false;
							requiredString = Create(value, expander, ref copy);

							newZero.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newZero.Add(requiredString);
							break;

					}
				}
			}

			int length = newOne.Count();
			int width = newOne[0].Length - 1;
			bool expand = false;
			for (int i = 0; i < length; i++)
			{
				string line = string.Empty;
				
				foreach (string s in num)
				{
					switch (s)
					{
						case "1":
							expand = false;
							if (newOne[i].Length != one[0].Length + expander - 1)
							{
								expand = true;
							}
							line = line + BuildLine(newOne[i], expander, expand) + ' ';
							break;
						case "2":
							expand = false;
							if (newTwo[i].Length != two[0].Length + expander - 1)
							{
								expand = true;
							}
							line = line + BuildLine(newTwo[i],expander,expand) + ' ';
							break;
						case "3":
							expand = false;
							if (newThree[i].Length != three[0].Length + expander - 1)
							{
								expand = true;
							}
							line = line + BuildLine(newThree[i], expander, expand) + ' ';
							break;
						case "4":
							expand = false;
							if (newFour[i].Length != four[0].Length + expander - 1)
							{
								expand = true;
							}
							line = line + BuildLine(newFour[i], expander, expand) + ' ';
							break;
						case "5":
							expand = false;
							if (newFive[i].Length != five[0].Length + expander - 1)
							{
								expand = true;
							}
							line = line + BuildLine(newFive[i], expander, expand) + ' ';
							break;
					}
				}
				Console.WriteLine(line);
			}
			//Console.WriteLine("Line:");

			//foreach (var a in newOne)
			//	Console.WriteLine(a);
			//foreach (var a in newTwo)
			//	Console.WriteLine(a);
			//foreach(var a in newThree)
			//	Console.WriteLine(a);
			//foreach(var a in newFour)
			//	Console.WriteLine(a);
			//foreach (var a in newFive)
			//	Console.WriteLine(a);
			//foreach (var a in newSix)
			//	Console.WriteLine(a);
			//foreach (var a in newSeven)
			//	Console.WriteLine(a);
			//foreach (var a in newEight)
			//	Console.WriteLine(a);
			//foreach (var a in newNine)
			//	Console.WriteLine(a);
			//foreach (var a in newZero)
			//	Console.WriteLine(a);
			return "";
		}

		private string BuildLine(string numberToProcess, int expander, bool expand)
		{
			int ctr = 0;
			string line = string.Empty;
			while (ctr < numberToProcess.Length)
			{
				line = line + numberToProcess[ctr];
				ctr++;
			}
			if (expand)
			{
				ctr = 1;
				while(ctr < expander)
				{
					line = line + ' ';
					ctr++;
				}
			}
			return line;
		}

		public string Create(string value, int expander, ref bool copy)
		{
			string requiredString = string.Empty;
			int index = 0;
			//if (value.Equals("   "))
			//{
			//	for (int j = 1; j <= expander; j++)
			//	{
			//		value = value + " ";
			//	}
			//	requiredString = requiredString + value;
			//} else
			//{
				foreach (var a in value)
				{
					index++;
					string requiredOne = string.Empty;
					if (a == ' ')
					{
						requiredString = requiredString + a;
						//string spaceExpander = string.Empty;
						//for (int j = 1; j <= expander; j++)
						//{
						//	spaceExpander = a + " ";
						//}
						//requiredString = requiredString + spaceExpander;
					}
						
					if (a == '-')
					{
						for (int j = 1; j <= expander; j++)
						{
							if (j == expander)
								requiredOne = requiredOne + a;
							else
								requiredOne = requiredOne + "-";
						}
						requiredString = requiredString + requiredOne;
					}
					if (a == '|')
					{
						if (value.StartsWith("|") && index == 1)
						{
							requiredOne = requiredOne + "|";
							requiredString = requiredString + requiredOne;
						}
						else
						{
							for (int j = 1; j <= expander; j++)
							{
								if (j == expander)
									requiredOne = requiredOne + a;
								else
									requiredOne = requiredOne + " ";
							}
							requiredString = requiredString + requiredOne;
						}

						copy = true;
					}
				}
			//}

			return requiredString;

		}
	}
}
