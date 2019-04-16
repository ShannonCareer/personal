using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAccAttchRater
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Attachment Rater";

			int boxesSold = 0; //phone devices
			//int billPays = 0;
			double accessRate = 0.0;
			double attachRate = 0.0; //accessRate / boxesSold

			boxesSold = int.Parse(Prompt("Enter the number of Boxes Sold: "));

			accessRate = double.Parse(Prompt("Enter the amount of accessory sales: "));

			attachRate = accessRate / Convert.ToDouble(boxesSold);

			Console.WriteLine("The attach rate for the day is: $" + attachRate);

			Console.ReadKey();
		}

		static string Prompt(string msg)
		{
			Console.Write(msg + "");
			return Console.ReadLine();		
		}
	}
}
