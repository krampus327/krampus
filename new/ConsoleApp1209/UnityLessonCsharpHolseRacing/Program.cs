namespace UnityLessonCsharpHolseRacing
{
    class program
    {
        static Random random; //말의 달리는 속도를 랜덤하게 생성하기위한 난수 변수
        static bool isGameFinished = false; //경주가 끝났는지 체크하는 변수
        static int minSpeed = 10; //달리는 속도의 최소값
        static int maxSpeed = 20; //달리는 속도의 최대값
        static int finishDistance = 200; //결승점 거리
        static void Main(string[] args)

        {
            Horse[] arr_horse = new Horse[5]; //말 5마리를 인슽턴스화 시키기 위한 배열
            string[] arr_FinishedHolseName = new string[5]; //결승점을 통과한 말의 이름을 지정한 배열
            int currentGrade = 1; //현재 등수
            int length = arr_horse.Length; //말들이 지정된 배열의 길이
            for (int i = 0; i < length; i++)
            {
                arr_horse[i] = new Horse();
                arr_horse[i].name = "경주마" + i;
            }
            Console.WriteLine("경주 시작!");
            int count = 0;
            while (isGameFinished == false)
            {
                Console.WriteLine($"---------------{count}---------------");
                for (int i = 0; i< length; i++) //랜덤한 속도로 말을 달리게 하는 for문
                {
                    if (arr_horse[i].dontMove == false) // i번째 말이 움직일수 있으면
                    {
                        random = new Random(); //난수용 인스턴스
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1); //minSpeed~maxSpeed 범위내의 난수
                        arr_horse[i].Run(tmpMoveDistance);
                        Console.WriteLine($"{arr_horse[i].name}가 달린거리 : { arr_horse[i].distance}");
                        if (arr_horse[i].distance >= finishDistance)
                        {
                            arr_horse[i].dontMove = true;
                            arr_FinishedHolseName[currentGrade - 1] = arr_horse[i].name; //결승점에 도달한 말의 이름을 현재 등수 -1번째 자리에 저장
                            currentGrade++; //현재 등수를 1 증가시킨다
                        }
                    }
                    
                }
                if(currentGrade > 5)
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 끝!");
                    break;
                }

                Thread.Sleep(1000);
                count++;
            }
            Console.WriteLine("-----------------------결과 발표-----------------------");
            for(int i = 0; i < length; i++) // 경주가 끝난 말의 이름을 등수대로ㅓ 출력해주는 for문
            {
                Console.WriteLine($"{i+1}등 : {arr_FinishedHolseName[i]} ");
            }
        }
    
    }
    class Horse
    {
        public string name; //이름
        public int distance; //달린 거리
        public bool dontMove; //움직이지마!

        public void Run(int moveDistance)
        {
            if (dontMove) return;
            distance += moveDistance;
        }
    }
}