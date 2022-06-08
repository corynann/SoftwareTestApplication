using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestApplication.UnitTests
{
    internal static class Utilities
    {
        internal static List<int> RandomInts(int count)
        {
            List<int> list = new List<int>();

            Random random = new Random();
            Random IsPossitve = new Random();

            for (int i = 0; i < count; i++)
            {
                int val = random.Next(int.MinValue / count, int.MaxValue / count);

                list.Add(val);
            }

            return list;
        }

        internal static List<double> RandomDoubles(int count)
        {
            List<double> list = new List<double>();

            Random random = new Random();
            Random IsPossitve = new Random();

            for (int i = 0; i < count; i++)
            {
                double val = random.Next((int)(double.MinValue / count), (int)(double.MaxValue / count)) ;

                list.Add(val);
            }

            return list;
        }
    }
}
