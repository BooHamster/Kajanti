using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin.KuinkaMonta();
            Monkey.KuinkaMonta();
            Dog.KuinkaMonta();

            Eläin eläin = new Eläin();
            Dog.KuinkaMonta();

            eläin.Ääntele();

            Dog dog = new Dog();
            dog.Ääntele();

            Dog Dog2= new Dog();

            Dog Dog23= new Dog();

            Monkey monkey = new Monkey();
            monkey.Ääntele();

            Monkey monkey2 = new Monkey();
            monkey2.Ääntele();
            Monkey monkey3 = new Monkey();
            monkey3.Ääntele();
            Eläin.KuinkaMonta();
            Dog.KuinkaMonta();
            Monkey.KuinkaMonta();
        }
    }
}
