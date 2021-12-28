using System;
using System.Collections.Generic;

namespace UnityLessonCsharp_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------
            //List
            //----------------------------------------------------
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            // 0번째 인덱스부터 탐색하고 인자와 같은 요소를 발견하면 삭제
            //삭제 성공시 True 반환, 인자와 같은 요소를 못찾으면 False 반환.
            _list.Remove(3);
            int length = _list.Count;
            for (int i = 0; i < length; i++)
            {
                int tmpoNumber = _list[i];
                Console.WriteLine(tmpoNumber);
            }

            foreach (int num in _list)
            {
                Console.WriteLine(num);
            }

            //----------------------------------------------------
            //Dictionary
            //----------------------------------------------------
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손 대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");
            _dic.Remove("검사");
            bool isSwordmanExist = _dic.ContainsKey("검사");
            if (isSwordmanExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사: {tmpValue}");
            }
            else
            {
                Console.WriteLine("검사를 찾을 수 없습니다.");
            }
            foreach (string sub in _dic.Keys)
            {
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub}: {tmpValue}");
            }

            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }

            foreach (KeyValuePair<string, string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey}: {tmpValue}");
            }
            // 위 세가지 경우가 있지만,  

            // dictionary 는 단어 뜻대로 사전 처럼 사용하기 위한 collection 이다. 

            // 우리가 사전을 찾을때 ,  

            // 단어를 먼저 찾고 거기에 따라 단어의 뜻을 찾는다.  

            // dictionary 에서 key 는 단어, value 는 단어의 뜻과 같은 역할이다. 

            // 따라서 foreach 문을 사용해서 접근할때도, 

            // dictionary 의 key 로 반복문을 통해 접근하는 경우가 대부분이지,  

            // value 나 dictionary 자체로 접근하는 경우는 잘 없다.  

            // 마치 '사과' 라는 단어를 검색하면 '사과나무에서 열리는 열매' 라는 뜻을 찾는것이지 

            // '사과나무에서 열리는 열매' 를 검색해서 '사과'를 찾거나 

            // '사과 : 사과나무에서 열리는 열매' 자체를 검색하지 않는것과 같다고 생각하면 된다.

            //----------------------------------------------------
            //queue (list와 비슷하나 FIFO = first input, first out체계이다.)
            //----------------------------------------------------
            Queue<int> _queue = new Queue<int>();

            _queue.Enqueue(10);
            _queue.Enqueue(20);
            _queue.Enqueue(30);

            Console.WriteLine(_queue.Peek()); //가장 첫번째에 있는 값을 반환
            Console.WriteLine(_queue.Dequeue());//Queue의 가장 첫번재에 있는 값을 제거하고 반환
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());

            //_queue.Dequeue(); //10빠져나옴
            //_queue.Dequeue(); //20빠져나옴
            //_queue.Dequeue(); //30빠져나옴

            //----------------------------------------------------
            //Stack (list와 비슷하나 LIFO = Last input, First out의 체계이다.
            //----------------------------------------------------
            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            Console.WriteLine(_stack.Peek());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
        }
    }
}
