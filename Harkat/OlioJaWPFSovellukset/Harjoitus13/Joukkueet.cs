using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkueet
    {
        public static Dictionary<string, Joukkue> SMLiiga = new Dictionary<string, Joukkue>(); //Luodaan Opiskelija tyyppinen kokoelma, jossa avain on string tyyppinen.
        private static string Tunnus { get; set; }
        public static string Nimi = "";
        public static string KotiKaupunki = "";


        public static void LisääJoukkue() //Metodi Opiskelija olion lisäämiselle Kokoelma luokan sisällä
        {
            bool Tarkista = false;  //Boolean muuttuja jolla tarkistetaan myöhemmin onko Opiskelija olion luominen sallittua

            Console.WriteLine();  //Nämä tyhjät Console.WriteLinet ovat vain luettavuutta varten, ulkoasu on selkeämpi kun kaikki tekstit eivät ole kiinni toisissaan
            Console.WriteLine("Anna uuden Joukkueen Nimi: ");
            Nimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Anna uuden Joukkueen Kotikaupunki: ");
            KotiKaupunki = Console.ReadLine();
            Console.WriteLine();

            while (!Tarkista)    // While looppi jonka tarkoitus on käydä Tarkistus metodi OpiskelijaID:lle, ja jos tarkistus no väärä niin käydään mennään käymään catch lauseen virheilmoitus läpi
            {
                try  //Katso try lauseen sisällön läpi, ja jos käyttäjä syöttää väärin OpiskelijaID:een, niin silloin siirrytään catch lauseeseen
                {
                    Console.WriteLine("Syötä Joukkueen Tunnus, sen on oltava tasan 3 merkkiä pitkä: ");
                    Tunnus = Console.ReadLine();  //Käyttäjä saa syöttää Opiskelija ID:een itse
                    Tarkista = TarkistaJoukkueenNimi(Tunnus); //Määritetään boolean Tarkista samaksi kuin TarkistaID metodi, ja käydään Tarkista metodi läpi käyttäjän antamalle OpiskelijaID:lle
                }
                catch (Poikkeukset) //Virheilmoitus metodi on sisällytetty catch lauseen () sulkeiden sisään, jolloin voidaan jättää {} sisältö tyhjäksi
                {

                }
            }

            if (Tarkista) //Jos OpiskelijaID oli oikein syötetty, TarkistaID palauttaa Tarkista booleanille true vastauksen, jolloin tämä if lause käydään läpi
            {
                SMLiiga.Add(Tunnus, new Joukkue(Nimi, KotiKaupunki, Tunnus)); //Luodaan Opiskelija olio, ja asetetaan arvot Opiskelija olion konstruktorista, ja samalla lisätään Opiskelija olio Opiskelijat Kokoelmaan
                TulostaViesti(string.Format("Uusi Joukkue {0} On lisätty SM-Liigaan", SMLiiga[Tunnus].HaeData()));  //Käydään TulostaViesti metodi läpi
            }
        }

        public static bool TarkistaJoukkueenNimi(string id) //Metodi OpiskelijaID:een tarkistukseen
        {
            if (SMLiiga.ContainsKey(id)) //Katsotaan onko Opiskelijat Kokoelmassa jo lisätty avain ContainsKey() Metodilla, mikä on valmis metodi, ja palauttaa true arvon jos se löytää Kokoelmasta jo saman avaimen, ja falsen jos se ei löydä samaa avainta
            {
                throw new Poikkeukset("Joukkue Tunnus " + id + " ei ole uniikki, anna uusi Tunnus"); //Tämä tulostuu jos annettu avain löytyi jo Kokoelmasta
            }
            else if (id.Length < 3 || id.Length > 3) //Tämä katsoo onko annettu avain annettujen arvojen sisällä, tässä tapauksessa ei lyhyempi tai pidempi kuin 6 merkkiä
            {
                throw new Poikkeukset("Joukkueen Tunnus " + id + " on liian pitkä tai lyhyt. Joukkueen tunnuksen tulee olla tasan 3 merkkiä"); //Tämä tulostuu jos annettu avain oli väärän pituinen
            }
            else
            {
                return true; //Jos avain oli sopivan pituinen ja uniikki, niin silloin palautetaan boolean arvo joka oli määritelty tälle metodille true arvoon
            }
        }


        public static void PoistaJoukkue(int syötettyIndex) //Opiskelija olion poistamiseen Kokoelmasta tarkoitettu metodi, missä määritellään että sen arvo on syötettyIndex muuttujan arvo Pääohjelmasta
        {
            int i = 0; //Luodaan int muuttuja ja määritetään se 0 arvoksi

            foreach (string avain in SMLiiga.Keys) //Tämä käydään läpi jokaiselle muuttujalle foreach lauseen sisällä, tässä tapauksessa avain(key) Opiskelijat.Keys hakemiston sisältä, tämä avain tai key, on tässä tapauksessa OpiskelijaID
            {
                if (i == syötettyIndex)  //Tämä if lause toteutetaan jos muuttuja i on sama kuin käyttäjän pääohjelmassa syöttämä arvo
                {
                    TulostaViesti("Joukkue " + SMLiiga[avain].HaeData() + " poistettu SM-Liigasta "); //Ensin käytetään TulostaViesti Metodia, mikä lisää muutaman Console.Write rivin, sitten käytetään HaeData metodia käyttäjän antaman numeron vastaavalle Opiskelija avaimelle(OpiskelijaID)
                    SMLiiga.Remove(avain); //Poistetaan käyttäjän antamaa numeroa vastaava Opiskelija olio, Opiskelijat kokoelmasta
                    break; //Poistutaan metodista
                }

                i++; //i Muuttujan arvoa nostetaan yhdellä, niin kauan, että se vastaa syötettyIndex arvoa
            }
        }

        // Loopataan lista läpi, ja tulostetaan opiskelijat konsoliin
        public static void TulostaSMLiiga()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (SMLiiga.Count == 0) //Tämä if lause toteutuu jos Opiskelija Kokoelma on tyhjä, elikkä sisältää 0 Opiskelija oliota
            {
                TulostaViesti("SM-Liigassa ei ole Joukkueita");
                return; //Poistutaan Metodista
            }

            int i = 1; //Luodaan ja määritetään muuttuja int i arvoon 1

            TulostaViesti("Joukkueet SM-Liigassa: ");

            foreach (Joukkue joukkue in SMLiiga.Values) //Toteutetaan jokaiselle Opiskelija luokan Opiskelijalle Opiskelijat kokoelman Values hakemiston sisällä, arvot ovat <string> = OpiskelijaID, ja <Kokoelman tyyppi> = Opiskelija
            {
                Console.WriteLine("{0}: {1}", i, joukkue.HaeData()); // Tulostaa {0} arvoon i muuttujan arvon, ja {1} arvoon opiskelija.HaeData Metodilla Opiskelija olion tiedot 
                i++; //Kun foreach käy Opiskelija olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            }
        }
        public static void TulostaViesti(string message) //Metodi minkä pitäisi vähentää Console.WriteLinen käyttöä, kun Metodia käytetään voidaan Metodin sulkeiden sisälle Kirjoittaa se mitä halutaan, Metodi tulostaa aina kaksi ylimmäista Console.WriteLinea, ja sen jälkeen sen mitä oli kirjoitettu TulostaViestin sulkeiden sisään. esim TulostaViesti("Tulosta Tämä"), tai sitä voisi myös käyttää näin TulostaViesti(Console.ReadLine), jos halutaan, että käyttäjä voi kirjoittaa viestin sisällön
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);

        }
    }
}
