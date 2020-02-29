using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing array of length 64
            int[] MyArray = new int[64];
            for(int i = 0; i < MyArray.Length; i++)
            {
                //assigning value of index i to My Array
                MyArray[i] = i;

            }

            //printing value of MyArray
            foreach(var i in MyArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
