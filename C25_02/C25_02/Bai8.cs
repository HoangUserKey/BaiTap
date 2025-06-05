using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_02
{
    internal class Bai8
    {
        struct HocVien
        {
            public string SCCCD;
            public string HoTen;
            public string QueQuan;
            public string GioiTinh;
            public int NamSinh;
            public string SDT;
            public List<string> MaMonDangHoc; // Danh sách mã môn đang học
        }

        // Cấu trúc Giảng Viên
        struct GiangVien
        {
            public string SCCCD;
            public string SDT;
            public string QueQuan;
            public string HoTen;
            public string GioiTinh;
            public int NamSinh;
            public string ChucVu;
        }

        // Cấu trúc Khoa
        struct Khoa
        {
            public string MaKhoa;
            public string TenKhoa;
            public string MaTruongKhoa;
        }

        class MonHoc
        {
            public string MaMonHoc; 
            public string TenMonHoc;
            public int TinChi;       
        }

        public static void baiTap()
        {
            List<HocVien> hocVienLs = new List<HocVien>();

            List<GiangVien> giangViens = new List<GiangVien>();

            ArrayList KhoaLis = new ArrayList();

            ArrayList monHocList = new ArrayList();



            HocVien hocVien = new HocVien
            {
                SCCCD = "123456789",
                HoTen = "Nguyen Van A",
                QueQuan = "Ha Noi",
                GioiTinh = "Nam",
                NamSinh = 2003,
                SDT = "0123456789",
                MaMonDangHoc = new List<string> { "MH001", "MH002" }
            };
            hocVienLs.Add(hocVien);

            // Nhập dữ liệu Giảng Viên
            GiangVien giangVien = new GiangVien
            {
                SCCCD = "987654321",
                SDT = "0987654321",
                QueQuan = "Ha Noi",
                HoTen = "Tran Van B",
                GioiTinh = "Nu",
                NamSinh = 1985,
                ChucVu = "Giao Vien Bo Mon"
            };
            giangViens.Add(giangVien);

            // Nhập dữ liệu Khoa
            Khoa khoa = new Khoa
            {
                MaKhoa = "C25.02",
                TenKhoa = "Lap trinh game",
                MaTruongKhoa = "987654321"
            };
            KhoaLis.Add(khoa);

            // Nhập dữ liệu Môn Học
            MonHoc monHoc = new MonHoc
            {
                MaMonHoc = "MH001",
                TenMonHoc = "Lap Trinh C#",
                TinChi = 3
            };
            monHocList.Add(monHoc);

            // Hiển thị dữ liệu
            Console.WriteLine("Danh sach hoc vien:");
            foreach (var hv in hocVienLs)
            {
                Console.WriteLine($"SCCCD: {hv.SCCCD}, Ho Ten: {hv.HoTen}, Môn Đang Hoc: {string.Join(", ", hv.MaMonDangHoc)}");
            }

            Console.WriteLine("\nDanh sach giang Viên:");
            foreach (var gv in giangViens)
            {
                Console.WriteLine($"SCCCD: {gv.SCCCD}, Ho Ten: {gv.HoTen}, Chuc vu: {gv.ChucVu}");
            }

            Console.WriteLine("\nDanh sachh Khoa:");
            foreach (Khoa k in KhoaLis)
            {
                Console.WriteLine($"Ma Khoa: {k.MaKhoa}, Tên Khoa: {k.TenKhoa}, Ma truong Khoa: {k.MaTruongKhoa}");
            }

            Console.WriteLine("\nDanh sachh Môn Hoc:");
            foreach (MonHoc mh in monHocList)
            {
                Console.WriteLine($"Ma Môn: {mh.MaMonHoc}, Tên Môn: {mh.TenMonHoc}, Tin Chi: {mh.TinChi}");
            }

            Console.WriteLine("\nNhap du lieu thanh cong");
        }

    }


}

