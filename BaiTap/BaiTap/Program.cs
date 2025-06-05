using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            showBai40();
        }

        public static void showBai40()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int sl = int.Parse(Console.ReadLine());
            List<SVAI> list = new List<SVAI>();

            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine($"Nhap Thong tin sinh vien thu {i + 1}:");
                SVAI sVAI = new SVAI();
                sVAI.Nhap();
                list.Add(sVAI);
            }

            Console.WriteLine("\nDanh sach sinh vien");
            foreach (var sVAI1 in list)
            {
                sVAI1.Xuat();
            }

            list.Sort((a,b) => b.Dtb.CompareTo(a.Dtb));
            Console.WriteLine("\nDanh sach sinh vien sau khi xap xep:");
            foreach (var svai in list)
            {
                svai.Xuat();
            }

        }

        public static void showBai39()
        {
            //// Nhập thông tin một người
            //Console.WriteLine("Nhập thông tin một người:");
            //Nguoi nguoi = new Nguoi();
            //nguoi.NhapTT();
            //Console.WriteLine("\nThông tin người:");
            //nguoi.xuatTT();

            Console.Write("Nhap so luong nhan vien: ");
            int sl = int.Parse(Console.ReadLine());
            List<NhanVien> list = new List<NhanVien>();

            for (int i = 0; i < sl; i++) {
                Console.WriteLine($"Nhap Thong tin nhan vien thu {i + 1}:");
                NhanVien nhanVien = new NhanVien();
                nhanVien.NhapTT();
                list.Add(nhanVien);
            }

            Console.WriteLine("Danh sach nhan vien");
            foreach (var nhanVien in list)
            {
                nhanVien.xuatTT();
            }

            list.Sort((nv1, nv2) => nv2.tinhLuong().CompareTo(nv1.tinhLuong()));

            Console.WriteLine("\nDanh sach sau khi giam dan");
            foreach (var nv in list)
            {
                nv.xuatTT();
            }

        }
    }
}
