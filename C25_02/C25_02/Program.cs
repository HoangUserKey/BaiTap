using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace C25_02
{
    internal class Program
    {
        static int totalShipsProcessed = 0;
        static Queue<Tuple<int, DateTime>> shipQueue = new Queue<Tuple<int, DateTime>>();



        static void Main(string[] args)
        {
            //Bai4.Bai1();   
            //Bai4.Bai2();
            //Bai4.Bai3();
            //Bai4.NgayGio();
            //Bai5.bai8();

            //Console.WriteLine(Bai5.bai9());

            //bai11();


            //Bai5.bai10();


            //Bai6.bai346();
            //Bai7.bai3();

            //Bai8.baiTap();

            // Buổi 9



            // Gọi hàm TinhTich và in ra kết quả
            //Bai2();
            //GuiLoiChao();
            //Bai4();
            //Bai9.bai11();
            //int[] array = null;
            //Bai9.bai12(ref array);


            //hocVien hocVien = new hocVien();
            //nhapHocVien(ref hocVien);
            //Console.ReadKey();

            //string message;
            //if (KiemTraDuLieuHocVien(hocVien, out message))
            //{
            //    Console.WriteLine("Nhap du lieu thanh cong");
            //}
            //else
            //{
            //    Console.WriteLine($"Lỗi: {message}");
            //}




            benTau();

            //Bai9.bai13();
        }


        public static void bai11()
        {

            int num = 20; // Bắt đầu từ số nguyên dương nhỏ nhất không chứa số 1
            while (true)
            {
                if (MeetsConditions(num))
                {
                    Console.WriteLine($"So nguyen duong thoa man dk là: " + num);
                    break;
                }
                num++;
            }
        }

        static bool MeetsConditions(int n)
        {
            string strNum = n.ToString();
            if (strNum.Contains('1')) return false; // Điều kiện không có số 1

            int sumDigits = 0;
            foreach (char c in strNum)
            {
                sumDigits += c - '0';
            }
            if (sumDigits % 8 != 0) return false; // Điều kiện tổng chữ số chia hết cho 8

            int reversedNum = int.Parse(ReverseString(strNum));
            if (Math.Abs(n - reversedNum) % 7 != 0) return false; // Điều kiện hiệu với số đảo ngược chia hết cho 7

            return true;
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public int TinhTong(int so1, int so2)
        {
            return so1 + so2; // Trả về tổng của hai số
        }

        // Sử dụng hàm
        public void ExampleUsage()
        {
            int a = 5;
            int b = 7;
            int ketQua = TinhTong(a, b);
            Console.WriteLine("Tong cua a va b là: " + ketQua);
        }

        public static void Bai2()
        {
            double ketQua = TinhTich();
            Console.WriteLine("Tích của hai số là: " + ketQua);
        }
        // Hàm để tính tích hai số nguyên và trả về kiểu số thực
        public static double TinhTich()
        {
            // Nhập hai số từ bàn phím
            Console.Write("Nhap so thu nhat: ");
            int so1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int so2 = int.Parse(Console.ReadLine());

            // Tính tích và trả về kết quả dưới dạng số thực
            return (double)(so1 * so2);
        }




        public static void GuiLoiChao()
        {
            // Yêu cầu người dùng nhập tên từ bàn phím
            Console.Write("Nhao ho va tên: ");
            string ten = Console.ReadLine();

            // In lời chào ra màn hình
            Console.WriteLine("Xin chao, " + ten);
        }



        public static void Bai4()
        {
            // Nhập xâu văn bản từ bàn phím
            Console.Write("Nhap xau van ban: ");
            string vanBan = Console.ReadLine();

            // Gọi hàm VietHoaDauTu
            string ketQua = VietHoaDauTu(vanBan);

            // Hiển thị kết quả
            Console.WriteLine("Chuoi sau khi viet hoa:  " + ketQua);

        }

        // Hàm để viết hoa chữ cái đầu của mỗi từ trong xâu văn bản
        public static string VietHoaDauTu(string vanBan)
        {
            // Kiểm tra nếu chuỗi đầu vào rỗng hoặc null
            if (string.IsNullOrEmpty(vanBan))
            {
                return vanBan;
            }

            // Sử dụng TextInfo để viết hoa chữ cái đầu mỗi từ
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToUpper(vanBan.ToLower());
        }


        public struct hocVien
        {
            public int id;
            public string name;
            public int KhoaID;
        }

        public struct GiangVien
        {
            public int id;
            public string namegiaoVien;
            public int ChucVuID;
            public int hocHamID;
        }
        public struct Khoa
        {
            public int id;
            public string nameKhoa;
        }
        public struct HocPhan
        {
            public int id;
            public string nameHocPhan;
            public int khoaID;
        }

        public struct chucVu
        {
            public int id;
            public string nameHocphan;
        }
        public struct hocHam
        {
            public int id;
            public string nameHocpham;
        }

        public static void nhapHocVien(ref hocVien hocVien)
        {
            Console.WriteLine("Nhap ID hoc vien: ");
            hocVien.id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten hoc vien: ");
            hocVien.name = Console.ReadLine();

            Console.Write("nhap ID khoa: ");
            hocVien.KhoaID = int.Parse(Console.ReadLine());

        }

        public static bool KiemTraDuLieuHocVien(hocVien hocVien, out string message)
        {
            if (hocVien.id <= 0)
            {
                message = "id ko hop le";
                return false;
            }
            if (string.IsNullOrWhiteSpace(hocVien.name))
            {
                message = "ten hoc vien khong duoc de trong";
                return false;

            }
            if (hocVien.KhoaID <= 0)
            {
                message = "ID khoa khong hop le";
                return false;

            }
            message = "Du lieu hop le.";
            return true;
        }


        static void ProcessShip(out int waitingShips)
        {
            if (shipQueue.Count > 0)
            {
                var shipData = shipQueue.Dequeue();
                int currentShip = shipData.Item1;
                DateTime arrivalTime = shipData.Item2;
                DateTime startProcessingTime = DateTime.Now;

                Console.WriteLine($"tau {currentShip} bat dau chuyen hang luc {startProcessingTime:HH:mm:ss}, đã cập bến lúc {arrivalTime:HH:mm:ss}");

                // Giả lập thời gian chuyển hàng từ 1-5 giây
                Thread.Sleep(new Random().Next(1000, 5000));

                DateTime finishedProcessingTime = DateTime.Now;
                Console.WriteLine($"tau {currentShip} da hoan tat chuyen luc {finishedProcessingTime:HH:mm:ss}");

                totalShipsProcessed++;
                waitingShips = shipQueue.Count;
            }
            else
            {
                waitingShips = 0;
            }
        }


        public static void benTau()
        {
            Random random = new Random();
            int maxShips = 10; // Giới hạn số tàu để tránh vòng lặp vô hạn

            for (int i = 0; i < maxShips; i++)
            {
                // Giả lập tàu cập bến
                int shipId = totalShipsProcessed + shipQueue.Count + 1;
                DateTime arrivalTime = DateTime.Now;
                shipQueue.Enqueue(new Tuple<int, DateTime>(shipId, arrivalTime));

                Console.WriteLine($"Tau {shipId} da den ben luc {arrivalTime:HH:mm:ss}");
                Console.WriteLine("Tau đang cho: "+shipQueue.Count);

                // Chờ từ 5-10 giây trước khi có tàu mới cập bến
                Thread.Sleep(random.Next(5000, 10000));

                // Nếu có tàu trong bến thì xử lý
                while (shipQueue.Count > 0)
                {
                    ProcessShip(out int waitingShips);
                    Console.WriteLine($"Tong so tau dang chuyen hang: {totalShipsProcessed}");
                    Console.WriteLine(" Tàu đang chờ: "+ waitingShips);
                }

            }

        }
    }
}
