using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Bai2
{
    //nếu giá trị ban đầu ko xác định được kiểu giữ liệu thì ta dùng var thay vì int,long...
    // ví dụ var i = 123; thì i sẽ mang kiểu dữ liệu int,
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            //ChanLe();
            //KhaiBao();


            //SinhVien sv = new SinhVien();
            //sv.HoTen = "Pham Quang Giang";
            //sv.Tuoi = 19;
            //sv.diem = 9;
            //sv.SDT = "039564893";

            //Console.Write("Nhap ho va ten: ");
            //sv.HoTen = Console.ReadLine();

            //Console.Write("Nhap Tuoi: ");
            //sv.Tuoi = Console.ReadLine();

            //Console.Write("Nhap Diem: ");
            //sv.diem= Console.ReadLine();

            //Console.Write("Nhap SDT: ");
            //sv.SDT = Console.ReadLine();


            //Console.WriteLine("Ho va ten: "+sv.HoTen);
            //Console.WriteLine("Tuoi: "+sv.Tuoi);
            //Console.WriteLine("Diem: "+sv.diem);
            //Console.WriteLine("SDT: "+sv.SDT);

            bai10();
            //Hoc_Vien();
            Console.ReadKey();
            //Mon_Hoc();
            //Giang_Vien();
            //Khoa();

            //thongTinSV();

            //KiemTrakiTu();
            //phepTinh();

            //MauSac();
            //MonHocEn();
            //NgayNghi();

        }

        public static void Bai1()
        {
            Console.Write("Nhap 3 chu cai: ");
            String input = Console.ReadLine();

            string reversedString = input[2].ToString() + input[1].ToString() + input[0].ToString();

            Console.WriteLine("Chuoi nguoc lai: " + reversedString);
        }

        public static void ChanLe()
        {

            Console.Write("Nhap 1 so : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("So ban vua nhap là so chan.");
            }
            else
            {
                Console.WriteLine("So ban vua nhap là so le.");
            }

        }

        /// /////// emum
        public enum DaysOfWeek
        {
            Thu2,
            Thu3,
            Thu4,
            Thu5,
            Thu6,
            Thu7,
            ChuNhat
        }

        // Khai báo kiểu liệt kê cho màu sắc
        public enum Colors
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White
        }

        // Khai báo kiểu liệt kê cho các môn học
        public enum Subjects
        {
            Toan,
            hoa,
            tin

        }

        public static void KhaiBao()
        {
            // Khai báo kiểu liệt kê cho các thứ trong tuần
            DaysOfWeek today = DaysOfWeek.Thu4;
            Console.WriteLine(today);

            // Ví dụ sử dụng kiểu liệt kê Colors
            Colors favoriteColor = Colors.Blue;
            Console.WriteLine(favoriteColor);

            // Ví dụ sử dụng kiểu liệt kê Subjects
            Subjects favoriteSubject = Subjects.Toan;
            Console.WriteLine(favoriteSubject);

        }


        // ep kieu Struct
        public struct SinhVien
        {
            public String HoTen;
            public String Tuoi;
            public String diem;
            public String SDT;

        }





        // cấu trúc học viên

        public struct HocVien
        {
            public String CCCD;
            public String HoTen;
            public String QueQuan;
            public String GioiTinh;
            public String SDT;
            public String MaMonHoc;
            public String namSinh;
        }
        static string ChuanHoa(string input)
        {

            string result = input.Trim(); //xoá dcách đầu cuối

            result = result.ToLower();//viet thuong

            var tachXau = result.Split(' ');//tách xau

            result = string.Empty;
            for (int i = 0; i < tachXau.Length; i++)
            {
                result = result + tachXau[i].Substring(0, 1).ToUpper() + tachXau[i].Substring(1) + " ";//viet hoa chu cai đầu
            }

            result = result.TrimEnd();// xoa dau cách ơ cuoi

            return result;
        }

        public static void Hoc_Vien()
        {
            HocVien hocVien = new HocVien();
            int sns;

            Console.Write("Nhap CCCD: ");
            hocVien.CCCD = Console.ReadLine();

            Console.Write("Nhap Ho Ten: ");
            hocVien.HoTen = Console.ReadLine();

            //do
            //{
            //    Console.Write("Nhap nam sinh: ");
            //    hocVien.namSinh = Console.ReadLine();

            //    if (int.TryParse(hocVien.namSinh, out sns) && sns > 1999 && sns < DateTime.Now.Year)
            //    {
            //        return sns;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nam sinh khong hop le");
            //    }

            //} while (true);

            while (true)
            {
                Console.Write("Nhap nam sinh: ");
                if (int.TryParse(Console.ReadLine(), out int namSinh) && namSinh > 1997 && namSinh < 2008)
                {
                    //namSinh = namSinh;
                    break;
                }
                else
                {
                    Console.WriteLine("Nam sinh khong hop le");
                }
            }


            //dinh dang gioi tinh
            while (true)
            {
                Console.Write("Nhap gioi tinh: ");
                hocVien.GioiTinh = Console.ReadLine();

                if (hocVien.GioiTinh == "Nam" || hocVien.GioiTinh == "Nu")
                    break;
                else
                    Console.WriteLine("Gioi tinh khong hop le.");
            }


            Console.Write("Nhap SDT: ");
            hocVien.SDT = Console.ReadLine();

            Console.Write("Nhap ma mon hoc: ");
            hocVien.MaMonHoc = Console.ReadLine();

            //in ra màn hình
            Console.WriteLine("\nso CCCD: " + hocVien.CCCD);

            //hocVien.HoTen = Regex.Replace(hocVien.HoTen.Trim(), @"\s+", " ");

            hocVien.HoTen = ChuanHoa(hocVien.HoTen);
            Console.WriteLine("so Ho Ten: " + hocVien.HoTen);


            //Console.WriteLine("so Que Quan: " + hocVien.QueQuan);

            Console.WriteLine("so Gioi Tinh: " + hocVien.GioiTinh);
            Console.WriteLine("so SDT: " + hocVien.SDT);
            Console.WriteLine("so Ma Mon Hoc: " + hocVien.MaMonHoc);


        }


        // cấu trúc môn học

        public struct MonHoc
        {
            public String maMon;
            public String tenMon;
            public String maGiangDay;
        }

        public static void Mon_Hoc()
        {
            MonHoc monHoc = new MonHoc();

            Console.Write("Nhap ma mon: ");
            monHoc.maMon = Console.ReadLine();

            Console.Write("Nhap ten mon: ");
            monHoc.tenMon = Console.ReadLine();

            Console.Write("Nhap ma giang day: ");
            monHoc.maGiangDay = Console.ReadLine();


            Console.WriteLine("Ma mon: " + monHoc.maMon);
            Console.WriteLine("Ten mon: " + monHoc.tenMon);
            Console.WriteLine("ma giang day: " + monHoc.maGiangDay);
        }


        public struct giangVien
        {
            public String CCCD;
            public String hoTen;
            public String queQuan;
            public String namSinh;
            public String SDT;
            public String chucVu;
        }

        public static void Giang_Vien()
        {
            giangVien giangVien = new giangVien();

            Console.Write("Nhap cccd: ");
            giangVien.CCCD = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            giangVien.hoTen = Console.ReadLine();

            Console.Write("Nhap que quan: ");
            giangVien.queQuan = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            giangVien.namSinh = Console.ReadLine();

            Console.Write("Nhap SDT: ");
            giangVien.SDT = Console.ReadLine();

            Console.Write("Nhap chuc vu: ");
            giangVien.chucVu = Console.ReadLine();


            Console.WriteLine("So CCCD: " + giangVien.CCCD);
            Console.WriteLine("Ho ten giang vien: " + giangVien.hoTen);
            Console.WriteLine("So CCCD: " + giangVien.queQuan);
            Console.WriteLine("Que quan: " + giangVien.namSinh);
            Console.WriteLine("Nam sinh: " + giangVien.SDT);
            Console.WriteLine("Chuc vu: " + giangVien.chucVu);

        }

        // cấu truc khoa

        public struct khoa
        {
            public string Makhoa;
            public string tenKhoa;
            public string maTruongKhoa;
        }

        public static void Khoa()
        {
            khoa khoa = new khoa();
            Console.Write("Nhap ma khoa: ");
            khoa.Makhoa = Console.ReadLine();

            Console.Write("Nhap ten khoa : ");
            khoa.tenKhoa = Console.ReadLine();

            Console.Write("Nhap ma truong khoa: ");
            khoa.maTruongKhoa = Console.ReadLine();

            Console.WriteLine("ma khoa: " + khoa.Makhoa);
            Console.WriteLine("ten khoa: " + khoa.tenKhoa);
            Console.WriteLine("Ma truong khoa: " + khoa.maTruongKhoa);

        }


        public enum ChucVu
        {
            canBo = 1, giaoVu = 2, phoKhoa = 3, truongKhoa = 4, troGiang = 5, giangVienChinh = 6
        }

        public enum HocHam_Vi
        {
            tienSi = 2, phoGiaoSu = 4, giaoSu = 5, tienSiKhoaHoc = 6
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void thongTinSV()
        {
            HocVien hocVien = new HocVien();
            MonHoc monHoc = new MonHoc();
            khoa khoa = new khoa();

            //hoc vien
            Console.Write("Nhap CCCD: ");
            hocVien.CCCD = Console.ReadLine();

            Console.Write("Nhap Ho Ten: ");
            hocVien.HoTen = Console.ReadLine();

            Console.Write("Nhap que quan: ");
            hocVien.QueQuan = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            hocVien.GioiTinh = Console.ReadLine();

            Console.Write("Nhap SDT: ");
            hocVien.SDT = Console.ReadLine();

            Console.Write("Nhap ma mon hoc: ");
            hocVien.MaMonHoc = Console.ReadLine();

            //mon hoc
            Console.Write("Nhap ten mon: ");
            monHoc.tenMon = Console.ReadLine();

            //khoa


            Console.Write("Nhap ten khoa : ");
            khoa.tenKhoa = Console.ReadLine();
            Console.Write("Nhap ma truong khoa: ");
            khoa.maTruongKhoa = Console.ReadLine();


            // in ra man hinh
            Console.WriteLine("-------------------------------------------------------------------");
            //ttsv
            Console.WriteLine("\nso CCCD: " + hocVien.CCCD);
            Console.WriteLine("so Ho Ten: " + hocVien.HoTen);
            Console.WriteLine("so Que Quan: " + hocVien.QueQuan);

            Console.WriteLine("so Gioi Tinh: " + hocVien.GioiTinh);
            Console.WriteLine("so SDT: " + hocVien.SDT);

            //Mon
            Console.WriteLine("Ten mon: " + monHoc.tenMon);

            // Khoa
            Console.WriteLine("ten khoa: " + khoa.tenKhoa);
            Console.WriteLine("Ma truong khoa: " + khoa.maTruongKhoa);



        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //kiem tra kí tự
        public static void KiemTrakiTu()
        {
            Console.WriteLine("nhap 1 ky tu: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Xuống dòng sau khi nhập ký tự

            if (char.IsDigit(input))
            {
                Console.WriteLine(" la chu so.");
            }
            else if ("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine("la so nguyen am");
            }
            else
            {
                Console.WriteLine("la ky tu khac");
            }

        }


        //Phép toán

        public static void phepTinh()
        {
            int a;
            int b;
            int c;

            Console.Write("Nhap so a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so b = ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine("ket qua cua phep tinh la: " + c);
        }

        // chọn giá trị màu sắc

        public enum mauSac
        {
            Do = 1, xanh = 2, tim = 3, vang = 4
        }

        public static void MauSac()
        {
            Console.WriteLine("chon gia chi mau sac (do = 1, xanh =2, tim =3, vang = 4)");
            Console.Write("ban chon gia tri so: ");
            int giatri = Convert.ToInt32(Console.ReadLine());

            if (giatri == (int)mauSac.Do)
            {
                Console.WriteLine("Ban chon mau do");
            }
            else if (giatri == (int)mauSac.xanh)
            {
                Console.WriteLine("Ban chon mau xanh");
            }
            else if (giatri == (int)mauSac.tim)
            {
                Console.WriteLine("Ban chon mau tim");
            }
            else if (giatri == (int)mauSac.vang)
            {
                Console.WriteLine("Ban chon mau vang");
            }
            else
            {
                Console.WriteLine("vui long chỉ nhap gia tri tư 1-4");
            }

        }

        // in ra man hinh mon hoc

        public enum monHocEn
        {
            toan, tin, anh
        }

        public static void MonHocEn()
        {
            Console.WriteLine("Mon: " + monHocEn.toan);
            Console.WriteLine("Mon: " + monHocEn.tin);
            Console.WriteLine("Mon: " + monHocEn.anh);
        }

        // thong báo thu 7-cn nghi
        public enum ngayNghi
        {
            Thu7 = 7, chuNhat = 8
        }

        public static void NgayNghi()
        {

            Console.WriteLine("Nhap gia tri 1-8 đe kiem tra ngay nghi");
            Console.Write("Ban chon thu: ");
            int ngay = Convert.ToInt32(Console.ReadLine());

            if (ngay == (int)ngayNghi.Thu7 || ngay == (int)ngayNghi.chuNhat)
            {
                Console.WriteLine("La ngay nghi");
            }
            else
            {
                Console.WriteLine("La ngay di lam");
            }
        }



        public static void bai8()
        {
            List<int> list = new List<int>();

            // Thêm 10 số nguyên vào danh sách
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i); // Thêm các số từ 1 đến 10
            }

            Console.WriteLine("Danh sách ban đầu:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Hiển thị danh sách đảo ngược
            list.Reverse();
            Console.WriteLine("Danh sách đảo ngược:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Tìm kiếm số 5 và xóa hết nếu có
            list.RemoveAll(n => n == 5);
            Console.WriteLine("Danh sách sau khi xóa số 5:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Sắp xếp danh sách theo thứ tự tăng dần
            list.Sort();
            Console.WriteLine("Danh sách sắp xếp tăng dần:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Sắp xếp danh sách theo thứ tự giảm dần
            list.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("Danh sách sắp xếp giảm dần:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }




        public static void bai9()
        {
            // Tạo Stack (ngăn xếp) và Queue (hàng đợi)
            Stack<int> evenStack = new Stack<int>();
            Queue<int> oddQueue = new Queue<int>();

            // Nhập dữ liệu từ bàn phím
            Console.WriteLine("nhap cac so nguyeb (nhan 'dung' de ket thuc):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "dung")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        evenStack.Push(number); // Thêm số chẵn vào Stack
                    }
                    else
                    {
                        oddQueue.Enqueue(number); // Thêm số lẻ vào Queue
                    }
                }
                else
                {
                    Console.WriteLine("so nguyen khong hop le!");
                }
            }

            // Hiển thị danh sách trong Stack
            Console.WriteLine("\ncac so chan trong Stack:");
            int[] listEven = evenStack.ToArray();
            for (int i = 0; i < listEven.Length; i++)
            {
                Console.Write(listEven[i] + " ");
            }
            Console.WriteLine();

            // Hiển thị danh sách trong Queue
            Console.WriteLine("\nCac so le trong Queue:");
            int[] listOdd = oddQueue.ToArray();
            for (int i = 0; i < listOdd.Length; i++)
            {
                Console.Write(listOdd[i] + " ");
            }
            Console.WriteLine();

        }
        public static void bai10()
        {
            // Tạo danh sách sổ điện thoại
            List<string> phoneBook = new List<string>();

            // Thêm 10 phần tử vào danh sách
            phoneBook.Add("Nguyen Van A - 0901234567");
            phoneBook.Add("Tran Thi B - 0912345678");
            phoneBook.Add("Le Van C - 0923456789");
            phoneBook.Add("Pham Thi D - 0934567890");
            phoneBook.Add("Do Van E - 0945678901");
            phoneBook.Add("Hoang Thi F - 0956789012");
            phoneBook.Add("Ngo Van G - 0967890123");
            phoneBook.Add("Bui Thi H - 0978901234");
            phoneBook.Add("Dang Van I - 0989012345");
            phoneBook.Add("Vu Thi K - 0990123456");

            // Hiển thị danh sách trực tiếp trong chương trình
            Console.WriteLine("Danh sach so dien thoại:");
            if (phoneBook.Count == 0)
            {
                Console.WriteLine("Danh sach trong.");
            }
            else
            {
                for (int i = 0; i < phoneBook.Count; i++)
                {
                    Console.WriteLine(phoneBook[i]);
                }
            }


            // Kiểm tra sự tồn tại của 1 số điện thoại
            Console.WriteLine("\nNhập số điện thoại cần kiểm tra:");
            string phoneNumberToCheck = Console.ReadLine();
            bool phoneExists = phoneBook.Exists(entry => entry.Contains(phoneNumberToCheck));
            if (phoneExists)
            {
                Console.WriteLine("Số điện thoại tồn tại.");
            }
            else
            {
                Console.WriteLine("Số điện thoại không tồn tại.");
            }

            // Kiểm tra sự tồn tại của 1 họ tên
            Console.WriteLine("\nNhập họ tên cần kiểm tra:");
            string nameToCheck = Console.ReadLine();
            bool nameExists = phoneBook.Exists(entry => entry.Contains(nameToCheck));
            if (nameExists)
            {
                Console.WriteLine("Họ tên tồn tại.");
            }
            else
            {
                Console.WriteLine("Họ tên không tồn tại.");
            }

            // Xóa một số điện thoại theo tên
            Console.WriteLine("\nNhập họ tên cần xóa:");
            string nameToDelete = Console.ReadLine();
            if (phoneBook.Exists(entry => entry.Contains(nameToDelete)))
            {
                phoneBook.RemoveAll(entry => entry.Contains(nameToDelete));
                Console.WriteLine("Đã xóa các mục liên quan đến họ tên: " + nameToDelete);
            }
            else
            {
                Console.WriteLine("Không tìm thấy họ tên trong danh sách.");
            }
            Console.WriteLine("Danh sách sau khi xóa theo tên:");
        

            // Xóa cả danh sách
            Console.WriteLine("\nXóa toàn bộ danh sách...");
            if (phoneBook.Count > 0)
            {
                phoneBook.Clear();
                Console.WriteLine("Danh sách đã bị xóa.");
            }
            else
            {
                Console.WriteLine("Danh sách đã trống.");
            }
            Console.WriteLine("Danh sách hiện tại:" );

           


        }

    }
}