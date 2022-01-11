namespace UnityLessonCsharpHolseRacing
{
    class Holse
    {
        public string name;
        public int distance;

        public void Run(int moveDistance)
        {
            distance = moveDistance;
        }
    }
    class HolseRacing
    {
        static void main(string[] args)
        {
            Holse[] arr_Holse = new Holse[5];
            string[] arr_FinishedHolseName = new string[5];
            int length = arr_Holse.Length;
            for(int i = 0; i < arr_Holse .Length, i++)
            {
                arr_Holse[i] = new Holse();
                arr_Holse[i].name = "경주마" + i;
            }

            Console.WriteLine("경주 시작!");

            while (!isGameFinished)
            {
                for(int i=0; i < length; i++)
                {
                    random = new Random();
                    int tmpMoiveDistance = Random Next
                }
            }
        }
    }
}