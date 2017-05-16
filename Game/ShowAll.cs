using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    class ShowAll<T>
    {
        public ShowAll(IIterator<T> it)
        {
            Console.Write(it.First());
            while (!it.End())
            {
                Console.WriteLine(it.Next());
            }
            Console.WriteLine();
        }
    }
}
