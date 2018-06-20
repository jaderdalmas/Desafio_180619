using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Helper
{
    public class Fibonacci
    {
        static long RecursivaTradicional(int n)
        {
            if (n < 2)
                return n;
            else
                return RecursivaTradicional(n - 1) + RecursivaTradicional(n - 2);
        }

        static long RecursivaTerneiro(int n)
        {
            return (n < 2) ? n : RecursivaTerneiro(n - 1) + RecursivaTerneiro(n - 2);
        }

        static long Iterativa(int n)
        {
            int F = (n > 0 ? 1 : 0); // atual
            int ant = 0; // anterior

            for (int i = 2; i <= n; i++)
            {
                F += ant;
                ant = F - ant;
            }

            return F;
        }
    }
}