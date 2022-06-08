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
                int val = random.Next();

                if (IsPossitve.Next() % 2 != 0)
                    val = val * -1;

                list.Add(val);
            }

            return list;
        }
    }
}
