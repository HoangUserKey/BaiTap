using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class phanSo
    {
        public int tuSo { get; set; }
        public int mauSo {  get;set; }

        public static void show()
        {
            Console.WriteLine();
        }
        public static phanSo operator + (phanSo x, phanSo y) {
            phanSo result = new phanSo();
            result.tuSo = x.tuSo*y.mauSo + y.tuSo*x.mauSo;
            result.mauSo = x.mauSo + y.mauSo;
            return result;
        }

        public static bool operator < (phanSo x, phanSo y) {
            
            bool result = false;
        
            if(x.tuSo * y.mauSo < y.tuSo * x.mauSo)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool operator >(phanSo x, phanSo y)
        {

            bool result = false;

            if (x.tuSo * y.mauSo > y.tuSo * x.mauSo)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static phanSo operator ++ ( phanSo x)// tien to
        {
            x.tuSo += 1;
            return x;

        }
        //public static phanSo operator ++(phanSo x, phanSo y)// tien to
        //{
        //    phanSo result = new phanSo();
        //    x.tuSo += 1;
        //    return result;

        //}

        internal class Person
        {
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
            public decimal Salary { get; set; }

            // Hàm khởi tạo mặc định
            public Person()
            {
                Name = "Unknown";
                Birthday = DateTime.MinValue;
                Salary = 0;
            }

            // Hàm khởi tạo với chỉ tên
            public Person(string name)
            {
                Name = name;
                Birthday = DateTime.MinValue;
                Salary = 0;
            }

            // Hàm khởi tạo đầy đủ
            public Person(string name, DateTime birthday, decimal salary)
            {
                Name = name;
                Birthday = birthday;
                Salary = salary;
            }

            ~Person()
            {
                Console.WriteLine($"Destructor: "+Name);
            }


            // Phương thức hiển thị thông tin
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Birthday: {Birthday.ToShortDateString()}, Salary: {Salary:C}");
            }

        }

        public static void Show()
        {
            Person p1 = new Person();
            Person p2 = new Person("Hoang");
            Person p3 = new Person("Quang", new DateTime(2003, 05, 12), 50000);

            // Hiển thị thông tin của từng đối tượng
            p1.DisplayInfo();
            p2.DisplayInfo();
            p3.DisplayInfo();

        }
    }
}
