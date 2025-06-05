using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{
    interface IStuden
    {
        void HienThi();
    }
    class SinhVien : IStuden
    {
        public int ID {  get; set; }
        public string TenSv { get; set; }
        public string ngaySinh {  get; set; }
        public string soDienThoai {  get; set; }

        public SinhVien() { }

        public SinhVien(int ID, string tenSv, string ngaySinh, string soDienThoai)
        {
            this.ID = ID;
            TenSv = tenSv;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
        }

        public void HienThi() {
            Console.WriteLine("Id: "+ID);
            Console.WriteLine("Ten sinh vien "+TenSv);
            Console.WriteLine("Ngay sinh: "+ngaySinh);
            Console.WriteLine("So dien thoai: "+soDienThoai);
            Console.WriteLine();

        }
    }

    class QuanLySinhVien
    {
        List<SinhVien> sinhViens = new List<SinhVien>();

        public void ThemSV()
        {
            Console.Write("Nhap ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sinh vien: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap nagy sinh: ");
            string ngaySinh = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string sdt = Console.ReadLine();


            sinhViens.Add(new SinhVien(id, ten, ngaySinh, sdt));
            Console.WriteLine("Them sv thanh cong");
            Console.WriteLine();
        }

        public void xemDanhSach()
        {
            Console.WriteLine();
            if (sinhViens.Count ==0)
            {
                Console.WriteLine("danh sach trong");
            }
            foreach (var sinhvien in sinhViens)
            {
                sinhvien.HienThi();
            }
        }

        public void TimKiemSV()
        {
            Console.WriteLine();
            Console.Write("Nhap id can tim: ");
            int id = int.Parse(Console.ReadLine());

            //  var sinhVien = sinhViens.Find(sv => sv.ID == id);
            var sinhvien = sinhViens.Find(sv => sv.ID == id);
            if (sinhvien != null)
            {
                sinhvien.HienThi();
            }
            else {
                Console.WriteLine("Sinh vien nay khong ton tai");
            }
            Console.WriteLine();
        }
    } 
}
