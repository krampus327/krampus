﻿namespace UnityLessonCsharpDiceGame
{
    internal class Tileinfo_Star : Tileinfo
    {
        public int starValue = 3; //플레이어가 획득할 수 있는 샛별 갯수 정보

        public override void TileEvent()
        {
            base.TileEvent();
            {
                base.TileEvent();
                starValue++;
            }
        }
    }
}