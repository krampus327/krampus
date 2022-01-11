using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLessonCsharpDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public int a = 4;
        public int b = 7;
        public int sumValue;
        public int subValue;
        public int divValue;
        sumValue = Sum(a, b);
        subValue = Sub(a, b);
        divValue = Div(a, b);
        PrintCalc(sumVlaue, subValue, divValue);

        CalcDelegate CD_sum = Sum;
        CalcDelegate CD_sub = Sub;
        CalcDelegate CD_div = delegate (int a, int b)
        {
            return a / b;
        }

            static int Sum(int a, int b)
            {
                return a + b;
            }
            static int Sub(int a, int b)
            {
                return a - b;
            }
            static int Div(int a, int b)
            {
                return a / b;
            }
            static void PrintCalc(int a, int b)
            {
                Console.WriteLine("Sum : (sumValue)");
                Console.WriteLine("Sub : (subValue)");
                Console.WriteLine("Div : (divValue)");
            }
            static void PrintCalc(int a, int b, Calcdelegate sum, Calcdelegate sub, Calcdelegate div)
            {
                Console.WriteLine($"Sum")
            }
    }
}
//delegate 대리자
//함수의 인자로 함수를 받고 싶을때

//delegate 반환형 델리게이트이름(인자);