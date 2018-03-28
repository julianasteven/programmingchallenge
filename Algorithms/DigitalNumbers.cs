using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class DigitalNumbers
	{
		string[][] one = new string[5][]
		{
			new string[] { " "," ", " " },
			new string[] { " ","|", " " },
			new string[] { " "," ", " " },
			new string[] { " ","|", " " },
			new string[] { " "," ", " " },
		};
		string[][] two = new string[5][]
		{
			new string[] { " ","- ", " " },
			new string[] { " "," ", "|" },
			new string[] { " ","-", " " },
			new string[] { "|", " ", " " },
			new string[] { " ","-", " " },
		};

		string[][] three = new string[5][]
		{
			new string[] { " ", "-", " " },
			new string[] { " ", " ", "|" },
			new string[] { " ", "-", " " },
			new string[] { " ", " ", "|" },
			new string[] { " ", "-", " " },
		};


		public string Compute()
		{
			string[] num = { "1", "2" };
			int expander = 2;
			Console.WriteLine(one[1].Count());
			for (int i=0;i< 5; i++)
			{
				string line = string.Empty;
				//Console.WriteLine(one[i][0]+one[i][1]+one[i][2] +" "+ two[i][0]+two[i][1]+two[i][2]);
					foreach (string s in num)
					{
						switch (s)
						{
							case "1":
								line = line + one[i][0] + one[i][1] + one[i][2];
								break;
							case "2":
								line = line + two[i][0] + two[i][1] + two[i][2];
								break;
						}
					}
				Console.WriteLine(line);
			}

			return "";
		}
	}
}



//how do you make the pattern
