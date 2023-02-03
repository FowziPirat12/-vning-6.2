using System;
namespace Övning_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("Hejsan");
            SkrivBaklänges("Detta blir Baklänges");
            SkrivBaklänges("Även dätta går åt fel håll");
        }

        static void SkrivBaklänges(string meddelande)
        {
            for(int i= meddelande.Length-1; i>=0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
            Console.WriteLine();
        }
    }
}