using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{
    internal class SoNguyen
    {
        public static void soNguyen()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

           
            for (int i = 0; i < 10000; i++)
            {
                numbers.Add(random.Next(1, 1001));
            }

          
            numbers.Sort();

          
            var frequency = numbers.GroupBy(n => n)
                                   .Where(g => g.Count() > 5)
                                   .Select(g => new { Number = g.Key, Count = g.Count() });


            Console.WriteLine("Cac so hien nhieu hon 5:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"so {item.Number} xuat hien {item.Count} lan");
            }

        }
    }
}
