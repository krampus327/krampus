using System;

namespace C샵_array
{
    class Program
    {
        //array
        //형태 : 자료형[]
        //자료형이 정적으로 나열되어있는 형태 즉, 한번 크기를 정해놓으면 바꿀 수 없다.
        static int[] arr_testint = new int[5];
        static float[] arr_testfloat = new float[3];
        static float[] arr_testfloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_teststring = new string[3];
        static void Main(string[] args)
        {
            arr_testint[0] = 5;
            arr_testint[1] = 4;
            arr_testint[2] = 3;
            arr_testint[3] = 2;
            arr_testint[4] = 1;

            Console.WriteLine(arr_testint[0]);
            Console.WriteLine(arr_testint[1]);
            Console.WriteLine(arr_testint[2]);
            Console.WriteLine(arr_testint[3]);
            Console.WriteLine(arr_testint[4]);

            arr_testfloat[0] = 2.0f;
            arr_testfloat[1] = 4.0f;
            arr_testfloat[2] = 6.0f;

            Console.WriteLine(arr_testfloat[0]);
            Console.WriteLine(arr_testfloat[1]);
            Console.WriteLine(arr_testfloat[2]);

            arr_teststring[0] = "김아무개";
            arr_teststring[1] = "이아무개";
            arr_teststring[2] = "박아무개";

            Console.WriteLine(arr_teststring[0]);
            Console.WriteLine(arr_teststring[1]);
            Console.WriteLine(arr_teststring[2]);
        }
    }
}

//반복문 1.for문 , 2.while문 3.foreach문 4.do while문

//분기문 1.if문 2.swich-case문