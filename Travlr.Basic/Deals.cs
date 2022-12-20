using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travlr.Basic
{
    public class Deals
    {
        public static void DealList()
        {
            List<string> dealsproduct = new()
            {
                "Hotels Kuta",
                "Hotel Seminyak",
                "back"
            };

            foreach (var item in dealsproduct)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Choose Deals: ");
            switch (Console.ReadLine())
            {
                case "1":

                    ListCart.Cart();
                    Console.WriteLine("Success Add to cart");
                    break;
                case "2":
                    Console.WriteLine("Back Order");
                    break; 

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
                    Console.Clear();
                    break;*/
                    
                default:
                    break;
            }
        }
    }
}