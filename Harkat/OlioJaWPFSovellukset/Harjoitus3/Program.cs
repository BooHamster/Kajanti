using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            {      
                Boolean lopeta = false;
                Console.WriteLine("Tervetuloa käyttämään Harvia 3000, Burn your nuts off kiuasta");
                while (lopeta != true)
                {
                    Kiuas();
                    Console.ResetColor();
                    Console.WriteLine("Haluatko palata takaisin saunaan käyttämään Harvia kiuasta? K=kyllä/E=Ei");
                    if (Console.ReadLine().ToUpper() == "E") lopeta = true;

                }
                Console.ReadLine();
            }

            static void Kiuas()
            {
                bool jatka = true;
                Console.WriteLine();
                Kiuas Kiuas1 = new Kiuas("Harvia 3000, Burn your nuts off model", false, 0, 0);
                    while (jatka == true && Kiuas1.Kuolit != true)
                    {
                        try
                        {
                            Kiuas1.TulostaData();
                            Console.Write("Anna Toiminto: ");
                            string asetus = Console.ReadLine();
                            if (asetus.Equals("k") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.ONJAOFF();
                            }

                            else if (asetus.Equals("n") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.LisääLämpöä(10);
                            }

                            else if (asetus.Equals("l") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.LaskeLämpöä(10);
                            }

                            else if (asetus.Equals("h") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.HeitäLöylyä(5);
                            }

                            else if (asetus.Equals("p") && Kiuas1.Kuolit != true)
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
}
