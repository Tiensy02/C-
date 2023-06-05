using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[3];
            for ( int i = 0; i < array.Length; i++ )
            {
                array[i] = i;
            }
            foreach(int i in array )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(array[3]);

        }
       
    }
}
