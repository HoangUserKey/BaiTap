using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Bai14
    {
        //public static void show()
        //{
        //    person p = new person();
        //    Worker w = new Worker();
        //    person z = new Worker();

        //    p.ShowInfor();
        //    w.ShowInfor();
        //    z.ShowInfor();
        //}
    }
    
    //class person
    //{
    //   public virtual void ShowInfor()
    //    {
    //        Console.WriteLine("1");
    //    }
    //}

    //class Worker : person { 
    //    public override void ShowInfor()
    //    {
    //        Console.WriteLine("2");
    //    }
    
    //}
 

    class Person
    {
        public string hoTen { get; set; }    
        public string gioiTinh {  get; set; }
        public string ngaySinh {  get; set; }
        public string diaChi { get; set; }

        public Person() { }

        public Person(string hoTen, string gioiTinh, string ngaySinh, string diaChi) { 
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }

        public virtual void NhapTT()
        {
            Console.Write("Nhap Ho Ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap gioi tính: ");
            gioiTinh= Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh= Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi= Console.ReadLine();
        }

        public virtual void ShowInfor()
        {
            Console.WriteLine("Ho Ten: " + hoTen);
            Console.WriteLine("Gioi tinh: "+gioiTinh);
            Console.WriteLine("Ngay sinh: " + ngaySinh);
            Console.WriteLine("Dia chi: "+diaChi);
         
        }
    }

// class studenr
    class Student : Person
    {
        public string msv {  get; set; }
        public double dbt {  get; set; }
        public string email {  get; set; }

        public Student() { }

        public Student(string hoTen, string gioiTinh, string ngaySinh, string diaChi, string msv, double dbt, string email)
            :base( hoTen,  gioiTinh,  ngaySinh,  diaChi)
        {
            this.msv = msv;
            this.dbt = dbt;
            this.email = email;
        }

        public override void NhapTT() { 
            base.NhapTT();
            Console.Write("Nhap msv: ");
            msv = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            dbt = double.Parse(Console.ReadLine());
            Console.Write("Nhap email: ");
            email = Console.ReadLine();

        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            Console.WriteLine("Ma sinh vien: "+ msv);
            Console.WriteLine("Diem trung binh: " + dbt);
            Console.WriteLine("Email: " + email);
            Console.WriteLine(IsEligibleForScholarship() ? "Duoc hoc bong" : "khong duoc hoc bong");
            HocBong();
        }

        public bool IsEligibleForScholarship()
        {
            return dbt > 8;
        }

        public  void HocBong()
        {

            if (dbt > 8)
            {
                Console.WriteLine("Duoc hoc bong");
            }
            else
            {
                Console.WriteLine("khong duoc hoc bong");
            }
        }
    }
    //// bai 4
    ///

    class Teacher : Person
    {
        public string lopDay { get; set; }
        public double luongMotGio { get; set; }
        public int soGioDay { get; set; }
        public Teacher() { }

        public Teacher(string hoTen, string gioiTinh, string ngaySinh, string diaChi, string lopDay, double luongMotGio, int soGioDay)
            : base(hoTen, gioiTinh, ngaySinh, diaChi)
        {
            {
                this.lopDay = lopDay;
                this.luongMotGio = luongMotGio;
                this.soGioDay = soGioDay;
            }
        }

        public override void NhapTT()
        {
            base.NhapTT();
            Console.Write("Nhap lop day (G, H, I, K, L, M): ");
            lopDay = Console.ReadLine().ToUpper();

            // Kiểm tra lớp có bắt đầu bằng ký tự hợp lệ không
            if (!"GHIKLM".Contains(lopDay[0]))
            {
                Console.WriteLine("Lop khong hop le");
                return;
            }

            Console.Write("Nhap luong 1 gio day ");
            luongMotGio = double.Parse(Console.ReadLine());
            Console.Write("Nhap so gio day trong 1 thang: ");
            soGioDay = int.Parse(Console.ReadLine());

        }
        public override void ShowInfor()
        {
            base.ShowInfor();
            Console.WriteLine("Lop giang day: " + lopDay);
            Console.WriteLine("Luong mot gio: " + luongMotGio);
            Console.WriteLine("So gio day: " + soGioDay);
            Console.WriteLine($"Luong thuc nhan: {TinhLuong()}");
        }

        public double TinhLuong()
        {
            double luong = luongMotGio * soGioDay;
            if (lopDay.StartsWith("L") || lopDay.StartsWith("M"))
            {
                luong += 200000;
            }
            return luong;
        }

    
    public static void MENU()
        {
            List<Teacher> danhSachGiangVien = new List<Teacher>();

            int luaChon;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap thong tin giang vien");
                Console.WriteLine("2. Hien thi thong tin giang vien");
                Console.WriteLine("3. Giang vien co gio day cao nhat trong thang");
                Console.WriteLine("4. Giang vien co luong thuc cao nhat");
                Console.WriteLine("5. Thoat");
                Console.Write("Ban chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Nhap so khong hop le");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        Console.Write("Nhap so luong giang vien: ");
                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\n Nhap giang vien thu {i + 1}:");
                            Teacher gv = new Teacher();
                            gv.NhapTT();
                            danhSachGiangVien.Add(gv);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nDanh sach giang vien");
                        foreach (var gv in danhSachGiangVien)
                        {
                            gv.ShowInfor();
                        }
                        break;

                    case 3:
                        if (danhSachGiangVien.Count > 0)
                        {
                            int maxHours = danhSachGiangVien.Max(gv => gv.soGioDay);
                            Console.WriteLine("\nGiang vien co gio day cao nhat");
                            foreach (var gv in danhSachGiangVien.Where(gv => gv.soGioDay == maxHours))
                            {
                                gv.ShowInfor();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach giang vien trong");
                        }
                        break;

                    case 4:
                        if (danhSachGiangVien.Count > 0)
                        {
                            double maxSalary = danhSachGiangVien.Max(gv => gv.TinhLuong());
                            Console.WriteLine("\nGiang vien co luong thuc cao nhat");
                            foreach (var gv in danhSachGiangVien.Where(gv => gv.TinhLuong() == maxSalary))
                            {
                                gv.ShowInfor();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach giang vien trong");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thoat chương trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }

            } while (luaChon != 5);




        }

    }
}
