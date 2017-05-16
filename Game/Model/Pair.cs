using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class Pair<T>
    {
        T obj1, obj2;
        public Pair(T _obj1, T _obj2)
        {
            obj1 = _obj1;
            obj2 = _obj2;
        }

        public override string ToString()
        {
            return obj1.ToString() + " VS. " + obj2.ToString();
        }
    }
}
