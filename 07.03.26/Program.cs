using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._26
{
    class Program
    {
        public static int GetSum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {

            Task<int> task1 = Task<int>.Factory.StartNew(() =>
            GetSum(4,5)
            );
            int result = task1.Result;
            Console.WriteLine(result);

        }
    }
}
