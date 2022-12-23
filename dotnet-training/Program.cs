using dotnet_training.Models;
using System.Data;
using System.Runtime.CompilerServices;
namespace dotnet_training
{
    public class Program
    {
        /* List Of deals, define Deals product  */

        public static List<Deal> DealList = new List<Deal>
        { 
            new Deal { Id = 1, Name = "Treat Yourself to the Ultimate Lombok Escape" },
            new Deal { Id = 2, Name = "Epic NYE Celebration ft. Clean Bandit, Timmy Trumpet and KSHMR"}
        };

        
        /* List of Accommodation, define Deals  */
        public static List<Accommodation> AccomList = new List<Accommodation>
        {
            new Accommodation { Id = 1, Name = "Hotels A" },
            new Accommodation { Id = 2, Name = "Hotels B"}
        };

        /* Add item to cart */
        public static Cart Cart = new Cart();

        public static void Main(string[] args)
        {
            ShowMainMenu();
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("====== Welcome to our services. Please Choose the product you want to buy =====");
            Console.WriteLine("\n");
            Console.WriteLine("1. List of Products");
            Console.WriteLine("2. List of Cart \n");
            Console.WriteLine("Choose the menu:");
            switch (Console.ReadLine())
            { 
                case "1":
                    Console.Clear();
                    ShowProductList();
                    break; 
                case "2":
                    Console.Clear();
                    ShowCartItemList();
                    break;
            }
        }

        private static void ShowCartItemList()
        {
            if (Cart.Items.Any())
            {
                foreach (var item in Cart.Items)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The cart is empty!");
                Console.WriteLine("You will redirect to the main menu");
            }
            Thread.Sleep(1000);
            Console.Clear();
            ShowMainMenu();
        }

        public static void ShowProductList()
        {
            Console.WriteLine("1. Deals");
            Console.WriteLine("2. Accoms");
            Console.WriteLine("3. Back");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    ShowDealProducts();
                    break;
                case "2":
                    Console.Clear();
                    ShowAccommProduct();
                    break;
                case "3":
                    Console.Clear();
                    ShowMainMenu();
                    break;
            }
        }

        public static void ShowDealProducts()
        {
            foreach (var item in DealList)
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }

            Console.WriteLine("99. Back");

            var input = Console.ReadLine();

            if (input == "99")
            {
                ShowProductList();
                return;
            }

            AddDealToCart(productId: input);
            ShowMainMenu();
        }

        public static void ShowAccommProduct()
        {
            foreach (var item in AccomList)
            {
                Console.WriteLine(item.Id + ". " + item.Name);
            }

            var input = Console.ReadLine();

            Console.WriteLine("99. Back");

            if (input == "99") 
            {
                Console.Clear();
                ShowProductList();
                return;
            }

            AddDealToCart(productId: input);
            /*Console.Clear();
            Console.WriteLine("");
            Console.Clear();*/
            ShowMainMenu();
        }

        public static void AddDealToCart(string? productId)
        {
            int productIdInt = int.Parse(s: productId);

            var deal = DealList.First(x => x.Id == productIdInt);
            Cart.Items.Add(deal);

            var accom = AccomList.First(x => x.Id == productIdInt);
            Cart.Items.Add(accom);

        }
    }
}