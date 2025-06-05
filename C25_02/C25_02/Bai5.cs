using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_02
{
    internal class Bai5
    {
        public static void bai1()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine("a và b  dương.");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("a và b  âm.");
            }
            else
            {
                Console.WriteLine($"Gia tri cua a là {a}, b b {b}.");
            }

        }

        public static void bai2() {

            Console.Write("Nhap a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = Int32.Parse(Console.ReadLine());

            String chon = Console.ReadLine();
         

            switch (chon)
            {

                case "+":
                    int c = a + b;
                    Console.WriteLine(c);
                    break;
                case "-":
                    int e = a + b;
                    Console.WriteLine(e);
                    break;
                case "*":
                    int t = a + b;
                    Console.WriteLine(t);
                    break;
                case "/":
                    int h = a + b;
                    Console.WriteLine(h);
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }

        }

        public static void bai3()
        {
            int n = 10;
            int tong = 0;
            for (int i = 0; i < 10; i++)
            {
                tong += i;
                Console.WriteLine(tong);
            }
        }

        public static void bai4() {
            Console.Write("Nhập số nguyên N: ");
            int N = int.Parse(Console.ReadLine());

            long Tong = 0;
            long a = 1; // Biến lưu giá trị giai thừa

            for (int i = 1; i <= N; i++)
            {
                a *= i; // Tính giai thừa của i
                Tong += a; // Cộng vào tổng
            }

            Console.WriteLine($"S({N}) = {Tong}");
        }

        public static void bai5() {
            //Console.Write("Nhập số nguyên dương N: ");
            //int N = int.Parse(Console.ReadLine());

            int n = 10;

            Console.WriteLine($"Các ước số của {n} là:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) // Kiểm tra nếu i là ước số của N
                {
                    Console.Write(i + " ");
                }
            }

        }

        public static void bai6() {
               bool IsPrime(int n)
            {
                if (n < 2) return false;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }

                return true;

                Console.Write("Nhập số nguyên N: ");
                int N = int.Parse(Console.ReadLine());


             
                if (IsPrime(N))
                    Console.WriteLine($"{N} là số nguyên tố.");
                else
                    Console.WriteLine($"{N} không phải là số nguyên tố.");

            }

           
        }
        public static void bai7()
        {
            Console.Write("Nhập số nguyên N: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = Math.Abs(N); // Đảm bảo xử lý số âm

            while (temp > 0)
            {
                sum += temp % 10; // Lấy chữ số cuối cùng và cộng vào tổng
                temp /= 10; // Loại bỏ chữ số cuối cùng
            }

            Console.WriteLine($"Tổng các chữ số của {N} là: {sum}");

        }

        public static void bai8() {
            int n = 26;
          
            for (int i=2; i<= n; i++)
            {
                bool result = true;
                if (i>2)
                    for (int j=2; j<= n; j++)
                        { if (i%j == 0)
                            
                          result = false;
                        break;
                    
                    }
                if (result)
                    Console.WriteLine(i);
                  
            }
        }
        public static int bai9() {
            int a, b, c, d;
            for (a=1;a<=9;a++)
                for(b=1;b<=9;b++)
                    for(c=1;c<=9;c++)
                        for(d=1;d<=9;d++)
                        {
                            bool dk1 = (a + b + c + d) % 7 == 0;
                            if (dk1)
                            {
                                return 1000 * a + 100 * b + 10 * c + d;

                            }
                            
                        }  
            return 0;
            
                
           
        }

        public static void bai10() {
            Console.Write("Nhap so N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write($"Phan tich {N} thanh so nguyen to: ");
            PrimeFactorization(N);


        }

        static void PrimeFactorization(int n)
        {
            bool first = true; // Biến để kiểm soát việc in dấu 'x'

            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    if (!first)
                        Console.Write(" x ");
                    Console.Write(i);
                    first = false;
                    n /= i;
                }
            }
            Console.WriteLine();
        }

    }
}


