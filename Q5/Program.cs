using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入年份: ");
			string input = Console.ReadLine();

			int year = Convert.ToInt32(input);


			DateTime firstDay = new DateTime(year, 1, 1);
			DateTime firstSunday = firstDay;
			int weekday = (int)firstDay.DayOfWeek;
			if (weekday > 0)
			{
				firstSunday = firstDay.AddDays(7 - weekday);
			}

				Console.WriteLine($"第一個週日是{firstSunday:yyyy/MM/dd}");
			}
		}
    }
