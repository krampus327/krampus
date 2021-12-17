using System;

namespace ConsoleApp1214_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            //점연산자
            //클래스의 멤버에 접근할때 사용, namespace안의 클래스에 접근할때 사용
            person1.age = 40; //정수형은 그냥 숫자 입력
            person1.height = 223.4f; //실수형은 숫자뒤에 f추가 입력
            person1.isFemale = false; //논리형은 true 또는 false
            person1.genderChar = '남'; //문자형은 ''작은 따옴표 안에 단일문자
            person1.name = "김아무개"; //문자열형은 ""큰따옴훂 안에 다중문자

            person1 SayAllinfo();

            Person person2 = new Person();
            person1.age = 80; //정수형은 그냥 숫자 입력
            person1.height = 123.4f; //실수형은 숫자뒤에 f추가 입력
            person1.isFemale = true; //논리형은 true 또는 false
            person1.genderChar = '여'; //문자형은 ''작은 따옴표 안에 단일문자
            person1.name = "이아무개"; //문자열형은 ""큰따옴훂 안에 다중문자
        }
    }
    class Person


    {

        //접근제한자
        //위치 : 자료형 앞
        //아무것도 안써있으면 기본적으로 private
        //public, private, protected이 있다.
        //public : 다른 클래스에서도 접근 가능
        //private : 다른 클래스에서 접근 불가능
        //protected : 상속자만 접근 가능

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
        public void Sayallinfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }

        //입력 -> 함수기능 -> 출력
        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void SayName()
        {
            Console.WriteLine(name);
        }
    }

}
}
