using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
     abstract class HinhHoc
    {
        public abstract double DienTich();
        public abstract double ChuVi();

        public void Xuat()
        {
            Console.WriteLine("Dien tich = " + DienTich());
            Console.WriteLine("Chu vi = "+ChuVi());
        }


    }

    class HinhChuNhat : HinhHoc {
        public double Cd {  get; set; }
        public double Cr { get; set; }
        List<HinhChuNhat> hcn = new List<HinhChuNhat>();

        public HinhChuNhat() { }
        public HinhChuNhat(double Cd, double Cr) { 
            this.Cd = Cd;
            this.Cr = Cr;
        }

        public override double DienTich() {
            Console.Write("Nhap chieu dai: ");
            double cd = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double cr = double.Parse(Console.ReadLine());
            //hcn.Add(new HinhChuNhat(cd, cr));
            //Console.WriteLine("Them thanh cong");

            return Cd*Cr;
        
        }
        public override double ChuVi() {
            return (Cd + Cr) * 2;
        
        }
    
    }

    class HinhTron : HinhHoc
    {
        public double bankinh { get; set; }
        public HinhTron() { }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }

        public override double DienTich() {
            Console.Write("Nhap ban kinh: ");
            bankinh = double.Parse(Console.ReadLine());
            return Math.PI * bankinh*bankinh;
        
        }
        public override double ChuVi() {
            return 2 * Math.PI * bankinh;
        }
    }

    class HinhTamGiac : HinhHoc
    {
        public double canhA {  get; set; }
        public double canhB { get; set; }
        public double canhC { get; set; }

        public HinhTamGiac() { }

        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            this.canhA = canhA;
            this.canhB = canhB;
            this.canhC = canhC;
        }

        public override double DienTich() {

            Console.Write("Nhap chieu dai: ");
            canhA = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            canhB = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            canhC = double.Parse(Console.ReadLine());

            return 1/2 *canhA*canhC;
        }
        public override double ChuVi() {
            return canhA+canhB+canhC;
        }
    }


    //class QuanLyHinhHoc
    //{
    //    public void quanLyHCN()
    //    {
    //        HinhChuNhat hinhChuNhat = new HinhChuNhat();
    //        List<HinhChuNhat> hcn = new List<HinhChuNhat>();
    //        //List<HinhTron> ht = new List<HinhTron>();
    //        //List<HinhTamGiac> htg = new List<HinhTamGiac>();

    //        Console.Write("Nhap chieu dai: ");
    //        double cd = double.Parse(Console.ReadLine());
    //        Console.Write("Nhap chieu rong: ");
    //        double cr = double.Parse(Console.ReadLine());
    //        hcn.Add(new HinhChuNhat(cd,cr));
    //        Console.WriteLine("Them thanh cong");

    //        hinhChuNhat.Xuat();
    //    }
    //}
}
