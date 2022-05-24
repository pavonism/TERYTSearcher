using System;
using static TERYTSearcher.DatabaseSearcher;

namespace TERYTSearcher
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 2 || args.Length < 1)
            {
                Console.WriteLine("Usage: You should put only one parameter compatible with TERYT.");
                Console.WriteLine("If you want to search for streets you should also provide");
                Console.WriteLine("as a second argument destinated locality ID (SYM).");
                Console.ReadLine();
                return;
            }

            string teryt = args[0];

            // Validation: 
            // First two number must form even number ( % 2 == 0) in range 2 - 98
            // The second pair of numbers must form a number in range 1 - 99 (just excluding 0)
            // The third pair of numbers must form a number in range 1 - 99 (just excluding 0)
            // the last number means type of an administrative unit (1 - 9 [just exluding 0])
            if (!validateTERYT(teryt))
            {
                Console.WriteLine($"Given TERYT is not valid: {teryt}");
                return;
            }


            // Municipalities search
            var m = findMunicipality(teryt);
            if (m == null)
            {
                Console.WriteLine($"There is no municipality in database with TERYT: {teryt}");
                return;
            }
            Console.WriteLine($"All localities located in {m.NAZWA}:");
            var localities = readLocalities(teryt);
            printLocalities(localities);


            // Streets search
            if (args.Length == 2)
            {
                string sym = args[1];

                var s = findLocality(sym);
                if (s == null)
                {
                    Console.WriteLine($"There is no Locality in database with SYM: {sym}");
                    return;
                }
                Console.WriteLine($"All Streets located in {s.NAZWA}:");
                var streets = readStreets(sym);
                printStreets(streets);
            }

        }
    }
}



