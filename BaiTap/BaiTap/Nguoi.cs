using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Nguoi
    {
        private string maDinhDanh {  get; set; }
        private string hoTen { get; set; }

        public Nguoi() { }

        public Nguoi(string maDinhDanh, string hoTen)
        {
            this.maDinhDanh = maDinhDanh;
            this.hoTen = hoTen;
        }

        public void NhapTT()
        {
            Console.Write("Nhap ma dinh danh: ");
            maDinhDanh = Console.ReadLine();
            Console.Write("Nhap ho và ten: ");
            hoTen = Console.ReadLine();
        }
        public void xuatTT()
        {
            Console.WriteLine("ma dinh danh: " + maDinhDanh);
            Console.WriteLine("Ho va ten: "+hoTen);
        }
        public string GetMaDinhDanh() => maDinhDanh;
        public string GetHoTen() => hoTen;
    }

     class NhanVien : Nguoi { 
         public string namSinh {  get; set; }
        public double heSoLuong {  get; set; }
        private static double phuCap = 500;

        public NhanVien() { }
        
        public NhanVien(string maDinhDanh, string hoTen, string namSinh, double heSoLuong, double phuCap) : base(maDinhDanh, hoTen)
        {
            this.namSinh = namSinh;
            this.heSoLuong = heSoLuong;

        }
    
        public void NhapTT()
        {
            base.NhapTT();
            Console.Write("Nhap nam sinh : ");
            namSinh = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void xuatTT()
        {
            base.xuatTT();
            Console.WriteLine("nam sinh: " + namSinh);
            Console.WriteLine("He so luong: "+heSoLuong);
            Console.WriteLine($"Lương: {tinhLuong()}");
            Console.WriteLine();

        }
    
        public double tinhLuong()
        {
            return heSoLuong * 1550+ phuCap;
        }
        public static void SetTienPhuCap(double phucap)
        {
            phuCap = phucap;
        }
        public static double GetTienPhuCap()
        {
         return phuCap;   
        }
        public static bool operator <(NhanVien nv1, NhanVien nv2)
        {
            return nv1.tinhLuong() < nv2.tinhLuong();
        }

        public static bool operator >(NhanVien nv1, NhanVien nv2)
        {
            return nv1.tinhLuong() > nv2.tinhLuong();
        }

    }
}

