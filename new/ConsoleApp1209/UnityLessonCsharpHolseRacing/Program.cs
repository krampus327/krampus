namespace UnityLessonCsharpHolseRacing
{
    class program
    {
        static Random random;
        static bool isGameFinished = false;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int finishDistance = 200;
        static void Main(string[] args)

        {
            Holse[] arr_holse = new Holse[5];
            string[] arr_FinishedHolseName = new string[5];
            int currentGrade = 1;
            int length = arr_holse.Length;
            for (int i = 0; i < length; i++)0000
            {
                arr_holse[i] = new Holse();
                arr_holse[i].name = "경주마" + i;
            }
            Console.WriteLine("경주 시작!");
            int count = 0;
            while (isGameFinished == false)
            {
                Console.WriteLine($"---------------{count}---------------");
                for (int i = 0; i< length; i++)
                {
                    if (arr_holse[i].dontMove == false)
                    {
                        random = new Random();
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        arr_holse[i].Run(tmpMoveDistance);
                        Console.WriteLine($"{arr_holse[i].name}가 달린거리 : { arr_holse[i].distance}");
                        if (arr_holse[i].distance >= finishDistance)
                        {
                            arr_holse[i].dontMove = true;
                            arr_FinishedHolseName[currentGrade - 1] = arr_holse[i].name;
                            currentGrade++;
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
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine($"(i+1)등 : ");
            }
        }
    
    }
    class Holse
    {
        public string name;
        public int distance;
        public bool dontMove;

        public void Run(int moveDistance)
        {
            if (dontMove) return;
            distance += moveDistance;
        }
    }
}