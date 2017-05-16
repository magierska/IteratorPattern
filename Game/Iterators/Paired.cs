using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class Paired<T> : IIterator<Pair<T>>
    {
        ICustomCollection<T>[] lists;
        IIterator<T> it1;
        IIterator<T> it2;
        int ind1, ind2;
        public Paired(params ICustomCollection<T>[] _lists)
        {
            lists = _lists;
            it1 = lists[0].GetIterator();
            it2 = lists[0].GetIterator();
            ind1 = ind2 = 0;
        }

        public Pair<T> First()
        {
            it1 = lists[0].GetIterator();
            it2 = lists[0].GetIterator();
            ind1 = ind2 = 0;
            return new Pair<T>(it1.Current(), it2.Current());
        }

        public Pair<T> Current()
        {
            return new Pair<T>(it1.Current(), it2.Current());
        }
        public Pair<T> Next()
        {
            if (!it2.End())
            {
                it2.Next();
            }
            else if(ind2 < lists.Count() - 1)
            {
                it2 = lists[ind2++].GetIterator();
            }
            else if(ind2 == lists.Count() - 1)
            {
                if (!it1.End())
                {
                    it1.Next();
                    it2 = lists[0].GetIterator();
                }
                else if (ind1 < lists.Count() - 1)
                {
                    it1 = lists[ind1++].GetIterator();
                    it2 = lists[0].GetIterator();
                }
            }
            return new Pair<T>(it1.Current(), it2.Current());
        }

        public bool End()
        {
            return ind1 == lists.Count()-1 && ind2 == lists.Count()-1 && it1.End() && it2.End();
        }

    }
}
