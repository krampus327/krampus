using System;

namespace ConsoleApp1216
{
    class Program
    {
        static void Main(string[] args)
        {
            orc orc1 = new orc();

            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200.0f;
            orc1.age = 140;
            orc1.genderChar = '남';
            orc1.isResting = false;
            if (orc1.isResting == true)
            {
                orc1.Smash();
                orc1.Jump();
            }
            else
            {
                Console.WriteLine("상급오크는 바쁘다.");
            }

            orc orc2 = new orc();

            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.age = 60;
            orc2.genderChar = '여';
            orc2.isResting = true;
            if(orc2.isResting == true)
            {
                orc2.Smash();
                orc2.Jump();
            }
            else
            {
                Console.WriteLine("하급오크는 바쁘다.");
            }
            
        }
    }
    class orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다");
        }
    }
    
}

//객체선정
//    오크(ORC)

//    추상화
//    오크의 구성요소
    
//    정보 (변수)
//    이름
//    키
//    몸무게
//    나이
//    성별문자
//    쉬고있는지? 

//    기능(함수)
//    휘두르기
//    점프하기

//    클래스화

//    객체화
//    오크2마리 생성
//오크 1
//    이름: 상급오크
//    키 : 240.2
//    무게: 200.0
//    나이: 140
//    성별문자: 남
//    쉬고있는지? : 거짓

//    오크2
//    이름 : 하급오크
//    키 : 140.4
//    무게 120.0
//    나이: 60
//    성별문자: 여
//    쉬고있는가? : 참

//if 상급오크가 쉬고있으면 점프와 휘두르기 시전
//    쉬지 않고 있으면 콘솔창에 (오크1의 이름)은 바쁘다 출력
//    if 하급오크가 쉬고있으면 점프와 휘두르기 시전
//    쉬지 않고 있으면 콘솔창에 (오크2의 이름)은 바쁘다 출력

//    인스턴스화