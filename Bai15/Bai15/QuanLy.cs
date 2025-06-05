using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    interface IRunnable
    {
        void Chay();
    
    }
    abstract class Animal1 : IRunnable
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string LoaiThucAn { get; set; }

        public Animal1(string ten, int tuoi, string loaiThucAn)
        {
            Ten = ten;
            Tuoi = tuoi;
            LoaiThucAn = loaiThucAn;
        }

        public abstract void PhatAmThanh();

        public void Ngu()
        {
            Console.WriteLine($"{Ten} dang ngu.");
        }

        public void Chay()
        {
            Console.WriteLine($"{Ten} dang chay.");
        }



        public static void Show()
        {
            List<IRunnable> danhSachChay = new List<IRunnable>();

            // Thêm các đối tượng vào danh sách
            danhSachChay.Add(new Cat1("MEO", 2, "Ca"));
            danhSachChay.Add(new Dog1("CHO", 3, "Xuong"));
            danhSachChay.Add(new People("Nam", 25, "Tuyen Quang", "0987654321"));
            danhSachChay.Add(new Car("Toyota", 5, "Do"));
            
            // Gọi phương thức Chay() của tất cả các đối tượng
            Console.WriteLine("\n===== Danh sach doi tuong dang chay =====");
            foreach (IRunnable item in danhSachChay)
            {
                item.Chay();
            }


        }
    }
    class Cat1 : Animal1
    {
        public Cat1(string ten, int tuoi, string loaiThucAn) : base(ten, tuoi, loaiThucAn) { }

        public override void PhatAmThanh()
        {
            Console.WriteLine($"{Ten} Keu: Meo meo!");
        }


    }

    class Dog1 : Animal1
    {
        public Dog1(string ten, int tuoi, string loaiThucAn) : base(ten, tuoi, loaiThucAn) { }

        public override void PhatAmThanh()
        {
            Console.WriteLine($"{Ten} Keu: Gâu gâu!");
        }


    }

    class People : IRunnable
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public People(string ten, int tuoi, string diaChi, string soDienThoai)
        {
            Ten = ten;
            Tuoi = tuoi;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public void Hoc()
        {
            Console.WriteLine($"{Ten} đang hoc.");
        }

        public void Chay()
        {
            Console.WriteLine($"{Ten} đang chay.");
        }
    }

    class Car : IRunnable
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string Mau { get; set; }

        public Car(string ten, int tuoi, string mau)
        {
            Ten = ten;
            Tuoi = tuoi;
            Mau = mau;
        }

        public void Nghi()
        {
            Console.WriteLine($"Xe {Ten} mau {Mau} dang nghi.");
        }

        public void Chay()
        {
            Console.WriteLine($"Xe {Ten} mau {Mau} dang chay.");
        }


    }
}