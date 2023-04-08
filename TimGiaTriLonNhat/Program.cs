using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimGiaTriLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            Console.WriteLine("Max value in the array: " + max);

        }
    }
}
