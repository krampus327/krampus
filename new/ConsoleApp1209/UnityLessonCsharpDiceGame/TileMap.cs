using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLessonCsharpDiceGame
{
    internal class TileMap
    {
        public Dictionary<int, Tileinfo> dic_tile = new Dictionary<int, Tileinfo>();

        public void MapSetup(int maxTileNum)
        {
            for (int i = 0; i < maxTileNum; i++)
            {
                if (i / 5 == 0)
                {
                    Tileinfo Tileinfo_Star = new Tileinfo_Star();
                    Tileinfo_Star.index = i;
                    Tileinfo_Star.name = "Star";
                    Tileinfo_Star.discription = "This is star tile. You'll get star and star amout on this tile increase 1";
                    dic_tile.Add(i, Tileinfo_Star);
                }
                else
                {
                    Tileinfo tileinfo_Dummy = new Tileinfo();
                    tileinfo_Dummy.index = i;
                    tileinfo_Dummy.name = "Dummy";
                    tileinfo_Dummy.discription = "This is Dummy Tile";
                    dic_tile.Add(i, tileinfo_Dummy);
                }

            }
        }
    }
}
