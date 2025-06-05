using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
    interface IWork
    {
        void DoWork();
    }

    interface IOvertime
    {
        void DoOvertime(int hours);
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract int CalculateSalary();
    }

    class Developer : Employee, IWork, IOvertime
    {
        private int overtimeHours;

        public Developer(string name, int overtimeHours) : base(name)
        {
            this.overtimeHours = overtimeHours;
        }

        public override int CalculateSalary()
        {
            return 5000 + 100 * overtimeHours;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} dang lam viec");
        }

        public void DoOvertime(int hours)
        {
            Console.WriteLine($"{Name} lam ngoai gio {hours} tieng.");
        }
    }

    class Designer : Employee, IWork
    {
        public Designer(string name) : base(name) { }

        public override int CalculateSalary()
        {
            return 4000;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} dang lam viec");
        }
    }

    class Manager : Employee, IWork, IOvertime
    {
        private int overtimeHours;

        public Manager(string name, int overtimeHours) : base(name)
        {
            this.overtimeHours = overtimeHours;
        }

        public override int CalculateSalary()
        {
            return 6000 + 150 * overtimeHours;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} lam viec");
        }

        public void DoOvertime(int hours)
        {
            Console.WriteLine($"{Name} lam ngoai gio {hours} tieng.");
        }
    }

    class showLuong
    {
        public showLuong()
        {
            List<Employee> employees = new List<Employee>();
            Random random = new Random();

            Console.Write("Nhap so luong nhan vien: ");
            int employeeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"Nhap thong tin nhan vien {i + 1}:");

                Console.Write("Ten nhan vien: ");
                string name = Console.ReadLine();

                Console.Write("Chuc vu (Developer/Designer/Manager): ");
                string role = Console.ReadLine();

                if (role.Equals("Developer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("So gio lam them: ");
                    int overtimeHours = int.Parse(Console.ReadLine());
                    employees.Add(new Developer(name, overtimeHours));
                }
                else if (role.Equals("Designer", StringComparison.OrdinalIgnoreCase))
                {
                    employees.Add(new Designer(name));
                }
                else if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("So gio lam them: ");
                    int overtimeHours = int.Parse(Console.ReadLine());
                    employees.Add(new Manager(name, overtimeHours));
                }
                else
                {
                    Console.WriteLine("Chức vụ không hợp lệ! Vui lòng nhập lại.");
                    i--; // Quay lại vòng lặp để nhập lại nhân viên
                }
            }

            Console.WriteLine("\nThông tin nhân viên:");
            foreach (var employee in employees)
            {
                employee.DoWork();
                Console.WriteLine($"Lương: {employee.CalculateSalary()}");

                if (employee is IOvertime overtimeEmployee)
                {
                    int randomHours = random.Next(1, 6);
                    overtimeEmployee.DoOvertime(randomHours);
                }

                Console.WriteLine();
            }
        }


    }
}
