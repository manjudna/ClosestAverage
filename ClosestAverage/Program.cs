using System;
using System.Linq;

namespace ClosestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int len=Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }         
            
            Console.WriteLine("The closest average for given array is: " + ClosestAve(arr));
            Console.ReadLine();
        }

        /// <summary>
        /// Finds and returns the closest ave for given array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int ClosestAve(int[] arr)
        {
            var av = arr.Sum() / arr.Length;
            var nearest = arr.OrderBy(x => Math.Abs((long)x - av)).First();
            return nearest;
        }
    }
}
