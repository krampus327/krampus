using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLessonCsharpClassInheritance
{
    class Person : Creature , itwoLeggedwalker
    {
        public float height;

        //override : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드


        public override void Breath()
        {
            base.Breath();
            height += 0.00004f;
            weight += 0.00002f;
        }

        public void TwoLeggedWalker()
        {
            Console.WriteLine("두발로 걷는다.");
        }
    }
}
