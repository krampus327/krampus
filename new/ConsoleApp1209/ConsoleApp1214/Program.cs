using System;

namespace ConsoleApp1214
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //Camel case
    //Class Function , namespace등은 대문자로 시작한다.
    //변수는 소문자로 시작한다.
    //단어가 바뀔때 첫 문자는 대문자로 시작한다.

    //줄임말은 되도록 사용하지 않는다.
    //이름을 보았을때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
    //애매핟거나 복잡한 내용이 있으면 주석을 달아준다.
    class Person
        //사람클래스이다.
        //말하는 기능이 있다.

    {

        // bit = 한자리 이진수.( 0과 1 . 정보 처리의 최소단위 ) 

        // 1 byte = 8 bit. ( CPU의 데이터 처리 최소 단위. ) 

        // 4 byte = 8*4 bit = 32 bit. 

        // 표현할 수 있는 수의 범위는 2^(bit 수). 

        public int age; // 4 byte 정수 -2147483648~2147483647 

        public float height; // 4 byte 실수 

        public bool isFemale; // 1 byte 논리 

        public char genderChar; // 2 byte 문자 

        public string name; // 문자열. 문자 갯수 * 2 byte 크기 

        //모든 말하는 함수를 호출한다.
        void Sayallinfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }

        //입력 -> 함수기능 -> 출력
        void SayAge()
        {
            Console.WriteLine(age);
        }
        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void SayName()
        {
            Console.WriteLine(name);
        }
    }

}