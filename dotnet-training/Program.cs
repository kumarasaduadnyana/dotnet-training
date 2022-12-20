using System.Runtime.CompilerServices;
using Travlr.Basic;
namespace dotnet_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            List<string> ListMenu = new List<string>();
            ListMenu.Add("1. List Product");
            ListMenu.Add("2. List Cart");

            foreach (var item in ListMenu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Choose the number: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Product.ListOfProduct();
                    break;

                case "2":
                    ListCart.Cart();
                    break;

                case "3":
                    Console.WriteLine("Exit");
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Showing List Success");
                    break;
            }
        }
    }
}