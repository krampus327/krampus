using System;

namespace 스태틱_샘플
{
    class Program
    {
        static void Main(string[] args)
        {
            orc orc1 = new orc();
            orc1.name = "오크";
            orc1.height = 240.0f;

            orc.typeName = "오크타입설계도";
            orc.SayTypeName();

            Person person1 = new Person();

            //static 멤버(변수의 함수)는 객체단위로 접근할 수가 없다.
            //static으로 정의된 클래스는 인스턴스화가 불가능하다.
        }
    }
    class orc
    {
        //접근제한자
        //자료형 앞에 붙어서 해당 변수/함수/클래스의 접근권한을 지정한다.
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        //static 키워드는 정적 성질을 부여하는 키워드
        //정적 이라는 것은 메모리에 할당할 수가 없다 라는 뜻
        //반대로 동적은 메모리 할당이 가능하다.
        static public string typeName;

        static public void SayTypeName;
        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다");
        }
    }
    static class Person
    {
        //static class를 쓰는 이유
        //객체를 찍어내는 것이 아니라 정보,기능,개념등이 유일하게 필요한 경우
        //
    }
}
