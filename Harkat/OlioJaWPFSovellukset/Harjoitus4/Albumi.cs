using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public string Hinta;
        
        
       
        List<Kappale> EltonJohn = new List<Kappale>();

        Kappale YourSong = new Kappale("Your Song", "3:50");
        Kappale RocketMan = new Kappale("Your Song", "2:40");
        Kappale TinyDancer = new Kappale("Tiny Dancer", "4:15");
        Kappale Levon = new Kappale("Levon", "3:50");
        Kappale CrocodileRock = new Kappale("Crocodile Rock", "2:50");
        Kappale CandleInTheWind = new Kappale("Candle In The Wind", "2:59");
        Kappale SomeoneSavedMyLifeTonight = new Kappale("Someone saved my life Tonight", "3:30");
        Kappale MonaLisasAndMadHatters = new Kappale("Mona Lisas and Mad Hatters", "3:20");
        Kappale CanYouFeelTheLoveTonight = new Kappale("Can you feel the love tonight", "3:10");

        public void LisääKappale()
        {
            EltonJohn.Add(YourSong);
            EltonJohn.Add(RocketMan);
            EltonJohn.Add(TinyDancer);
            EltonJohn.Add(Levon);
            EltonJohn.Add(CrocodileRock);
            EltonJohn.Add(CandleInTheWind);
            EltonJohn.Add(SomeoneSavedMyLifeTonight);
            EltonJohn.Add(MonaLisasAndMadHatters);
            EltonJohn.Add(CanYouFeelTheLoveTonight);
        }

        public void TulostaData()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-- Artisti:  " + Artisti);
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Genre:  " + Genre);
            Console.WriteLine("-- Hinta:  " + Hinta);
            Console.WriteLine();
            Console.WriteLine("Songs: ");
            Console.WriteLine(YourSong.ToString());
            Console.WriteLine(RocketMan.ToString());
            Console.WriteLine(TinyDancer.ToString());
            Console.WriteLine(Levon.ToString());
            Console.WriteLine(CrocodileRock.ToString());
            Console.WriteLine(CandleInTheWind.ToString());
            Console.WriteLine(SomeoneSavedMyLifeTonight.ToString());
            Console.WriteLine(MonaLisasAndMadHatters.ToString());
            Console.WriteLine(CanYouFeelTheLoveTonight.ToString());      
        }

    }
}
