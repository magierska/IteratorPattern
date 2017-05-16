using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class CustomLinkedListIterator<T> : IIterator<T>
    {
        CustomLinkedList<T> list;
        LinkedNode<T> index;
        public CustomLinkedListIterator(CustomLinkedList<T> _list)
        {
            list = _list;
            index = list.Head;
        }
        public T First()
        {
            index = list.Head;
            return index.Value;
        }

        public T Current()
        {
            return index.Value;
        }
        public T Next()
        {
            index = index.Next;
            return index.Value;
        }

        public bool End()
        {
            return index == list.Tail;
        }
    }
}
