using System;

namespace P127.HW._14._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 70, 65, 100, 90, 30, 95, 40 };
        }
        public static int firstMethod(int[] points,ref int SumStudy)
        {
            int sum = 0;
            for (int i = 0; i < points.Length; i++)
            {
                
                sum += points[i];
                
            }
            return sum;
        }
        public static int secondMethod(int SumPoints,ref int SumStudy)
        {
            return SumPoints / SumStudy;
        }
    }
}
