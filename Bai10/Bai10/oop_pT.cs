using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bai10
{
    internal class oop_pT
    {
        private string HoTen {  get; set; }
        private DateTime NgaySinh {  get; set; }
        private string QueQuan {  get; set; }
        private double HeSoLuong {  get; set; }
        private double TienThuong {  get; set; }

        // Constructor
        public oop_pT(string hoTen, DateTime ngaySinh, string queQuan, double heSoLuong, double tienThuong)
        {
            HoTen = ChuanHoaHoTen(hoTen);
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            HeSoLuong = heSoLuong;
            TienThuong = tienThuong;
        }

        // Phương thức chuẩn hóa họ tên
        private string ChuanHoaHoTen(string hoTen)
        {
            TextInfo textInfo = new CultureInfo("vi-VN", false).TextInfo;
            return textInfo.ToTitleCase(hoTen.ToLower());
        }

        // Phương thức tính lương
        public double TinhLuong()
        {
            return HeSoLuong * 1_500_000 + TienThuong;
        }

        // Phương thức nâng lương
        public void NangLuong(double heSoLuongMoi)
        {
            if (heSoLuongMoi > HeSoLuong)
            {
                HeSoLuong = heSoLuongMoi;
                Console.WriteLine("he so luong moi: "+ HeSoLuong);
            }
            else
            {
                Console.WriteLine("He so luong moi hien tai");
            }
        }

        // Phương thức hiển thị thông tin nhân viên
        public void HienThiThongTin()
        {
            Console.WriteLine("Ho Ten: "+HoTen);
            Console.WriteLine($"Nagy sinh: {NgaySinh:dd/MM/yyyy}");
            Console.WriteLine("Que quan: "+ QueQuan);
            Console.WriteLine("He so luong: "+ HeSoLuong);
            Console.WriteLine($"Tien thuong: {TienThuong:N0} VNĐ");
            Console.WriteLine($"Lương tong: {TinhLuong():N0} VNĐ");
        }

        public static void NhanVien()
        {
            //oop_pT nv = new oop_pT("Tran Viet Hoang", new DateTime(2003, 03, 01), "Tuyen Quang", 2.5, 5000000);
            //oop_pT nv1 = new oop_pT("Tran Van B", new DateTime(2003, 03, 01), "Tuyen Quang", 2.5, 8000000);
            //oop_pT nv2 = new oop_pT("Tran Van C", new DateTime(2003, 03, 01), "Tuyen Quang", 2.7, 6000000);
            //oop_pT nv3 = new oop_pT("Tran Van D", new DateTime(2003, 03, 01), "Tuyen Quang", 2.1, 7000000);
            //oop_pT nv4 = new oop_pT("Tran Van G", new DateTime(2003, 03, 01), "Tuyen Quang", 2.8, 9000000);
            //oop_pT nv5 = new oop_pT("Tran Van H", new DateTime(2003, 03, 01), "Tuyen Quang", 2.3, 2000000);
            //nv.HienThiThongTin();
            //nv1.HienThiThongTin();
            //nv2.HienThiThongTin();
            //nv3.HienThiThongTin();
            //nv4.HienThiThongTin();
            //nv5.HienThiThongTin();



            // Nâng lương
            //nv.NangLuong(3.0);
            //Console.WriteLine($"Luong sau nang: {nv.TinhLuong():N0} VNĐ");

            // Tạo danh sách nhân viên
            List<oop_pT> danhSachNhanVien = new List<oop_pT>
        {
            new oop_pT("Tran Viet Hoang", new DateTime(2003, 03, 01), "Tuyen Quang", 2.5, 5000000),
            new oop_pT("Tran Van B", new DateTime(2003, 03, 01), "Tuyen Quang", 2.5, 8000000),
            new oop_pT("Tran Van C", new DateTime(2003, 03, 01), "Tuyen Quang", 2.7, 6000000),
            new oop_pT("Tran Van D", new DateTime(2003, 03, 01), "Tuyen Quang", 2.1, 7000000),
            new oop_pT("Tran Van G", new DateTime(2003, 03, 01), "Tuyen Quang", 2.8, 9000000),
        };

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine("\nHo Ten: " +nhanVien.HoTen);
                Console.WriteLine($"Nagy sinh: "+nhanVien.NgaySinh);
                Console.WriteLine("Que quan: " + nhanVien.QueQuan);
                Console.WriteLine("He so luong: " +nhanVien.HeSoLuong);
                Console.WriteLine($"Tien thuong: "+nhanVien.TienThuong);
                

            }
            //OrderByDescending
            // Tìm nhân viên có lương cao nhất
            oop_pT nvLuongCaoNhat = danhSachNhanVien.OrderByDescending(nv => nv.TinhLuong()).First();

            Console.WriteLine("\nNhan vien co lương cao nhat:");
            nvLuongCaoNhat.HienThiThongTin();


            oop_pT nvLuongThapNhat = danhSachNhanVien.OrderBy(nv => nv.TinhLuong()).First();

            Console.WriteLine("\nNhan vien co luong thap nhat:");
            nvLuongThapNhat.HienThiThongTin();



        }

    }
}
