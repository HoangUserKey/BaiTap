using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           //QuanLy ql = new QuanLy();
           // ql.NhapDuLieu();
           //QuanLyHinhHoc ql = new QuanLyHinhHoc();
           // ql.quanLyHCN();
           //HinhChuNhat hinhChuNhat = new HinhChuNhat();
           // hinhChuNhat.Xuat();

            Manager manager = new Manager();
            manager.Show();
        }
    }
}
