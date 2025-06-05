using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_02
{
    internal class Bai4
    {
        public static void ToanTu()
        {
            // ví dụ x=5
            // 1. y= x++ là gán y bằng x rồi mới + thêm 1 để bằng 6
            //2. y = ++x; là x cộng thêm 1 để bằng 6 rồi mới gán y bằng x
        }

        public static void Bai1() {
            Console.Write("Nhap 1 so nguyen: ");
            int a = Int32.Parse(Console.ReadLine());

            //Convert.ToString(a, 2) Chuyển đổi số nguyên a sang dạng chuỗi biểu diễn nhị phân. 
            //Tham số 2 chỉ định rằng chúng ta đang sử dụng hệ nhị phân.
            //PadLeft(8, '0'); đảm bảo là chuyển số nhị phân đủ  8 bit và sẵn sàng thêm 0 nếu cần

            string NhiPhan = Convert.ToString(a, 2).PadLeft(8, '0');


            Console.WriteLine("rang nhi phan 8 bit: "+ NhiPhan);

            int z = a >> 1; //kiểu toán tử dịch sang phải 1 bít(a<<1 là dịch sang trái)
            string NhiPhan1 = Convert.ToString(z, 2).PadLeft(8, '0');
            Console.WriteLine("rang nhi phan 8 bit: " + z);
            Console.WriteLine("rang nhi phan 8 bit: " + NhiPhan1);

        }

        public static void Bai2() {
            int a=4, b=6, c=9;


            //cach 1
            //int max = a;

            //if (b > max) max = b;
            //if (c > max) max = c;

            //Console.WriteLine("so lon nhat là: "+max);

            // cach 2

            Console.WriteLine(a>b ? (a>c?a:c):(b> c?b:c));


        }

        public static void Bai3() {

            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Số lớn nhất: "+ numbers.Max());
            Console.WriteLine("Số nhỏ nhất: "+ numbers.Min());


        }

        public struct MyDate
        {
            public int Day;
            public int Month;
            public int Year;

     
        }




       public static void NgayGio()
        {
            // Nhập số giây
            Console.Write("Nhap so giay: ");
            long totalSeconds = long.Parse(Console.ReadLine());


            // Tính toán ngày, giờ, phút, giây
            long days = totalSeconds / 86400; // 1 ngày = 86400 giây
            totalSeconds %= 86400;

            long hours = totalSeconds / 3600; // 1 giờ = 3600 giây
            totalSeconds %= 3600;

            long minutes = totalSeconds / 60; // 1 phút = 60 giây
            long seconds = totalSeconds % 60;

            // Xuất kết quả
            Console.WriteLine($"{days} ngay, {hours} gio, {minutes} phut, {seconds} giay");
        }

    }

}



    

