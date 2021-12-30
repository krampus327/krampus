using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLessonCsharp_structure
{
    class Warrior
    {
        public Stats _stats;
        public void SetStats(int STR, int DEX, int CON, int WIS, int INT, int REG)
        {
            _stats._STR = STR;
            _stats._STR = DEX;
            _stats._STR = CON;
            _stats._STR = WIS;
            _stats._STR = INT;
            _stats._STR = REG;
        }
    }
}
