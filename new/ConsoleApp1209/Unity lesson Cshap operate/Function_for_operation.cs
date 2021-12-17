using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_lesson_Cshap_operate
{
    class Function_for_operation
    {
        //산술연산
        //덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        static public int Div(int a, int b)
        {
            return a / b;
        }
        static public int Rem(int a, int b)
        {
            return a % b;
        }
        static public int Inc(int a)
        {
            return a++;
        }
        static public int Dec(int a)
        {
            return a--;
        }
        static public bool isSame(int a, int b)
        {
            return a == b;
        }
        static public bool isDeference(int a, int b)
        {
            return a != b;
        }
    }
}
