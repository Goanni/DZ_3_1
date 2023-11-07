using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_1
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    public class stack<T>
    {
        private Node<T> top;
        private int count;

        public stack()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Size()
        {
            return count;
        }

        public void Push(T data)
        {
            if (count == 100)
            {
                Console.WriteLine("В стеке не может быть больше 100 эллементов. Добавлнеие элемента невозможно");
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
                count++;
                Console.WriteLine("Ok");
            }
        }

        public T Back()
        {
            if (IsEmpty()) 
                throw new InvalidOperationException("Стек пуст!");
            return top.Data;
        }

        public T Pop()
        {
            if (IsEmpty()) 
                throw new InvalidOperationException("Стек пуст!");
            Node<T> temp = top;
            top = top.Next;
            count--;
            return temp.Data;
        }

        public void Clear()
        {
            while (!IsEmpty()) Pop();

        }

        public void Exit()
        {
            Clear();
            Console.WriteLine("Bye!");
        }
    }
    internal class DZ_3_1
    {
        static void Main()
        {
            stack<int> stack_ = new stack<int>();
            stack_.Push(3);

            stack_.Push(14);

            int a = stack_.Size();
            Console.WriteLine(a);

            stack_.Clear();
            Console.WriteLine("Ok");

            stack_.Push(1);

           int b = stack_.Back();
            Console.WriteLine(b);

            stack_.Push(2);

            b = stack_.Back();
            Console.WriteLine(b);

            int c = stack_.Pop();
            Console.WriteLine(c);

            a = stack_.Size();
            Console.WriteLine(a);

            c = stack_.Pop();
            Console.WriteLine(c);

            a = stack_.Size();
            Console.WriteLine(a);

            stack_.Exit();

        }
    }
}
