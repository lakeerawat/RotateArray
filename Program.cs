using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayChallenge
{
     class Program
    {
        static void RotateArray(int[] input)
        {
            int temp = input[0];
            for (int i=0; i<input.Length-1; i++)
            {
                input[i] = input[i+1];
            }
            input[input.Length-1] = temp;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, };
            RotateArray(arr);
            Array.ForEach(arr, Console.WriteLine);
                Console.ReadLine();
        }
    }
}
