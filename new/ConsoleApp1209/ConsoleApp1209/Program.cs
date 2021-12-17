// using 키워드
// using 뭔가를 사용하겠다 라고 선언하는 키워드
// system이라는걸 사용하겠다 라는 뜻
// using은 언제 쓰는가?
// 예시 ) 네임스페이스 정리
// 만약에 consoleApp1209(2)라는 namespace의 클래스 등 정보를 가져와 쓰고싶다
// ->using consolApp1209(2)라고 스크립트 최상단에 선언해줌.
// 예시 2)우선순위가 차순위인 함수 호출
// UnityEngine Physics . Unity Physics
// 두가지 중에 기본적으로는 UnityEngine Physics가 우선순위
// 두 네임스페이스 모두Raycast()라는 함수를 포함하고 있다.
// 나는 Unity Physics RayCast()를 쓰고싶다
// 일반적으로 Raycast()를 호출하면UnityEngine Physics RayCast()가 호출됨
// using RayCast = Unity Physics RayCast;
// 라고 해주면 RayCast()호출했을때 Unity Physics RayCast()가 호풀됨
using System;

// namespace 키워드
// 클래스간의 멤버 이름 충돌을 방지
namespace ConsoleApp1209
{
    // program class
    //모든 프로젝트는 처음 실행파일(exe)을 통해 실행될 떄에
    //main함수를 실행하며
    //C#에서는 Main함수조차도 객체지향 컨셉에 맞게 Program이라는 클래스안에 선언되어있음. 
    class Program
    {
        // static 키워드
        // static(정적)은 dynamic(동적)의 반대 개념 키워드
        // static은 상황에 따라 메모리에 할당할 수 없는 성질
        // dynamic은 상황 조건에 따라 메모리에 할당할 수 있는 성질
        // Main함수는 static으로 정의되었으므로 하나만 존재 할 수 있다.
        // static은 메모리에 할당할 수 없는 정적 키워드
        // 만약에 class에 static이 붙는다
        // 그러면 그에딸린 모든 변수나 함수도 static이어야 함.
        
        // void = 자료형
        // void 반환값이 없다.
        // 함수의 기본형태 : 입력 -> 기능수행 -> 출력
        // void 를 반환하는 함수는 : 입력->기능수행
        // void는 입력이 없어도 기능을 수행하고 반환값이 없음

        // args?
        // argument 인자 , 인수
        // 함수에서 받을 입력
        // 표기 방법은 함수 이름 뒤에 괄호열고 "자료형" "인자이름" 형태로 써준다.
        static void Main(string[] args)
        {
            // Console?
            // using으로 선언했던 System이라는 namespace 안에 있는 클래스
            Console.WriteLine("Hello World!");
        }
    }
}
