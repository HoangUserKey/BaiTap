using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_02
{
    internal class Bai7
    {
        //String là bất biến (immutable) và ko cho phép có lớp con. Là 1 kiểu dữ liệu dùng để lưu trữ chuỗi ký tự Unicode và cung cấp các phương thức để xử lý chuỗi.
        // StringBuilder là tùy biến (mutable)


        public static void bai1()
        {
            String hoTen = "Tran Viet Hoang";
            String ngaysinh = "01/03/2003";
            String que = "Tuyen Quang";

            Console.WriteLine(hoTen+" "+ngaysinh + " " + que);
            
        }



        public static void bai2() {
            //Console.Write("Nhap chuoi str: ");
            //string str = Console.ReadLine();
            String str = "      Tran Viet Hoang    9   ";

            String s = "   abcdefj";
            //Console.Write("Nhap chuoi s: ");
            //string s = Console.ReadLine();

            // Kiểm tra chuỗi s có nằm trong str hay không
            if (str.Contains(s))
            {
                Console.WriteLine($"chuoi \"{s}\" chuoi trong \"{str}\".");
            }
            else
            {
                Console.WriteLine($"chuoi \"{s}\" không chuoi trong \"{str}\".");
            }

            // So sánh độ dài hai chuỗi
            if (s.Length > str.Length)
            {
                Console.WriteLine($"chuoi \"{s}\" dai hon chuoi \"{str}\".");
            }
            else if (s.Length < str.Length)
            {
                Console.WriteLine($"chuoi \"{s}\" ngan hon chuoi \"{str}\".");
            }
            else
            {
                Console.WriteLine($"Hai chuoi co do dai bang nhau.");
            }

            // kiem tra doi sứng
            if (IsPalindrome(str))
            {
                Console.WriteLine($"chuoi \"{str}\" co tinh doi xưng.");
            }
            else
            {
                Console.WriteLine($"chuoi \"{str}\" không co tinh doi xuong.");
            }
            //tính số từ

            int wordCount = CountWords(str);
            Console.WriteLine($"\nchuoi \"{str}\" co {wordCount} tu.");


            // Cắt đầu chuỗi
            Console.WriteLine($"\nchuoi sau khi cat dau: \"{TrimStartString(str)}\"");

            // Cắt cuối chuỗi
            Console.WriteLine($"Chuoi sau khi cat cuoi chuoi: \"{TrimEndString(str)}\"");

            // Cắt cả chuỗi
            Console.WriteLine($"Chuoi sau khi ca chuoi \"{TrimWholeString(str)}\"");
        }

        static int CountWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))//Kiểm tra chuỗi có rỗng hoặc chỉ chứa khoảng trắng
            {
                return 0;
            }

            string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);//Phương thức Split() dùng để tách chuỗi str thành một mảng các từ (words).

            return words.Length;
            //Dấu phân tách (' ', '\t', '\n'): Chuỗi được chia dựa trên các ký tự khoảng trắng (' '), tab ('\t'), hoặc dòng mới ('\n').

        }

        static string TrimStartString(string str)
        {
            return str.TrimStart();
        }

        static string TrimEndString(string str)
        {
            return str.TrimEnd();
        }

        static string TrimWholeString(string str)
        {
            return str.Trim();
        }



        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            //Nếu str[left] khác str[right], chuỗi không phải là đối xứng, trả về false
            //Nếu ký tự đầu và cuối giống nhau, tiếp tục kiểm tra bằng cách tăng left lên và giảm right xuống.

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;//không có sự khác biệt nào, chuỗi được xem là đối xứng và phương thức trả về true.

        }



        public static void bai3()
        {
            // Tạo một biến StringBuilder
            StringBuilder sb = new StringBuilder("Tran Viet Hoang");

            // Thêm dữ liệu vào bằng phương thức Append
            sb.Append(" Hoc Code ");
            Console.WriteLine("Sau khi Append: " + sb);

            // Xóa một phần dữ liệu bằng Remove
            sb.Remove(9, 13); 
            Console.WriteLine("Sau khi Remove: " + sb);

            //Thêm dữ liệu bằng AppendFormat
            sb.AppendFormat(" Tran Viet Hoang", 22 + " Tuoi");
            Console.WriteLine("Sau khi AppendFormat: " + sb);

            //// Chèn dữ liệu vào giữa biến bằng Insert
            sb.Insert(22, "TUYEN QUANG ");
            Console.WriteLine("Sau khi Insert: " + sb);

            //// Xóa một phần dữ liệu bằng Remove
            sb.Remove(3, 5); // Xóa ký tự từ vị trí 3 đến 5
            Console.WriteLine("Sau khi Remove (3-5): " + sb);

            sb.Replace('a', 'e');
            Console.WriteLine("Sau khi Replace ('a' -> 'e'): " + sb);

        }


    }
}
