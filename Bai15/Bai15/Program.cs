using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal.Show();
            Animal1.Show();
        }
    }

    //class ZooTest
    //{
    //    static Zoo zoo = new Zoo(); // Khởi tạo đối tượng Zoo

    //    static void Main()
    //    {
    //        while (true)
    //        {
    //            Console.WriteLine("\n===== Quan Ly So Tu =====");
    //            Console.WriteLine("1.Them Chuong");
    //            Console.WriteLine("2. Xoa chuong");
    //            Console.WriteLine("3. Them con vat");
    //            Console.WriteLine("4. Xoa con vat");
    //            Console.WriteLine("5. Danh sach cac con vay");
    //            Console.WriteLine("6. Thoat");
    //            Console.Write("Ban chon chuc nang so: ");

    //            int choice;
    //            if (!int.TryParse(Console.ReadLine(), out choice))
    //            {
    //                Console.WriteLine("chuong trinh khong hop le");
    //                continue;
    //            }

    //            switch (choice)
    //            {
    //                case 1:
    //                    ThemChuong();
    //                    break;
    //                case 2:
    //                    XoaChuong();
    //                    break;
    //                case 3:
    //                    ThemConVat();
    //                    break;
    //                case 4:
    //                    XoaConVat();
    //                    break;
    //                case 5:
    //                    zoo.XemDanhSachChuong();
    //                    break;
    //                case 6:
    //                    Console.WriteLine("Thoat chuong trinh");
    //                    return;
    //                default:
    //                    Console.WriteLine("Lua chon khong hop le");
    //                    break;
    //            }
    //        }
    //    }

    // Thêm chuồng
    //        static void ThemChuong()
    //        {
    //            Console.Write("Nhap ma chuong: ");
    //            int maChuong;
    //            if (!int.TryParse(Console.ReadLine(), out maChuong))
    //            {
    //                Console.WriteLine("Ma chuong phai la so");
    //                return;
    //            }
    //            zoo.ThemChuong(new Chuong(maChuong));
    //        }

    //        // Xóa chuồng
    //        static void XoaChuong()
    //        {
    //            Console.Write("Nhap ma chuong can xoa: ");
    //            int maChuong;
    //            if (!int.TryParse(Console.ReadLine(), out maChuong))
    //            {
    //                Console.WriteLine("Ma chuong phai la so");
    //                return;
    //            }
    //            zoo.XoaChuong(maChuong);
    //        }

    //        // Thêm con vật
    //        static void ThemConVat()
    //        {
    //            Console.Write("Nhap ma chuong de them con vat: ");
    //            int maChuong;
    //            if (!int.TryParse(Console.ReadLine(), out maChuong))
    //            {
    //                Console.WriteLine("Ma chuong phai la so");
    //                return;
    //            }

    //            Chuong chuong = null;
    //            foreach (Chuong c in zoo.danhsachChuong)
    //            {
    //                if (c.maChuong == maChuong)
    //                {
    //                    chuong = c;
    //                    break;
    //                }
    //            }

    //            if (chuong == null)
    //            {
    //                Console.WriteLine("khong tim thay chuong");
    //                return;
    //            }

    //            Console.WriteLine("Chon loai dong vat (Tiger/Dog/Cat): ");
    //            string loai = Console.ReadLine().Trim().ToLower();

    //            Console.Write("Nhap ten con vat: ");
    //            string ten = Console.ReadLine();

    //            Console.Write("Nhap tuoi con vat: ");
    //            int tuoi;
    //            if (!int.TryParse(Console.ReadLine(), out tuoi))
    //            {
    //                Console.WriteLine("Tuoi phai la so");
    //                return;
    //            }

    //            Console.Write("mo ta: ");
    //            string mota = Console.ReadLine();

    //            Animal animal = null;
    //            switch (loai)
    //            {
    //                case "tiger":
    //                    animal = new Tiger(ten, tuoi, mota);
    //                    break;
    //                case "dog":
    //                    animal = new Dog(ten, tuoi, mota);
    //                    break;
    //                case "cat":
    //                    animal = new Cat(ten, tuoi, mota);
    //                    break;
    //                default:
    //                    Console.WriteLine("Loai dong vat khong hop le");
    //                    return;
    //            }

    //            chuong.ThemConVat(animal);
    //        }

    //        // Xóa con vật
    //        static void XoaConVat()
    //        {
    //            Console.Write("Nhap ma chuong can xoa: ");
    //            int maChuong;
    //            if (!int.TryParse(Console.ReadLine(), out maChuong))
    //            {
    //                Console.WriteLine("Ma chuong phai la so");
    //                return;
    //            }

    //            Chuong chuong = null;
    //            foreach (Chuong c in zoo.danhsachChuong)
    //            {
    //                if (c.maChuong == maChuong)
    //                {
    //                    chuong = c;
    //                    break;
    //                }
    //            }

    //            if (chuong == null)
    //            {
    //                Console.WriteLine("Khong tim thay chuong");
    //                return;
    //            }

    //            Console.Write("Nhap ten con vat can xoa: ");
    //            string ten = Console.ReadLine();

    //            chuong.XoaConVat(ten);
    //        }
    //    }

}
