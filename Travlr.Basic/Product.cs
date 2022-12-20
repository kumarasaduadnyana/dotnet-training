using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travlr.Basic
{
    public class Product
    {
        public static void ListOfProduct()
        {
            List<string> products = new()
            {
                "1. Deals",
                "2. Accommodation",
                "3. Back"
            };

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            switch (Console.ReadLine())
            {
                case "1":
                    Deals.DealList();
                    break;
                
                case "2":
                    Accommodation.AccommodationList(); break;
                
                case "3":
                    /*do
                    {
                        Console.WriteLine("Back to main menu?");
                        ConsoleKeyInfo keyPressed;
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key != ConsoleKey.D1 && keyPressed.Key != ConsoleKey.NumPad1)
                        {
                            Console.Clear();
                            break;
                        }

                    } while (true);
                    Program.MainMenu();
                    Console.Clear();*/
                    
                    break;
                default:
                    break;
            }
        }
    }
}
