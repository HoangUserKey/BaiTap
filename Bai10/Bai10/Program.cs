using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Student1
    {
        public string masv { get; set; }
        public string HoTen { get; set; }
        public double dtb { get; set; }
        public bool hocBong { get; set; }

        public Student1(string masv, string name, double avgScore)
        {
            this.masv = masv;
            HoTen = name;
            dtb = avgScore;
            hocBong = avgScore >= 8.0; // Giả định sinh viên có học bổng nếu điểm trung bình >= 8.0
        }

        public override string ToString()
        {
            return $"Masv: {masv}, Ho ten: {HoTen}, Diem TB: {dtb}, Hoc Bong: {(hocBong ? "Co" : "khong")}";
        }
    }

    class StudentTest
    {
        static List<Student1> students = new List<Student1>();


        static void Main()
        {

            Teacher .MENU();

            ///////////////////////////////////////////////////////////////////////
            //int choice;
            //do
            //{
            //    Console.WriteLine("\nMenu:");
            //    Console.WriteLine("1. Nhap danh sach sinh vien");
            //    Console.WriteLine("2. Hien thi thong tin sinhu vien");
            //    Console.WriteLine("3. Sinh viên co diem TB cao nhat va thap nhat");
            //    Console.WriteLine("4. tim kiem sinh vien theo ma");
            //    Console.WriteLine("5. Hien thi sinh vien theo bang chu cai");
            //    Console.WriteLine("6. Hien thi thong tin sinh vien duoc hoc bong");
            //    Console.WriteLine("7. Thoat");
            //    Console.Write("Chon: ");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            NhapTT();
            //            break;
            //        case 2:
            //            ShowTT();
            //            break;
            //        case 3:
            //            DTBCaoThap();
            //            break;
            //        case 4:
            //            TimKiem();
            //            break;
            //        case 5:
            //            BangchuCai();
            //            break;
            //        case 6:
            //            ShowHocBong();
            //            break;
            //        case 7:
            //            Console.WriteLine("Thoat chuong trinh.");
            //            break;
            //        default:
            //            Console.WriteLine("Nhap lai.");
            //            break;
            //    }
            //} while (choice != 7);
        }

        static void NhapTT()
        {
            Console.Write("Nhap so luong sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thông tin sinh vien {i + 1}:");
                Console.Write("Ma Sinh Vien: ");
                string id = Console.ReadLine();
                Console.Write("Ten sinh vien: ");
                string name = Console.ReadLine();
                Console.Write("Diem trung binh: ");
                double avgScore = double.Parse(Console.ReadLine());

                students.Add(new Student1(id, name, avgScore));
            }
        }

        static void ShowTT()
        {
            Console.WriteLine("Danh sach sinh viên:");
            students.ForEach(student => Console.WriteLine(student));
        }

        static void DTBCaoThap()
        {
            if (students.Count == 0) return;
            var maxStudent = students.OrderByDescending(s => s.dtb).First();
            var minStudent = students.OrderBy(s => s.dtb).First();

            Console.WriteLine("Sinh viên co diem cao nhat:");
            Console.WriteLine(maxStudent);
            Console.WriteLine("Sinh viên co diem thap nhat:");
            Console.WriteLine(minStudent);
        }


        static void BangchuCai()
        {
            Console.WriteLine("Ds theo chu cai");
            students.OrderBy(s => s.HoTen).ToList().ForEach(student => Console.WriteLine(student));
        }

        static void ShowHocBong()
        {
            Console.WriteLine("Ds co hoc bong");
            students.Where(s => s.hocBong).OrderByDescending(s => s.dtb).ToList().ForEach(student => Console.WriteLine(student));
        }

        static void TimKiem()
        {
            Console.Write("Nhap ma can tim: ");
            string id = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.masv == id);
            Console.WriteLine(student != null ? student.ToString() : "Khong tim thay sinh viên.");
        }

    }
}