using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class CustomLinkedList<T> : ICustomCollection<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private int length = 0;

        public void Add(T value)
        {
            LinkedNode<T> newNode = new LinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        public LinkedNode<T> Head
        {
            get
            {
                return head;
            }
        }
        public LinkedNode<T> Tail
        {
            get
            {
                return tail;
            }
        }
        public IIterator<T> GetIterator()
        {
            return new CustomLinkedListIterator<T>(this);
        }
    }
}
