using System;
using System.Collections.Generic;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi GreatestHitsEltonJohn = new Albumi(); //
            GreatestHitsEltonJohn.Artisti = "Elton John";
            GreatestHitsEltonJohn.Nimi = "Greatest Hits";
            GreatestHitsEltonJohn.Genre = "Pop";
            GreatestHitsEltonJohn.Hinta = "50 £";

            GreatestHitsEltonJohn.LisääKappale();            
            GreatestHitsEltonJohn.TulostaAlbumi();
            GreatestHitsEltonJohn.TulostaKappaleet();
            Kappale GoodByeYellowBrickRoad = new Kappale("Goodbye Yellow Brick Road", "3:80");
            Kappale DontGoBreaking = new Kappale("Don't go breaking my heart", "4:80");
            GreatestHitsEltonJohn.Kappaleet2.Add(GoodByeYellowBrickRoad);
            GreatestHitsEltonJohn.Kappaleet2.Add(DontGoBreaking);
            GreatestHitsEltonJohn.TulostaKappaleet2();
            GreatestHitsEltonJohn.TulostaKappaleet2();

            Albumi MichaelJackson = new Albumi();
            Kappale SpeedDemon = new Kappale("SpeedDemon", "3:00");
            MichaelJackson.Artisti = "Michael Jackson";
            MichaelJackson.Nimi = "Thriller";
            MichaelJackson.Genre = "Pop";
            MichaelJackson.Hinta = "100 £";

            MichaelJackson.Kappaleet.Add("---Thriller, 5:60");
            MichaelJackson.Kappaleet.Add("---Beat it, 3:60");
            MichaelJackson.Kappaleet.Add("---Man in the mirror, 6:40");
            MichaelJackson.Kappaleet.Add("---Smooth criminal, 3:40");
            MichaelJackson.Kappaleet.Add("---Earth Song, 5:20");
            MichaelJackson.Kappaleet2.Add(SpeedDemon);
            MichaelJackson.LisääKappale2();
            MichaelJackson.TulostaAlbumi();
            MichaelJackson.TulostaKappaleet();
            MichaelJackson.TulostaKappaleet2();





        }
    }
}
