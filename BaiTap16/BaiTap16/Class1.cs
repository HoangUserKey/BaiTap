using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
    interface IVehicle
    {
        void Move();
        void Stop();
    }

    class Car : IVehicle
    {
        public string name { get; set; }
        public Car() { }
        public Car(string name)
        {
            this.name = name;
        }

        public void Move() {
            Console.WriteLine($"{name} is moving on the road.");
        }
        public void Stop() {
            Console.WriteLine($"{name} has stopped");

        }
    }

    class Bicycle : IVehicle
    {
        public string name { get; set; }
        public Bicycle() { }
        public Bicycle(string name) {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{name} Bicycle is pedaling");
        }
        public void Stop()
        {
            Console.WriteLine($"{name} Bicycle has stopped ");

        }
    }

    class Airplane : IVehicle
    {
        public string name { get; set; }
        public Airplane() { }
        public Airplane(string name) {
            this.name = name;
        }
        public void Move()
        {
            Console.WriteLine($"{name} is flying in the sky");
        }
        public void Stop()
        {
            Console.WriteLine($"{name} has landed ");

        }
    }

    class Manager1{
        public  void Show()
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            // Thêm các đối tượng vào danh sách
            vehicles.Add(new Car("ÔTO"));
            vehicles.Add(new Bicycle("BONG BAY"));
            vehicles.Add(new Airplane("MAY BAY"));

            // Gọi phương thức Chay() của tất cả các đối tượng
            Console.WriteLine("\n===== Danh sach doi tuong dang chay =====");
            foreach (IVehicle item in vehicles)
            {
                item.Move();
                item.Stop();
            }

        }
    }
}
  