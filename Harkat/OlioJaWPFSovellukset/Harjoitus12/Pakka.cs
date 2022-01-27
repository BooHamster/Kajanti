using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harjoitus12
{
    static class Pakka
    {
        public static Dictionary<string, Kortti> Kortit = new Dictionary<string, Kortti>(); //Luodaan uusi Kortti Kokoelma
      
        public static bool lisää = true; //Booli korttien lisäys metodia varten
        public static void LisääKortit() //Korttien lisäys metodi Kortit kokoelmaan
        {
            if (lisää) //If lause sen tarkistamiseen onko Kortit jo lisätty Kokoelmaan, elikkä tämä if lause käydään läpi jos kortteja ei ole vielä lisätty Kokoelmaan
            {
                Kortit.Add("Pata Ässä", new Kortti("Pata Ässä")); //Luodaan uusi Kortti olio ja lisätään se Kortit Kokoelmaan
                Kortit.Add("Pata Kakkonen", new Kortti("Pata Kakkonen"));
                Kortit.Add("Pata Kolmonen", new Kortti("Pata Kolmonen"));
                Kortit.Add("Pata Nelonen", new Kortti("Pata Nelonen"));
                Kortit.Add("Pata Vitonen", new Kortti("Pata Vitonen"));
                Kortit.Add("Pata Kutonen", new Kortti("Pata Kutonen"));
                Kortit.Add("Pata Seiska", new Kortti("Pata Seiska"));
                Kortit.Add("Pata Kasi", new Kortti("Pata Kasi"));
                Kortit.Add("Pata Ysi", new Kortti("Pata Ysi"));
                Kortit.Add("Pata Kymppi", new Kortti("Pata Kymppi"));
                Kortit.Add("Pata Jätkö", new Kortti("Pata Jätkä"));
                Kortit.Add("Pata Kuningatar", new Kortti("Pata Kuningatar"));
                Kortit.Add("Pata Kuningas", new Kortti("Pata Kuningas"));
                Kortit.Add("Pata Jokeri", new Kortti("Pata Jokeri"));

                Kortit.Add("Hertta Ässä", new Kortti("Hertta Ässä"));
                Kortit.Add("Hertta Kakkonen", new Kortti("Hertta Kakkonen"));
                Kortit.Add("Hertta Kolmonen", new Kortti("Hertta Kolmonen"));
                Kortit.Add("Hertta Nelonen", new Kortti("Hertta Nelonen"));
                Kortit.Add("Hertta Vitonen", new Kortti("Hertta Vitonen"));
                Kortit.Add("Hertta Kutonen", new Kortti("Hertta Kutonen"));
                Kortit.Add("Hertta Seiska", new Kortti("Hertta Seiska"));
                Kortit.Add("Hertta Kasi", new Kortti("Hertta Kasi"));
                Kortit.Add("Hertta Ysi", new Kortti("Hertta Ysi"));
                Kortit.Add("Hertta Kymppi", new Kortti("Hertta Kymppi"));
                Kortit.Add("Hertta Jätkö", new Kortti("Hertta Jätkä"));
                Kortit.Add("Hertta Kuningatar", new Kortti("Hertta Kuningatar"));
                Kortit.Add("Hertta Kuningas", new Kortti("Hertta Kuningas"));
                Kortit.Add("Hertta Jokeri", new Kortti("Hertta Jokeri"));

                Kortit.Add("Ruutu Ässä", new Kortti("Ruutu Ässä"));
                Kortit.Add("Ruutu Kakkonen", new Kortti("Ruutu Kakkonen"));
                Kortit.Add("Ruutu Kolmonen", new Kortti("Ruutu Kolmonen"));
                Kortit.Add("Ruutu Nelonen", new Kortti("Ruutu Nelonen"));
                Kortit.Add("Ruutu Vitonen", new Kortti("Ruutu Vitonen"));
                Kortit.Add("Ruutu Kutonen", new Kortti("Ruutu Kutonen"));
                Kortit.Add("Ruutu Seiska", new Kortti("Ruutu Seiska"));
                Kortit.Add("Ruutu Kasi", new Kortti("Ruutu Kasi"));
                Kortit.Add("Ruutu Ysi", new Kortti("Ruutu Ysi"));
                Kortit.Add("Ruutu Kymppi", new Kortti("Ruutu Kymppi"));
                Kortit.Add("Ruutu Jätkä", new Kortti("Ruutu Jätkä"));
                Kortit.Add("Ruutu Kuningatar", new Kortti("Ruutu Kuningatar"));
                Kortit.Add("Ruutu Kuningas", new Kortti("Ruutu Kuningas"));
                Kortit.Add("Ruutu Jokeri", new Kortti("Ruutu Jokeri"));

                Kortit.Add("Risti Ässä", new Kortti("Risti Ässä"));
                Kortit.Add("Risti Kakkonen", new Kortti("Risti Kakkonen"));
                Kortit.Add("Risti Kolmonen", new Kortti("Risti Kolmonen"));
                Kortit.Add("Risti Nelonen", new Kortti("Risti Nelonen"));
                Kortit.Add("Risti Vitonen", new Kortti("Risti Vitonen"));
                Kortit.Add("Risti Kutonen", new Kortti("Risti Kutonen"));
                Kortit.Add("Risti Seiska", new Kortti("Risti Seiska"));
                Kortit.Add("Risti Kasi", new Kortti("Risti Kasi"));
                Kortit.Add("Risti Ysi", new Kortti("Risti Ysi"));
                Kortit.Add("Risti Kymppi", new Kortti("Risti Kymppi"));
                Kortit.Add("Risti Jätkä", new Kortti("Risti Jätkä"));
                Kortit.Add("Risti Kuningatar", new Kortti("Risti Kuningatar"));
                Kortit.Add("Risti Kuningas", new Kortti("Risti Kuningas"));
                Kortit.Add("Risti Jokeri", new Kortti("Risti Jokeri"));
                Console.WriteLine();
                Console.WriteLine("Kortit lisätty pakkaan!");
                lisää = false;
            }
            else //Jos kortit on jo lisätty Kortit Kokoelmaan, niin silloin käydään tämä else lause läpi
            {
                Console.WriteLine();
                Console.WriteLine("Olet jo lisännyt kortit pakkaan, senkin pahvi!");
            }
        }


        public static void Sekoita() //Korttien sekoitus Metodi luokan sisältä
        {
            var rnd = new Random(); //luodaan uusi random muuttuja
            var randomized = Kortit.OrderBy(item => rnd.Next()); //Luodaan ja määritellään muuttuja mikä Randomisoi Kortit Kokoelman käyttäen rnd randomi Muuttujan parametrejä, mitkä on arvot kokoelmasta, elikkä arvot minimistä maksimiin saadaan Kokoelman arvoista
            int i = 1; //Luodaan Int muuttuja foreach looppia varten
            Console.WriteLine();
            foreach (var value in randomized) //foreach looppi jokaista arvoa var muuttuja randomized muuttujasta, tässä tapauksessa 56 arvoa Kortit Kokoelmasta
            {
                Console.WriteLine("{0}. Kortti on: " + value.Key,i); //Tulostaa käyttäjälle randomisoidun listan korteista, tulostaen ensin i muuttujan arvon, sitten arvon randomized muuttujasta, mikä on Kortti olio Kortit kokoelmasta, minkä järjestys on randomisoitu
                i++; //Lisätään aina yksi, elikkä i + 1= arvo, jotta looppi jatkuu kunnes kaikki arvot on tulostettu Kortit Kokoelmasta
            }
        }
    
        public static void TulostaPakka()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (Kortit.Count == 0) //Tämä if lause toteutuu jos Pakka Kokoelma on tyhjä, elikkä sisältää 0 Kortti oliota
            {
                Console.WriteLine();
                Console.WriteLine("Pakka on Tyhjä, lisää kortit pakkaan!");
                return; //Poistutaan Metodista
            }

            int i = 1; //Luodaan ja määritetään muuttuja int i arvoon 1
            Console.WriteLine();
            Console.WriteLine("Kortit Pakassa: ");

            foreach (Kortti kortti in Kortit.Values) //Toteutetaan jokaiselle Kortti luokan Kortille Kortit kokoelman Values hakemiston sisällä, arvot ovat <string>, ja <Kokoelman tyyppi> = Kortti
            {
                Console.WriteLine("{0}: {1}", i, kortti.Tiedot()); // Tulostaa {0} arvoon i muuttujan arvon, ja {1} arvoon Kortti.HaeData Metodilla Kortti olion tiedot 
                i++; //Kun foreach käy Kortti olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            }
        }
    }
}
