using System;

namespace Peli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvaa luku!");

            //arvotaan satunnainen luku, josta tulee pelin oikea vastaus
            Random satunnainen = new Random();
            int oikeaLuku = satunnainen.Next(1, 21);
            //Console.WriteLine(oikeaLuku); //tämä jätetty kommenttina jotta voisi testata koodin toiminnan 

            //annetaan pelaajalle kolme arvauskertaa
            int arvauskertoja = 0;
            while (arvauskertoja < 3)
            {
                //arvauskerrat kasvaa
                arvauskertoja++;

                //kysytään pelaajalta arvaus ja muunnetaan se numeroksi
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                int arvaus = int.Parse(Console.ReadLine());

                //tarkistetaan, onko annettu luku oikein vai väärin, jos väärin - tulostetaan vihje
                if (arvaus < oikeaLuku)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvaus > oikeaLuku)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                //jos arvattu oikein, tulostetaan onnituleviestin
                else
                {
                    Console.WriteLine("Voitit!");
                    //silmukka päättyy
                    break;
                }

            }
            //Kun pelaaja on yrittänyt 3 kertaa tai arvannut oikein - tulostetaan ilmoitus pelin loppumisesta 
            Console.WriteLine("Peli loppui!");
        }
    }
}
