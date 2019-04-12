using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBA_staff2019
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "The LBA Group Staff 2019";

			string[] jobs = new string[7] {"Sales","Finance","HR","PR","Custodial","CRM","iT"};

			Console.WriteLine("Until the company grows, you're going to have to do all of these jobs: ");

				for(int x = 0; x < jobs.Length; x++)
				{
				Console.WriteLine(jobs[x]); 
				} //end for loop 

			Console.Write("\n");

			Console.WriteLine("Using the foreach loop, it will display as: ");

			foreach (string roles in jobs)
			{
				Console.WriteLine(roles);
			}
			Console.Write("\n");

			Console.WriteLine("Follow us at @TheLBAGroup = Instagram ");
			Console.WriteLine("Facebook = www.facebook.com/thelbagroup.co ");

			Console.ReadKey();
		}
	}
}