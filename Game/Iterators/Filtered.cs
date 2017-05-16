using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class Filtered<T> : IIterator<T>
    {
        ICustomCollection<T> list;
        IIterator<T> it;
        char c;
        public Filtered(ICustomCollection<T> _list, char _c)
        {
            list = _list;
            it = list.GetIterator();
            c = _c;
        }
        public T First()
        {
            char t = it.First().ToString()[0];
            while (t != c && !it.End())
                t = it.Next().ToString()[0];
            return it.Current();
        }

        public T Current()
        {
            return it.Current();
        }
        public T Next()
        {
            char t = it.Next().ToString()[0];
            while (t != c && !it.End())
                t = it.Next().ToString()[0];
            return it.Current();
        }

        public bool End()
        {
            return it.End();
        }
    }
}
