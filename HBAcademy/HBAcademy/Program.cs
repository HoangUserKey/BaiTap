using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO là khai báo file,....
using static System.Math;// khai báo math phải có static

namespace Bai2
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            //Bai2.Test1.Hel1o();

            while (true) {

                Console.WriteLine("---------------- MENU-------------");
                Console.WriteLine("Bai 1");
                Console.WriteLine("Bai 2");
                Console.WriteLine("Bai 3");
                Console.WriteLine("Bai 4");
                Console.WriteLine("Thoat");
                Console.Write("Ban chon bai so: ");

                String chon = Console.ReadLine();

                switch (chon) {

                    case "1":
                        Bai2Child.HBAcademy.Hcn();
                        break;
                    case "2":
                        Bai2Child.HBAcademy.Profile();
                        break;
                    case "3":
                        Bai2Child.HBAcademy.Population();
                        break;
                    case "4":
                        Bai2Child.HBAcademy.M_unicode();
                        break;

                    case "5":
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            }

        }

    }
}
