using System;

namespace C0732101
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkoverTheList();
        }
    }

    class Dog
    {
        public static int NumberofDogs = 0;
        public Dog()
        {
            Dog.NumberofDogs++;
        }

        public String DogName;
        public String DogBreed;
        public Dog NextDog;
    }

    class LinkedList
    {
        public Dog Current;
        public Dog Head;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.NextDog = Fifi;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poddle";
            Fifi.NextDog = Jordan;

            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "Germansheppard";
            Jordan.NextDog = Fido;

            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.NextDog = null;
        }
        public void WalkoverTheList()
        {
            Current = Head;

            while (Current != null)
            {
                Console.WriteLine(Current.DogName);
                Current = Current.NextDog;
            }
            Console.ReadLine();


        }
    }
}