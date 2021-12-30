using System;

namespace UnityLessonCsharp_garbageCollecter
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA bb = new AA(3);
        }
    }

    class AA
    {
        public AA()
        {

        }
        ~AA() // 소멸자
        {

        }
        //C#에서 소멸자를 따로 호출하지 않는 이유
        //GC(garbage Collector)가 런타임으로 쓰레기 객체를 검색해서
        //삭제하기 때문에
    }
}
