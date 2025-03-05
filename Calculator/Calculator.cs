using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static int Substract(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        
        
        public static int Multiply(int num1 , int num2)
        {
            
            return num1*num2;
        }
        public static float Divide(float num1 , float num2)
        {
            
            return num1/num2;
        }
        
    }
}
