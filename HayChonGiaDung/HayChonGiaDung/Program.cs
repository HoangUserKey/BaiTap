using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayChonGiaDung
{
    class PriceGuessGame
    {
        static Dictionary<string, int> products = new Dictionary<string, int>
    {
        { "Dien thoai", 1000 },
        { "Laptop", 1500 },
        { "Tai nghe", 200 },
        { "TV", 1200 }
    };

        static Random rand = new Random();

        static void Main()
        {
            Console.WriteLine(" CHAO MUNG BAN DEN VOI HAY CHON GIA DUNG!");
            var selectedProduct = GetRandomProduct();
            Console.WriteLine($"\n🔹 San pham: {selectedProduct.Key}");
            Console.Write(" Đoan gia: ");

            int guess;
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                int actualPrice = selectedProduct.Value;
                int difference = Math.Abs(actualPrice - guess);

                Console.WriteLine($" Gia thuc te: {actualPrice} USD");
                if (difference == 0)
                    Console.WriteLine(" Ban doan chinh xac!Ban da là nguoi chien thang");
                else if (difference <= 100)
                    Console.WriteLine(" Ban doan gan dung.");
                else
                    Console.WriteLine(" Sai roi! ");
            }
            else
            {
                Console.WriteLine("Nhap so hop le");
            }
        }

        static KeyValuePair<string, int> GetRandomProduct()
        {
            var productList = new List<KeyValuePair<string, int>>(products);
            return productList[rand.Next(productList.Count)];
        }
    }

}
