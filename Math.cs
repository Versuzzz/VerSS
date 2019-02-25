using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Math
    {
        public static void BinPow(int a, int n)
        {
            var use = 0;
            if (use == n)
            {
                Console.WriteLine($"n={use},a={a}");
            }
            else
            {
                a *= a;
                BinPow(a,n);
                use++;
            }
        }
    }
}
