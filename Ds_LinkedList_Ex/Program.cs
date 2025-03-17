using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ds_LinkedList_Ex
{
    class LinkedListExample
    {
        static void Main(string[] args)
        {
            // 정수 저장하는 LinkedList 선언
            LinkedList<int> numbers = new LinkedList<int>();

            // Node를 List 끝에 추가
            numbers.AddLast(10);
            numbers.AddLast(20);
            numbers.AddLast(30);

            Console.WriteLine("<초기 LinkedList elements print>");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //
            //  .....
            //

            // List 시작부분에 Node 추가
            numbers.AddFirst(5);
            Console.WriteLine("\n<Add된 LinkedList elements print>");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //
            //  .....
            //

            // 특정 Node 뒤에 새로운 Node 추가 (20뒤에 25추가)
            LinkedListNode<int> node20 = numbers.Find(20);
            if (node20 != null)
            {
                numbers.AddAfter(node20, 25);
            }
            Console.WriteLine("\n<특정 Node 뒤에 Add된 LinkedList elements print>");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //
            //  .....
            //

            // Node 제거
            numbers.Remove(30);

            Console.WriteLine("\n<업데이트된 LinkedList elements print>");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
