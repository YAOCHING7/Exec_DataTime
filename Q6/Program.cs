using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int day = DateTime.Today.Day; 

			string msg = string.Empty;

			if (day > 20)
			{
				msg = "下旬";
			}
			else if (day > 10)
			{
				msg = "中旬";
			}
			else
			{
				msg = "下旬";
			}

			Console.WriteLine($"今天是本月的: {msg}");
		}
    }
}
