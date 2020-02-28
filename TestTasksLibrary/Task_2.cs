using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasksLibrary
{

    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        IDoubleLinkedListNode<T> Next { get; set; }
        IDoubleLinkedListNode<T> Prev { get; set; }
    }

    class MyDll<T> : IDoubleLinkedListNode<T>
    {
        public MyDll(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public IDoubleLinkedListNode<T> Next { get; set; }
        public IDoubleLinkedListNode<T> Prev { get; set; }
    }

    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedListNode<T> First { get; set; }
        IDoubleLinkedListNode<T> Last { get; set; }
        void Reverse();
        void AddFirst(T value);
        void AddLast(T value);
    }

    public class DoubleLL<T> : IDoubleLinkedList<T>
    {
        public DoubleLL()
        {
            countNode = 0;
        }

        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }
        private int countNode { get; set; }
        public void AddFirst(T value)
        {
            IDoubleLinkedListNode<T> node = new MyDll<T>(value);
            IDoubleLinkedListNode<T> temp = First;
            node.Next = temp;
            First = node;
            if (countNode == 0)
                Last = First;
            else
                temp.Prev = node;
            countNode++;
        }

        public void AddLast(T value)
        {
            IDoubleLinkedListNode<T> node = new MyDll<T>(value);

            if (First == null)
                First = node;
            else
            {
                Last.Next = node;
                node.Prev = Last;
            }
            Last = node;
            countNode++;

        }

        public void Reverse()
        {
            IDoubleLinkedListNode<T> node = First;
            IDoubleLinkedListNode<T> temp = null;

            if ((node != null) && (node.Next != null))
            {
                while (node != null)
                {
                    temp = node.Prev;
                    node.Prev = node.Next;
                    node.Next = temp;
                    node = node.Prev;
                }

                temp.Next = First;
                First = temp.Prev;
                Last = temp.Next;
            }

        }

    }

}
