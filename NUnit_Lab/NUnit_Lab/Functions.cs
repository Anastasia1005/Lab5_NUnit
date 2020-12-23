using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Lab
{
    class Functions
    {
        public double InchToCm(double inch)
        {
            if (inch <= 0)
            {
                throw new ArgumentException("Входящее значение не может быть меньше, либо равным нулю");
            }
            return (inch * 2.54);
        }

        public bool IsEvenNumber(int num1)
        {
            if (num1 % 2 == 0)
                return true;
            else
                return false;
        }

        public int MaxElementOnArray(int[] arr)
        {
            if (arr.Length == 0)
                throw new Exception("Пустой массив");

            int max = arr[0];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                else
                    continue;
            }
            return max;
        }

        public int RemainerOfDivision(int num1, int num2)
        {
            if (num2 == 0)
                throw new Exception("Делитель не должен быть равен нулю");
            return num1 % num2;
        }
    }
}
