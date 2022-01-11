using System;

namespace ConsoleApp1209_3

{

    class Program

    {

        static bool condition1 = false;

        static bool condition2 = false;

        static bool condition3 = false;



        static void Main(string[] args)

        {

            if (condition1)

            {

                Console.WriteLine("조건 1이 참이다");

            }

            else if (condition2)

            {

                Console.WriteLine("조건 1이 거짓이고 조건 2가 참이다");

            }

            else if (condition3)

            {

                Console.WriteLine("조건 1,2가 거짓이고 조건 3이 참이다");

            }

            else

            {

                Console.WriteLine("조건 1,2,3 모두 거짓이다");

            }

        }

    }

}

//객체선정

//추상화 : 사람의 특징과 정보 요약, 사람은 나이와 키와 남자인지 여자인지와 이름이 있다

//클래스화 (설계도 제작) : 추상화에서 각 특징과 요소들의 형태를 정의
//변수"나이"는 정수형이다
//변수"키"는 실수형이다.
//변수"여자인가?"는 논리형이다.
//변수"성별문자"는 문자형이다.
//변수"이름"은 문자열이다.

//객체화 : (설계도로 객체를 만든다, 찍어낸다.)
//객체 : 클래스로 만들어진 사물/개념

//인스턴스화 : (클래스로 생성한 객체를 메모리에 할당해준다.)
//인스턴스 : 메모리에 할당된 객체