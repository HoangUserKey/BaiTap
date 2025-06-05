using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{
    interface IShape
    {
        double TinhChuVi();

        double TinhDienTich();
    }
     class HinhChuNhat : IShape
     {
        public double Cd {  get; set; }
        public double Cr {  get; set; }

        public HinhChuNhat() { }
        public HinhChuNhat(int cd, int cr)
        {
            Cd = cd;
            Cr = cr;
        }

        public double TinhChuVi() {
            Console.Write("Nhap chieu dai: ");
             Cd = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
             Cr = int.Parse(Console.ReadLine());

            return 2*(Cr+Cd);
        
        }
        public double TinhDienTich() {


            return Cd * Cr;
        }
     }

    class HinhTron : IShape {
        public double banKinh {  get; set; }
        public HinhTron() { }

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public double TinhChuVi() {
            Console.Write("Nhap ban khinh hinh tron: ");
            banKinh = double.Parse(Console.ReadLine());

            return 2 * Math.PI *banKinh;
            

        }
        public double TinhDienTich() {

           
            return Math.PI * banKinh * banKinh;
        
        }
    
    }
    class HinhHoc
    {
        public void ThongTinHCN()
        {           
            HinhChuNhat HinhChuNhat = new HinhChuNhat();
            Console.WriteLine($"Chu vi Hinh chu nhat: {HinhChuNhat.TinhChuVi()}");
            Console.WriteLine($"Dien tich hinh tron: {HinhChuNhat.TinhDienTich()}");

        }

        public void ThongTinTron() {
            

            HinhTron HinhTron = new HinhTron();
            Console.WriteLine($"Chu vi Hinh Tron: {HinhTron.TinhChuVi()}");
            Console.WriteLine($"Dien tich Hinh Tron: {HinhTron.TinhDienTich()}");


        }
    }
}
