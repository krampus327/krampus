using System;

namespace Unity_lesson_Cshap_operate
{
    class Program
    {
        static int a = 14;
        static int b = 5;
        static int c;
        static void Main(string[] args)
        {
            //산술 연산
            //더하기, 빼기, 곱하기, 나누기, 나머지
            //더하기
            c = Function_for_operation.Sum(a, b);
            Console.WriteLine(c);
            //빼기
            c = Function_for_operation.Sub(a, b);
            Console.WriteLine(c);
            //곱하기
            c = Function_for_operation.Mul(a, b);
            Console.WriteLine(c);
            //나누기 정수를 나누기하면 소수점은 버린다.(나머지를 버린다)
            c = Function_for_operation.Div(a, b);
            Console.WriteLine(c);
            //나머지
            c = Function_for_operation.Rem(a, b);
            Console.WriteLine(c);

            //증감 연산
            //증가연산자, 감소연산자
            //증가연산
            c = Function_for_operation.Inc(c); // ==c = c + 1;
            Console.WriteLine(c);
            //감소연산
            c = Function_for_operation.Dec(c); ; // ==c = c - 1;
            Console.WriteLine(c);

            //관계 연산
            //같음, 다름, 크기 비교 연산
            //관계연산의 결과가 참이면 true, 거짓이면 false를 반환함
            //같음 비교
            Console.WriteLine(a == b);
            //다름 비교
            Console.WriteLine(a != b);
            //크기 비교
            //크다
            Console.WriteLine(a > b);
            //작다
            Console.WriteLine(a < b);
            //크거나 같다
            Console.WriteLine(a >= b);
            //작거나 같다
            Console.WriteLine(a <= b);

            //대입 연산
            //(더해서, 빼서 곱해서 나눠서 나머지를)대입
            c += b; //c = c + b;
            Console.WriteLine(c);
            c -= b; //c = c - b
            Console.WriteLine(c);
            c *= b;
            Console.WriteLine(c);
            c /= b;
            Console.WriteLine(c);
            c %= b;
            Console.WriteLine(c);

            //논리 연산
            //양측의 피연산자들을 비교해서 연산 수행
            //or, and, xor, not
            bool A = true;
            bool B = false;

            //or
            //a와 b 둘중 하나라도 참(true)이면 참(true) 반환, 나머지 경우에는 false 반환
            Console.WriteLine(A | B);

            //and
            //a와 b 둘다 true이면 true 반환, 나머지 경우에는 false 반환
            Console.WriteLine(A & B);

            //xor
            //a와 b 둘 중에 하나만 true일 때 true 반환, 나머지 경우에는 false 반환
            Console.WriteLine(A ^ B);

            //not
            //a의 반대 부호 반환(true 이면 false, false 이면 true)
            Console.WriteLine(!A);

            //조건부 논리연산
            //왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다.

            //or 조건부 논리연산
            //만약 A가 true 이면 B의 값에 관계없이 결과값이 true이다.
            //연산을 하지 않고 A 값을 반환한다.
            Console.WriteLine(A || B);
            //and 조건부 논리연산
            //만약 A가 false이면 B의 값에 관계없이 결과값이 false이다.
            //연산을 하지 않고 A 값을 반환한다.
            Console.WriteLine(A && B);

            //비트 연산
            //비트연산 하는 이유 : 데이터를 효울적으로 관리하기 위함
            //or, and, xor, not, shift=left, shift-right
            int howManyBitYouWantToShift = 1;
            //or
            Console.WriteLine(a | b);
            //and
            Console.WriteLine(a & b);
            //xor
            Console.WriteLine(a ^ b);
            //not
            Console.WriteLine(~a);
            //shift-left
            Console.WriteLine(a << howManyBitYouWantToShift);
            //shift-right
            Console.WriteLine(a >> howManyBitYouWantToShift);
        }
    }
    
    //FSM Finite State Machine 유한 상태머신 (상태의 개수가 정해진 머신)
    //클래스의 상태에 따라 다른 동작을 하기위해 사용
    //ex 플레이

    [Flags]

    public enum e_FSM
    {
        IDLE = 0.
        STATE_1 = 1 << 0.
        STATE_2 = 1 << 1.
        STATE_3 = 1 << 2.
        STATE_4 = 1 << 3.
    }
}
