using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLessonCsharpDiceGame
{
    internal class Program
    {
        static private int totalTile = 20; //칸의 갯수
        static private int currentStarPoint = 0; //샛별 갯수
        static private int totalDiceNumber = 20; //주사위 갯수
        static private int previousTileIndex = 0; //이전 칸의 번호 (플레이어가 샛별칸을 지나는지 비교하기 위함)
        static private int currentTileIndex = 0; //현재 칸의 번호
        static private Random random; //난수 생성용 변수

        static void Main(string[] args)
        {
            TileMap map = new TileMap(); // 맵 클래스 인스턴스화
            map.MapSetup(totalTile); // 맵 생성

            int currentDiceNumber = totalDiceNumber; // 현재 주사위 갯수 초기값은 최대 주사위 갯수
            while(currentDiceNumber > 0)
            {
                int diceValue = RollADice();
                Console.WriteLine($"주사위값은 : {diceValue}");
                currentDiceNumber--;
                currentTileIndex += diceValue;

                //플레이어가 샛별칸을 지날때 (5의 배수칸을 지날때)
                if(previousTileIndex / 5 < currentTileIndex / 5)
                {
                    int passedStarTileIndex = CalcPassedStarTileIndex(currentTileIndex); // 지나온 샛별칸 번호 계산
                    TileInfo passedStarTileInfo = map.dic_tile.GetValueOrDefault(passedStarTileIndex); // 지나온 샛별칸의 Tileinfo 가져오기
                    TileInfo_Star passedStarTileInfo_Star = passedStarTileInfo as TileInfo_Star; // Tileinfo 타입을  Tileinfo_Star에
                    if (passedStarTileInfo_Star != null) // 샛별칸의 Tileinfo 정보를 가져오는데 성공했으면
                    {
                        currentStarPoint += passedStarTileInfo_Star.starValue; // 샛별점수 누적
                    }
                }

                if(currentTileIndex > totalTile) // 현재칸이 최대칸을 넘어가 버렸을때
                {
                    currentTileIndex -= totalTile; // 현재칸에다가 최대칸을 뺀다
                }

                TileInfo info = map.dic_tile.GetValueOrDefault(currentTileIndex); // map에서 현재칸의 TileInfo를 가져옴
                if (info == null) // 현재칸의 TileInfo를 가져오지 못했을때는 프로그램을 강제종료한다
                    return;
                Console.WriteLine($"Tile Index : {currentTileIndex}"); // 현재 칸의 번호 출력
                string tileMapName = info.name; // 현재 칸의 이름
                switch (tileMapName) // 현재칸의 이름에 따른 분기문
                {
                    case " Dummy":
                        break;
                    case "Star":
                        break;
                    default:
                        return;

                }
            }
        }

        static private int RollADice()
        {
            string userInput = "Default";
            while (userInput != "")
            {
                Console.WriteLine("Roll a dice ! Press Enter");
                userInput = Console.ReadLine();
            }
            random = new Random(); // 난수 생성용 인스턴스
            int diceValue = random.Next(1, 6 + 1); // 1~6 중 랜덤한 정수
            return diceValue;
        }

        //현재 칸의 번호를 넣어주면 지나온 샛별칸의 번호를 반환해주는 함수
        static public int CalcPassedStarTileIndex(int currentTileIndex)
        {
            int index = currentTileIndex / 5 * 5;
            return index;
        }
    }
}
