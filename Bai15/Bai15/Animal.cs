using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    abstract class Animal
    {
        public string ten;
        protected int tuoi; 
        protected string mota; 


        public Animal() { }

        public Animal(string ten)
        {
            this.ten = ten;
        }

        public Animal(string ten, int tuoi)
        {
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public Animal(string ten, int tuoi, string mota)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.mota = mota;
        }

        public abstract void XemThongTin();

        public abstract void TiengKeu();

        public static void Show()
        {
            Chuong chuong1 = new Chuong(555);

            Tiger tiger = new Tiger("HO", 5, "Ho trang");
            Dog dog = new Dog("CHO", 3, "Cho long vang");
            Cat cat = new Cat("MEO", 2, "Meo tam the");

            tiger.XemThongTin();
            tiger.TiengKeu();

            dog.XemThongTin();
            dog.TiengKeu();

            cat.XemThongTin();
            cat.TiengKeu();

            Console.WriteLine();
            // Thêm động vật vào chuồng
            chuong1.ThemConVat(tiger);
            chuong1.ThemConVat(dog);
            chuong1.ThemConVat(cat);

            Console.WriteLine();
            // Hiển thị danh sách động vật trong chuồng
            chuong1.XemDanhSach();

            Console.WriteLine();
            // Xóa một con vật theo tên
            chuong1.XoaConVat("MEO");
            Console.WriteLine();

            // Hiển thị danh sách sau khi xóa
            chuong1.XemDanhSach();


            Console.WriteLine();
            // Khởi tạo sở thú
            Zoo myZoo = new Zoo();
            Console.WriteLine();
            // Khởi tạo chuồng
            Chuong chuong3 = new Chuong(101);
            Chuong chuong2 = new Chuong(102);
            Console.WriteLine();
            // Thêm chuồng vào sở thú
            myZoo.ThemChuong(chuong1);
            myZoo.ThemChuong(chuong2);
            Console.WriteLine();
            // Thêm động vật vào chuồng
            chuong1.ThemConVat(tiger);
            chuong1.ThemConVat(dog);
            chuong2.ThemConVat(cat);
            Console.WriteLine();
            // Hiển thị danh sách các chuồng
            myZoo.XemDanhSachChuong();
            Console.WriteLine();
            // Xóa một chuồng
            myZoo.XoaChuong(102);
            Console.WriteLine();
            // Hiển thị lại danh sách sau khi xóa chuồng
            myZoo.XemDanhSachChuong();


        }
    }

    class Tiger : Animal
    {
        public Tiger(string ten, int tuoi, string mota) : base(ten, tuoi, mota) { }

        public override void XemThongTin()
        {
            Console.WriteLine($"Loai: Ho | Ten: {ten} | Tuoi: {tuoi} | Mo ta: {mota}");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Gaooooooooo");
        }
    }

    class Dog : Animal
    {
        public Dog(string ten, int tuoi, string mota) : base(ten, tuoi, mota) { }

        public override void XemThongTin()
        {
            Console.WriteLine($"Loai: Cho | Ten: {ten} | Tuoi: {tuoi} | Mo Ta: {mota}");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Sua: Gâu gâu");
        }
    }

    class Cat : Animal
    {
        public Cat(string ten, int tuoi, string mota) : base(ten, tuoi, mota) { }

        public override void XemThongTin()
        {
            Console.WriteLine($"Lai: Mèo | Ten: {ten} | Tuoi: {tuoi} | Mo ta: {mota}");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Keu: Meo meo!");
        }
    }

    class Chuong
    {
        public int maChuong;
        public ArrayList animalList;

        // Hàm khởi tạo
        public Chuong(int maChuong)
        {
            this.maChuong = maChuong;
            animalList = new ArrayList();
        }

        public void ThemConVat(Animal a)
        {
            animalList.Add(a);
            Console.WriteLine($"Da them {a.GetType().Name} - {a.ten} vao chuong {maChuong}.");
        }


        public void XoaConVat(string ten)
        {
            Animal ani = null;
            foreach (Animal a in animalList)
            {
                if (a.ten == ten)
                {
                    ani = a;
                    break;
                }
            }

            if (ani != null)
            {
                animalList.Remove(ani);
                Console.WriteLine($"Đa xoa {ten} khoi chuong {maChuong}.");
            }
            else
            {
                Console.WriteLine($"khong tim thay {ten} trong chuong {maChuong}.");
            }
        }

        // Hiển thị danh sách động vật trong chuồng
        public void XemDanhSach()
        {
            Console.WriteLine($"Danh sach dong vat trong chuong {maChuong}:");
            foreach (Animal a in animalList)
            {
                a.XemThongTin();
            }
        }

    }

    class Zoo
    {
        public ArrayList danhsachChuong;

        // Hàm khởi tạo
        public Zoo()
        {
            danhsachChuong = new ArrayList();
        }

        // Thêm một chuồng vào danh sách
        public void ThemChuong(Chuong c)
        {
            danhsachChuong.Add(c);
            Console.WriteLine($"Da them chuong {c.maChuong} vao so thu");
        }

        // Xóa một chuồng khỏi danh sách dựa trên mã chuồng
        public void XoaChuong(int maChuong)
        {
            Chuong chuongToRemove = null;
            foreach (Chuong c in danhsachChuong)
            {
                if (c.maChuong == maChuong)
                {
                    chuongToRemove = c;
                    break;
                }
            }

            if (chuongToRemove != null)
            {
                danhsachChuong.Remove(chuongToRemove);
                Console.WriteLine($"Da xoa chuong {maChuong}khoi so thu");
            }
            else
            {
                Console.WriteLine($"Khong tim thay chuong co ma {maChuong}.");
            }
        }

        // Hiển thị danh sách các chuồng và động vật trong sở thú
        public void XemDanhSachChuong()
        {
            Console.WriteLine("Danh sac cac chuong");
            foreach (Chuong c in danhsachChuong)
            {
                Console.WriteLine($"Chuong {c.maChuong}:");
                c.XemDanhSach();
            }
        }
    }

}
