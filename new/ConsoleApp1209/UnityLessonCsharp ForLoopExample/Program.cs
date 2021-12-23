using System; 

//orc객체를 10마리 만들고 오크들의 인스턴스는 orc타입 배열에 넣어준다
//각 개체의 이름은 '오크0'부터 '오크9'까지
//각 오크에게 isResting의  값을 아무거나 넣어준다(True나 false중 아무거나)
//각 오크가 쉬고있는지 확인해서 쉬고있다면 점프하도록 한다.

namespace UnityLesson_CSharp_ClassExample1

    {

        class Program

        {

            static void Main(string[] args)

            {

            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
            }

            for (int i = 0; i < length; i++)
            {
                arr_Orc[i].isResting = GetRandomBool();
            }

            for (int i = 0; i < length; i++)
            {
                if (arr_Orc[i].isResting)
                {
                    arr_Orc[i].Jump();
                }
            }
            static public bool GetRandomBool()
            {
                Random rand = new Random();
                bool value = Convert ToBoolean(rand.Next(0, 2));
                return value;
            }




           



                // 함수 내에서 if 문으로 체크한 후 동작실행 하는 예제 

                orc1.CheckIsRestingAndDash();

            }

        }



        class Orc

        {

            public string name;

            public float height;

            public float weight;

            public int age;

            public char genderChar;

            public bool isResting;



            public void Smash()

            {

                Console.WriteLine($"{name} (이)가 휘둘렀다!");

            }

            public void Jump()

            {

                Console.WriteLine($"{name} (이)가 점프했다!");

            }



            public void Dash()

            {

                Console.WriteLine($"{name} (이)가 돌진했다")
    
        }



            public void CheckIsRestingAndDash()

            {

                if (isResting)

                {

                    Dash();

                }

                else

                {

                    Console.WriteLine($"{name} (이)는 바빠서 돌진을 할 수가 없다");

                }

            }



        }

    }
}
