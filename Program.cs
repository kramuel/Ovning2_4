using System;

namespace Ovning2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string userInput = "";
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Måndag":
                    Console.WriteLine("1");
                    break;
                case "Tisdag":
                    Console.WriteLine("2");
                    break;
                case "Onsdag":
                    Console.WriteLine("3");
                    break;
                case "Torsdag":
                    Console.WriteLine("4");
                    break;
                case "Fredag":
                    Console.WriteLine("5");
                    break;
                case "Lördag":
                    Console.WriteLine("6");
                    break;
                case "Söndag":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("felinput");
                    break;

            }

            Console.ReadKey();
            
        }
    }
}
