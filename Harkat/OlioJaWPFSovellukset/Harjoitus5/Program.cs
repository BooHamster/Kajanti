using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Boolean lopeta = false;
                Console.WriteLine("Tämä on Ultimate laskinator over 9000");
                while (lopeta != true)
                {
                    Laskin();
                    Console.ResetColor();
                    Console.WriteLine("Haluatko vielä laskea universumin salaisuuksia? K=kyllä/E=Ei");
                    if (Console.ReadLine().ToUpper() == "E") lopeta = true;

                }
                Console.ReadLine();
            }
        }
        static void Laskin()
        {
            bool jatka = true;
            Console.WriteLine();
            while (jatka == true)
            {
                try
                {
                    Console.WriteLine("Minkälaisen laskun haluat tehdä?");
                    Console.WriteLine("Yhteenlasku syötä y, vähennyslasku syötä v, kertolasku syötä k, jakolasku syötä j, jos haluat lopettaa syötä p? ");
                    string asetus = Console.ReadLine();
                    Laskin Laskin1 = new Laskin();
                    if (asetus.Equals("y"))
                    {
                        Console.WriteLine("Valitsit yhteenlaskun, valitse kaksi lukua mitkä lasketaan yhteen");
                        Laskin1.ValueA = Int32.Parse(Console.ReadLine()); 
                        Laskin1.ValueB = Int32.Parse(Console.ReadLine());                       
                        Laskin1.Summa();
                    }

                    else if (asetus.Equals("v"))
                    {
                        Console.WriteLine("Valitsit vähennyslaskun, valitse mitkä kaksi lukua vähennetään");
                        Laskin1.ValueA = Int32.Parse(Console.ReadLine());
                        Laskin1.ValueB = Int32.Parse(Console.ReadLine());
                        Laskin1.Erotus();
                    }

                    else if (asetus.Equals("k"))
                    {
                        Console.WriteLine("Valitsit kertolaskun, valitse mitkä kaksi lukua kerrotaan");
                        Laskin1.ValueA = Int32.Parse(Console.ReadLine());
                        Laskin1.ValueB = Int32.Parse(Console.ReadLine());
                        Laskin1.KertoLasku();
                    }

                    else if (asetus.Equals("j"))
                    {
                        Console.WriteLine("Valitsit jakolaskun, valitse mitkä kaksi lukua jaetaan");
                        Laskin1.ValueA = Int32.Parse(Console.ReadLine());
                        Laskin1.ValueB = Int32.Parse(Console.ReadLine());
                        Laskin1.JakoLasku();
                    }

                    else if (asetus.Equals("p"))
                    {
                        jatka = false;
                    }

                    else
                    {
                        Console.WriteLine("Annoit väärän toiminnon");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Annoit väärän toiminnon");
                }
            }

        }
    }
}
