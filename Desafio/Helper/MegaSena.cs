using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Helper
{
    public static class MegaSena
    {
        public static int[] GetMegaSena(int i)
        {
            List<int> numbers = new List<int>();

            Random r = new Random(i);
            while (numbers.Count < 6)
            {
                numbers.Add(r.Next(1, 60));
                numbers = numbers.Distinct().ToList();
            }

            return numbers.OrderBy(x => x).ToArray();
        }
    }
}