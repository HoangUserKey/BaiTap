using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
    internal class LopHoc
    {
        private string maLop;
        private string tenLop; 

        public LopHoc() { }
        public LopHoc(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }

        public void NhapTT()
        {
            Console.Write("Nhap ma lop: ");
            maLop = Console.ReadLine();
            Console.Write("Nhap ten lop: ");
            tenLop = Console.ReadLine();
            Console.WriteLine();
        }

        public void XuatTT()
        {
            Console.WriteLine("Ma lop: " + maLop);
            Console.WriteLine("Ten lop: "+tenLop);
        }
        public string GetmaLopHoc() => maLop;

    }

    class GiangDay : LopHoc {
        private string maGiangVien {  get; set; }
        private string maMonHoc { get; set; }
        public int soTinChi { get; set; }
        private static int soTietDaGiangDay { get; set; }

        public GiangDay() { }
        public GiangDay(string maLop, string tenLop, string maGiangVien, string maMonHoc, string maLopHoc, int soTinChi) : base(maLop, "")
        {
            this.maGiangVien = maGiangVien;
            this.maMonHoc = maMonHoc;
            this.soTinChi = soTinChi;
        }

        public void NhapTT()
        {
            base.NhapTT();
            Console.Write("Nhap ma giang vien: ");
            maGiangVien = Console.ReadLine();
            Console.Write("Nhap ma mon hoc: ");
            maMonHoc = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            soTinChi = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tiet giang day: ");
            soTietDaGiangDay = int.Parse(Console.ReadLine());
        }

        public void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("Ma giangVien: " + maGiangVien);
            Console.WriteLine("Ten mon hoc: " + maMonHoc);
            Console.WriteLine("So tin chi: " + soTinChi);
            Console.WriteLine("So tiet giang day: " + soTietDaGiangDay);
        }

        public int TinhSoTietConLai() => (soTinChi * 15) - soTietDaGiangDay;
        public int GetSoTinChi() => soTinChi;

        public int GetSoTietConLai() => TinhSoTietConLai();
        public string GetmagiangVien() => maGiangVien;


    }

    class QuanLy
    {
        public void NhapDuLieu()
        {
            // Nhập thông tin lớp học
            LopHoc lopHoc = new LopHoc();
            lopHoc.NhapTT();
            Console.WriteLine("\nTHONG TIN LOP HOC");
            lopHoc.XuatTT();

            // Nhập thông tin n đối tượng GIANGDAY
            Console.Write("Nhap so luong giang day: ");
            int n = int.Parse(Console.ReadLine());
            List<GiangDay> danhSachGiangDay = new List<GiangDay>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin giang day thu: {i + 1}:");
                GiangDay gd = new GiangDay();
                gd.NhapTT();
                danhSachGiangDay.Add(gd);
            }

            // In thông tin các đối tượng GIANGDAY
            Console.WriteLine("\nTHONG TIN GIANG DAY");
            foreach (var gd in danhSachGiangDay)
            {
                gd.XuatTT();
            }

            // Hiển thị các lớp học có 3 tín chỉ
            Console.WriteLine("\nCac lop co 3 tin chi: ");
            foreach (var gd in danhSachGiangDay.Where(g => g.GetSoTinChi() == 3))
            {
                gd.XuatTT();
            }

            // Tìm giảng viên có số tiết còn lại phải giảng dạy thấp nhất
            int minTietConLai = danhSachGiangDay.Min(g => g.GetSoTietConLai());
            Console.WriteLine("\nCac giang vuen co so tiet giang dạy thap nhat là: ");
            foreach (var gd in danhSachGiangDay.Where(g => g.GetSoTietConLai() == minTietConLai))
            {
                Console.WriteLine($"ma giang vien: {gd.GetmagiangVien()}");
            }



        }

    }
}
