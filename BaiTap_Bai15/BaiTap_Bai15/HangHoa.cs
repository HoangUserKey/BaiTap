using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{

    interface IProduct
    {
        void HienThi();

        void TinhGiaTri();
    }

     class HangHoa : IProduct
    {
        public int ID {  get; set; }
        public string TenHang {  get; set; }
        public int soLuong {  get; set; }
        public double DonGia { get; set; }

        public HangHoa() { }

        public HangHoa(int iD, string tenHang, int soLuong, double donGia)
        {
            ID = iD;
            TenHang = tenHang;
            this.soLuong = soLuong;
            DonGia = donGia;
        }

        public void HienThi()
        {
            Console.WriteLine();
            Console.WriteLine("Id: " + ID);
            Console.WriteLine("Ten hang: "+TenHang);
            Console.WriteLine("So luong: "+soLuong);
            Console.WriteLine("Don gia: "+DonGia);
            Console.WriteLine();
        }

        public void TinhGiaTri()
        {
            double giaTriSP =  soLuong * DonGia;

            Console.WriteLine("Tong gia tri hang hoa =  " + giaTriSP);
            Console.WriteLine();

        }
    }

    class QuanLyHangHoa
    {
        List<HangHoa> hangHoas = new List<HangHoa>();

        public void ThemHangHoa()
        {
            Console.WriteLine("Id: " );
            int id = int.Parse( Console.ReadLine() );
            Console.WriteLine("Ten hang: " );
            string tenhang = Console.ReadLine();
            Console.WriteLine("So luong: " );
            int soluong = int.Parse( Console.ReadLine() );
            Console.WriteLine("Don gia: " );
            double dongia = double.Parse( Console.ReadLine() );

            hangHoas.Add(new HangHoa(id,tenhang,soluong,dongia));
            Console.WriteLine("Them thanh cong");
        }

        public void HienThiHangHoa()
        {
            if (hangHoas.Count == 0)
            {
                Console.WriteLine("danh sach trong");
            }

            foreach (var hanghoas in hangHoas)
            {
                hanghoas.HienThi();
            }
        }

        public void TinhGiaTriHangHoa()
        {
            foreach (var hHoa in hangHoas)
            {
                hHoa.TinhGiaTri();
            }
        }
    }
}
