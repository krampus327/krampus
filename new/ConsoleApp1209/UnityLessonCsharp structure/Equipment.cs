using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLessonCsharp_structure
{
    class Equipment
    {
        //예제
        //아래 장비 능력치들을 EquipmentAbility 라는 구조체로 정의하고
        public int _ATK;
        public int _DEX;
        public int _HP;
        public int _MP;
        public int _Durability;
        public Stats _stats;

        //stats 형 멤버변수도 정의한다.
    }
    struct EquipmentAbility
    {
        public int _ATK;
        public int _DEX;
        public int _HP;
        public int _MP;
        public int _Durability;
    }
    class Equipment1
    {

    }
}
