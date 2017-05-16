using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    public interface IIterator<P>
    {
        P First();
        P Current();
        P Next();
        bool End();
    }
}
