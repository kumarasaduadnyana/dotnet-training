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
            new Deal { Id = 1, Name = "Voucher A" },
            new Deal { Id = 2, Name = "Voucher B"}
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
            Console.WriteLine("1. List Products");
            Console.WriteLine("2. List Cart");

            switch (Console.ReadLine())
            { 
                case "1":
                    ShowProductList();
                    break; 
                case "2":
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
                Console.WriteLine("The cart is empty!");
            }

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
                    ShowDealProducts();
                    break;
                case "2":
                    ShowAccommProduct();
                    break;
                case "3":
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
                ShowProductList();
                return;
            }

            AddDealToCart(input);
            ShowMainMenu();
        }

        public static void AddDealToCart(string productId)
        {
            var productIdInt = int.Parse(productId);

            var deal = DealList.First(x => x.Id == productIdInt);
            Cart.Items.Add(deal);
        }
    }
}