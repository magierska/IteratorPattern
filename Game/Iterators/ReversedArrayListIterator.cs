using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class ReversedArrayListIterator<T> : IIterator<T>
    {
        ReversedArrayList<T> list;
        int index;
        public ReversedArrayListIterator(ReversedArrayList<T> _list)
        {
            list = _list;
            index = 0;
        }
        public T First()
        {
            index = 0;
            return list.Get(0);
        }
        public T Current()
        {
            return list.Get(index);
        }

        public T Next()
        {
            index++;
            return list.Get(index);
        }

        public bool End()
        {
            return index == list.Size - 1;
        }
    }
}
