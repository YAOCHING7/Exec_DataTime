using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            int year = today.Year;
            int month = today.Month;

            DateTime result = new DateTime(year, month, 1);

            var dt = result.AddMonths(1);
            var dt2 = dt.AddDays(-1);
        }
    }
}
