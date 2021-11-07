using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp2_11._7._21_CM
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<int> listNumbersOne = new List<int>
            {
                1,
                2
            };

            List<int> listNumbersTwo = new List<int>
            {
                3,
                4
            };

            double medianResult = FindMedianSortedArrays(listNumbersOne.ToArray(), listNumbersTwo.ToArray());

            Console.WriteLine(medianResult.ToString());
            Console.ReadKey();
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double[] arrayOne = Array.ConvertAll<int, double>(nums1, x => x);
            double[] arrayTwo = Array.ConvertAll<int, double>(nums2, x => x);

            double[] concatenatedArray = ConcatenateArrays(arrayOne, arrayTwo);

            int arrayLength = concatenatedArray.Length;

            Array.Sort(concatenatedArray);

            double medianResult = new double();

            if (arrayLength % 2.0 == 0)
            {
                double middleElement1 = concatenatedArray[(arrayLength / 2) - 1];
                double middleElement2 = concatenatedArray[arrayLength / 2];
                medianResult = (middleElement1 + middleElement2) / 2;
            }
            else
            {
                medianResult = concatenatedArray[arrayLength / 2];
            }

            return medianResult;
        }

        private static double[] ConcatenateArrays(double[] arrayOne, double[] arrayTwo)
        {
            double[] concatenatedArray;

            if (arrayOne == null)
                _ = arrayTwo;

            if (arrayTwo == null)
                _ = arrayOne;

            concatenatedArray = arrayOne.Concat(arrayTwo).ToArray();

            return concatenatedArray;
        }
    }
}
