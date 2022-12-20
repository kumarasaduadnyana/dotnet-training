using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travlr.Basic
{
    internal class Accommodation
    {
        public static void AccommodationList()
        {
            List<string> listProduct = new List<string>();
            listProduct.Add("1. Hotel Kuta");
            listProduct.Add("2. Villa Kura");

            foreach (var item in listProduct)
            {
                Console.Write(listProduct);
            }
        }
    }
}
