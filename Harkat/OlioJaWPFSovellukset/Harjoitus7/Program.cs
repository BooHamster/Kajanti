using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            Hissi Hissi1 = new Hissi();

            while (jatka != false)
            {
                try
                {
                    Console.Write("Olet hississä jossa on 1-6 kerrosta, mihin kerrokseen haluaisit mennä? Anna kerroksen numero: ");
                    Hissi1.AsetaKerros();
                    Console.WriteLine("jos haluat poistua hissistä paina 'p' nappia: ");
                    if (Console.ReadKey(true).Key == ConsoleKey.P)
                    {
                        Console.WriteLine("Poistuit hissistä");
                        jatka = false;
                    }
                    else
                    {
                        Hissi1.AsetaKerros();
                    }
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Annoit väärän toiminnon");
                }
            }
            //Hissi1.Kerros = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Olet kerroksessa: " + Hissi1.Kerros.ToString());

        }
    }
}
