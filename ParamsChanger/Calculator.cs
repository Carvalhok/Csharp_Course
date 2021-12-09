using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsChanger
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triple(ref int x)
        {
            x *= 3;
        }

        public static void Double(int origin, out int resultado)
        {
            resultado = 2 * origin;
        }
    }
}
