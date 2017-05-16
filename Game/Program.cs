
using Game;
using Game.CustomCollections;
using Game.Model;
using Game.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<Hero> zone1List = generateZone1();
            ICustomCollection<Hero> zone2List = generateZone2();
            ICustomCollection<Hero> zone3List = generateZone3();

            IIterator<Hero> it1 = zone1List.GetIterator();
            IIterator<Hero> it2 = zone2List.GetIterator();
            IIterator<Hero> it3 = zone3List.GetIterator();

            ShowAll<Hero> showall1 = new ShowAll<Hero>(it1);
            ShowAll<Hero> showall2 = new ShowAll<Hero>(it2);
            ShowAll<Hero> showall3 = new ShowAll<Hero>(it3);

            Paired<Hero> paired = new Paired<Hero>(zone1List, zone2List, zone3List);

            Console.WriteLine("Paired:");
            ShowAll<Pair<Hero>> showpaired = new ShowAll<Pair<Hero>>(paired);

            Filtered<Hero> filt1 = new Filtered<Hero>(zone1List, 'D');
            Filtered<Hero> filt2 = new Filtered<Hero>(zone2List, 'B');
            Filtered<Hero> filt3 = new Filtered<Hero>(zone3List, 'C');

            Console.WriteLine("Filt1:");
            ShowAll<Hero> showallfilt1 = new ShowAll<Hero>(filt1);
            Console.WriteLine("Filt2:");
            ShowAll<Hero> showallfilt2 = new ShowAll<Hero>(filt2);
            Console.WriteLine("Filt3:");
            ShowAll<Hero> showallfilt3 = new ShowAll<Hero>(filt3);

        }

        // DO NOT CHANGE CODE BELOW

        static ICustomCollection<Hero> generateZone1()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for(int i=0; i<20; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone2()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone3()
        {
            ReversedArrayList<Hero> result = new ReversedArrayList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }
    }
}
