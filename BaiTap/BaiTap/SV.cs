using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class SV
    {
        public string maSV {  get; set; }
        public string hoTen {  get; set; }
        public SV() { }
        public SV(string maSV, string hoTen) { 
            this.maSV = maSV;
            this.hoTen = hoTen;
        }

        public void Nhap()
        {
            Console.Write("Nhap maSV: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma Sinh Vien: "+ maSV);
            Console.WriteLine("Ho ten: "+hoTen);
        }
    }
    class SVAI : SV {
         public double Dtb {  get; set; }

        public SVAI() { }
        public SVAI(string maSV, string hoTen, double dtb) : base(maSV, hoTen) {
             this.Dtb = dtb;
        }
        
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem trung binh: ");
            Dtb = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem trung binh: "+Dtb);
        }

        public static bool operator < (SVAI a, SVAI b) {
            return a.Dtb < b.Dtb;
        }

        public static bool operator >(SVAI a, SVAI b) {
            return b.Dtb > a.Dtb;
        }
    }
}
