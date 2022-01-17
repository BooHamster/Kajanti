using System;

namespace OmaOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Boolean lopeta = false;
                Console.WriteLine("Tämä on aviomies simulaattori, pelaa vain jos et ole heikko hermoinen!");
                while (lopeta != true)
                {
                    Helvetti();
                    Console.ResetColor();
                    Console.WriteLine("Haluatko takaisin helvettiin? ");
                    if (Console.ReadLine().ToUpper() == "E") lopeta = true;

                }
                Console.ReadLine();

                static void Helvetti()
                {
                    bool jatka = true;
                    Console.WriteLine();
                    Mies Mies1 = new Mies(false, 100); ;
                    Console.WriteLine("Anna nimesi, mut älä jos se on Yrjö!: ");
                    while (jatka == true && Mies1.Kuollut != true)
                    {
                        try
                        {
                            Mies1.NäytäInfo();
                            string asetus = Console.ReadLine();
                            if (number(1, 1) == 1) 
                            {
                                Console.WriteLine("Kohtaat vaimosi, hän haluaa hieronnan, annatko rakkaalle vaimollesi hieronnan? k/e ");
                            }
                            if (asetus.Equals("e"))
                            {
                                Mies1.OtaLämää(10);
                            }

                            else if (asetus.Equals("k"))
                            {
                                Console.WriteLine("Annat vaimollesi ronskin hieronnan, hän hymisee tyytyväisenä unee ");
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Annoit väärän toiminnon");
                        }

                    }

                    static int number(int min, int max)
                    {
                        Random random = new Random();
                        return random.Next(min, max);
                    }
                }
            }
            
        }
    }
}
