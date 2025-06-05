using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai2;

using static System.Console;//khái báo sẽ ko cần gọi console để dùng writeLine nữa

namespace Bai2
{
    internal class Test1

    {
        // static để báo cho ctrinh biết thành phần chỉ cần dịch 1 lần, ko thể khởi tạo

       public static void Hel1o( ) {

           String name =  Console.ReadLine();

            WriteLine("Tôi tên là: " +name);
        }

    }

    
}

namespace Bai2Child
{
    internal class Test2 {
        public static void Hel1o()
        {
            WriteLine("I am fine, thank");
        }
    }


    // tạo đối tượng là HBacademy
    //gán giá trị crong, cdai bằng ReadLine()
    // in ra màn hình bằng writeLine()

    internal class HBAcademy
    {


        public static void Hcn()
        {
            WriteLine("Bai 1");

            Write("Nhap chieu rong hinh chu nhat: ");
            int cr = Convert.ToInt32(Console.ReadLine());

            Write("Nhap chieu dai hinh chu nhat: ");
            int cd= Convert.ToInt32(Console.ReadLine());

            WriteLine("Chieu rong laf: " + cr);
            WriteLine("Chieu dai la: "+cd);

        }


        public static void Profile()
        {
            // nhập từ bàn phím
            WriteLine("\nBai 2\n");

            Write("Student name: ");
            String name = Console.ReadLine();

            Write("gender(male/female): ");
            String gender = Console.ReadLine();

            Write("age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Write("birthday (MM/dd/yyyy): ");
            String bd = Console.ReadLine();

            Write("address: ");
            String address = Console.ReadLine();

            Write("email: ");
            String email = Console.ReadLine();

            Write("father's name: ");
            String nameF = Console.ReadLine();

            Write("mother's name: ");
            String nameM = Console.ReadLine();

            WriteLine("\n*** Student Information ***\n");

            // in ra màn hinhh

            WriteLine("Name: "+name);
            WriteLine("age: "+age);
            WriteLine("gender: "+gender);
            WriteLine("Date of birth: "+bd);
            WriteLine("Address: "+address);
            WriteLine("Email; "+email);
            WriteLine("Student's father name: "+nameF);
            WriteLine("Student mother name: "+nameM);

        }

        public static void Population()
        {
            Write("City: ");
            String City = Console.ReadLine();
            Write("Population 1940: ");
            String Popu40 = Console.ReadLine();
            Write("Population 1950: ");
            String Popu50 = Console.ReadLine();
            Write("Change: ");
            String Change = Console.ReadLine();

            WriteLine("-----------------------------------------------------");
            Write("City: ");
            String City2 = Console.ReadLine();
            Write("Population 1940: ");
            String Popu40_2 = Console.ReadLine();
            Write("Population 1950: ");
            String Popu50_2 = Console.ReadLine();
            Write("Change: ");
            String Change2 = Console.ReadLine();

            WriteLine("-----------------------------------------------------");
            Write("City: ");
            String City3 = Console.ReadLine();
            Write("Population 1940: ");
            String Popu40_3 = Console.ReadLine();
            Write("Population 1950: ");
            String Popu50_3 = Console.ReadLine();
            Write("Change: ");
            String Change3 = Console.ReadLine();

            WriteLine("-----------------------------------------------------");
            Write("City: ");
            String City4 = Console.ReadLine();
            Write("Population 1940: ");
            String Popu40_4 = Console.ReadLine();
            Write("Population 1950: ");
            String Popu50_4 = Console.ReadLine();
            Write("Change: ");
            String Change4 = Console.ReadLine();
            WriteLine("");

            //WriteLine("City " + "Year" + "Population" + "Year" +"Population" + "Chage(%)");
            WriteLine("{0,-15} {1}   {2}   {3}   {4}   {5}", City, "1940", Popu40, "1950", Popu50, Change+"%");
            WriteLine("{0,-15} {1}   {2}   {3}   {4}   {5}", City2, "1940", Popu40_2, "1950", Popu50_2, Change2 + "%");
            WriteLine("{0,-15} {1}   {2}   {3}   {4}   {5}", City3, "1940", Popu40_3, "1950", Popu50_3, Change3 + "%");
            WriteLine("{0,-15} {1}   {2}   {3}   {4}   {5}", City4, "1940", Popu40_4, "1950", Popu50_4, Change4 + "%");



        }


        public static void M_unicode()
        {
            // dùng char để khi chuyển đổi giữa mã Unicde và kí tự hiệu quả hơn
            // vì char là kí tự đơn lẻ 
            //unicode cũng là kí tự đơn lẻ
            while (true) {
                WriteLine("\nChọn 1 chuong trinh");
                WriteLine("1. Nhap 1 ky tu de hien thi ma Unicode.");
                WriteLine("2. Nhap 1 mã Unicode de hien thi ky tu.");
                WriteLine("3. Hien thi bang ma Unicode (tu 0 đen 255).");
                WriteLine("4. Thoat.");
                Write("ban chon chuong trinh so: ");

                String chon = Console.ReadLine();

                switch (chon) {

                    case "1":
                        Write("Nhap 1 ky tu: ");
                        char Kt = Console.ReadKey().KeyChar;// lấy ký tự vừa nhâp
                        WriteLine("\nMa Unicode cua ky tu la: "+ (int) Kt);//{kt} giá trị của biến kt nhập ở trên. {(int)Kt} là chuyển ký tự trong biến thành số nguyên.
                        break;

                    case "2":
                        Write("nhap 1 mã Unicode từ 0-255: ");
                        // console.Readline() để đọc đầu vào từ chuỗi
                        //int.TryParse chuyển chuỗi sang số nguyên. ko chuyển được thì else
                        if(int.TryParse(Console.ReadLine(), out int unicode) && unicode >= 0 && unicode < 255)
                        {
                            WriteLine("\nki tu cua ma Unicode " +unicode+" là: " +(char)unicode);
                        }
                        else
                        {
                            WriteLine("\nma khong ho le!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Bang ma Unicde tu 0-255: ");
                        // i=0. bắt đầu vs gtri i=0
                        // <= 255. lặp tới khi giá trị i nhỏ hơn ỏ bằng 255
                        // i++. sau mỗi lần lặp i tăng thêm 1.
                        for (int i = 0; i <= 255; i++)
                        {
                            WriteLine("ma Unicode " +i+ " : "+(char)i);
                        }
                        break;
                    case "4":
                        WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;

                    
                }


            }

        }

    }
}
