using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my app");
            Console.WriteLine("");
            Console.WriteLine("1. Adoptable Dogs");
            Console.WriteLine("2. Adoptable Cats");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Please select an option from above");

            string userselection;
            userselection = Console.ReadLine();


            switch (userselection)
            {
                case "1":
                    Dogs();
                    break;
                case "2":
                    Cats();
                    break;
                case "3":
                    Exit();
                    break;
            }

            Menu();
        }

        static void Dogs()
        {
            Console.WriteLine("This is the dog!");
            Console.ReadLine();
        }

        static void Cats()
        {
            Console.WriteLine("This is the cats one!");
            Console.ReadLine();
        }

        static void Exit()
        {
            Console.WriteLine("This is the exit!");
            Console.ReadLine();
        }
    }
}
