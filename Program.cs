using System;

namespace DeletingfromMiddleofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deleting from any point in array

            int[] intArray = new int[6];
            int length = 0;
            Console.WriteLine("Oringinal Array: ");

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("New Array: ");

            for (int i = 2; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;

            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
