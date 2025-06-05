using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{
    /// BAi 2
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLySinhVien qlsv = new QuanLySinhVien();
            NewManager newManager = new NewManager();
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa();

            HinhHoc hinhHoc = new HinhHoc();

            while (true) {
                //bai1
                //Console.WriteLine("QUAN LY SINH VIEN");
                //Console.WriteLine("1. Them sinh vien");
                //Console.WriteLine("2. Xem danh sach sinh vien");
                //Console.WriteLine("3. Tim kiem sinh vien");
                //Console.WriteLine("4. Thoat");

                //bai2
                //Console.WriteLine("\nMENU Quan Ly Tin Tuc");
                //Console.WriteLine("1. Thêm tin tuc");
                //Console.WriteLine("2. Xem danh sach tin tuc");
                //Console.WriteLine("3. Danh gia tin tuc");
                //Console.WriteLine("4. Thoat");

                //bai3
                //Console.WriteLine("\nMenu:");
                //Console.WriteLine("1. Them hang hoa");
                //Console.WriteLine("2. Hien thi danh sach hang hoa");
                //Console.WriteLine("3. Tinh ra tri hang hoa");
                //Console.WriteLine("4. Thoat");

                // Bai4 Hinh chu nhat, hinh tron
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Hinh chu nhat");
                Console.WriteLine("2. Hinh tron");
                Console.WriteLine("4. Thoat");

                Console.Write("Ban chon chuc nang so: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon) {
                    case 1:
                        //qlsv.ThemSV();
                        //newManager.InsertNew();
                        //quanLyHangHoa.ThemHangHoa();
                        hinhHoc.ThongTinHCN();
                        break;
                    case 2:
                        //qlsv.xemDanhSach();
                        //newManager.ViewListNew();
                        //quanLyHangHoa.HienThiHangHoa();
                        hinhHoc.ThongTinTron();
                        break;
                    case 3:
                        //qlsv.TimKiemSV();
                        //newManager.RateNews();
                        //quanLyHangHoa.TinhGiaTriHangHoa();
                        break;
                    case 4:
                        return;
                        break;
                    default:
                        Console.WriteLine("Nhap sai , nhap lai");
                        break;
                }

            }
        }
    }

    // Bai 1
    //class ManagePhoneBook
    //{
    //    static void Main()
    //    {
    //        PhoneBook phoneBook = new PhoneBook();
    //        while (true)
    //        {
    //            Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
    //            Console.WriteLine("1. Insert Phone");
    //            Console.WriteLine("2. Remove Phone");
    //            Console.WriteLine("3. Update Phone");
    //            Console.WriteLine("4. Sort Phone");
    //            Console.WriteLine("5. Search Phone");
    //            Console.WriteLine("6. Exit");
    //            Console.Write("Choose an option: ");

    //            int choice = int.Parse(Console.ReadLine());

    //            switch (choice)
    //            {
    //                case 1:
    //                    Console.Write("Nhap ten: ");
    //                    string name = Console.ReadLine();
    //                    Console.Write("Nhap SDT: ");
    //                    string phone = Console.ReadLine();
    //                    phoneBook.InsertPhone(name, phone);
    //                    break;
    //                case 2:
    //                    Console.Write("Nhap ten can xoa: ");
    //                    name = Console.ReadLine();
    //                    phoneBook.RemovePhone(name);
    //                    break;
    //                case 3:
    //                    Console.Write("Nhap ten can update: ");
    //                    name = Console.ReadLine();
    //                    Console.Write("Nhap SDT: ");
    //                    string newphone = Console.ReadLine();
    //                    phoneBook.UpdatePhone(name, newphone);
    //                    break;
    //                case 4:
    //                    phoneBook.Sort();
    //                    break;
    //                case 5:
    //                    Console.Write("Nhap ten can tim: ");
    //                    name = Console.ReadLine();
    //                    phoneBook.SearchPhone(name);
    //                    break;
    //                case 6:
    //                    return;
    //                default:
    //                    Console.WriteLine("Nhap sai , nhap lai");
    //                    break;
    //            }
    //        }
    //    }
    //}


    /// BAi 2
    /// 


}
