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
		}
		
		
		public string Compute()
		{
			string[] num = { "1", "2" , "3","4"};
			int expander = 3;
			List<string> newOne = new List<string>();
			List<string> newTwo = new List<string>();
			List<string> newThree = new List<string>();
			List<string> newFour = new List<string>();
			for (int i=0;i< 5; i++)
			{
				string line = string.Empty;
				//Console.WriteLine(one[i][0]+one[i][1]+one[i][2] +" "+ two[i][0]+two[i][1]+two[i][2]);
					foreach (string s in num)
					{
					switch (s)
					{
						case "1":
							string value = one[i];
							string requiredString = string.Empty;
							bool copy = false;
							foreach (var a in value)
							{
								string requiredOne = string.Empty;
								if (a == ' ')
									requiredString = requiredString + a;
								if (a == '-')
								{
									for (int j = 1; j <= expander; j++)
									{
										if (j == expander)
											requiredOne = requiredOne + a;
										else
											requiredOne = requiredOne + " ";
									}
									requiredString = requiredString + requiredString;
								}
								if (a == '|')
								{
									for (int j = 1; j <= expander; j++)
									{
										if (j == expander)
											requiredOne = requiredOne + a;
										else
											requiredOne = requiredOne + " ";
									}
									requiredString = requiredString + requiredOne;
									copy = true;
								}
							}

							newOne.Add(requiredString);
							one[i] = requiredString;
								if (copy)
									for (int j = 1; j < expander; j++)
										newOne.Add(requiredString);
							break;
						case "2":
							//line = line + two[i] + two[i] + two[i];
							value = two[i];
							requiredString = string.Empty;
							copy = false;
							foreach (var a in value)
							{
								string requiredOne = string.Empty;
								if (a == ' ')
									requiredString = requiredString + a;
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
									if(value.StartsWith(" "))
									{
										for (int j = 1; j <= expander; j++)
										{
											if (j == expander)
												requiredOne = requiredOne + a;
											else
												requiredOne = requiredOne + " ";
										}

									} else
									{
										requiredOne = requiredOne + a;
									}
									
									requiredString = requiredString + requiredOne;
									copy = true;
								}
							}

							//Console.WriteLine("a:" +a +":");
							newTwo.Add(requiredString);
							two[i] = requiredString;
							if (copy)
								for(int j = 1; j < expander; j++)
									newTwo.Add(requiredString);
							break;
						case "3":
							value = three[i];
							requiredString = string.Empty;
							copy = false;
							foreach (var a in value)
							{
								string requiredOne = string.Empty;
								if (a == ' ')
									requiredString = requiredString + a;
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
									for (int j = 1; j <= expander; j++)
									{
										if (j == expander)
											requiredOne = requiredOne + a;
										else
											requiredOne = requiredOne + " ";
									}
									requiredString = requiredString + requiredOne;
									copy = true;
								}
							}

							//Console.WriteLine("a:" +a +":");
							newThree.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newThree.Add(requiredString);
							break;
						case "4":
							value = four[i];
							requiredString = string.Empty;
							copy = false;
							int index = 0;
							foreach (var a in value)
							{
								index++;
								string requiredOne = string.Empty;
								if (a == ' ')
									requiredString = requiredString + a;
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
									} else
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

							newFour.Add(requiredString);
							if (copy)
								for (int j = 1; j < expander; j++)
									newFour.Add(requiredString);
							break;
					}
				}

			}
			Console.WriteLine("Line:");

			foreach (var a in newOne)
				Console.WriteLine(a);
			foreach (var a in newTwo)
				Console.WriteLine(a);
			foreach(var a in newThree)
				Console.WriteLine(a);
			foreach(var a in newFour)
				Console.WriteLine(a);
			return "";
		}
	}
}



//how do you make the pattern
