using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkue
    {
        public static Dictionary<int, Pelaaja> Pelaajat = new Dictionary<int, Pelaaja>(); //Luodaan Opiskelija tyyppinen kokoelma, jossa avain on string tyyppinen.          

        public static int PelaajaNumero;  //Tuodaan muuttujat Opiskelija luokasta, jotta voidaan asettaa ne tässä luokassa, muuten niitä ei pysty asettamaan kun luodaan Opiskelija Olio Kokoelma luokan sisällä
        public static string etunimi = "";
        public static string sukunimi = "";
        private string Nimi { get; set; }
        private string Kotikaupunki { get; set; }

        private string  Tunnus { get; set; }
        public Joukkue(string _nimi, string _kaupunki, string _tunnus)
        {
            Nimi = _nimi;
            Kotikaupunki = _kaupunki;
            Tunnus = _tunnus;
        }

        public void LisääPelaaja() //Metodi Opiskelija olion lisäämiselle Kokoelma luokan sisällä
        {
            bool Tarkista = false;  //Boolean muuttuja jolla tarkistetaan myöhemmin onko Opiskelija olion luominen sallittua
            
            Console.WriteLine("Syötä Pelaajan Etunimi: ");
            etunimi = Console.ReadLine();  // Käyttäjä saa antaa itse Opiskelijalle Etunimen
            Console.WriteLine();  //Nämä tyhjät Console.WriteLinet ovat vain luettavuutta varten, ulkoasu on selkeämpi kun kaikki tekstit eivät ole kiinni toisissaan
            Console.WriteLine("Syötä Pelaajan Sukunimi: ");
            sukunimi = Console.ReadLine(); // Käyttäjä saa antaa itse Opiskelijalle Sukunimen
            Console.WriteLine();
            while (!Tarkista)    // While looppi jonka tarkoitus on käydä Tarkistus metodi OpiskelijaID:lle, ja jos tarkistus no väärä niin käydään mennään käymään catch lauseen virheilmoitus läpi
            {
                try  //Katso try lauseen sisällön läpi, ja jos käyttäjä syöttää väärin OpiskelijaID:een, niin silloin siirrytään catch lauseeseen
                {
                    Console.WriteLine("Syötä Pelaajan Peli Numero, sen on oltava vain 2 Numeroa: ");
                    PelaajaNumero = Convert.ToInt32(Console.ReadLine());  //Käyttäjä saa syöttää Opiskelija ID:een itse
                    Tarkista = TarkistaPelaajaNumero(PelaajaNumero); //Määritetään boolean Tarkista samaksi kuin TarkistaID metodi, ja käydään Tarkista metodi läpi käyttäjän antamalle OpiskelijaID:lle
                }
                catch (Poikkeukset) //Virheilmoitus metodi on sisällytetty catch lauseen () sulkeiden sisään, jolloin voidaan jättää {} sisältö tyhjäksi
                {

                }
            }

            if (Tarkista) //Jos OpiskelijaID oli oikein syötetty, TarkistaID palauttaa Tarkista booleanille true vastauksen, jolloin tämä if lause käydään läpi
            {
                Pelaajat.Add(PelaajaNumero, new Pelaaja(etunimi, sukunimi, PelaajaNumero)); //Luodaan Opiskelija olio, ja asetetaan arvot Opiskelija olion konstruktorista, ja samalla lisätään Opiskelija olio Opiskelijat Kokoelmaan
                TulostaViesti(string.Format("Uusi Pelaaja {0} on lisätty Joukkueeseen {1}",  Pelaajat[PelaajaNumero].HaeData(), Nimi));  //Käydään TulostaViesti metodi läpi
            }
        }

        public static bool TarkistaPelaajaNumero(int id) //Metodi OpiskelijaID:een tarkistukseen
        {
            if (Pelaajat.ContainsKey(id)) //Katsotaan onko Opiskelijat Kokoelmassa jo lisätty avain ContainsKey() Metodilla, mikä on valmis metodi, ja palauttaa true arvon jos se löytää Kokoelmasta jo saman avaimen, ja falsen jos se ei löydä samaa avainta
            {
                throw new Poikkeukset("Pelaaja Numero " + id + " ei ole uniikki, anna uusi ID"); //Tämä tulostuu jos annettu avain löytyi jo Kokoelmasta
            }
            else if (id < 2 || id > 2) //Tämä katsoo onko annettu avain annettujen arvojen sisällä, tässä tapauksessa ei lyhyempi tai pidempi kuin 6 merkkiä
            {
                throw new Poikkeukset("Pelaaja Numero " + id + " on liian pitkä tai lyhyt. Pelaaja Numeron Pituus tulee olla tasan 2 numeroa"); //Tämä tulostuu jos annettu avain oli väärän pituinen
            }
            else
            {
                return true; //Jos avain oli sopivan pituinen ja uniikki, niin silloin palautetaan boolean arvo joka oli määritelty tälle metodille true arvoon
            }
        }


        public void PoistaPelaaja(int syötettyIndex) //Opiskelija olion poistamiseen Kokoelmasta tarkoitettu metodi, missä määritellään että sen arvo on syötettyIndex muuttujan arvo Pääohjelmasta
        {
            int i = 0; //Luodaan int muuttuja ja määritetään se 0 arvoksi

            foreach (int avain in Pelaajat.Keys) //Tämä käydään läpi jokaiselle muuttujalle foreach lauseen sisällä, tässä tapauksessa avain(key) Opiskelijat.Keys hakemiston sisältä, tämä avain tai key, on tässä tapauksessa OpiskelijaID
            {
                if (i == syötettyIndex)  //Tämä if lause toteutetaan jos muuttuja i on sama kuin käyttäjän pääohjelmassa syöttämä arvo
                {
                    TulostaViesti("Pelaaja " + Pelaajat[avain].HaeData() + " poistettu Joukkueesta " + Nimi); //Ensin käytetään TulostaViesti Metodia, mikä lisää muutaman Console.Write rivin, sitten käytetään HaeData metodia käyttäjän antaman numeron vastaavalle Opiskelija avaimelle(OpiskelijaID)
                    Pelaajat.Remove(avain); //Poistetaan käyttäjän antamaa numeroa vastaava Opiskelija olio, Opiskelijat kokoelmasta
                    break; //Poistutaan metodista
                }

                i++; //i Muuttujan arvoa nostetaan yhdellä, niin kauan, että se vastaa syötettyIndex arvoa
            }
        }

        // Loopataan lista läpi, ja tulostetaan opiskelijat konsoliin
        public static void TulostaJoukkue()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (Pelaajat.Count == 0) //Tämä if lause toteutuu jos Opiskelija Kokoelma on tyhjä, elikkä sisältää 0 Opiskelija oliota
            {
                TulostaViesti("Joukkueessa ei ole pelaajia");
                return; //Poistutaan Metodista
            }

            int i = 1; //Luodaan ja määritetään muuttuja int i arvoon 1

            TulostaViesti("Pelaajat Joukkueessa: ");

            foreach (Pelaaja pelaaja in Pelaajat.Values) //Toteutetaan jokaiselle Opiskelija luokan Opiskelijalle Opiskelijat kokoelman Values hakemiston sisällä, arvot ovat <string> = OpiskelijaID, ja <Kokoelman tyyppi> = Opiskelija
            {
                Console.WriteLine("{0}: {1}", i, pelaaja.HaeData()); // Tulostaa {0} arvoon i muuttujan arvon, ja {1} arvoon opiskelija.HaeData Metodilla Opiskelija olion tiedot 
                i++; //Kun foreach käy Opiskelija olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            }
        }
        public static void TulostaViesti(string message) //Metodi minkä pitäisi vähentää Console.WriteLinen käyttöä, kun Metodia käytetään voidaan Metodin sulkeiden sisälle Kirjoittaa se mitä halutaan, Metodi tulostaa aina kaksi ylimmäista Console.WriteLinea, ja sen jälkeen sen mitä oli kirjoitettu TulostaViestin sulkeiden sisään. esim TulostaViesti("Tulosta Tämä"), tai sitä voisi myös käyttää näin TulostaViesti(Console.ReadLine), jos halutaan, että käyttäjä voi kirjoittaa viestin sisällön
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);

        }

        public string HaeData() //Opiskelijan tietojen tulostamiseen tarkoitettu Metodi
        {
            return Nimi + "." + " Kotikaupunki: "+ Kotikaupunki + "." + " Tunnus: " + Tunnus + "."; //Palauttaa nämä tiedot, tämän voisi kyllä toteuttaa myös Console.Write komennolla myös
        }
    }
}
