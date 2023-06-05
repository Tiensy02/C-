using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeLearn
{
    class generic
    {
        static void Main(String[] args)
        {
            int a = 45;
            int b = 9;
            Console.WriteLine($"gia tri cua a la: {a}, gia tri cua b la: {b}");
            swap( ref a, ref b );
            Console.WriteLine($"gia tri cua a la: {a}, gia tri cua b la: {b}");

        }
        static void swap(ref int a,  ref int b)
        {
            int step = a;
            a = b;
            b = step;
        }
    }
}
